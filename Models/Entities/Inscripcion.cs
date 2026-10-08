using System;
using System.Collections.Generic;

namespace App_CAMPSYS.Models.Entities;

public partial class Inscripcion
{
    public int InscripcionId { get; set; }

    public DateTime FechaInscripcion { get; set; }

    public DateTime FechaInicio { get; set; }

    public DateTime FechaFinalizacion { get; set; }

    public decimal Costo { get; set; }

    public string Estado { get; set; } = null!;

    public int CampistaId { get; set; }

    public int CabanaId { get; set; }

    public virtual Campista Campista { get; set; } = null!;

    public virtual Cabana Cabana { get; set; } = null!;

    public virtual ICollection<DetalleInscripcionActividad> Detalles { get; set; } = new List<DetalleInscripcionActividad>();
}
