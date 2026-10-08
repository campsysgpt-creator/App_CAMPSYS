using App_CAMPSYS.Data;
using App_CAMPSYS.Models.Entities;
using App_CAMPSYS.View.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace App_CAMPSYS.Presenters;

// Migrado desde CapaNegocios.logicastaff + CapaDatos.datosstaff (arquitectura de capas).
// La versión anterior en esta arquitectura solo tenía Cargar()/Agregar(); aquí se
// restauran Login, Filtrar, Actualizar y Eliminar, que existían en el original.
public class StaffPresenter
{
    private readonly IStaffView? _view;
    private readonly IVisualizacionView? _visualizacionView;
    private readonly CampsysDbContext _db = new();
    private string _tipoVisualizacion = "Campistas";

    // Roles válidos según requerimiento (antes en logicastaff.ObtenerRolesValidos)
    private static readonly List<string> RolesValidos = new()
    {
        "Ayudante de cocina",
        "Programador de actividades",
        "Líder de Cabaña",
        "Instructor",
        "Guía"
    };

    public StaffPresenter(IStaffView view)
    {
        _view = view;
    }

    // La visualización y sus filtros pertenecen ahora a StaffPresenter.
    public StaffPresenter(IVisualizacionView view)
    {
        _visualizacionView = view ?? throw new ArgumentNullException(nameof(view));
    }

    public void CargarInicial()
    {
        _view.MostrarRolesValidos(RolesValidos);
    }

    // Req — buscar campista (mayor de 18) para registrarlo o editarlo como staff
    public void Buscar(string textoBusqueda)
    {
        textoBusqueda = (textoBusqueda ?? "").Trim();

        var campista = _db.Campistas
            .FirstOrDefault(c => c.NombreCompleto.Contains(textoBusqueda) || c.DocId.Contains(textoBusqueda));

        if (campista == null)
        {
            _view.MostrarSinResultadoBusqueda();
            return;
        }

        if (campista.Edad < 18)
        {
            _view.MostrarMensaje("El campista debe ser mayor de 18 años para ser Staff.");
            return;
        }

        var staff = _db.Staffs.Include(s => s.Campista)
            .FirstOrDefault(s => s.CampistaId == campista.CampistaId);

        _view.MostrarResultadoBusqueda(campista, staff);
    }

    public void Registrar(int campistaId, string rol, string password)
    {
        try
        {
            Validar(campistaId, rol, password);

            if (_db.Staffs.Any(s => s.CampistaId == campistaId))
            {
                _view.MostrarMensaje("Este campista ya pertenece al staff.");
                return;
            }

            _db.Staffs.Add(new Staff { CampistaId = campistaId, Rol = rol, Password = password });
            _db.SaveChanges();

            _view.MostrarMensaje("Staff registrado exitosamente.");
            _view.LimpiarFormulario();
        }
        catch (Exception ex)
        {
            _view.MostrarMensaje("Error: " + ex.Message);
        }
    }

    public void Actualizar(int staffId, string rol, string password)
    {
        try
        {
            var staff = _db.Staffs.Find(staffId);
            if (staff == null)
            {
                _view.MostrarMensaje("No se encontró el registro de staff.");
                return;
            }

            if (string.IsNullOrEmpty(rol) || !RolesValidos.Contains(rol))
                throw new Exception("Debe asignar un rol válido al staff.");
            if (string.IsNullOrEmpty(password) || password.Length < 6)
                throw new Exception("La contraseña debe tener mínimo 6 caracteres.");

            staff.Rol = rol;
            staff.Password = password;
            _db.SaveChanges();

            _view.MostrarMensaje("Staff actualizado exitosamente.");
        }
        catch (Exception ex)
        {
            _view.MostrarMensaje("Error: " + ex.Message);
        }
    }

    public void Eliminar(int staffId)
    {
        var staff = _db.Staffs.Find(staffId);
        if (staff == null)
        {
            _view.MostrarMensaje("No se encontró el registro de staff.");
            return;
        }

        _db.Staffs.Remove(staff);
        _db.SaveChanges();

        _view.MostrarMensaje("Staff eliminado.");
        _view.LimpiarFormulario();
    }

    // Req — filtrar por nombre o cédula del campista
    public void Filtrar(string busqueda)
    {
        if (_visualizacionView != null)
        {
            FiltrarVisualizacion(busqueda);
            return;
        }

        busqueda = (busqueda ?? "").Trim();

        IQueryable<Staff> query = _db.Staffs.Include(s => s.Campista);

        if (!string.IsNullOrEmpty(busqueda))
        {
            query = query.Where(s => s.Campista.NombreCompleto.Contains(busqueda)
                                   || s.Campista.DocId.Contains(busqueda));
        }

        _view.MostrarStaffFiltrado(query.ToList());
    }

