using App_CAMPSYS.Data;
using App_CAMPSYS.Models.Entities;
using App_CAMPSYS.View.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace App_CAMPSYS.Presenters;

public class InscripcionPresenter
{
    private readonly IInscripcionView? _view;
    private readonly IModificarView? _modificarView;
    private readonly CampsysDbContext _db = new();

    private int _campistaId;
    private int _inscripcionId;

    public InscripcionPresenter(IInscripcionView view)
    {
        _view = view ?? throw new ArgumentNullException(nameof(view));

        _view.GrabarClicked += OnGrabarClicked;
        _view.EdadCambiada += OnEdadCambiada;
        _view.FechasCambiadas += OnFechasCambiadas;
    }

    // La modificación de inscripciones pertenece ahora a este presenter.
    public InscripcionPresenter(IModificarView view)
    {
        _modificarView = view ?? throw new ArgumentNullException(nameof(view));
    }

    // Se llama al abrir el formulario (equivalente al FormInscripcion_Load anterior)
    public void CargarDatosIniciales()
    {
        using var db = new CampsysDbContext();

        var departamentos = db.Departamentos
            .AsNoTracking()
            .OrderBy(d => d.Nombre)
            .Select(d => new DepartamentoItem(d.DepartamentoId, d.Nombre))
            .ToList();
        _view.CargarDepartamentos(departamentos);

        var cabanas = db.Cabanas
            .AsNoTracking()
            .Where(c => c.CuposDisponibles > 0)
            .OrderBy(c => c.CodigoCabana)
            .Select(c => new CabanaItem(c.CabanaId, c.CodigoCabana))
            .ToList();
        _view.CargarCabanasDisponibles(cabanas);

        var actividades = db.Actividades
            .AsNoTracking()
            .OrderBy(a => a.NombreActividad)
            .Select(a => new ActividadItem(a.ActividadId, a.NombreActividad, a.Costo))
            .ToList();
        _view.CargarActividades(actividades);

        _view.HabilitarSeccionTutor(false);
        RecalcularCosto();
    }

    // Req 1.1 — bloquear cédula si menor de 16 + tutor si menor de 18
    private void OnEdadCambiada(object? sender, EventArgs e)
    {
        int edad = _view.Edad;

        _view.HabilitarCampoDocId(edad >= 16);
        _view.HabilitarSeccionTutor(RequiereTutor(edad));

        RecalcularCosto();
    }

    private void OnFechasCambiadas(object? sender, EventArgs e) => RecalcularCosto();

    public static bool RequiereTutor(int edad) => edad < 18;

    // Recalcula el costo con todas las actividades incluidas (Req 1.2)
    private void RecalcularCosto()
    {
        try
        {
            int totalActividades = _view.ActividadesSeleccionadasIds.Count;
            decimal costo = CalcularCostoCompleto(_view.FechaInicio, _view.FechaFinalizacion, totalActividades);
            _view.MostrarCostoCalculado(costo);
        }
        catch
        {
            _view.MostrarCostoCalculado(0m);
        }
    }

    // Regla de negocio original: C$500 por día + C$100 por actividad
    public static decimal CalcularCostoCompleto(DateTime fechaInicio, DateTime fechaFinalizacion, int totalActividades)
    {
        int dias = (fechaFinalizacion.Date - fechaInicio.Date).Days;
        if (dias <= 0) dias = 1;
        return (dias * 500m) + (totalActividades * 100m);
    }

