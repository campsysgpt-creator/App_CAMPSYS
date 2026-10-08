using System.Drawing;
using App_CAMPSYS.Models.Entities;
using App_CAMPSYS.Presenters;
using App_CAMPSYS.View.Interfaces;

namespace App_CAMPSYS.View;

public partial class FormModificar : FormularioBase, IModificarView
{
    private readonly InscripcionPresenter p;

    public FormModificar()
    {
        InitializeComponent();
        p = new InscripcionPresenter(this);
        this.WindowState = FormWindowState.Maximized;
        this.MinimumSize = new Size(900, 700);

        // El Designer agrega tableLayoutPanel1 (Dock=Fill, ocupa todo el form)
        // ANTES que txtbuscar/btnbuscar en el z-order — eso hace que el panel
        // completo se dibuje ENCIMA del cuadro de búsqueda, dejándolo invisible
        // y sin poder hacerle clic (se sentía como "pantalla congelada").
        // Se los trae al frente explícitamente.
        btnbuscar.BringToFront();
        txtbuscar.BringToFront();
    }

    private void FormModificar_Load(object sender, EventArgs e)
    {
        // El Designer trae "Buscar por nombre o cédula" como texto REAL del
        // campo (no es un placeholder visual). Si no se limpia aquí, el primer
        // clic en Buscar busca ese texto literal, no encuentra nada y los
        // grupos (deshabilitados por diseño hasta encontrar un registro)
        // nunca se habilitan — eso es lo que se veía como "formulario
        // inhabilitado que no deja buscar".
        txtbuscar.Text = "";
        txtbuscar.ForeColor = TextColor;
        txtbuscar.GotFocus += (s, args) =>
        {
            if (txtbuscar.Text == "Buscar por nombre o cédula")
            {
                txtbuscar.Text = "";
                txtbuscar.ForeColor = TextColor;
            }
        };
        txtbuscar.LostFocus += (s, args) =>
        {
            if (string.IsNullOrWhiteSpace(txtbuscar.Text))
            {
                txtbuscar.Text = "Buscar por nombre o cédula";
                txtbuscar.ForeColor = Color.Gray;
            }
        };

        // Los grupos ya nacen deshabilitados desde el Designer (Enabled=false)
        // hasta que una búsqueda encuentre un registro válido.
        p.CargarInicial();
    }

    private void grpCampista_Enter(object sender, EventArgs e) { }

    // Req nuevo: igual que en FormInscripcion, el grupo de Tutor se habilita/
    // deshabilita automáticamente en cuanto se escribe la edad del campista
    // (regla de negocio: menor de 18 requiere tutor), sin esperar a que se
    // guarde el cambio.
    private void nudedad_ValueChanged(object sender, EventArgs e)
    {
        grpTutor.Enabled = InscripcionPresenter.RequiereTutor((int)nudedad.Value);
    }

    // Req — buscar por nombre/cédula de campista O tutor
    private void btnbuscar_Click(object sender, EventArgs e)
    {
        string texto = txtbuscar.Text.Trim();
        if (texto.Equals("Buscar por nombre o cédula", StringComparison.OrdinalIgnoreCase))
            texto = "";

        if (string.IsNullOrWhiteSpace(texto))
        {
            MessageBox.Show("Escriba un nombre o cédula para buscar.", "Aviso");
            return;
        }

        p.Buscar(texto);
    }

    private void btnactualizar_Click(object sender, EventArgs e) => Guardar();

