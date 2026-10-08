namespace App_CAMPSYS.View.Interfaces;

// WinForms usa reflexión (TypeDescriptor) para DisplayMember/ValueMember.
// Los ValueTuple NO sirven para esto: sus nombres de campo solo existen
// en tiempo de compilación. Por eso usamos records — sí generan
// propiedades reales en tiempo de ejecución.

public record DepartamentoItem(int Id, string Nombre);

public record CabanaItem(int Id, string Codigo);

public record ActividadItem(int Id, string Nombre, decimal Costo);
