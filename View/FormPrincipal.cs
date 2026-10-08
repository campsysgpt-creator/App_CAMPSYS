using System.Drawing;

namespace App_CAMPSYS.View;

public partial class FormPrincipal : FormularioBase
{
    public FormPrincipal()
    {
        InitializeComponent();
    }

    private void FormPrincipal_Load(object sender, EventArgs e) { }

    private void FormPrincipal_Resize(object sender, EventArgs e) { }

    // Borde izquierdo verde decorativo en cada tarjeta (migrado desde CapaPresentacion.FormPrincipal;
    // se había perdido y por eso las tarjetas del menú no mostraban su estilo).
    private void Panel_Paint(object sender, PaintEventArgs e)
    {
        if (sender is not Panel pnl) return;
        using (Pen pen = new Pen(Color.FromArgb(22, 101, 52), 4))
            e.Graphics.DrawLine(pen, 0, 0, 0, pnl.Height);
        using (Pen borde = new Pen(Color.FromArgb(220, 252, 231), 1))
            e.Graphics.DrawRectangle(borde, 0, 0, pnl.Width - 1, pnl.Height - 1);
    }

    private void pnlContent_Paint(object sender, PaintEventArgs e) { }
    private void pnlHeader_Paint(object sender, PaintEventArgs e) { }
    private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e) { }

    private void btnInscripcion_Click(object sender, EventArgs e) => new FormInscripcion().ShowDialog();
    private void btnModificar_Click(object sender, EventArgs e) => new FormModificar().ShowDialog();
    private void btnStaff_Click(object sender, EventArgs e) => new FormStaff().ShowDialog();

    private void btnVerCampistas_Click(object sender, EventArgs e) => new FormVisualizacion("Campistas").ShowDialog();
    private void btnVerInscripciones_Click(object sender, EventArgs e) => new FormVisualizacion("Inscripciones").ShowDialog();
    private void btnVerTutores_Click(object sender, EventArgs e) => new FormVisualizacion("Tutores").ShowDialog();

    private void btnAyuda_Click(object sender, EventArgs e)
        => MessageBox.Show("Sistema CAMPSYS\nGestión de campamento.", "Ayuda");
}