    private void btneliminar_Click(object sender, EventArgs e)
    {
        var confirm = MessageBox.Show(
            "¿Está seguro de eliminar esta inscripción? Esta acción no se puede deshacer.",
            "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

        if (confirm == DialogResult.Yes)
        {
            p.Eliminar();
            this.Close();
        }
    }

    private void Guardar()
    {
        var actividadesIds = lstactividades.Items
            .Cast<ActividadItem>()
            .Select(a => a.Id)
            .ToList();

        p.Actualizar(
            txtnombrecompleto.Text, txtdocid.Text, (int)nudedad.Value, cmbsexo.Text, txtnumerocelular.Text,
            txtgmail.Text, txtdireccion.Text, cmbdepartamento.SelectedValue is int depId ? depId : 0,
            grpTutor.Enabled, txttutornombre.Text, txttutordocid.Text, (int)nudtutoredad.Value,
            cmbtutorsexo.Text, txttutorcelular.Text,
            dtpfechainicio.Value, dtpfechafinalizacion.Value,
            cmbcabana.SelectedValue is int cabId ? cabId : 0,
            cmbestado.SelectedItem?.ToString() ?? "Activo",
            actividadesIds);
    }

    // ================= IModificarView =================

    public void CargarDepartamentos(List<DepartamentoItem> departamentos)
    {
        cmbdepartamento.DataSource = departamentos;
        cmbdepartamento.DisplayMember = nameof(DepartamentoItem.Nombre);
        cmbdepartamento.ValueMember = nameof(DepartamentoItem.Id);
    }

    public void CargarCabanas(List<CabanaItem> cabanas)
    {
        cmbcabana.DataSource = cabanas;
        cmbcabana.DisplayMember = nameof(CabanaItem.Codigo);
        cmbcabana.ValueMember = nameof(CabanaItem.Id);
    }

    public void CargarActividades(List<ActividadItem> actividades)
    {
        lstactividades.DataSource = actividades;
        lstactividades.DisplayMember = nameof(ActividadItem.Nombre);
        lstactividades.ValueMember = nameof(ActividadItem.Id);
    }

    public void MostrarResultadoBusqueda(Campista campista, Tutor? tutor, Inscripcion? inscripcion)
    {
        txtnombrecompleto.Text = campista.NombreCompleto;
        txtdocid.Text = campista.DocId;
        nudedad.Value = Math.Max(nudedad.Minimum, Math.Min(nudedad.Maximum, campista.Edad));
        cmbsexo.Text = campista.Sexo;
        txtnumerocelular.Text = campista.NumeroCelular;
        txtgmail.Text = campista.Gmail;
        txtdireccion.Text = campista.Direccion;
        cmbdepartamento.SelectedValue = campista.DepartamentoId;

        if (tutor != null)
        {
            grpTutor.Enabled = true;
            txttutornombre.Text = tutor.NombreCompleto;
            txttutordocid.Text = tutor.DocId;
            nudtutoredad.Value = Math.Max(nudtutoredad.Minimum, Math.Min(nudtutoredad.Maximum, tutor.Edad));
            cmbtutorsexo.Text = tutor.Sexo;
            txttutorcelular.Text = tutor.NumeroCelular;
        }
        else
        {
            grpTutor.Enabled = false;
        }

        if (inscripcion != null)
        {
            dtpfechainicio.Value = inscripcion.FechaInicio;
            dtpfechafinalizacion.Value = inscripcion.FechaFinalizacion;
            cmbcabana.SelectedValue = inscripcion.CabanaId;
            lblcosto.Text = "C$ " + inscripcion.Costo.ToString("0.00");

            cmbestado.Items.Clear();
            cmbestado.Items.Add("Activo");
            cmbestado.Items.Add("Inactivo");
            cmbestado.SelectedItem = inscripcion.Estado;
        }

        grpCampista.Enabled = true;
        grpInscripcion.Enabled = true;
        btnactualizar.Enabled = true;
        btneliminar.Enabled = true;
    }

    public void MostrarSinResultadoBusqueda()
        => MessageBox.Show("No se encontró ningún registro con ese nombre o cédula.", "Aviso");

    public void MostrarMensaje(string mensaje) => MessageBox.Show(mensaje, "CAMPSYS");

    private void grpInscripcion_Enter(object sender, EventArgs e)
    {

    }
}
