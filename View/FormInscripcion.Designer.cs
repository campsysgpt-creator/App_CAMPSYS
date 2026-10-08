namespace App_CAMPSYS.View
{
    partial class FormInscripcion
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            grpCampista = new GroupBox();
            txtdireccion = new TextBox();
            cmbdepartamento = new ComboBox();
            txtgmail = new TextBox();
            txtnumerocelular = new TextBox();
            cmbsexo = new ComboBox();
            nudedad = new NumericUpDown();
            mtxtdocid = new MaskedTextBox();
            txtnombrecompleto = new TextBox();
            lblDireccionCampista = new Label();
            lblDepartamentoCampista = new Label();
            lblGmailCampista = new Label();
            lblNumeroCelularCampista = new Label();
            lblSexoCampista = new Label();
            lblEdadCampista = new Label();
            lblDocIdCampista = new Label();
            lblNombreCompletoCampista = new Label();
            grpTutor = new GroupBox();
            nudtutoredad = new NumericUpDown();
            cmbtutorsexo = new ComboBox();
            txttutorcelular = new TextBox();
            mtxttutordocid = new MaskedTextBox();
            txttutornombre = new TextBox();
            lblNumeroCelularTutor = new Label();
            lblSexpTutor = new Label();
            lblEdadTutor = new Label();
            lblDocIdTutor = new Label();
            lblNombrCompletoTutor = new Label();
            grpInscripcion = new GroupBox();
            btncancelar = new Button();
            lstactividades = new ListBox();
            lblActividadesIncluidas = new Label();
            btngrabar = new Button();
            cmbcabana = new ComboBox();
            dtpfechafinalizacion = new DateTimePicker();
            dtpfechainicio = new DateTimePicker();
            lblcosto = new Label();
            lblCostoTitulo = new Label();
            lblActividades = new Label();
            lblCabaña = new Label();
            lblFechaFinal = new Label();
            lblfechainicio = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            grpCampista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudedad).BeginInit();
            grpTutor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudtutoredad).BeginInit();
            grpInscripcion.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // grpCampista
            // 
            grpCampista.BackColor = Color.Azure;
            grpCampista.Controls.Add(txtdireccion);
            grpCampista.Controls.Add(cmbdepartamento);
            grpCampista.Controls.Add(txtgmail);
            grpCampista.Controls.Add(txtnumerocelular);
            grpCampista.Controls.Add(cmbsexo);
            grpCampista.Controls.Add(nudedad);
            grpCampista.Controls.Add(mtxtdocid);
            grpCampista.Controls.Add(txtnombrecompleto);
            grpCampista.Controls.Add(lblDireccionCampista);
            grpCampista.Controls.Add(lblDepartamentoCampista);
            grpCampista.Controls.Add(lblGmailCampista);
            grpCampista.Controls.Add(lblNumeroCelularCampista);
            grpCampista.Controls.Add(lblSexoCampista);
            grpCampista.Controls.Add(lblEdadCampista);
            grpCampista.Controls.Add(lblDocIdCampista);
            grpCampista.Controls.Add(lblNombreCompletoCampista);
            grpCampista.Dock = DockStyle.Fill;
            grpCampista.Location = new Point(10, 13);
            grpCampista.Margin = new Padding(3, 5, 3, 5);
            grpCampista.Name = "grpCampista";
            grpCampista.Padding = new Padding(3, 5, 3, 5);
            grpCampista.Size = new Size(1280, 248);
            grpCampista.TabIndex = 0;
            grpCampista.TabStop = false;
            grpCampista.Text = "Datos del Campista";
            grpCampista.Enter += grpCampista_Enter;
            // 
            // txtdireccion
            // 
            txtdireccion.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtdireccion.BorderStyle = BorderStyle.None;
            txtdireccion.Location = new Point(133, 186);
            txtdireccion.Margin = new Padding(3, 5, 3, 5);
            txtdireccion.Name = "txtdireccion";
            txtdireccion.Size = new Size(990, 24);
            txtdireccion.TabIndex = 15;
            // 
            // cmbdepartamento
            // 
            cmbdepartamento.FormattingEnabled = true;
            cmbdepartamento.Location = new Point(638, 136);
            cmbdepartamento.Margin = new Padding(3, 5, 3, 5);
            cmbdepartamento.Name = "cmbdepartamento";
            cmbdepartamento.Size = new Size(248, 33);
            cmbdepartamento.TabIndex = 14;
            cmbdepartamento.SelectedIndexChanged += cmbdepartamento_SelectedIndexChanged;
            // 
            // txtgmail
            // 
            txtgmail.BorderStyle = BorderStyle.None;
            txtgmail.Location = new Point(100, 134);
            txtgmail.Margin = new Padding(3, 5, 3, 5);
            txtgmail.Name = "txtgmail";
            txtgmail.Size = new Size(312, 24);
            txtgmail.TabIndex = 13;
            // 
            // txtnumerocelular
            // 
            txtnumerocelular.BorderStyle = BorderStyle.None;
            txtnumerocelular.Location = new Point(912, 85);
            txtnumerocelular.Margin = new Padding(3, 5, 3, 5);
            txtnumerocelular.Name = "txtnumerocelular";
            txtnumerocelular.Size = new Size(187, 24);
            txtnumerocelular.TabIndex = 12;
            // 
            // cmbsexo
            // 
            cmbsexo.FormattingEnabled = true;
            cmbsexo.Items.AddRange(new object[] { "Masculino", "Femenino" });
            cmbsexo.Location = new Point(638, 80);
            cmbsexo.Margin = new Padding(3, 5, 3, 5);
            cmbsexo.Name = "cmbsexo";
            cmbsexo.Size = new Size(162, 33);
            cmbsexo.TabIndex = 11;
            // 
            // nudedad
            // 
            nudedad.BorderStyle = BorderStyle.None;
            nudedad.Location = new Point(438, 82);
            nudedad.Margin = new Padding(3, 5, 3, 5);
            nudedad.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudedad.Name = "nudedad";
            nudedad.Size = new Size(100, 27);
            nudedad.TabIndex = 10;
            nudedad.Value = new decimal(new int[] { 1, 0, 0, 0 });
            nudedad.ValueChanged += nudedad_ValueChanged;
            // 
            // mtxtdocid
            // 
            mtxtdocid.BorderStyle = BorderStyle.None;
            mtxtdocid.Location = new Point(100, 85);
            mtxtdocid.Margin = new Padding(3, 5, 3, 5);
            mtxtdocid.Mask = "000-000000-0000A";
            mtxtdocid.Name = "mtxtdocid";
            mtxtdocid.Size = new Size(224, 24);
            mtxtdocid.TabIndex = 9;
            mtxtdocid.MaskInputRejected += mtxtdocid_MaskInputRejected;
            // 
            // txtnombrecompleto
            // 
            txtnombrecompleto.BorderStyle = BorderStyle.None;
            txtnombrecompleto.Location = new Point(223, 34);
            txtnombrecompleto.Margin = new Padding(3, 5, 3, 5);
            txtnombrecompleto.Name = "txtnombrecompleto";
            txtnombrecompleto.Size = new Size(500, 24);
            txtnombrecompleto.TabIndex = 8;
            // 
            // lblDireccionCampista
            // 
            lblDireccionCampista.AutoSize = true;
            lblDireccionCampista.Font = new Font("Arial", 10F, FontStyle.Bold);
            lblDireccionCampista.Location = new Point(9, 186);
            lblDireccionCampista.Name = "lblDireccionCampista";
            lblDireccionCampista.Size = new Size(106, 24);
            lblDireccionCampista.TabIndex = 16;
            lblDireccionCampista.Text = "Direccion:";
            // 
            // lblDepartamentoCampista
            // 
            lblDepartamentoCampista.AutoSize = true;
            lblDepartamentoCampista.Font = new Font("Arial", 10F, FontStyle.Bold);
            lblDepartamentoCampista.Location = new Point(464, 136);
            lblDepartamentoCampista.Name = "lblDepartamentoCampista";
            lblDepartamentoCampista.Size = new Size(150, 24);
            lblDepartamentoCampista.TabIndex = 17;
            lblDepartamentoCampista.Text = "Departamento:";
            // 
            // lblGmailCampista
            // 
            lblGmailCampista.AutoSize = true;
            lblGmailCampista.Font = new Font("Arial", 10F, FontStyle.Bold);
            lblGmailCampista.Location = new Point(9, 134);
            lblGmailCampista.Name = "lblGmailCampista";
            lblGmailCampista.Size = new Size(71, 24);
            lblGmailCampista.TabIndex = 18;
            lblGmailCampista.Text = "Gmail:";
            // 
            // lblNumeroCelularCampista
            // 
            lblNumeroCelularCampista.AutoSize = true;
            lblNumeroCelularCampista.Font = new Font("Arial", 10F, FontStyle.Bold);
            lblNumeroCelularCampista.Location = new Point(824, 91);
            lblNumeroCelularCampista.Name = "lblNumeroCelularCampista";
            lblNumeroCelularCampista.Size = new Size(83, 24);
            lblNumeroCelularCampista.TabIndex = 19;
            lblNumeroCelularCampista.Text = "Celular:";
            // 
            // lblSexoCampista
            // 
            lblSexoCampista.AutoSize = true;
            lblSexoCampista.Font = new Font("Arial", 10F, FontStyle.Bold);
            lblSexoCampista.Location = new Point(560, 91);
            lblSexoCampista.Name = "lblSexoCampista";
            lblSexoCampista.Size = new Size(64, 24);
            lblSexoCampista.TabIndex = 20;
            lblSexoCampista.Text = "Sexo:";
            // 
            // lblEdadCampista
            // 
            lblEdadCampista.AutoSize = true;
            lblEdadCampista.Font = new Font("Arial", 10F, FontStyle.Bold);
            lblEdadCampista.Location = new Point(359, 88);
            lblEdadCampista.Name = "lblEdadCampista";
            lblEdadCampista.Size = new Size(65, 24);
            lblEdadCampista.TabIndex = 21;
            lblEdadCampista.Text = "Edad:";
            // 
            // lblDocIdCampista
            // 
            lblDocIdCampista.AutoSize = true;
            lblDocIdCampista.Font = new Font("Arial", 10F, FontStyle.Bold);
            lblDocIdCampista.Location = new Point(9, 85);
            lblDocIdCampista.Name = "lblDocIdCampista";
            lblDocIdCampista.Size = new Size(82, 24);
            lblDocIdCampista.TabIndex = 22;
            lblDocIdCampista.Text = "Cédula:";
            // 
            // lblNombreCompletoCampista
            // 
            lblNombreCompletoCampista.AutoSize = true;
            lblNombreCompletoCampista.Font = new Font("Arial", 10F, FontStyle.Bold);
            lblNombreCompletoCampista.Location = new Point(9, 29);
            lblNombreCompletoCampista.Name = "lblNombreCompletoCampista";
            lblNombreCompletoCampista.Size = new Size(187, 24);
            lblNombreCompletoCampista.TabIndex = 23;
            lblNombreCompletoCampista.Text = "Nombre Completo:";
            // 
            // grpTutor
            // 
            grpTutor.BackColor = Color.Azure;
            grpTutor.Controls.Add(nudtutoredad);
            grpTutor.Controls.Add(cmbtutorsexo);
            grpTutor.Controls.Add(txttutorcelular);
            grpTutor.Controls.Add(mtxttutordocid);
            grpTutor.Controls.Add(txttutornombre);
            grpTutor.Controls.Add(lblNumeroCelularTutor);
            grpTutor.Controls.Add(lblSexpTutor);
            grpTutor.Controls.Add(lblEdadTutor);
            grpTutor.Controls.Add(lblDocIdTutor);
            grpTutor.Controls.Add(lblNombrCompletoTutor);
            grpTutor.Dock = DockStyle.Fill;
            grpTutor.Enabled = false;
            grpTutor.Location = new Point(10, 271);
            grpTutor.Margin = new Padding(3, 5, 3, 5);
            grpTutor.Name = "grpTutor";
            grpTutor.Padding = new Padding(3, 5, 3, 5);
            grpTutor.Size = new Size(1280, 248);
            grpTutor.TabIndex = 8;
            grpTutor.TabStop = false;
            grpTutor.Text = "Datos del Tutor (requerido para menores de 18)";
            grpTutor.Enter += grpTutor_Enter;
            // 
            // nudtutoredad
            // 
            nudtutoredad.BorderStyle = BorderStyle.None;
            nudtutoredad.Location = new Point(89, 118);
            nudtutoredad.Margin = new Padding(3, 5, 3, 5);
            nudtutoredad.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudtutoredad.Name = "nudtutoredad";
            nudtutoredad.Size = new Size(150, 27);
            nudtutoredad.TabIndex = 18;
            nudtutoredad.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // cmbtutorsexo
            // 
            cmbtutorsexo.FormattingEnabled = true;
            cmbtutorsexo.Items.AddRange(new object[] { "Masculino", "Femenino" });
            cmbtutorsexo.Location = new Point(416, 120);
            cmbtutorsexo.Margin = new Padding(3, 5, 3, 5);
            cmbtutorsexo.Name = "cmbtutorsexo";
            cmbtutorsexo.Size = new Size(151, 33);
            cmbtutorsexo.TabIndex = 19;
            // 
            // txttutorcelular
            // 
            txttutorcelular.BorderStyle = BorderStyle.None;
            txttutorcelular.Location = new Point(789, 118);
            txttutorcelular.Margin = new Padding(3, 5, 3, 5);
            txttutorcelular.Name = "txttutorcelular";
            txttutorcelular.Size = new Size(208, 24);
            txttutorcelular.TabIndex = 20;
            // 
            // mtxttutordocid
            // 
            mtxttutordocid.BorderStyle = BorderStyle.None;
            mtxttutordocid.Location = new Point(663, 49);
            mtxttutordocid.Margin = new Padding(3, 5, 3, 5);
            mtxttutordocid.Mask = "000-000000-0000A";
            mtxttutordocid.Name = "mtxttutordocid";
            mtxttutordocid.Size = new Size(333, 24);
            mtxttutordocid.TabIndex = 17;
            // 
            // txttutornombre
            // 
            txttutornombre.BorderStyle = BorderStyle.None;
            txttutornombre.Location = new Point(223, 49);
            txttutornombre.Margin = new Padding(3, 5, 3, 5);
            txttutornombre.Name = "txttutornombre";
            txttutornombre.Size = new Size(333, 24);
            txttutornombre.TabIndex = 16;
            // 
            // lblNumeroCelularTutor
            // 
            lblNumeroCelularTutor.AutoSize = true;
            lblNumeroCelularTutor.Font = new Font("Arial", 10F, FontStyle.Bold);
            lblNumeroCelularTutor.Location = new Point(667, 120);
            lblNumeroCelularTutor.Name = "lblNumeroCelularTutor";
            lblNumeroCelularTutor.Size = new Size(83, 24);
            lblNumeroCelularTutor.TabIndex = 21;
            lblNumeroCelularTutor.Text = "Celular:";
            // 
            // lblSexpTutor
            // 
            lblSexpTutor.AutoSize = true;
            lblSexpTutor.Font = new Font("Arial", 10F, FontStyle.Bold);
            lblSexpTutor.Location = new Point(337, 120);
            lblSexpTutor.Name = "lblSexpTutor";
            lblSexpTutor.Size = new Size(64, 24);
            lblSexpTutor.TabIndex = 22;
            lblSexpTutor.Text = "Sexo:";
            // 
            // lblEdadTutor
            // 
            lblEdadTutor.AutoSize = true;
            lblEdadTutor.Font = new Font("Arial", 10F, FontStyle.Bold);
            lblEdadTutor.Location = new Point(9, 120);
            lblEdadTutor.Name = "lblEdadTutor";
            lblEdadTutor.Size = new Size(65, 24);
            lblEdadTutor.TabIndex = 23;
            lblEdadTutor.Text = "Edad:";
            // 
            // lblDocIdTutor
            // 
            lblDocIdTutor.AutoSize = true;
            lblDocIdTutor.Font = new Font("Arial", 10F, FontStyle.Bold);
            lblDocIdTutor.Location = new Point(564, 49);
            lblDocIdTutor.Name = "lblDocIdTutor";
            lblDocIdTutor.Size = new Size(82, 24);
            lblDocIdTutor.TabIndex = 24;
            lblDocIdTutor.Text = "Cédula:";
            // 
            // lblNombrCompletoTutor
            // 
            lblNombrCompletoTutor.AutoSize = true;
            lblNombrCompletoTutor.Font = new Font("Arial", 10F, FontStyle.Bold);
            lblNombrCompletoTutor.Location = new Point(9, 49);
            lblNombrCompletoTutor.Name = "lblNombrCompletoTutor";
            lblNombrCompletoTutor.Size = new Size(187, 24);
            lblNombrCompletoTutor.TabIndex = 25;
            lblNombrCompletoTutor.Text = "Nombre Completo:";
            // 
            // grpInscripcion
            // 
            grpInscripcion.BackColor = Color.Azure;
            grpInscripcion.Controls.Add(btncancelar);
            grpInscripcion.Controls.Add(lstactividades);
            grpInscripcion.Controls.Add(lblActividadesIncluidas);
            grpInscripcion.Controls.Add(btngrabar);
            grpInscripcion.Controls.Add(cmbcabana);
            grpInscripcion.Controls.Add(dtpfechafinalizacion);
            grpInscripcion.Controls.Add(dtpfechainicio);
            grpInscripcion.Controls.Add(lblcosto);
            grpInscripcion.Controls.Add(lblCostoTitulo);
            grpInscripcion.Controls.Add(lblActividades);
            grpInscripcion.Controls.Add(lblCabaña);
            grpInscripcion.Controls.Add(lblFechaFinal);
            grpInscripcion.Controls.Add(lblfechainicio);
            grpInscripcion.Dock = DockStyle.Fill;
            grpInscripcion.Location = new Point(10, 529);
            grpInscripcion.Margin = new Padding(3, 5, 3, 5);
            grpInscripcion.Name = "grpInscripcion";
            grpInscripcion.Padding = new Padding(3, 5, 3, 5);
            grpInscripcion.Size = new Size(1280, 508);
            grpInscripcion.TabIndex = 9;
            grpInscripcion.TabStop = false;
            grpInscripcion.Text = "Datos de Inscripcion";
            // 
            // btncancelar
            // 
            btncancelar.BackColor = Color.FromArgb(46, 117, 182);
            btncancelar.Font = new Font("Arial", 10F, FontStyle.Bold);
            btncancelar.ForeColor = Color.White;
            btncancelar.Location = new Point(912, 366);
            btncancelar.Margin = new Padding(3, 5, 3, 5);
            btncancelar.Name = "btncancelar";
            btncancelar.Size = new Size(150, 70);
            btncancelar.TabIndex = 0;
            btncancelar.Text = "Cancelar";
            btncancelar.UseVisualStyleBackColor = false;
            // 
            // lstactividades
            // 
            lstactividades.BorderStyle = BorderStyle.None;
            lstactividades.FormattingEnabled = true;
            lstactividades.ItemHeight = 25;
            lstactividades.Location = new Point(392, 152);
            lstactividades.Margin = new Padding(3, 5, 3, 5);
            lstactividades.Name = "lstactividades";
            lstactividades.SelectionMode = SelectionMode.None;
            lstactividades.Size = new Size(374, 150);
            lstactividades.TabIndex = 24;
            lstactividades.TabStop = false;
            // 
            // lblActividadesIncluidas
            // 
            lblActividadesIncluidas.AutoSize = true;
            lblActividadesIncluidas.Font = new Font("Arial", 8F, FontStyle.Italic);
            lblActividadesIncluidas.ForeColor = Color.Gray;
            lblActividadesIncluidas.Location = new Point(388, 329);
            lblActividadesIncluidas.Name = "lblActividadesIncluidas";
            lblActividadesIncluidas.Size = new Size(403, 19);
            lblActividadesIncluidas.TabIndex = 25;
            lblActividadesIncluidas.Text = "C$100 por actividad — todas incluidas en la inscripción";
            // 
            // btngrabar
            // 
            btngrabar.BackColor = Color.FromArgb(200, 60, 60);
            btngrabar.Font = new Font("Arial", 10F, FontStyle.Bold);
            btngrabar.ForeColor = Color.White;
            btngrabar.Location = new Point(1079, 366);
            btngrabar.Margin = new Padding(3, 5, 3, 5);
            btngrabar.Name = "btngrabar";
            btngrabar.Size = new Size(150, 70);
            btngrabar.TabIndex = 1;
            btngrabar.Text = "Grabar";
            btngrabar.UseVisualStyleBackColor = false;
            btngrabar.Click += btngrabar_Click_1;
            // 
            // cmbcabana
            // 
            cmbcabana.FormattingEnabled = true;
            cmbcabana.Location = new Point(113, 125);
            cmbcabana.Margin = new Padding(3, 5, 3, 5);
            cmbcabana.Name = "cmbcabana";
            cmbcabana.Size = new Size(224, 33);
            cmbcabana.TabIndex = 23;
            // 
            // dtpfechafinalizacion
            // 
            dtpfechafinalizacion.Location = new Point(700, 55);
            dtpfechafinalizacion.Margin = new Padding(3, 5, 3, 5);
            dtpfechafinalizacion.Name = "dtpfechafinalizacion";
            dtpfechafinalizacion.Size = new Size(286, 31);
            dtpfechafinalizacion.TabIndex = 22;
            dtpfechafinalizacion.ValueChanged += dtpfechafinalizacion_ValueChanged;
            // 
            // dtpfechainicio
            // 
            dtpfechainicio.Location = new Point(163, 55);
            dtpfechainicio.Margin = new Padding(3, 5, 3, 5);
            dtpfechainicio.Name = "dtpfechainicio";
            dtpfechainicio.Size = new Size(286, 31);
            dtpfechainicio.TabIndex = 21;
            dtpfechainicio.ValueChanged += dtpfechainicio_ValueChanged;
            // 
            // lblcosto
            // 
            lblcosto.AutoSize = true;
            lblcosto.Font = new Font("Arial", 14F, FontStyle.Bold);
            lblcosto.ForeColor = Color.DarkGreen;
            lblcosto.Location = new Point(832, 212);
            lblcosto.Name = "lblcosto";
            lblcosto.Size = new Size(107, 33);
            lblcosto.TabIndex = 26;
            lblcosto.Text = "C$0.00";
            // 
            // lblCostoTitulo
            // 
            lblCostoTitulo.AutoSize = true;
            lblCostoTitulo.Font = new Font("Arial", 10F, FontStyle.Bold);
            lblCostoTitulo.Location = new Point(824, 168);
            lblCostoTitulo.Name = "lblCostoTitulo";
            lblCostoTitulo.Size = new Size(126, 24);
            lblCostoTitulo.TabIndex = 27;
            lblCostoTitulo.Text = "Costo Total:";
            lblCostoTitulo.Click += lblCostoTitulo_Click;
            // 
            // lblActividades
            // 
            lblActividades.AutoSize = true;
            lblActividades.Font = new Font("Arial", 10F, FontStyle.Bold);
            lblActividades.Location = new Point(388, 125);
            lblActividades.Name = "lblActividades";
            lblActividades.Size = new Size(349, 24);
            lblActividades.TabIndex = 28;
            lblActividades.Text = "Actividades incluidas en el paquete:";
            // 
            // lblCabaña
            // 
            lblCabaña.AutoSize = true;
            lblCabaña.Font = new Font("Arial", 10F, FontStyle.Bold);
            lblCabaña.Location = new Point(9, 125);
            lblCabaña.Name = "lblCabaña";
            lblCabaña.Size = new Size(88, 24);
            lblCabaña.TabIndex = 29;
            lblCabaña.Text = "Cabaña:";
            // 
            // lblFechaFinal
            // 
            lblFechaFinal.AutoSize = true;
            lblFechaFinal.Font = new Font("Arial", 10F, FontStyle.Bold);
            lblFechaFinal.Location = new Point(488, 55);
            lblFechaFinal.Name = "lblFechaFinal";
            lblFechaFinal.Size = new Size(191, 24);
            lblFechaFinal.TabIndex = 30;
            lblFechaFinal.Text = "Fecha Finalizacion:";
            // 
            // lblfechainicio
            // 
            lblfechainicio.AutoSize = true;
            lblfechainicio.Font = new Font("Arial", 10F, FontStyle.Bold);
            lblfechainicio.Location = new Point(9, 55);
            lblfechainicio.Name = "lblfechainicio";
            lblfechainicio.Size = new Size(130, 24);
            lblfechainicio.TabIndex = 31;
            lblfechainicio.Text = "Fecha Inicio:";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 22F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 22F));
            tableLayoutPanel1.Controls.Add(grpInscripcion, 0, 2);
            tableLayoutPanel1.Controls.Add(grpCampista, 0, 0);
            tableLayoutPanel1.Controls.Add(grpTutor, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.Padding = new Padding(7, 8, 7, 8);
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(1300, 1050);
            tableLayoutPanel1.TabIndex = 10;
            // 
            // FormInscripcion
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.Green;
            ClientSize = new Size(1300, 1050);
            Controls.Add(tableLayoutPanel1);
            Margin = new Padding(3, 5, 3, 5);
            Name = "FormInscripcion";
            Text = "Nueva Inscripción - CAMPSYS";
            WindowState = FormWindowState.Maximized;
            Load += FormInscripcion_Load;
            Resize += FormInscripcion_Resize;
            grpCampista.ResumeLayout(false);
            grpCampista.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudedad).EndInit();
            grpTutor.ResumeLayout(false);
            grpTutor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudtutoredad).EndInit();
            grpInscripcion.ResumeLayout(false);
            grpInscripcion.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpCampista;
        private System.Windows.Forms.TextBox txtdireccion;
        private System.Windows.Forms.ComboBox cmbdepartamento;
        private System.Windows.Forms.TextBox txtgmail;
        private System.Windows.Forms.TextBox txtnumerocelular;
        private System.Windows.Forms.ComboBox cmbsexo;
        private System.Windows.Forms.NumericUpDown nudedad;
        private System.Windows.Forms.MaskedTextBox mtxtdocid;       // Req 1.3
        private System.Windows.Forms.TextBox txtnombrecompleto;
        private System.Windows.Forms.Label lblDireccionCampista;
        private System.Windows.Forms.Label lblDepartamentoCampista;
        private System.Windows.Forms.Label lblGmailCampista;
        private System.Windows.Forms.Label lblNumeroCelularCampista;
        private System.Windows.Forms.Label lblSexoCampista;
        private System.Windows.Forms.Label lblEdadCampista;
        private System.Windows.Forms.Label lblDocIdCampista; 
        private System.Windows.Forms.Label lblNombreCompletoCampista;
        private System.Windows.Forms.GroupBox grpTutor;
        private System.Windows.Forms.NumericUpDown nudtutoredad;
        private System.Windows.Forms.ComboBox cmbtutorsexo;
        private System.Windows.Forms.TextBox txttutorcelular;
        private System.Windows.Forms.MaskedTextBox mtxttutordocid;  // mask tutor
        private System.Windows.Forms.TextBox txttutornombre;
        private System.Windows.Forms.Label lblNumeroCelularTutor;
        private System.Windows.Forms.Label lblSexpTutor;
        private System.Windows.Forms.Label lblEdadTutor;
        private System.Windows.Forms.Label lblDocIdTutor;
        private System.Windows.Forms.Label lblNombrCompletoTutor;
        private System.Windows.Forms.GroupBox grpInscripcion;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.Button btngrabar;
        private System.Windows.Forms.ListBox lstactividades;         // Req 1.2
        private System.Windows.Forms.Label lblActividadesIncluidas;
        private System.Windows.Forms.ComboBox cmbcabana;
        private System.Windows.Forms.DateTimePicker dtpfechafinalizacion;
        private System.Windows.Forms.DateTimePicker dtpfechainicio;
        private System.Windows.Forms.Label lblcosto;
        private System.Windows.Forms.Label lblCostoTitulo;
        private System.Windows.Forms.Label lblActividades;
        private System.Windows.Forms.Label lblCabaña;
        private System.Windows.Forms.Label lblFechaFinal;
        private System.Windows.Forms.Label lblfechainicio;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}