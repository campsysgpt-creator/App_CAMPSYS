using System.Collections.Generic;

namespace App_CAMPSYS.Models.Entities;

public partial class Departamento
{
    public int DepartamentoId { get; set; }

    public string Codigo { get; set; } = null!;

    public string Nombre { get; set; } = null!;

    public bool Estado { get; set; }

    public virtual ICollection<Campista> Campistas { get; set; } = new List<Campista>();
}
