using System.Drawing;
using App_CAMPSYS.Presenters;
using App_CAMPSYS.View.Interfaces;

namespace App_CAMPSYS.View;

public partial class FormVisualizacion : FormularioBase, IVisualizacionView
{
    private readonly StaffPresenter p;
    private readonly string tipovista;

    public FormVisualizacion() : this("Campistas") { }

    public FormVisualizacion(string tipo)
    {
        InitializeComponent();
        tipovista = string.IsNullOrWhiteSpace(tipo) ? "Campistas" : tipo;
        p = new StaffPresenter(this);
        this.WindowState = FormWindowState.Maximized;
        this.MinimumSize = new Size(800, 600);
        AplicarEstilos();
    }

    private void AplicarEstilos()
    {
        EstilizarBotonSecundario(btnfiltrar);
        EstilizarTituloSeccion(lbltitulo);
        dgvdatos.BackgroundColor = Color.White;
        dgvdatos.BorderStyle = BorderStyle.FixedSingle;
        dgvdatos.GridColor = BorderColor;
        dgvdatos.DefaultCellStyle.SelectionBackColor = PrimaryColor;
        dgvdatos.DefaultCellStyle.SelectionForeColor = Color.White;
    }

    private void FormVisualizacion_Load(object sender, EventArgs e)
    {
        GuardarPosicionesOriginales();

        dgvdatos.ReadOnly = true;
        dgvdatos.AllowUserToAddRows = false;
        dgvdatos.AllowUserToDeleteRows = false;
        dgvdatos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        dgvdatos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        dgvdatos.BackgroundColor = Color.White;

        // Placeholder para el TextBox de búsqueda
        txtfiltro.Text = "Buscar...";
        txtfiltro.ForeColor = Color.Gray;
        txtfiltro.GotFocus += (s, args) =>
        {
            if (txtfiltro.Text == "Buscar...") { txtfiltro.Text = ""; txtfiltro.ForeColor = TextColor; }
        };
        txtfiltro.LostFocus += (s, args) =>
        {
            if (string.IsNullOrWhiteSpace(txtfiltro.Text)) { txtfiltro.Text = "Buscar..."; txtfiltro.ForeColor = Color.Gray; }
        };

        p.Cargar(tipovista);
    }

    private void FormVisualizacion_Resize(object sender, EventArgs e) => RedimensionarFormulario();

    private void btnfiltrar_Click(object sender, EventArgs e)
    {
        string filtro = txtfiltro.Text.Trim();
        if (filtro.Equals("Buscar...", StringComparison.OrdinalIgnoreCase))
            filtro = "";
        p.Filtrar(filtro);
    }

    // ================= IVisualizacionView =================

    public void MostrarDatos(object datos) => dgvdatos.DataSource = datos;

    public void MostrarTitulo(string titulo) => lbltitulo.Text = titulo;
}
