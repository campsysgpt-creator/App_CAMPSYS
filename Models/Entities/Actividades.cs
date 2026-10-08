using System.Collections.Generic;

namespace App_CAMPSYS.Models.Entities;

public partial class Actividades
{
    public int ActividadId { get; set; }

    public string NombreActividad { get; set; } = null!;

    public decimal Costo { get; set; }

    public virtual ICollection<DetalleInscripcionActividad> Detalles { get; set; } = new List<DetalleInscripcionActividad>();
}
