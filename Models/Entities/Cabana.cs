using System.Collections.Generic;

namespace App_CAMPSYS.Models.Entities;

public partial class Cabana
{
    public int CabanaId { get; set; }

    public string CodigoCabana { get; set; } = null!;

    public string Ubicacion { get; set; } = null!;

    public int Capacidad { get; set; }

    public int CuposDisponibles { get; set; }

    public virtual ICollection<Inscripcion> Inscripciones { get; set; } = new List<Inscripcion>();
}
