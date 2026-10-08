namespace App_CAMPSYS.Models.Entities;

public partial class DetalleInscripcionActividad
{
    public int DetalleId { get; set; }

    public int InscripcionId { get; set; }

    public int ActividadId { get; set; }

    public virtual Inscripcion Inscripcion { get; set; } = null!;

    public virtual Actividades Actividad { get; set; } = null!;
}
