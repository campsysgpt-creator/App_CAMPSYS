namespace App_CAMPSYS.Models.Entities;

public partial class Staff
{
    public int StaffId { get; set; }

    public int CampistaId { get; set; }

    public string Rol { get; set; } = null!;

    public string Password { get; set; } = null!;

    public virtual Campista Campista { get; set; } = null!;
}
