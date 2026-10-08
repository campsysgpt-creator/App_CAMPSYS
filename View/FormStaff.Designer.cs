namespace App_CAMPSYS.View
{
    partial class FormStaff
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.grpLogin = new System.Windows.Forms.GroupBox();
            this.lbllogindocid = new System.Windows.Forms.Label();
            this.txtlogindocid = new System.Windows.Forms.TextBox();
            this.lblloginpassword = new System.Windows.Forms.Label();
            this.txtloginpassword = new System.Windows.Forms.TextBox();
            this.btnlogin = new System.Windows.Forms.Button();
            this.lblsesionautiva = new System.Windows.Forms.Label();
            this.btnvercampistas = new System.Windows.Forms.Button();
            this.grpBuscar = new System.Windows.Forms.GroupBox();
            this.txtbuscar = new System.Windows.Forms.TextBox();
            this.btnbuscar = new System.Windows.Forms.Button();
            this.txtfiltrostaff = new System.Windows.Forms.TextBox();
            this.btnfiltrarstaff = new System.Windows.Forms.Button();
            this.grpDatosCampista = new System.Windows.Forms.GroupBox();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.txtdocid = new System.Windows.Forms.TextBox();
            this.txtedad = new System.Windows.Forms.TextBox();
            this.txtsexo = new System.Windows.Forms.TextBox();
            this.txtcelular = new System.Windows.Forms.TextBox();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.cmbrol = new System.Windows.Forms.ComboBox();
            this.lblNombreCompletoCampista = new System.Windows.Forms.Label();
            this.lblDocIdCampista = new System.Windows.Forms.Label();
            this.lblEdadCampista = new System.Windows.Forms.Label();
            this.lblSexoCampista = new System.Windows.Forms.Label();
            this.lblNumeroCelularCampista = new System.Windows.Forms.Label();
            this.lblpassword = new System.Windows.Forms.Label();
            this.lblrol = new System.Windows.Forms.Label();
            this.btngrabar = new System.Windows.Forms.Button();
            this.btnactualizar = new System.Windows.Forms.Button();
            this.btneliminar = new System.Windows.Forms.Button();
            this.dgvstaff = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.grpLogin.SuspendLayout();
            this.grpBuscar.SuspendLayout();
            this.grpDatosCampista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvstaff)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpLogin
            // 
            this.grpLogin.Controls.Add(this.lbllogindocid);
            this.grpLogin.Controls.Add(this.txtlogindocid);
            this.grpLogin.Controls.Add(this.lblloginpassword);
            this.grpLogin.Controls.Add(this.txtloginpassword);
            this.grpLogin.Controls.Add(this.btnlogin);
            this.grpLogin.Controls.Add(this.lblsesionautiva);
            this.grpLogin.Controls.Add(this.btnvercampistas);
            this.grpLogin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpLogin.Location = new System.Drawing.Point(4, 5);
            this.grpLogin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpLogin.Name = "grpLogin";
            this.grpLogin.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpLogin.Size = new System.Drawing.Size(1380, 142);
            this.grpLogin.TabIndex = 0;
            this.grpLogin.TabStop = false;
            this.grpLogin.Text = "Inicio de Sesión Staff";
            // 
            // lbllogindocid
            // 
            this.lbllogindocid.AutoSize = true;
            this.lbllogindocid.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.lbllogindocid.Location = new System.Drawing.Point(12, 55);
            this.lbllogindocid.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbllogindocid.Name = "lbllogindocid";
            this.lbllogindocid.Size = new System.Drawing.Size(82, 24);
            this.lbllogindocid.TabIndex = 0;
            this.lbllogindocid.Text = "Cédula:";
            // 
            // txtlogindocid
            // 
            this.txtlogindocid.Location = new System.Drawing.Point(100, 50);
            this.txtlogindocid.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtlogindocid.Name = "txtlogindocid";
            this.txtlogindocid.Size = new System.Drawing.Size(224, 31);
            this.txtlogindocid.TabIndex = 1;
            // 
            // lblloginpassword
            // 
            this.lblloginpassword.AutoSize = true;
            this.lblloginpassword.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.lblloginpassword.Location = new System.Drawing.Point(350, 55);
            this.lblloginpassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblloginpassword.Name = "lblloginpassword";
            this.lblloginpassword.Size = new System.Drawing.Size(126, 24);
            this.lblloginpassword.TabIndex = 2;
            this.lblloginpassword.Text = "Contraseña:";
            // 
            // txtloginpassword
            // 
            this.txtloginpassword.Location = new System.Drawing.Point(488, 50);
            this.txtloginpassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtloginpassword.Name = "txtloginpassword";
            this.txtloginpassword.PasswordChar = '*';
            this.txtloginpassword.Size = new System.Drawing.Size(224, 31);
            this.txtloginpassword.TabIndex = 2;
            // 
            // btnlogin
            // 
            this.btnlogin.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.btnlogin.Location = new System.Drawing.Point(738, 44);
            this.btnlogin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(150, 50);
            this.btnlogin.TabIndex = 3;
            this.btnlogin.Text = "Iniciar Sesión";
            this.btnlogin.UseVisualStyleBackColor = true;
            this.btnlogin.Click += new System.EventHandler(this.btnlogin_Click);
            // 
            // lblsesionautiva
            // 
            this.lblsesionautiva.AutoSize = true;
            this.lblsesionautiva.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Italic);
            this.lblsesionautiva.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblsesionautiva.Location = new System.Drawing.Point(912, 60);
            this.lblsesionautiva.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblsesionautiva.Name = "lblsesionautiva";
            this.lblsesionautiva.Size = new System.Drawing.Size(0, 22);
            this.lblsesionautiva.TabIndex = 4;
            this.lblsesionautiva.Visible = false;
            // 
            // btnvercampistas
            // 
            this.btnvercampistas.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.btnvercampistas.Location = new System.Drawing.Point(1125, 44);
            this.btnvercampistas.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnvercampistas.Name = "btnvercampistas";
            this.btnvercampistas.Size = new System.Drawing.Size(175, 50);
            this.btnvercampistas.TabIndex = 4;
            this.btnvercampistas.Text = "Ver Campistas";
            this.btnvercampistas.UseVisualStyleBackColor = true;
            this.btnvercampistas.Visible = false;
            this.btnvercampistas.Click += new System.EventHandler(this.btnvercampistas_Click);
            // 
            // grpBuscar
            // 
            this.grpBuscar.Controls.Add(this.txtbuscar);
            this.grpBuscar.Controls.Add(this.btnbuscar);
            this.grpBuscar.Controls.Add(this.txtfiltrostaff);
            this.grpBuscar.Controls.Add(this.btnfiltrarstaff);
            this.grpBuscar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpBuscar.Location = new System.Drawing.Point(4, 157);
            this.grpBuscar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpBuscar.Name = "grpBuscar";
            this.grpBuscar.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpBuscar.Size = new System.Drawing.Size(1380, 142);
            this.grpBuscar.TabIndex = 1;
            this.grpBuscar.TabStop = false;
            this.grpBuscar.Text = "Búsqueda";
            // 
            // txtbuscar
            // 
            this.txtbuscar.Location = new System.Drawing.Point(12, 48);
            this.txtbuscar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtbuscar.Name = "txtbuscar";
            this.txtbuscar.Size = new System.Drawing.Size(312, 31);
            this.txtbuscar.TabIndex = 5;
            this.txtbuscar.Text = "Buscar campista por nombre o cédula";
            // 
            // btnbuscar
            // 
            this.btnbuscar.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.btnbuscar.Location = new System.Drawing.Point(338, 40);
            this.btnbuscar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(125, 48);
            this.btnbuscar.TabIndex = 6;
            this.btnbuscar.Text = "Buscar";
            this.btnbuscar.UseVisualStyleBackColor = true;
            this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click);
            // 
            // txtfiltrostaff
            // 
            this.txtfiltrostaff.Location = new System.Drawing.Point(525, 48);
            this.txtfiltrostaff.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtfiltrostaff.Name = "txtfiltrostaff";
            this.txtfiltrostaff.Size = new System.Drawing.Size(312, 31);
            this.txtfiltrostaff.TabIndex = 7;
            this.txtfiltrostaff.Text = "Filtrar staff registrado";
            // 
            // btnfiltrarstaff
            // 
            this.btnfiltrarstaff.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.btnfiltrarstaff.Location = new System.Drawing.Point(850, 40);
            this.btnfiltrarstaff.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnfiltrarstaff.Name = "btnfiltrarstaff";
            this.btnfiltrarstaff.Size = new System.Drawing.Size(162, 48);
            this.btnfiltrarstaff.TabIndex = 8;
            this.btnfiltrarstaff.Text = "Filtrar Staff";
            this.btnfiltrarstaff.UseVisualStyleBackColor = true;
            this.btnfiltrarstaff.Click += new System.EventHandler(this.btnfiltrarstaff_Click);
            // 
            // grpDatosCampista
            // 
            this.grpDatosCampista.Controls.Add(this.txtnombre);
            this.grpDatosCampista.Controls.Add(this.txtdocid);
            this.grpDatosCampista.Controls.Add(this.txtedad);
            this.grpDatosCampista.Controls.Add(this.txtsexo);
            this.grpDatosCampista.Controls.Add(this.txtcelular);
            this.grpDatosCampista.Controls.Add(this.txtpassword);
            this.grpDatosCampista.Controls.Add(this.cmbrol);
            this.grpDatosCampista.Controls.Add(this.lblNombreCompletoCampista);
            this.grpDatosCampista.Controls.Add(this.lblDocIdCampista);
            this.grpDatosCampista.Controls.Add(this.lblEdadCampista);
            this.grpDatosCampista.Controls.Add(this.lblSexoCampista);
            this.grpDatosCampista.Controls.Add(this.lblNumeroCelularCampista);
            this.grpDatosCampista.Controls.Add(this.lblpassword);
            this.grpDatosCampista.Controls.Add(this.lblrol);
            this.grpDatosCampista.Controls.Add(this.btngrabar);
            this.grpDatosCampista.Controls.Add(this.btnactualizar);
            this.grpDatosCampista.Controls.Add(this.btneliminar);
            this.grpDatosCampista.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpDatosCampista.Enabled = false;
            this.grpDatosCampista.Location = new System.Drawing.Point(4, 309);
            this.grpDatosCampista.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpDatosCampista.Name = "grpDatosCampista";
            this.grpDatosCampista.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpDatosCampista.Size = new System.Drawing.Size(1380, 701);
            this.grpDatosCampista.TabIndex = 2;
            this.grpDatosCampista.TabStop = false;
            this.grpDatosCampista.Text = "Datos del Campista / Staff";
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(162, 42);
            this.txtnombre.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.ReadOnly = true;
            this.txtnombre.Size = new System.Drawing.Size(312, 31);
            this.txtnombre.TabIndex = 9;
            // 
            // txtdocid
            // 
            this.txtdocid.Location = new System.Drawing.Point(630, 48);
            this.txtdocid.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtdocid.Name = "txtdocid";
            this.txtdocid.ReadOnly = true;
            this.txtdocid.Size = new System.Drawing.Size(249, 31);
            this.txtdocid.TabIndex = 10;
            // 
            // txtedad
            // 
            this.txtedad.Location = new System.Drawing.Point(100, 198);
            this.txtedad.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtedad.Name = "txtedad";
            this.txtedad.ReadOnly = true;
            this.txtedad.Size = new System.Drawing.Size(99, 31);
            this.txtedad.TabIndex = 11;
            // 
            // txtsexo
            // 
            this.txtsexo.Location = new System.Drawing.Point(327, 195);
            this.txtsexo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtsexo.Name = "txtsexo";
            this.txtsexo.ReadOnly = true;
            this.txtsexo.Size = new System.Drawing.Size(149, 31);
            this.txtsexo.TabIndex = 12;
            // 
            // txtcelular
            // 
            this.txtcelular.Location = new System.Drawing.Point(639, 153);
            this.txtcelular.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtcelular.Name = "txtcelular";
            this.txtcelular.ReadOnly = true;
            this.txtcelular.Size = new System.Drawing.Size(249, 31);
            this.txtcelular.TabIndex = 13;
            // 
            // txtpassword
            // 
            this.txtpassword.Location = new System.Drawing.Point(639, 301);
            this.txtpassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.PasswordChar = '*';
            this.txtpassword.Size = new System.Drawing.Size(249, 31);
            this.txtpassword.TabIndex = 15;
            // 
            // cmbrol
            // 
            this.cmbrol.FormattingEnabled = true;
            this.cmbrol.Location = new System.Drawing.Point(100, 389);
            this.cmbrol.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbrol.Name = "cmbrol";
            this.cmbrol.Size = new System.Drawing.Size(274, 33);
            this.cmbrol.TabIndex = 14;
            // 
            // lblNombreCompletoCampista
            // 
            this.lblNombreCompletoCampista.AutoSize = true;
            this.lblNombreCompletoCampista.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.lblNombreCompletoCampista.Location = new System.Drawing.Point(9, 48);
            this.lblNombreCompletoCampista.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombreCompletoCampista.Name = "lblNombreCompletoCampista";
            this.lblNombreCompletoCampista.Size = new System.Drawing.Size(91, 24);
            this.lblNombreCompletoCampista.TabIndex = 16;
            this.lblNombreCompletoCampista.Text = "Nombre:";
            // 
            // lblDocIdCampista
            // 
            this.lblDocIdCampista.AutoSize = true;
            this.lblDocIdCampista.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.lblDocIdCampista.Location = new System.Drawing.Point(518, 52);
            this.lblDocIdCampista.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDocIdCampista.Name = "lblDocIdCampista";
            this.lblDocIdCampista.Size = new System.Drawing.Size(82, 24);
            this.lblDocIdCampista.TabIndex = 17;
            this.lblDocIdCampista.Text = "Cédula:";
            // 
            // lblEdadCampista
            // 
            this.lblEdadCampista.AutoSize = true;
            this.lblEdadCampista.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.lblEdadCampista.Location = new System.Drawing.Point(12, 198);
            this.lblEdadCampista.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEdadCampista.Name = "lblEdadCampista";
            this.lblEdadCampista.Size = new System.Drawing.Size(65, 24);
            this.lblEdadCampista.TabIndex = 18;
            this.lblEdadCampista.Text = "Edad:";
            // 
            // lblSexoCampista
            // 
            this.lblSexoCampista.AutoSize = true;
            this.lblSexoCampista.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.lblSexoCampista.Location = new System.Drawing.Point(255, 202);
            this.lblSexoCampista.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSexoCampista.Name = "lblSexoCampista";
            this.lblSexoCampista.Size = new System.Drawing.Size(64, 24);
            this.lblSexoCampista.TabIndex = 19;
            this.lblSexoCampista.Text = "Sexo:";
            // 
            // lblNumeroCelularCampista
            // 
            this.lblNumeroCelularCampista.AutoSize = true;
            this.lblNumeroCelularCampista.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.lblNumeroCelularCampista.Location = new System.Drawing.Point(517, 157);
            this.lblNumeroCelularCampista.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNumeroCelularCampista.Name = "lblNumeroCelularCampista";
            this.lblNumeroCelularCampista.Size = new System.Drawing.Size(83, 24);
            this.lblNumeroCelularCampista.TabIndex = 20;
            this.lblNumeroCelularCampista.Text = "Celular:";
            // 
            // lblpassword
            // 
            this.lblpassword.AutoSize = true;
            this.lblpassword.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.lblpassword.Location = new System.Drawing.Point(474, 305);
            this.lblpassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblpassword.Name = "lblpassword";
            this.lblpassword.Size = new System.Drawing.Size(126, 24);
            this.lblpassword.TabIndex = 21;
            this.lblpassword.Text = "Contraseña:";
            // 
            // lblrol
            // 
            this.lblrol.AutoSize = true;
            this.lblrol.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.lblrol.Location = new System.Drawing.Point(12, 398);
            this.lblrol.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblrol.Name = "lblrol";
            this.lblrol.Size = new System.Drawing.Size(48, 24);
            this.lblrol.TabIndex = 22;
            this.lblrol.Text = "Rol:";
            // 
            // btngrabar
            // 
            this.btngrabar.Enabled = false;
            this.btngrabar.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.btngrabar.Location = new System.Drawing.Point(1206, 503);
            this.btngrabar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btngrabar.Name = "btngrabar";
            this.btngrabar.Size = new System.Drawing.Size(125, 56);
            this.btngrabar.TabIndex = 16;
            this.btngrabar.Text = "Grabar";
            this.btngrabar.UseVisualStyleBackColor = true;
            this.btngrabar.Click += new System.EventHandler(this.btngrabar_Click);
            // 
            // btnactualizar
            // 
            this.btnactualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(117)))), ((int)(((byte)(182)))));
            this.btnactualizar.Enabled = false;
            this.btnactualizar.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.btnactualizar.Location = new System.Drawing.Point(820, 503);
            this.btnactualizar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnactualizar.Name = "btnactualizar";
            this.btnactualizar.Size = new System.Drawing.Size(138, 56);
            this.btnactualizar.TabIndex = 17;
            this.btnactualizar.Text = "Actualizar";
            this.btnactualizar.UseVisualStyleBackColor = false;
            this.btnactualizar.Click += new System.EventHandler(this.btnactualizar_Click);
            // 
            // btneliminar
            // 
            this.btneliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btneliminar.Enabled = false;
            this.btneliminar.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.btneliminar.Location = new System.Drawing.Point(1016, 503);
            this.btneliminar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(112, 56);
            this.btneliminar.TabIndex = 18;
            this.btneliminar.Text = "Eliminar";
            this.btneliminar.UseVisualStyleBackColor = false;
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
            // 
            // dgvstaff
            // 
            this.dgvstaff.AllowUserToAddRows = false;
            this.dgvstaff.AllowUserToDeleteRows = false;
            this.dgvstaff.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvstaff.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvstaff.Location = new System.Drawing.Point(42, 651);
            this.dgvstaff.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvstaff.Name = "dgvstaff";
            this.dgvstaff.ReadOnly = true;
            this.dgvstaff.RowHeadersWidth = 51;
            this.dgvstaff.RowTemplate.Height = 24;
            this.dgvstaff.Size = new System.Drawing.Size(1325, 312);
            this.dgvstaff.TabIndex = 19;
            this.dgvstaff.Visible = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.grpBuscar, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.grpLogin, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.grpDatosCampista, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1388, 1015);
            this.tableLayoutPanel1.TabIndex = 20;
            // 
            // FormStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1388, 1015);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.dgvstaff);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormStaff";
            this.Text = "Staff - CAMPSYS";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormStaff_Load);
            this.Resize += new System.EventHandler(this.FormStaff_Resize);
            this.grpLogin.ResumeLayout(false);
            this.grpLogin.PerformLayout();
            this.grpBuscar.ResumeLayout(false);
            this.grpBuscar.PerformLayout();
            this.grpDatosCampista.ResumeLayout(false);
            this.grpDatosCampista.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvstaff)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        // Declaraciones de controles
        private System.Windows.Forms.GroupBox grpLogin;
        private System.Windows.Forms.Label lbllogindocid;
        private System.Windows.Forms.TextBox txtlogindocid;
        private System.Windows.Forms.Label lblloginpassword;
        private System.Windows.Forms.TextBox txtloginpassword;
        private System.Windows.Forms.Button btnlogin;
        private System.Windows.Forms.Label lblsesionautiva;
        private System.Windows.Forms.Button btnvercampistas;
        private System.Windows.Forms.GroupBox grpBuscar;
        private System.Windows.Forms.TextBox txtbuscar;
        private System.Windows.Forms.Button btnbuscar;
        private System.Windows.Forms.TextBox txtfiltrostaff;
        private System.Windows.Forms.Button btnfiltrarstaff;
        private System.Windows.Forms.GroupBox grpDatosCampista;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.TextBox txtdocid;
        private System.Windows.Forms.TextBox txtedad;
        private System.Windows.Forms.TextBox txtsexo;
        private System.Windows.Forms.TextBox txtcelular;
        private System.Windows.Forms.TextBox txtpassword;
        private System.Windows.Forms.ComboBox cmbrol;
        private System.Windows.Forms.Label lblNombreCompletoCampista;
        private System.Windows.Forms.Label lblDocIdCampista;
        private System.Windows.Forms.Label lblEdadCampista;
        private System.Windows.Forms.Label lblSexoCampista;
        private System.Windows.Forms.Label lblNumeroCelularCampista;
        private System.Windows.Forms.Label lblpassword;
        private System.Windows.Forms.Label lblrol;
        private System.Windows.Forms.Button btngrabar;
        private System.Windows.Forms.Button btnactualizar;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.DataGridView dgvstaff;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}