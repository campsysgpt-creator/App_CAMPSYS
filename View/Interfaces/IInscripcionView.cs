using System;
using System.Collections.Generic;

namespace App_CAMPSYS.View.Interfaces;

public interface IInscripcionView
{
    // ---- Datos del Campista ----
    string NombreCompleto { get; set; }
    string DocId { get; set; }
    int Edad { get; set; }
    string Sexo { get; set; }
    string NumeroCelular { get; set; }
    string Gmail { get; set; }
    string Direccion { get; set; }
    int DepartamentoIdSeleccionado { get; set; }

    // ---- Datos del Tutor (solo si aplica) ----
    bool RequiereTutor { get; set; }
    string TutorNombreCompleto { get; set; }
    string TutorDocId { get; set; }
    int TutorEdad { get; set; }
    string TutorSexo { get; set; }
    string TutorNumeroCelular { get; set; }

    // ---- Datos de la Inscripción ----
    DateTime FechaInicio { get; set; }
    DateTime FechaFinalizacion { get; set; }
    int CabanaIdSeleccionada { get; set; }
    IReadOnlyList<int> ActividadesSeleccionadasIds { get; }

    // ---- Carga de combos/listas (el Presenter alimenta la vista) ----
    void CargarDepartamentos(IEnumerable<DepartamentoItem> departamentos);
    void CargarCabanasDisponibles(IEnumerable<CabanaItem> cabanas);
    void CargarActividades(IEnumerable<ActividadItem> actividades);
    void MostrarCostoCalculado(decimal costo);
    void HabilitarSeccionTutor(bool habilitar);
    void HabilitarCampoDocId(bool habilitar);

    // ---- Eventos que la Vista notifica al Presenter ----
    event EventHandler GrabarClicked;
    event EventHandler EdadCambiada;
    event EventHandler FechasCambiadas;

    // ---- Feedback al usuario ----
    void ShowMessage(string mensaje, bool esExito);
    void LimpiarFormulario();
}
