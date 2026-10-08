using App_CAMPSYS.Models.Entities;

namespace App_CAMPSYS.View.Interfaces;

public interface IModificarView
{
    void CargarDepartamentos(List<DepartamentoItem> departamentos);
    void CargarCabanas(List<CabanaItem> cabanas);
    void CargarActividades(List<ActividadItem> actividades);
    void MostrarResultadoBusqueda(Campista campista, Tutor? tutor, Inscripcion? inscripcion);
    void MostrarSinResultadoBusqueda();
    void MostrarMensaje(string mensaje);
}
