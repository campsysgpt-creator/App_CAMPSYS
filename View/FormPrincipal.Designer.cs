namespace App_CAMPSYS.View
{
    partial class FormPrincipal
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null) components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            pnlHeader = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            lblSubtitulo = new Label();
            panel1 = new Panel();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            pnlAcciones = new Panel();
            pnlestaf = new Panel();
            btnStaff = new Button();
            pnlayuda = new Panel();
            btnAyuda = new Button();
            pnlverincripcion = new Panel();
            btnVerInscripciones = new Button();
            pnltutores = new Panel();
            btnVerTutores = new Button();
            pnlvercampista = new Panel();
            btnVerCampistas = new Button();
            pnlmodificar = new Panel();
            btnModificar = new Button();
            pnlincripcion = new Panel();
            btnInscripcion = new Button();
            pnlContent = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            pictureBox5 = new PictureBox();
            pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            pnlAcciones.SuspendLayout();
            pnlestaf.SuspendLayout();
            pnlayuda.SuspendLayout();
            pnlverincripcion.SuspendLayout();
            pnltutores.SuspendLayout();
            pnlvercampista.SuspendLayout();
            pnlmodificar.SuspendLayout();
            pnlincripcion.SuspendLayout();
            pnlContent.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.Green;
            pnlHeader.Controls.Add(pictureBox1);
            pnlHeader.Controls.Add(label1);
            pnlHeader.Controls.Add(lblSubtitulo);
            pnlHeader.Controls.Add(panel1);
            pnlHeader.Controls.Add(pictureBox2);
            pnlHeader.Controls.Add(pictureBox3);
            pnlHeader.Controls.Add(pictureBox4);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Margin = new Padding(4);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(1339, 112);
            pnlHeader.TabIndex = 0;
            pnlHeader.Paint += pnlHeader_Paint;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 14);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(83, 71);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(129, 0);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(229, 60);
            label1.TabIndex = 0;
            label1.Text = "CAMPSYS";
            // 
            // lblSubtitulo
            // 
            lblSubtitulo.AutoSize = true;
            lblSubtitulo.Font = new Font("Segoe UI", 9.5F);
            lblSubtitulo.ForeColor = Color.FromArgb(187, 247, 208);
            lblSubtitulo.Location = new Point(158, 66);
            lblSubtitulo.Margin = new Padding(4, 0, 4, 0);
            lblSubtitulo.Name = "lblSubtitulo";
            lblSubtitulo.Size = new Size(316, 25);
            lblSubtitulo.TabIndex = 1;
            lblSubtitulo.Text = "Sistema de Gestión de Campamento";
            // 
            // panel1
            // 
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4);
            panel1.Name = "panel1";
            panel1.Size = new Size(0, 0);
            panel1.TabIndex = 2;
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(0, 0);
            pictureBox2.Margin = new Padding(4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(0, 0);
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Location = new Point(0, 0);
            pictureBox3.Margin = new Padding(4);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(0, 0);
            pictureBox3.TabIndex = 4;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Location = new Point(0, 0);
            pictureBox4.Margin = new Padding(4);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(0, 0);
            pictureBox4.TabIndex = 5;
            pictureBox4.TabStop = false;
            // 
            // pnlAcciones
            // 
            pnlAcciones.AutoScroll = true;
            pnlAcciones.BackColor = Color.White;
            pnlAcciones.Controls.Add(pnlestaf);
            pnlAcciones.Controls.Add(pnlayuda);
            pnlAcciones.Controls.Add(pnlverincripcion);
            pnlAcciones.Controls.Add(pnltutores);
            pnlAcciones.Controls.Add(pnlvercampista);
            pnlAcciones.Controls.Add(pnlmodificar);
            pnlAcciones.Controls.Add(pnlincripcion);
            pnlAcciones.Dock = DockStyle.Fill;
            pnlAcciones.Location = new Point(4, 4);
            pnlAcciones.Margin = new Padding(4);
            pnlAcciones.Name = "pnlAcciones";
            pnlAcciones.Size = new Size(326, 560);
            pnlAcciones.TabIndex = 0;
            pnlAcciones.Paint += Panel_Paint;
            // 
            // pnlestaf
            // 
            pnlestaf.Controls.Add(btnStaff);
            pnlestaf.Dock = DockStyle.Top;
            pnlestaf.Location = new Point(0, 796);
            pnlestaf.Name = "pnlestaf";
            pnlestaf.Padding = new Padding(20);
            pnlestaf.Size = new Size(300, 100);
            pnlestaf.TabIndex = 15;
            // 
            // btnStaff
            // 
            btnStaff.BackColor = Color.FromArgb(245, 158, 11);
            btnStaff.Cursor = Cursors.Hand;
            btnStaff.Dock = DockStyle.Fill;
            btnStaff.FlatAppearance.BorderSize = 0;
            btnStaff.FlatStyle = FlatStyle.Flat;
            btnStaff.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold);
            btnStaff.ForeColor = Color.White;
            btnStaff.Location = new Point(20, 20);
            btnStaff.Margin = new Padding(4);
            btnStaff.Name = "btnStaff";
            btnStaff.Size = new Size(260, 60);
            btnStaff.TabIndex = 6;
            btnStaff.Text = "Gestion de Staff";
            btnStaff.UseVisualStyleBackColor = false;
            btnStaff.Click += btnStaff_Click;
            // 
            // pnlayuda
            // 
            pnlayuda.Controls.Add(btnAyuda);
            pnlayuda.Dock = DockStyle.Top;
            pnlayuda.Location = new Point(0, 664);
            pnlayuda.Name = "pnlayuda";
            pnlayuda.Padding = new Padding(20);
            pnlayuda.Size = new Size(300, 132);
            pnlayuda.TabIndex = 14;
            // 
            // btnAyuda
            // 
            btnAyuda.BackColor = Color.FromArgb(240, 253, 244);
            btnAyuda.Cursor = Cursors.Hand;
            btnAyuda.Dock = DockStyle.Fill;
            btnAyuda.FlatAppearance.BorderColor = Color.Black;
            btnAyuda.FlatAppearance.BorderSize = 2;
            btnAyuda.FlatStyle = FlatStyle.Flat;
            btnAyuda.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold);
            btnAyuda.ForeColor = Color.DimGray;
            btnAyuda.Location = new Point(20, 20);
            btnAyuda.Margin = new Padding(4);
            btnAyuda.Name = "btnAyuda";
            btnAyuda.Size = new Size(260, 92);
            btnAyuda.TabIndex = 7;
            btnAyuda.Text = "Manual de Ayuda";
            btnAyuda.UseVisualStyleBackColor = false;
            btnAyuda.Click += btnAyuda_Click;
            // 
            // pnlverincripcion
            // 
            pnlverincripcion.Controls.Add(btnVerInscripciones);
            pnlverincripcion.Dock = DockStyle.Top;
            pnlverincripcion.Location = new Point(0, 533);
            pnlverincripcion.Name = "pnlverincripcion";
            pnlverincripcion.Padding = new Padding(20);
            pnlverincripcion.Size = new Size(300, 131);
            pnlverincripcion.TabIndex = 13;
            // 
            // btnVerInscripciones
            // 
            btnVerInscripciones.BackColor = Color.FromArgb(240, 253, 244);
            btnVerInscripciones.Cursor = Cursors.Hand;
            btnVerInscripciones.Dock = DockStyle.Fill;
            btnVerInscripciones.FlatAppearance.BorderColor = Color.Black;
            btnVerInscripciones.FlatAppearance.BorderSize = 2;
            btnVerInscripciones.FlatStyle = FlatStyle.Flat;
            btnVerInscripciones.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold);
            btnVerInscripciones.ForeColor = Color.Green;
            btnVerInscripciones.Location = new Point(20, 20);
            btnVerInscripciones.Margin = new Padding(4);
            btnVerInscripciones.Name = "btnVerInscripciones";
            btnVerInscripciones.Size = new Size(260, 91);
            btnVerInscripciones.TabIndex = 5;
            btnVerInscripciones.Text = "Ver Inscripciones";
            btnVerInscripciones.UseVisualStyleBackColor = false;
            btnVerInscripciones.Click += btnVerInscripciones_Click;
            // 
            // pnltutores
            // 
            pnltutores.Controls.Add(btnVerTutores);
            pnltutores.Dock = DockStyle.Top;
            pnltutores.Location = new Point(0, 394);
            pnltutores.Name = "pnltutores";
            pnltutores.Padding = new Padding(20);
            pnltutores.Size = new Size(300, 139);
            pnltutores.TabIndex = 12;
            // 
            // btnVerTutores
            // 
            btnVerTutores.BackColor = Color.FromArgb(240, 253, 244);
            btnVerTutores.Cursor = Cursors.Hand;
            btnVerTutores.Dock = DockStyle.Fill;
            btnVerTutores.FlatAppearance.BorderColor = Color.Black;
            btnVerTutores.FlatAppearance.BorderSize = 2;
            btnVerTutores.FlatStyle = FlatStyle.Flat;
            btnVerTutores.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold);
            btnVerTutores.ForeColor = Color.Green;
            btnVerTutores.Location = new Point(20, 20);
            btnVerTutores.Margin = new Padding(4);
            btnVerTutores.Name = "btnVerTutores";
            btnVerTutores.Size = new Size(260, 99);
            btnVerTutores.TabIndex = 4;
            btnVerTutores.Text = "Ver Tutores";
            btnVerTutores.UseVisualStyleBackColor = false;
            btnVerTutores.Click += btnVerTutores_Click;
            // 
            // pnlvercampista
            // 
            pnlvercampista.Controls.Add(btnVerCampistas);
            pnlvercampista.Dock = DockStyle.Top;
            pnlvercampista.Location = new Point(0, 258);
            pnlvercampista.Name = "pnlvercampista";
            pnlvercampista.Padding = new Padding(20);
            pnlvercampista.Size = new Size(300, 136);
            pnlvercampista.TabIndex = 11;
            // 
            // btnVerCampistas
            // 
            btnVerCampistas.BackColor = Color.FromArgb(240, 253, 244);
            btnVerCampistas.Cursor = Cursors.Hand;
            btnVerCampistas.Dock = DockStyle.Fill;
            btnVerCampistas.FlatAppearance.BorderColor = Color.Black;
            btnVerCampistas.FlatAppearance.BorderSize = 2;
            btnVerCampistas.FlatStyle = FlatStyle.Flat;
            btnVerCampistas.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold);
            btnVerCampistas.ForeColor = Color.Green;
            btnVerCampistas.Location = new Point(20, 20);
            btnVerCampistas.Margin = new Padding(4);
            btnVerCampistas.Name = "btnVerCampistas";
            btnVerCampistas.Size = new Size(260, 96);
            btnVerCampistas.TabIndex = 3;
            btnVerCampistas.Text = "Ver Campistas";
            btnVerCampistas.UseVisualStyleBackColor = false;
            btnVerCampistas.Click += btnVerCampistas_Click;
            // 
            // pnlmodificar
            // 
            pnlmodificar.Controls.Add(btnModificar);
            pnlmodificar.Dock = DockStyle.Top;
            pnlmodificar.Location = new Point(0, 130);
            pnlmodificar.Name = "pnlmodificar";
            pnlmodificar.Padding = new Padding(20);
            pnlmodificar.Size = new Size(300, 128);
            pnlmodificar.TabIndex = 10;
            // 
            // btnModificar
            // 
            btnModificar.BackColor = Color.FromArgb(240, 253, 244);
            btnModificar.Cursor = Cursors.Hand;
            btnModificar.Dock = DockStyle.Fill;
            btnModificar.FlatAppearance.BorderColor = Color.FromArgb(22, 101, 52);
            btnModificar.FlatAppearance.BorderSize = 2;
            btnModificar.FlatStyle = FlatStyle.Flat;
            btnModificar.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnModificar.ForeColor = Color.Green;
            btnModificar.Location = new Point(20, 20);
            btnModificar.Margin = new Padding(4);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(260, 88);
            btnModificar.TabIndex = 2;
            btnModificar.Text = "Modificar / Consultar";
            btnModificar.UseVisualStyleBackColor = false;
            btnModificar.Click += btnModificar_Click;
            // 
            // pnlincripcion
            // 
            pnlincripcion.Controls.Add(btnInscripcion);
            pnlincripcion.Dock = DockStyle.Top;
            pnlincripcion.Location = new Point(0, 0);
            pnlincripcion.Name = "pnlincripcion";
            pnlincripcion.Padding = new Padding(20);
            pnlincripcion.Size = new Size(300, 130);
            pnlincripcion.TabIndex = 8;
            // 
            // btnInscripcion
            // 
            btnInscripcion.BackColor = Color.FromArgb(240, 253, 244);
            btnInscripcion.Cursor = Cursors.Hand;
            btnInscripcion.Dock = DockStyle.Fill;
            btnInscripcion.FlatAppearance.BorderColor = Color.Black;
            btnInscripcion.FlatAppearance.BorderSize = 2;
            btnInscripcion.FlatStyle = FlatStyle.Flat;
            btnInscripcion.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnInscripcion.ForeColor = Color.Green;
            btnInscripcion.Location = new Point(20, 20);
            btnInscripcion.Margin = new Padding(4);
            btnInscripcion.Name = "btnInscripcion";
            btnInscripcion.Size = new Size(260, 90);
            btnInscripcion.TabIndex = 1;
            btnInscripcion.Text = "Nueva Inscripcion";
            btnInscripcion.UseVisualStyleBackColor = false;
            btnInscripcion.Click += btnInscripcion_Click;
            // 
            // pnlContent
            // 
            pnlContent.AutoScroll = true;
            pnlContent.BackColor = Color.FromArgb(240, 253, 244);
            pnlContent.Controls.Add(tableLayoutPanel1);
            pnlContent.Dock = DockStyle.Fill;
            pnlContent.Location = new Point(0, 112);
            pnlContent.Margin = new Padding(4);
            pnlContent.Name = "pnlContent";
            pnlContent.Size = new Size(1339, 568);
            pnlContent.TabIndex = 1;
            pnlContent.Paint += pnlContent_Paint;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 75F));
            tableLayoutPanel1.Controls.Add(pnlAcciones, 0, 0);
            tableLayoutPanel1.Controls.Add(pictureBox5, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(1339, 568);
            tableLayoutPanel1.TabIndex = 0;
            tableLayoutPanel1.Paint += tableLayoutPanel1_Paint;
            // 
            // pictureBox5
            // 
            pictureBox5.Dock = DockStyle.Fill;
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(337, 3);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(999, 562);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 1;
            pictureBox5.TabStop = false;
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(240, 253, 244);
            ClientSize = new Size(1339, 680);
            Controls.Add(pnlContent);
            Controls.Add(pnlHeader);
            Margin = new Padding(4);
            MinimumSize = new Size(994, 736);
            Name = "FormPrincipal";
            Text = "CAMPSYS - Sistema de Gestion de Campamento";
            WindowState = FormWindowState.Maximized;
            Load += FormPrincipal_Load;
            Resize += FormPrincipal_Resize;
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            pnlAcciones.ResumeLayout(false);
            pnlestaf.ResumeLayout(false);
            pnlayuda.ResumeLayout(false);
            pnlverincripcion.ResumeLayout(false);
            pnltutores.ResumeLayout(false);
            pnlvercampista.ResumeLayout(false);
            pnlmodificar.ResumeLayout(false);
            pnlincripcion.ResumeLayout(false);
            pnlContent.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblSubtitulo;
        private System.Windows.Forms.Panel pnlContent;
        private System.Windows.Forms.Panel pnlAcciones;
        private System.Windows.Forms.Button btnInscripcion;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnVerCampistas;
        private System.Windows.Forms.Button btnVerTutores;
        private System.Windows.Forms.Button btnVerInscripciones;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnAyuda;
        private System.Windows.Forms.Button btnStaff;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Panel pnlincripcion;
        private System.Windows.Forms.Panel pnlmodificar;
        private System.Windows.Forms.Panel pnlvercampista;
        private System.Windows.Forms.Panel pnltutores;
        private System.Windows.Forms.Panel pnlestaf;
        private System.Windows.Forms.Panel pnlayuda;
        private System.Windows.Forms.Panel pnlverincripcion;
    }
}