    // Req — login de staff con cédula + contraseña
    public void Login(string docId, string password)
    {
        docId = (docId ?? "").Trim();
        password = (password ?? "").Trim();

        if (string.IsNullOrEmpty(docId))
        {
            _view.MostrarMensaje("Ingrese su cédula.");
            return;
        }
        if (string.IsNullOrEmpty(password))
        {
            _view.MostrarMensaje("Ingrese su contraseña.");
            return;
        }

        var staff = _db.Staffs.Include(s => s.Campista)
            .FirstOrDefault(s => s.Campista.DocId == docId && s.Password == password);

        if (staff == null)
        {
            _view.MostrarMensaje("Cédula o contraseña incorrectos.");
            return;
        }

        _view.MostrarSesionIniciada(staff);
    }

    private void Validar(int campistaId, string rol, string password)
    {
        if (campistaId <= 0)
            throw new Exception("Debe seleccionar un campista válido.");
        if (string.IsNullOrEmpty(rol))
            throw new Exception("Debe asignar un rol al staff.");
        if (!RolesValidos.Contains(rol))
            throw new Exception("El rol seleccionado no es válido.");
        if (string.IsNullOrEmpty(password) || password.Length < 6)
            throw new Exception("La contraseña debe tener mínimo 6 caracteres.");
    }

    public void Cargar(string tipo)
    {
        var view = ObtenerVistaVisualizacion();
        _tipoVisualizacion = string.IsNullOrWhiteSpace(tipo) ? "Campistas" : tipo;
        view.MostrarTitulo("Visualización: " + _tipoVisualizacion);
        FiltrarVisualizacion("");
    }

    // Filtra Campistas, Tutores o Inscripciones según el tipo cargado.
    private void FiltrarVisualizacion(string texto)
    {
        var view = ObtenerVistaVisualizacion();
        texto = (texto ?? "").Trim().ToLower();

        switch (_tipoVisualizacion)
        {
            case "Tutores":
                var tutores = _db.Tutores.AsNoTracking()
                    .Select(t => new
                    {
                        ID = t.TutorId,
                        Nombre = t.NombreCompleto,
                        Cedula = t.DocId,
                        Edad = t.Edad,
                        Sexo = t.Sexo,
                        Celular = t.NumeroCelular,
                        IdCampista = t.CampistaId
                    }).ToList()
                    .Where(t => string.IsNullOrEmpty(texto)
                             || t.Nombre.ToLower().Contains(texto)
                             || t.Cedula.ToLower().Contains(texto)
                             || t.ID.ToString().Contains(texto)).ToList();
                view.MostrarDatos(tutores);
                break;

            case "Inscripciones":
                var inscripciones = _db.Inscripciones.AsNoTracking()
                    .Include(i => i.Campista)
                    .Include(i => i.Cabana)
                    .Select(i => new
                    {
                        ID = i.InscripcionId,
                        FInscripcion = i.FechaInscripcion,
                        FInicio = i.FechaInicio,
                        FFinalizacion = i.FechaFinalizacion,
                        Costo = i.Costo,
                        Estado = i.Estado,
                        Campista = i.Campista.NombreCompleto,
                        Cabana = i.Cabana.CodigoCabana
                    }).ToList()
                    .Where(i => string.IsNullOrEmpty(texto)
                             || i.Estado.ToLower().Contains(texto)
                             || i.ID.ToString().Contains(texto)
                             || i.Campista.ToLower().Contains(texto)).ToList();
                view.MostrarDatos(inscripciones);
                break;

            default:
                var campistas = _db.Campistas.AsNoTracking()
                    .Include(c => c.Departamento)
                    .Select(c => new
                    {
                        ID = c.CampistaId,
                        Nombre = c.NombreCompleto,
                        Cedula = c.DocId,
                        Edad = c.Edad,
                        Sexo = c.Sexo,
                        Celular = c.NumeroCelular,
                        Correo = c.Gmail,
                        Direccion = c.Direccion,
                        Departamento = c.Departamento.Nombre
                    }).ToList()
                    .Where(c => string.IsNullOrEmpty(texto)
                             || c.Nombre.ToLower().Contains(texto)
                             || c.Cedula.ToLower().Contains(texto)
                             || c.ID.ToString().Contains(texto)).ToList();
                view.MostrarDatos(campistas);
                break;
        }
    }

    private IVisualizacionView ObtenerVistaVisualizacion() =>
        _visualizacionView ?? throw new InvalidOperationException("Este presenter no fue creado para visualización.");
}