    private void OnGrabarClicked(object? sender, EventArgs e)
    {
        // Req 1.1 — validar cédula si edad >= 16
        if (_view.Edad >= 16 && string.IsNullOrWhiteSpace(_view.DocId))
        {
            _view.ShowMessage("Debe ingresar la cédula del campista.", esExito: false);
            return;
        }

        if (string.IsNullOrWhiteSpace(_view.NombreCompleto))
        {
            _view.ShowMessage("El nombre completo del campista es obligatorio.", esExito: false);
            return;
        }

        var actividadesIds = _view.ActividadesSeleccionadasIds;
        if (actividadesIds.Count == 0)
        {
            _view.ShowMessage("No hay actividades disponibles.", esExito: false);
            return;
        }

        try
        {
            using var db = new CampsysDbContext();

            bool docIdExiste = !string.IsNullOrWhiteSpace(_view.DocId)
                && db.Campistas.AsNoTracking().Any(c => c.DocId == _view.DocId);
            if (docIdExiste)
            {
                _view.ShowMessage($"La cédula '{_view.DocId}' ya pertenece a otro campista.", esExito: false);
                return;
            }

            bool hayCupos = db.Cabanas.AsNoTracking()
                .Any(c => c.CabanaId == _view.CabanaIdSeleccionada && c.CuposDisponibles > 0);
            if (!hayCupos)
            {
                _view.ShowMessage("No hay cupos disponibles en esta cabaña.", esExito: false);
                return;
            }

            var campista = new Campista
            {
                NombreCompleto = _view.NombreCompleto.Trim(),
                DocId = _view.DocId?.Trim() ?? "",
                Edad = _view.Edad,
                Sexo = _view.Sexo,
                NumeroCelular = _view.NumeroCelular.Trim(),
                Gmail = _view.Gmail.Trim(),
                Direccion = _view.Direccion.Trim(),
                DepartamentoId = _view.DepartamentoIdSeleccionado,
                Tipo = "Campista"
            };

            db.Campistas.Add(campista);

            if (_view.RequiereTutor)
            {
                var tutor = new Tutor
                {
                    NombreCompleto = _view.TutorNombreCompleto.Trim(),
                    DocId = _view.TutorDocId.Trim(),
                    Edad = _view.TutorEdad,
                    Sexo = _view.TutorSexo,
                    NumeroCelular = _view.TutorNumeroCelular.Trim(),
                    Campista = campista
                };
                db.Tutores.Add(tutor);
            }

            decimal costoFinal = CalcularCostoCompleto(_view.FechaInicio, _view.FechaFinalizacion, actividadesIds.Count);

            var inscripcion = new Inscripcion
            {
                FechaInicio = _view.FechaInicio,
                FechaFinalizacion = _view.FechaFinalizacion,
                Costo = costoFinal,
                Estado = "Activo",
                Campista = campista,
                CabanaId = _view.CabanaIdSeleccionada
            };
            db.Inscripciones.Add(inscripcion);

            foreach (int idActividad in actividadesIds)
            {
                db.DetallesInscripcionActividad.Add(new DetalleInscripcionActividad
                {
                    Inscripcion = inscripcion,
                    ActividadId = idActividad
                });
            }

            db.SaveChanges();

            _view.ShowMessage("Inscripción guardada exitosamente.", esExito: true);
            _view.LimpiarFormulario();
        }
        catch (DbUpdateException ex)
        {
            _view.ShowMessage($"Error de base de datos: {ex.InnerException?.Message ?? ex.Message}", esExito: false);
        }
        catch (Exception ex)
        {
            _view.ShowMessage($"Ocurrió un error inesperado: {ex.Message}", esExito: false);
        }
    }

    public void CargarInicial()
    {
        var view = ObtenerVistaModificar();

        view.CargarDepartamentos(_db.Departamentos.AsNoTracking()
            .OrderBy(d => d.Nombre)
            .Select(d => new DepartamentoItem(d.DepartamentoId, d.Nombre))
            .ToList());

        view.CargarCabanas(_db.Cabanas.AsNoTracking()
            .OrderBy(c => c.CodigoCabana)
            .Select(c => new CabanaItem(c.CabanaId, c.CodigoCabana))
            .ToList());

        view.CargarActividades(_db.Actividades.AsNoTracking()
            .OrderBy(a => a.NombreActividad)
            .Select(a => new ActividadItem(a.ActividadId, a.NombreActividad, a.Costo))
            .ToList());
    }

    public void Buscar(string textoBusqueda)
    {
        var view = ObtenerVistaModificar();

        try
        {
            textoBusqueda = (textoBusqueda ?? "").Trim();
            var campista = _db.Campistas.FirstOrDefault(c =>
                c.NombreCompleto.Contains(textoBusqueda) || c.DocId.Contains(textoBusqueda));

            if (campista == null)
            {
                var tutor = _db.Tutores.Include(t => t.Campista).FirstOrDefault(t =>
                    t.NombreCompleto.Contains(textoBusqueda) || t.DocId.Contains(textoBusqueda));
                campista = tutor?.Campista;
            }

            if (campista == null)
            {
                _campistaId = 0;
                _inscripcionId = 0;
                view.MostrarSinResultadoBusqueda();
                return;
            }

            _campistaId = campista.CampistaId;
            var tutorDelCampista = _db.Tutores.FirstOrDefault(t => t.CampistaId == _campistaId);
            var inscripcion = _db.Inscripciones
                .Where(i => i.CampistaId == _campistaId)
                .OrderByDescending(i => i.FechaInscripcion)
                .FirstOrDefault();

            _inscripcionId = inscripcion?.InscripcionId ?? 0;
            view.MostrarResultadoBusqueda(campista, tutorDelCampista, inscripcion);
        }
        catch (Exception ex)
        {
            view.MostrarMensaje("Error al buscar: " + ex.Message);
        }
    }

