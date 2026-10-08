using App_CAMPSYS.Models.Entities;

namespace App_CAMPSYS.View.Interfaces;

public interface IStaffView
{
    void MostrarRolesValidos(List<string> roles);
    void MostrarResultadoBusqueda(Campista campista, Staff? staffExistente);
    void MostrarSinResultadoBusqueda();
    void MostrarStaffFiltrado(List<Staff> staff);
    void MostrarSesionIniciada(Staff staff);
    void MostrarMensaje(string mensaje);
    void LimpiarFormulario();
}
