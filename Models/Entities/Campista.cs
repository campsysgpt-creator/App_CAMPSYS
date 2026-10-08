using System.Collections.Generic;

namespace App_CAMPSYS.Models.Entities;

public partial class Campista
{
    public int CampistaId { get; set; }

    public string NombreCompleto { get; set; } = null!;

    public string DocId { get; set; } = null!;

    public int Edad { get; set; }

    public string Sexo { get; set; } = null!;

    public string NumeroCelular { get; set; } = null!;

    public string Gmail { get; set; } = null!;

    public string Direccion { get; set; } = null!;

    public int DepartamentoId { get; set; }

    public string Tipo { get; set; } = null!;

    public virtual Departamento Departamento { get; set; } = null!;

    public virtual ICollection<Tutor> Tutores { get; set; } = new List<Tutor>();

    public virtual ICollection<Staff> Staffs { get; set; } = new List<Staff>();

    public virtual ICollection<Inscripcion> Inscripciones { get; set; } = new List<Inscripcion>();
}
