using System.Drawing;
using App_CAMPSYS.Models.Entities;
using App_CAMPSYS.Presenters;
using App_CAMPSYS.View.Interfaces;

namespace App_CAMPSYS.View;

public partial class FormStaff : FormularioBase, IStaffView
{
    private readonly StaffPresenter p;

    private int idcampistacargado = 0;
    private int idstaffcargado = 0;
    private bool stafflogueado = false;

    public FormStaff()
    {
        InitializeComponent();
        p = new StaffPresenter(this);
        this.WindowState = FormWindowState.Maximized;
        this.MinimumSize = new Size(900, 700);
        AplicarEstilos();
    }

    private void AplicarEstilos()
    {
        EstilizarBotonPrimario(btngrabar);
        EstilizarBotonSecundario(btnactualizar);
        EstilizarBotonPeligro(btneliminar);
        EstilizarBotonPrimario(btnlogin);
        EstilizarBotonSecundario(btnbuscar);
        EstilizarBotonSecundario(btnfiltrarstaff);
        EstilizarBotonPrimario(btnvercampistas);

        EstilizarGroupBox(grpLogin);
        EstilizarGroupBox(grpBuscar);
        EstilizarGroupBox(grpDatosCampista);

        lblsesionautiva.ForeColor = SuccessColor;
        lblsesionautiva.Font = new Font("Segoe UI", 9F, FontStyle.Italic);
    }

    private void FormStaff_Load(object sender, EventArgs e)
    {
        GuardarPosicionesOriginales();
        grpDatosCampista.Enabled = false;
        grpLogin.Visible = true;
        dgvstaff.Visible = false;
        btnvercampistas.Visible = false;
        p.CargarInicial();
    }

    private void FormStaff_Resize(object sender, EventArgs e) => RedimensionarFormulario();

    private void btnbuscar_Click(object sender, EventArgs e) => p.Buscar(txtbuscar.Text.Trim());

    private void btngrabar_Click(object sender, EventArgs e)
        => p.Registrar(idcampistacargado, cmbrol.SelectedItem?.ToString() ?? "", txtpassword.Text.Trim());

    private void btnactualizar_Click(object sender, EventArgs e)
        => p.Actualizar(idstaffcargado, cmbrol.SelectedItem?.ToString() ?? "", txtpassword.Text.Trim());

    private void btneliminar_Click(object sender, EventArgs e)
    {
        var confirm = MessageBox.Show("¿Eliminar este registro de staff?", "Confirmar",
            MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
        if (confirm == DialogResult.Yes)
            p.Eliminar(idstaffcargado);
    }

    private void btnfiltrarstaff_Click(object sender, EventArgs e) => p.Filtrar(txtfiltrostaff.Text.Trim());

    private void btnlogin_Click(object sender, EventArgs e)
        => p.Login(txtlogindocid.Text.Trim(), txtloginpassword.Text.Trim());

    private void btnvercampistas_Click(object sender, EventArgs e)
    {
        if (!stafflogueado)
        {
            MessageBox.Show("Debe iniciar sesión primero.", "Acceso denegado");
            return;
        }
        using var frm = new FormVisualizacion("Campistas");
        frm.ShowDialog(this);
    }

    // ================= IStaffView =================

    public void MostrarRolesValidos(List<string> roles)
    {
        cmbrol.DataSource = roles;
    }

    public void MostrarResultadoBusqueda(Campista campista, Staff? staffExistente)
    {
        idcampistacargado = campista.CampistaId;
        txtnombre.Text = campista.NombreCompleto;
        txtdocid.Text = campista.DocId;
        txtedad.Text = campista.Edad.ToString();
        txtsexo.Text = campista.Sexo;
        txtcelular.Text = campista.NumeroCelular;

        if (staffExistente != null)
        {
            idstaffcargado = staffExistente.StaffId;
            cmbrol.SelectedItem = staffExistente.Rol;
            btngrabar.Enabled = false;
            btnactualizar.Enabled = true;
            btneliminar.Enabled = true;
        }
        else
        {
            idstaffcargado = 0;
            btngrabar.Enabled = true;
            btnactualizar.Enabled = false;
            btneliminar.Enabled = false;
        }

        grpDatosCampista.Enabled = true;
    }

    public void MostrarSinResultadoBusqueda()
        => MessageBox.Show("No se encontró ningún campista.", "Aviso");

    public void MostrarStaffFiltrado(List<Staff> staff)
    {
        dgvstaff.DataSource = staff
            .Select(s => new
            {
                Id = s.StaffId,
                Nombre = s.Campista.NombreCompleto,
                Cedula = s.Campista.DocId,
                s.Rol
            })
            .ToList();
        dgvstaff.Visible = true;
        dgvstaff.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
    }

    public void MostrarSesionIniciada(Staff staff)
    {
        stafflogueado = true;

        MessageBox.Show($"Bienvenido {staff.Campista.NombreCompleto}\nRol: {staff.Rol}", "Sesión iniciada",
            MessageBoxButtons.OK, MessageBoxIcon.Information);

        btnvercampistas.Visible = true;
        lblsesionautiva.Text = $"Sesión activa: {staff.Campista.NombreCompleto}";
        lblsesionautiva.Visible = true;
    }

    public void MostrarMensaje(string mensaje) => MessageBox.Show(mensaje, "CAMPSYS");

    public void LimpiarFormulario()
    {
        txtnombre.Text = "";
        txtdocid.Text = "";
        txtedad.Text = "";
        txtsexo.Text = "";
        txtcelular.Text = "";
        txtpassword.Text = "";
        txtfiltrostaff.Text = "";
        idcampistacargado = 0;
        idstaffcargado = 0;
        grpDatosCampista.Enabled = false;
        btngrabar.Enabled = false;
        btnactualizar.Enabled = false;
        btneliminar.Enabled = false;
    }
}
