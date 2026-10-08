namespace App_CAMPSYS.View
{
    partial class FormModificar
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
            txtbuscar = new TextBox();
            btnbuscar = new Button();
            grpCampista = new GroupBox();
            txtnombrecompleto = new TextBox();
            txtdocid = new TextBox();
            nudedad = new NumericUpDown();
            cmbsexo = new ComboBox();
            txtnumerocelular = new TextBox();
            txtgmail = new TextBox();
            cmbdepartamento = new ComboBox();
            txtdireccion = new TextBox();
            lblNombreCompletoCampista = new Label();
            lblDocIdCampista = new Label();
            lblEdadCampista = new Label();
            lblSexoCampista = new Label();
            lblNumeroCelularCampista = new Label();
            lblGmailCampista = new Label();
            lblDepartamentoCampista = new Label();
            lblDireccionCampista = new Label();
            grpTutor = new GroupBox();
            txttutornombre = new TextBox();
            txttutordocid = new TextBox();
            nudtutoredad = new NumericUpDown();
            cmbtutorsexo = new ComboBox();
            txttutorcelular = new TextBox();
            lblNombrCompletoTutor = new Label();
            lblDocIdTutor = new Label();
            lblEdadTutor = new Label();
            lblSexpTutor = new Label();
            lblNumeroCelularTutor = new Label();
            grpInscripcion = new GroupBox();
            dtpfechainicio = new DateTimePicker();
            dtpfechafinalizacion = new DateTimePicker();
            cmbcabana = new ComboBox();
            lstactividades = new ListBox();
            lblcosto = new Label();
            lblCostoTitulo = new Label();
            cmbestado = new ComboBox();
            lblestado = new Label();
            lblActividades = new Label();
            lblCabaña = new Label();
            lblFechaFinal = new Label();
            lblfechainicio = new Label();
            btnactualizar = new Button();
            btneliminar = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            grpCampista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudedad).BeginInit();
            grpTutor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudtutoredad).BeginInit();
            grpInscripcion.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // txtbuscar
            // 
            txtbuscar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtbuscar.Location = new Point(838, 16);
            txtbuscar.Margin = new Padding(3, 5, 3, 5);
            txtbuscar.Name = "txtbuscar";
            txtbuscar.Size = new Size(312, 31);
            txtbuscar.TabIndex = 0;
            txtbuscar.Text = "Buscar por nombre o cédula";
            // 
            // btnbuscar
            // 
            btnbuscar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnbuscar.Font = new Font("Arial", 10F, FontStyle.Bold);
            btnbuscar.Location = new Point(1162, 11);
            btnbuscar.Margin = new Padding(3, 5, 3, 5);
            btnbuscar.Name = "btnbuscar";
            btnbuscar.Size = new Size(124, 38);
            btnbuscar.TabIndex = 1;
            btnbuscar.Text = "Buscar";
            btnbuscar.UseVisualStyleBackColor = true;
            btnbuscar.Click += btnbuscar_Click;
            // 
            // grpCampista
            // 
            grpCampista.BackColor = Color.Azure;
            grpCampista.Controls.Add(txtnombrecompleto);
            grpCampista.Controls.Add(txtdocid);
            grpCampista.Controls.Add(nudedad);
            grpCampista.Controls.Add(cmbsexo);
            grpCampista.Controls.Add(txtnumerocelular);
            grpCampista.Controls.Add(txtgmail);
            grpCampista.Controls.Add(cmbdepartamento);
            grpCampista.Controls.Add(txtdireccion);
            grpCampista.Controls.Add(lblNombreCompletoCampista);
            grpCampista.Controls.Add(lblDocIdCampista);
            grpCampista.Controls.Add(lblEdadCampista);
            grpCampista.Controls.Add(lblSexoCampista);
            grpCampista.Controls.Add(lblNumeroCelularCampista);
            grpCampista.Controls.Add(lblGmailCampista);
            grpCampista.Controls.Add(lblDepartamentoCampista);
            grpCampista.Controls.Add(lblDireccionCampista);
            grpCampista.Dock = DockStyle.Fill;
            grpCampista.Enabled = false;
            grpCampista.ForeColor = SystemColors.ActiveCaptionText;
            grpCampista.Location = new Point(3, 5);
            grpCampista.Margin = new Padding(3, 5, 3, 5);
            grpCampista.Name = "grpCampista";
            grpCampista.Padding = new Padding(3, 5, 3, 5);
            grpCampista.Size = new Size(1321, 252);
            grpCampista.TabIndex = 2;
            grpCampista.TabStop = false;
            grpCampista.Text = "Datos del Campista";
            grpCampista.Enter += grpCampista_Enter;
            // 
            // txtnombrecompleto
            // 
            txtnombrecompleto.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtnombrecompleto.BorderStyle = BorderStyle.None;
            txtnombrecompleto.Location = new Point(223, 49);
            txtnombrecompleto.Margin = new Padding(3, 5, 3, 5);
            txtnombrecompleto.Name = "txtnombrecompleto";
            txtnombrecompleto.Size = new Size(379, 24);
            txtnombrecompleto.TabIndex = 8;
            // 
            // txtdocid
            // 
            txtdocid.BorderStyle = BorderStyle.None;
            txtdocid.Location = new Point(663, 49);
            txtdocid.Margin = new Padding(3, 5, 3, 5);
            txtdocid.Name = "txtdocid";
            txtdocid.Size = new Size(333, 24);
            txtdocid.TabIndex = 9;
            // 
            // nudedad
            // 
            nudedad.BorderStyle = BorderStyle.None;
            nudedad.Location = new Point(89, 120);
            nudedad.Margin = new Padding(3, 5, 3, 5);
            nudedad.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudedad.Name = "nudedad";
            nudedad.Size = new Size(150, 27);
            nudedad.TabIndex = 10;
            nudedad.Value = new decimal(new int[] { 1, 0, 0, 0 });
            nudedad.ValueChanged += nudedad_ValueChanged;
            // 
            // cmbsexo
            // 
            cmbsexo.FormattingEnabled = true;
            cmbsexo.Items.AddRange(new object[] { "Masculino", "Femenino" });
            cmbsexo.Location = new Point(416, 114);
            cmbsexo.Margin = new Padding(3, 5, 3, 5);
            cmbsexo.Name = "cmbsexo";
            cmbsexo.Size = new Size(151, 33);
            cmbsexo.TabIndex = 11;
            // 
            // txtnumerocelular
            // 
            txtnumerocelular.BorderStyle = BorderStyle.None;
            txtnumerocelular.Location = new Point(766, 119);
            txtnumerocelular.Margin = new Padding(3, 5, 3, 5);
            txtnumerocelular.Name = "txtnumerocelular";
            txtnumerocelular.Size = new Size(141, 24);
            txtnumerocelular.TabIndex = 12;
            // 
            // txtgmail
            // 
            txtgmail.BorderStyle = BorderStyle.None;
            txtgmail.Location = new Point(97, 190);
            txtgmail.Margin = new Padding(3, 5, 3, 5);
            txtgmail.Name = "txtgmail";
            txtgmail.Size = new Size(232, 24);
            txtgmail.TabIndex = 13;
            // 
            // cmbdepartamento
            // 
            cmbdepartamento.FormattingEnabled = true;
            cmbdepartamento.Location = new Point(511, 185);
            cmbdepartamento.Margin = new Padding(3, 5, 3, 5);
            cmbdepartamento.Name = "cmbdepartamento";
            cmbdepartamento.Size = new Size(224, 33);
            cmbdepartamento.TabIndex = 14;
            // 
            // txtdireccion
            // 
            txtdireccion.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtdireccion.BorderStyle = BorderStyle.None;
            txtdireccion.Location = new Point(137, 252);
            txtdireccion.Margin = new Padding(3, 5, 3, 5);
            txtdireccion.Name = "txtdireccion";
            txtdireccion.Size = new Size(907, 24);
            txtdireccion.TabIndex = 15;
            // 
            // lblNombreCompletoCampista
            // 
            lblNombreCompletoCampista.AutoSize = true;
            lblNombreCompletoCampista.Font = new Font("Arial", 10F, FontStyle.Bold);
            lblNombreCompletoCampista.Location = new Point(9, 49);
            lblNombreCompletoCampista.Name = "lblNombreCompletoCampista";
            lblNombreCompletoCampista.Size = new Size(187, 24);
            lblNombreCompletoCampista.TabIndex = 16;
            lblNombreCompletoCampista.Text = "Nombre Completo:";
            // 
            // lblDocIdCampista
            // 
            lblDocIdCampista.AutoSize = true;
            lblDocIdCampista.Font = new Font("Arial", 10F, FontStyle.Bold);
            lblDocIdCampista.Location = new Point(564, 49);
            lblDocIdCampista.Name = "lblDocIdCampista";
            lblDocIdCampista.Size = new Size(82, 24);
            lblDocIdCampista.TabIndex = 17;
            lblDocIdCampista.Text = "Cédula:";
            // 
            // lblEdadCampista
            // 
            lblEdadCampista.AutoSize = true;
            lblEdadCampista.Font = new Font("Arial", 10F, FontStyle.Bold);
            lblEdadCampista.Location = new Point(9, 120);
            lblEdadCampista.Name = "lblEdadCampista";
            lblEdadCampista.Size = new Size(65, 24);
            lblEdadCampista.TabIndex = 18;
            lblEdadCampista.Text = "Edad:";
            // 
            // lblSexoCampista
            // 
            lblSexoCampista.AutoSize = true;
            lblSexoCampista.Font = new Font("Arial", 10F, FontStyle.Bold);
            lblSexoCampista.Location = new Point(337, 120);
            lblSexoCampista.Name = "lblSexoCampista";
            lblSexoCampista.Size = new Size(64, 24);
            lblSexoCampista.TabIndex = 19;
            lblSexoCampista.Text = "Sexo:";
            // 
            // lblNumeroCelularCampista
            // 
            lblNumeroCelularCampista.AutoSize = true;
            lblNumeroCelularCampista.Font = new Font("Arial", 10F, FontStyle.Bold);
            lblNumeroCelularCampista.Location = new Point(667, 120);
            lblNumeroCelularCampista.Name = "lblNumeroCelularCampista";
            lblNumeroCelularCampista.Size = new Size(83, 24);
            lblNumeroCelularCampista.TabIndex = 20;
            lblNumeroCelularCampista.Text = "Celular:";
            // 
            // lblGmailCampista
            // 
            lblGmailCampista.AutoSize = true;
            lblGmailCampista.Font = new Font("Arial", 10F, FontStyle.Bold);
            lblGmailCampista.Location = new Point(9, 190);
            lblGmailCampista.Name = "lblGmailCampista";
            lblGmailCampista.Size = new Size(71, 24);
            lblGmailCampista.TabIndex = 21;
            lblGmailCampista.Text = "Gmail:";
            // 
            // lblDepartamentoCampista
            // 
            lblDepartamentoCampista.AutoSize = true;
            lblDepartamentoCampista.Font = new Font("Arial", 10F, FontStyle.Bold);
            lblDepartamentoCampista.Location = new Point(337, 190);
            lblDepartamentoCampista.Name = "lblDepartamentoCampista";
            lblDepartamentoCampista.Size = new Size(150, 24);
            lblDepartamentoCampista.TabIndex = 22;
            lblDepartamentoCampista.Text = "Departamento:";
            // 
            // lblDireccionCampista
            // 
            lblDireccionCampista.AutoSize = true;
            lblDireccionCampista.Font = new Font("Arial", 10F, FontStyle.Bold);
            lblDireccionCampista.Location = new Point(9, 252);
            lblDireccionCampista.Name = "lblDireccionCampista";
            lblDireccionCampista.Size = new Size(106, 24);
            lblDireccionCampista.TabIndex = 23;
            lblDireccionCampista.Text = "Direccion:";
            // 
            // grpTutor
            // 
            grpTutor.BackColor = Color.Azure;
            grpTutor.Controls.Add(txttutornombre);
            grpTutor.Controls.Add(txttutordocid);
            grpTutor.Controls.Add(nudtutoredad);
            grpTutor.Controls.Add(cmbtutorsexo);
            grpTutor.Controls.Add(txttutorcelular);
            grpTutor.Controls.Add(lblNombrCompletoTutor);
            grpTutor.Controls.Add(lblDocIdTutor);
            grpTutor.Controls.Add(lblEdadTutor);
            grpTutor.Controls.Add(lblSexpTutor);
            grpTutor.Controls.Add(lblNumeroCelularTutor);
            grpTutor.Dock = DockStyle.Fill;
            grpTutor.Enabled = false;
            grpTutor.ForeColor = SystemColors.ActiveCaptionText;
            grpTutor.Location = new Point(3, 789);
            grpTutor.Margin = new Padding(3, 5, 3, 5);
            grpTutor.Name = "grpTutor";
            grpTutor.Padding = new Padding(3, 5, 3, 5);
            grpTutor.Size = new Size(1321, 256);
            grpTutor.TabIndex = 3;
            grpTutor.TabStop = false;
            grpTutor.Text = "Datos del Tutor";
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
            // txttutordocid
            // 
            txttutordocid.BorderStyle = BorderStyle.None;
            txttutordocid.Location = new Point(663, 49);
            txttutordocid.Margin = new Padding(3, 5, 3, 5);
            txttutordocid.Name = "txttutordocid";
            txttutordocid.Size = new Size(333, 24);
            txttutordocid.TabIndex = 17;
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
            txttutorcelular.Location = new Point(766, 120);
            txttutorcelular.Margin = new Padding(3, 5, 3, 5);
            txttutorcelular.Name = "txttutorcelular";
            txttutorcelular.Size = new Size(141, 24);
            txttutorcelular.TabIndex = 20;
            // 
            // lblNombrCompletoTutor
            // 
            lblNombrCompletoTutor.AutoSize = true;
            lblNombrCompletoTutor.Font = new Font("Arial", 10F, FontStyle.Bold);
            lblNombrCompletoTutor.Location = new Point(9, 49);
            lblNombrCompletoTutor.Name = "lblNombrCompletoTutor";
            lblNombrCompletoTutor.Size = new Size(187, 24);
            lblNombrCompletoTutor.TabIndex = 21;
            lblNombrCompletoTutor.Text = "Nombre Completo:";
            // 
            // lblDocIdTutor
            // 
            lblDocIdTutor.AutoSize = true;
            lblDocIdTutor.Font = new Font("Arial", 10F, FontStyle.Bold);
            lblDocIdTutor.Location = new Point(564, 49);
            lblDocIdTutor.Name = "lblDocIdTutor";
            lblDocIdTutor.Size = new Size(82, 24);
            lblDocIdTutor.TabIndex = 22;
            lblDocIdTutor.Text = "Cédula:";
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
            // lblSexpTutor
            // 
            lblSexpTutor.AutoSize = true;
            lblSexpTutor.Font = new Font("Arial", 10F, FontStyle.Bold);
            lblSexpTutor.Location = new Point(337, 120);
            lblSexpTutor.Name = "lblSexpTutor";
            lblSexpTutor.Size = new Size(64, 24);
            lblSexpTutor.TabIndex = 24;
            lblSexpTutor.Text = "Sexo:";
            // 
            // lblNumeroCelularTutor
            // 
            lblNumeroCelularTutor.AutoSize = true;
            lblNumeroCelularTutor.Font = new Font("Arial", 10F, FontStyle.Bold);
            lblNumeroCelularTutor.Location = new Point(667, 120);
            lblNumeroCelularTutor.Name = "lblNumeroCelularTutor";
            lblNumeroCelularTutor.Size = new Size(83, 24);
            lblNumeroCelularTutor.TabIndex = 25;
            lblNumeroCelularTutor.Text = "Celular:";
            // 
            // grpInscripcion
            // 
            grpInscripcion.BackColor = Color.Azure;
            grpInscripcion.Controls.Add(dtpfechainicio);
            grpInscripcion.Controls.Add(dtpfechafinalizacion);
            grpInscripcion.Controls.Add(cmbcabana);
            grpInscripcion.Controls.Add(lstactividades);
            grpInscripcion.Controls.Add(lblcosto);
            grpInscripcion.Controls.Add(lblCostoTitulo);
            grpInscripcion.Controls.Add(cmbestado);
            grpInscripcion.Controls.Add(lblestado);
            grpInscripcion.Controls.Add(lblActividades);
            grpInscripcion.Controls.Add(lblCabaña);
            grpInscripcion.Controls.Add(lblFechaFinal);
            grpInscripcion.Controls.Add(lblfechainicio);
            grpInscripcion.Controls.Add(btnactualizar);
            grpInscripcion.Controls.Add(btneliminar);
            grpInscripcion.Dock = DockStyle.Fill;
            grpInscripcion.Enabled = false;
            grpInscripcion.ForeColor = SystemColors.ActiveCaptionText;
            grpInscripcion.Location = new Point(3, 267);
            grpInscripcion.Margin = new Padding(3, 5, 3, 5);
            grpInscripcion.Name = "grpInscripcion";
            grpInscripcion.Padding = new Padding(3, 5, 3, 5);
            grpInscripcion.Size = new Size(1321, 512);
            grpInscripcion.TabIndex = 4;
            grpInscripcion.TabStop = false;
            grpInscripcion.Text = "Datos de Inscripcion";
            grpInscripcion.Enter += grpInscripcion_Enter;
            // 
            // dtpfechainicio
            // 
            dtpfechainicio.Location = new Point(163, 55);
            dtpfechainicio.Margin = new Padding(3, 5, 3, 5);
            dtpfechainicio.Name = "dtpfechainicio";
            dtpfechainicio.Size = new Size(286, 31);
            dtpfechainicio.TabIndex = 21;
            // 
            // dtpfechafinalizacion
            // 
            dtpfechafinalizacion.Location = new Point(700, 55);
            dtpfechafinalizacion.Margin = new Padding(3, 5, 3, 5);
            dtpfechafinalizacion.Name = "dtpfechafinalizacion";
            dtpfechafinalizacion.Size = new Size(286, 31);
            dtpfechafinalizacion.TabIndex = 22;
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
            // lstactividades
            // 
            lstactividades.BorderStyle = BorderStyle.None;
            lstactividades.FormattingEnabled = true;
            lstactividades.ItemHeight = 25;
            lstactividades.Location = new Point(388, 164);
            lstactividades.Margin = new Padding(3, 5, 3, 5);
            lstactividades.Name = "lstactividades";
            lstactividades.SelectionMode = SelectionMode.None;
            lstactividades.Size = new Size(349, 175);
            lstactividades.TabIndex = 24;
            lstactividades.TabStop = false;
            // 
            // lblcosto
            // 
            lblcosto.AutoSize = true;
            lblcosto.Font = new Font("Arial", 14F, FontStyle.Bold);
            lblcosto.ForeColor = Color.DarkGreen;
            lblcosto.Location = new Point(788, 164);
            lblcosto.Name = "lblcosto";
            lblcosto.Size = new Size(107, 33);
            lblcosto.TabIndex = 25;
            lblcosto.Text = "C$0.00";
            // 
            // lblCostoTitulo
            // 
            lblCostoTitulo.AutoSize = true;
            lblCostoTitulo.Font = new Font("Arial", 10F, FontStyle.Bold);
            lblCostoTitulo.Location = new Point(788, 125);
            lblCostoTitulo.Name = "lblCostoTitulo";
            lblCostoTitulo.Size = new Size(126, 24);
            lblCostoTitulo.TabIndex = 26;
            lblCostoTitulo.Text = "Costo Total:";
            // 
            // cmbestado
            // 
            cmbestado.FormattingEnabled = true;
            cmbestado.Items.AddRange(new object[] { "Activo", "Inactivo" });
            cmbestado.Location = new Point(113, 370);
            cmbestado.Margin = new Padding(3, 5, 3, 5);
            cmbestado.Name = "cmbestado";
            cmbestado.Size = new Size(186, 33);
            cmbestado.TabIndex = 25;
            // 
            // lblestado
            // 
            lblestado.AutoSize = true;
            lblestado.Font = new Font("Arial", 10F, FontStyle.Bold);
            lblestado.Location = new Point(9, 375);
            lblestado.Name = "lblestado";
            lblestado.Size = new Size(83, 24);
            lblestado.TabIndex = 27;
            lblestado.Text = "Estado:";
            // 
            // lblActividades
            // 
            lblActividades.AutoSize = true;
            lblActividades.Font = new Font("Arial", 10F, FontStyle.Bold);
            lblActividades.Location = new Point(388, 125);
            lblActividades.Name = "lblActividades";
            lblActividades.Size = new Size(216, 24);
            lblActividades.TabIndex = 28;
            lblActividades.Text = "Actividades incluidas:";
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
            // btnactualizar
            // 
            btnactualizar.BackColor = Color.FromArgb(46, 117, 182);
            btnactualizar.Enabled = false;
            btnactualizar.Font = new Font("Arial", 10F, FontStyle.Bold);
            btnactualizar.ForeColor = Color.White;
            btnactualizar.Location = new Point(988, 399);
            btnactualizar.Margin = new Padding(3, 5, 3, 5);
            btnactualizar.Name = "btnactualizar";
            btnactualizar.Size = new Size(138, 56);
            btnactualizar.TabIndex = 26;
            btnactualizar.Text = "Actualizar";
            btnactualizar.UseVisualStyleBackColor = false;
            btnactualizar.Click += btnactualizar_Click;
            // 
            // btneliminar
            // 
            btneliminar.BackColor = Color.FromArgb(200, 60, 60);
            btneliminar.Enabled = false;
            btneliminar.Font = new Font("Arial", 10F, FontStyle.Bold);
            btneliminar.ForeColor = Color.White;
            btneliminar.Location = new Point(1138, 399);
            btneliminar.Margin = new Padding(3, 5, 3, 5);
            btneliminar.Name = "btneliminar";
            btneliminar.Size = new Size(112, 56);
            btneliminar.TabIndex = 27;
            btneliminar.Text = "Eliminar";
            btneliminar.UseVisualStyleBackColor = false;
            btneliminar.Click += btneliminar_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 22F));
            tableLayoutPanel1.Controls.Add(grpCampista, 0, 0);
            tableLayoutPanel1.Controls.Add(grpTutor, 0, 2);
            tableLayoutPanel1.Controls.Add(grpInscripcion, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 49.8095245F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25.2380943F));
            tableLayoutPanel1.Size = new Size(1327, 1050);
            tableLayoutPanel1.TabIndex = 5;
            // 
            // FormModificar
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.Green;
            ClientSize = new Size(1327, 1050);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(btnbuscar);
            Controls.Add(txtbuscar);
            Margin = new Padding(3, 5, 3, 5);
            Name = "FormModificar";
            Text = "Modificar Inscripcion - CAMPSYS";
            WindowState = FormWindowState.Maximized;
            Load += FormModificar_Load;
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
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtbuscar;
        private System.Windows.Forms.Button btnbuscar;
        private System.Windows.Forms.GroupBox grpCampista;
        private System.Windows.Forms.TextBox txtnombrecompleto;
        private System.Windows.Forms.TextBox txtdocid;
        private System.Windows.Forms.NumericUpDown nudedad;
        private System.Windows.Forms.ComboBox cmbsexo;
        private System.Windows.Forms.TextBox txtnumerocelular;
        private System.Windows.Forms.TextBox txtgmail;
        private System.Windows.Forms.ComboBox cmbdepartamento;
        private System.Windows.Forms.TextBox txtdireccion;
        private System.Windows.Forms.Label lblNombreCompletoCampista;
        private System.Windows.Forms.Label lblDocIdCampista;
        private System.Windows.Forms.Label lblEdadCampista;
        private System.Windows.Forms.Label lblSexoCampista;
        private System.Windows.Forms.Label lblNumeroCelularCampista;
        private System.Windows.Forms.Label lblGmailCampista;
        private System.Windows.Forms.Label lblDepartamentoCampista;
        private System.Windows.Forms.Label lblDireccionCampista;
        private System.Windows.Forms.GroupBox grpTutor;
        private System.Windows.Forms.TextBox txttutornombre;
        private System.Windows.Forms.TextBox txttutordocid;
        private System.Windows.Forms.NumericUpDown nudtutoredad;
        private System.Windows.Forms.ComboBox cmbtutorsexo;
        private System.Windows.Forms.TextBox txttutorcelular;
        private System.Windows.Forms.Label lblNombrCompletoTutor;
        private System.Windows.Forms.Label lblDocIdTutor;
        private System.Windows.Forms.Label lblEdadTutor;
        private System.Windows.Forms.Label lblSexpTutor;
        private System.Windows.Forms.Label lblNumeroCelularTutor;
        private System.Windows.Forms.GroupBox grpInscripcion;
        private System.Windows.Forms.DateTimePicker dtpfechainicio;
        private System.Windows.Forms.DateTimePicker dtpfechafinalizacion;
        private System.Windows.Forms.ComboBox cmbcabana;
        private System.Windows.Forms.ListBox lstactividades;
        private System.Windows.Forms.Label lblcosto;
        private System.Windows.Forms.Label lblCostoTitulo;
        private System.Windows.Forms.ComboBox cmbestado;
        private System.Windows.Forms.Label lblestado;
        private System.Windows.Forms.Label lblActividades;
        private System.Windows.Forms.Label lblCabaña;
        private System.Windows.Forms.Label lblFechaFinal;
        private System.Windows.Forms.Label lblfechainicio;
        private System.Windows.Forms.Button btnactualizar;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}