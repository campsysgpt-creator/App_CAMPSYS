using System.Drawing;
using System.Windows.Forms;

namespace App_CAMPSYS.View;

// Clase base de estilos y responsividad, migrada desde CapaPresentacion.FormularioBase
// (arquitectura de capas). En la migración a MVP + EF Core esta clase nunca se portó,
// por eso ningún formulario nuevo tenía estilos ni redimensionado de controles.
public class FormularioBase : Form
{
    protected static readonly Color PrimaryColor = Color.FromArgb(22, 101, 52);   // Verde bosque
    protected static readonly Color PrimaryLight = Color.FromArgb(34, 197, 94);   // Verde claro
    protected static readonly Color PrimaryDark = Color.FromArgb(14, 68, 36);     // Verde oscuro
    protected static readonly Color AccentColor = Color.FromArgb(245, 158, 11);   // Ámbar
    protected static readonly Color SecondaryColor = Color.FromArgb(16, 185, 129); // Esmeralda
    protected static readonly Color SuccessColor = Color.FromArgb(34, 197, 94);   // Verde éxito
    protected static readonly Color DangerColor = Color.FromArgb(220, 38, 38);    // Rojo
    protected static readonly Color TextColor = Color.FromArgb(15, 23, 42);       // Casi negro
    protected static readonly Color TextLight = Color.FromArgb(100, 116, 139);    // Gris medio
    protected static readonly Color BorderColor = Color.FromArgb(203, 213, 225);  // Borde suave
    protected static readonly Color BackColorLight = Color.FromArgb(240, 253, 244); // Fondo verde muy claro
    protected static readonly Color CardColor = Color.White;
    protected static readonly Color HeaderColor = Color.FromArgb(22, 101, 52);

    public FormularioBase()
    {
        this.BackColor = BackColorLight;
        this.Font = new Font("Segoe UI", 9F, FontStyle.Regular);
        this.ForeColor = TextColor;
    }

    // ── Estilos de botones ────────────────────────────────────────
    protected void EstilizarBotonPrimario(Button btn)
    {
        btn.BackColor = PrimaryColor;
        btn.ForeColor = Color.White;
        btn.FlatStyle = FlatStyle.Flat;
        btn.FlatAppearance.BorderSize = 0;
        btn.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        btn.Cursor = Cursors.Hand;
        btn.Height = 36;
    }

    protected void EstilizarBotonSecundario(Button btn)
    {
        btn.BackColor = CardColor;
        btn.ForeColor = PrimaryColor;
        btn.FlatStyle = FlatStyle.Flat;
        btn.FlatAppearance.BorderSize = 1;
        btn.FlatAppearance.BorderColor = PrimaryColor;
        btn.Font = new Font("Segoe UI", 9F);
        btn.Cursor = Cursors.Hand;
        btn.Height = 36;
    }

    protected void EstilizarBotonPeligro(Button btn)
    {
        btn.BackColor = DangerColor;
        btn.ForeColor = Color.White;
        btn.FlatStyle = FlatStyle.Flat;
        btn.FlatAppearance.BorderSize = 0;
        btn.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        btn.Cursor = Cursors.Hand;
        btn.Height = 36;
    }

    protected void EstilizarBotonAccent(Button btn)
    {
        btn.BackColor = AccentColor;
        btn.ForeColor = Color.White;
        btn.FlatStyle = FlatStyle.Flat;
        btn.FlatAppearance.BorderSize = 0;
        btn.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        btn.Cursor = Cursors.Hand;
        btn.Height = 36;
    }

    // ── Estilo GroupBox como "card" ───────────────────────────────
    protected void EstilizarGroupBox(GroupBox gb)
    {
        gb.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        gb.ForeColor = PrimaryColor;
        gb.BackColor = CardColor;
        gb.Padding = new Padding(12, 16, 12, 12);
    }

    protected void EstilizarTituloSeccion(Label lbl)
    {
        lbl.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
        lbl.ForeColor = TextColor;
    }

    protected void EstilizarTextBox(TextBox txt)
    {
        txt.Font = new Font("Segoe UI", 9.5F);
        txt.BorderStyle = BorderStyle.FixedSingle;
        txt.Height = 28;
    }

    protected void EstilizarLabel(Label lbl)
    {
        lbl.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        lbl.ForeColor = TextLight;
        lbl.AutoSize = true;
    }

    // ── Responsividad reutilizable ─────────────────────────────────
    // Antes esta lógica estaba duplicada en cada formulario (FormStaff,
    // FormVisualizacion...). Aquí queda una sola vez para toda la app.
    private Dictionary<Control, Rectangle>? controlesOriginales;
    private Size formularioTamanioOriginal;

    protected void GuardarPosicionesOriginales()
    {
        controlesOriginales = new Dictionary<Control, Rectangle>();
        formularioTamanioOriginal = this.ClientSize;
        GuardarControlesRecursivo(this);
    }

    private void GuardarControlesRecursivo(Control parent)
    {
        foreach (Control c in parent.Controls)
        {
            controlesOriginales![c] = new Rectangle(c.Location, c.Size);
            if (c.HasChildren) GuardarControlesRecursivo(c);
        }
    }

    protected void RedimensionarFormulario()
    {
        if (controlesOriginales == null || formularioTamanioOriginal.IsEmpty) return;
        float escalaX = (float)this.ClientSize.Width / formularioTamanioOriginal.Width;
        float escalaY = (float)this.ClientSize.Height / formularioTamanioOriginal.Height;
        foreach (var kvp in controlesOriginales)
        {
            Control c = kvp.Key;
            if (c == null || c.IsDisposed) continue;
            Rectangle orig = kvp.Value;
            c.Location = new Point((int)(orig.X * escalaX), (int)(orig.Y * escalaY));
            c.Size = new Size((int)(orig.Width * escalaX), (int)(orig.Height * escalaY));
        }
        this.Invalidate();
    }
}
