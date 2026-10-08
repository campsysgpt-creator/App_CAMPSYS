using App_CAMPSYS.Presenters;
using App_CAMPSYS.View.Interfaces;
using System.Drawing;

namespace App_CAMPSYS.View;

public partial class FormInscripcion : Form, IInscripcionView
{
    private readonly InscripcionPresenter _presenter;

    public FormInscripcion()
    {
        InitializeComponent();
        this.WindowState = FormWindowState.Maximized;
        this.MinimumSize = new Size(900, 700);

        // El Form se pasa a sí mismo como IInscripcionView — el Presenter
        // no conoce WinForms, solo la interfaz.
        _presenter = new InscripcionPresenter(this);
    }

    private void FormInscripcion_Load(object sender, EventArgs e)
    {
        _presenter.CargarDatosIniciales();
    }

    // ================= IInscripcionView =================

    public string NombreCompleto
    {
        get => txtnombrecompleto.Text;
        set => txtnombrecompleto.Text = value;
    }

    public string DocId
    {
        get => mtxtdocid.Text.Trim().Replace("-", "").Replace("_", "");
        set => mtxtdocid.Text = value;
    }

    public int Edad
    {
        get => (int)nudedad.Value;
        set => nudedad.Value = value;
    }

    public string Sexo
    {
        get => cmbsexo.Text;
        set => cmbsexo.Text = value;
    }

    public string NumeroCelular
    {
        get => txtnumerocelular.Text;
        set => txtnumerocelular.Text = value;
    }

    public string Gmail
    {
        get => txtgmail.Text;
        set => txtgmail.Text = value;
    }

    public string Direccion
    {
        get => txtdireccion.Text;
        set => txtdireccion.Text = value;
    }

    public int DepartamentoIdSeleccionado
    {
        get => cmbdepartamento.SelectedValue is int id ? id : 0;
        set => cmbdepartamento.SelectedValue = value;
    }

    public bool RequiereTutor
    {
        get => grpTutor.Enabled;
        set => grpTutor.Enabled = value;
    }

    public string TutorNombreCompleto
    {
        get => txttutornombre.Text;
        set => txttutornombre.Text = value;
    }

    public string TutorDocId
    {
        get => mtxttutordocid.Text;
        set => mtxttutordocid.Text = value;
    }

    public int TutorEdad
    {
        get => (int)nudtutoredad.Value;
        set => nudtutoredad.Value = value;
    }

    public string TutorSexo
    {
        get => cmbtutorsexo.Text;
        set => cmbtutorsexo.Text = value;
    }

    public string TutorNumeroCelular
    {
        get => txttutorcelular.Text;
        set => txttutorcelular.Text = value;
    }

    public DateTime FechaInicio
    {
        get => dtpfechainicio.Value;
        set => dtpfechainicio.Value = value;
    }

    public DateTime FechaFinalizacion
    {
        get => dtpfechafinalizacion.Value;
        set => dtpfechafinalizacion.Value = value;
    }

    public int CabanaIdSeleccionada
    {
        get => cmbcabana.SelectedValue is int id ? id : 0;
        set => cmbcabana.SelectedValue = value;
    }

    public IReadOnlyList<int> ActividadesSeleccionadasIds
    {
        get
        {
            var ids = new List<int>();
            foreach (var item in lstactividades.Items)
            {
                if (item is ActividadItem actividad)
                    ids.Add(actividad.Id);
            }
            return ids;
        }
    }

    public void CargarDepartamentos(IEnumerable<DepartamentoItem> departamentos)
    {
        cmbdepartamento.DataSource = departamentos.ToList();
        cmbdepartamento.DisplayMember = nameof(DepartamentoItem.Nombre);
        cmbdepartamento.ValueMember = nameof(DepartamentoItem.Id);
    }

    public void CargarCabanasDisponibles(IEnumerable<CabanaItem> cabanas)
    {
        cmbcabana.DataSource = cabanas.ToList();
        cmbcabana.DisplayMember = nameof(CabanaItem.Codigo);
        cmbcabana.ValueMember = nameof(CabanaItem.Id);
    }

    public void CargarActividades(IEnumerable<ActividadItem> actividades)
    {
        lstactividades.DataSource = actividades.ToList();
        lstactividades.DisplayMember = nameof(ActividadItem.Nombre);
        lstactividades.ValueMember = nameof(ActividadItem.Id);
    }

    public void MostrarCostoCalculado(decimal costo)
    {
        lblcosto.Text = "C$ " + costo.ToString("0.00");
    }

    public void HabilitarSeccionTutor(bool habilitar) => grpTutor.Enabled = habilitar;

    public void HabilitarCampoDocId(bool habilitar)
    {
        mtxtdocid.Enabled = habilitar;
        mtxtdocid.BackColor = habilitar ? Color.White : Color.LightGray;
        if (!habilitar) mtxtdocid.Text = "";
    }

    public event EventHandler? GrabarClicked;
    public event EventHandler? EdadCambiada;
    public event EventHandler? FechasCambiadas;

    public void ShowMessage(string mensaje, bool esExito)
    {
        using var frm = new FrmMensaje(mensaje, esExito);
        frm.ShowDialog(this);
    }

    public void LimpiarFormulario()
    {
        txtnombrecompleto.Clear();
        mtxtdocid.Clear();
        nudedad.Value = nudedad.Minimum;
        txtnumerocelular.Clear();
        txtgmail.Clear();
        txtdireccion.Clear();
        txttutornombre.Clear();
        mtxttutordocid.Clear();
        txttutorcelular.Clear();
    }

    // ================= Eventos crudos de WinForms -> se los paso al Presenter =================

    private void nudedad_ValueChanged(object sender, EventArgs e) => EdadCambiada?.Invoke(this, e);

    private void dtpfechainicio_ValueChanged(object sender, EventArgs e) => FechasCambiadas?.Invoke(this, e);

    private void dtpfechafinalizacion_ValueChanged(object sender, EventArgs e) => FechasCambiadas?.Invoke(this, e);

    private void btngrabar_Click_1(object sender, EventArgs e) => GrabarClicked?.Invoke(this, e);

    private void btncancelar_Click(object sender, EventArgs e) => this.Close();

    private void cmbdepartamento_SelectedIndexChanged(object sender, EventArgs e) { }

    private void mtxtdocid_MaskInputRejected(object sender, MaskInputRejectedEventArgs e) { }

    private void lblCostoTitulo_Click(object sender, EventArgs e) { }

    private void grpTutor_Enter(object sender, EventArgs e) { }

    // Responsividad — redistribuye controles al cambiar tamaño (queda igual, es puramente visual)
    private void FormInscripcion_Resize(object sender, EventArgs e)
    {
        int margen = 20;
        int ancho = this.ClientSize.Width - (margen * 2);

        grpCampista.SetBounds(margen, 10, ancho, grpCampista.Height);
        grpTutor.SetBounds(margen, grpCampista.Bottom + 10, ancho, grpTutor.Height);
        grpInscripcion.SetBounds(margen, grpTutor.Bottom + 10, ancho, grpInscripcion.Height);
    }

    private void grpCampista_Enter(object sender, EventArgs e)
    {

    }
}