    public void Actualizar(
        string nombreCompleto, string docId, int edad, string sexo, string numeroCelular,
        string gmail, string direccion, int departamentoId,
        bool tieneTutor, string tutorNombre, string tutorDocId, int tutorEdad,
        string tutorSexo, string tutorCelular, DateTime fechaInicio,
        DateTime fechaFinalizacion, int cabanaId, string estado, List<int> actividadesIds)
    {
        var view = ObtenerVistaModificar();

        try
        {
            if (_campistaId <= 0)
            {
                view.MostrarMensaje("Primero debe buscar un registro.");
                return;
            }
            if (fechaInicio >= fechaFinalizacion)
                throw new Exception("La fecha de inicio debe ser menor a la fecha de finalización.");

            var campista = _db.Campistas.Find(_campistaId);
            if (campista == null)
            {
                view.MostrarMensaje("El campista ya no existe.");
                return;
            }

            campista.NombreCompleto = nombreCompleto.Trim();
            campista.DocId = docId.Trim();
            campista.Edad = edad;
            campista.Sexo = sexo;
            campista.NumeroCelular = numeroCelular.Trim();
            campista.Gmail = gmail.Trim();
            campista.Direccion = direccion.Trim();
            campista.DepartamentoId = departamentoId;

            if (tieneTutor)
            {
                var tutor = _db.Tutores.FirstOrDefault(t => t.CampistaId == _campistaId);
                if (tutor != null)
                {
                    tutor.NombreCompleto = tutorNombre.Trim();
                    tutor.DocId = tutorDocId.Trim();
                    tutor.Edad = tutorEdad;
                    tutor.Sexo = tutorSexo;
                    tutor.NumeroCelular = tutorCelular.Trim();
                }
            }

            if (_inscripcionId > 0)
            {
                var inscripcion = _db.Inscripciones.Find(_inscripcionId);
                if (inscripcion != null)
                {
                    inscripcion.FechaInicio = fechaInicio;
                    inscripcion.FechaFinalizacion = fechaFinalizacion;
                    inscripcion.CabanaId = cabanaId;
                    inscripcion.Estado = estado;
                    inscripcion.Costo = CalcularCostoCompleto(fechaInicio, fechaFinalizacion, actividadesIds.Count);

                    var detallesViejos = _db.DetallesInscripcionActividad
                        .Where(d => d.InscripcionId == _inscripcionId);
                    _db.DetallesInscripcionActividad.RemoveRange(detallesViejos);

                    foreach (int idActividad in actividadesIds)
                    {
                        _db.DetallesInscripcionActividad.Add(new DetalleInscripcionActividad
                        {
                            InscripcionId = _inscripcionId,
                            ActividadId = idActividad
                        });
                    }
                }
            }

            _db.SaveChanges();
            view.MostrarMensaje("Registro actualizado exitosamente.");
        }
        catch (Exception ex)
        {
            view.MostrarMensaje("Error: " + ex.Message);
        }
    }

    public void Eliminar()
    {
        var view = ObtenerVistaModificar();

        if (_inscripcionId <= 0)
        {
            view.MostrarMensaje("No hay una inscripción cargada para eliminar.");
            return;
        }

        var inscripcion = _db.Inscripciones.Find(_inscripcionId);
        if (inscripcion == null)
        {
            view.MostrarMensaje("La inscripción ya no existe.");
            return;
        }

        var detalles = _db.DetallesInscripcionActividad.Where(d => d.InscripcionId == _inscripcionId);
        _db.DetallesInscripcionActividad.RemoveRange(detalles);
        _db.Inscripciones.Remove(inscripcion);
        _db.SaveChanges();
        view.MostrarMensaje("Inscripción eliminada.");
        _inscripcionId = 0;
    }

    private IModificarView ObtenerVistaModificar() =>
        _modificarView ?? throw new InvalidOperationException("Este presenter no fue creado para modificar inscripciones.");
}
