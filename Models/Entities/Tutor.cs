namespace App_CAMPSYS.Models.Entities;

public partial class Tutor
{
    public int TutorId { get; set; }

    public string NombreCompleto { get; set; } = null!;

    public string DocId { get; set; } = null!;

    public int Edad { get; set; }

    public string Sexo { get; set; } = null!;

    public string NumeroCelular { get; set; } = null!;

    public int CampistaId { get; set; }

    public virtual Campista Campista { get; set; } = null!;
}
