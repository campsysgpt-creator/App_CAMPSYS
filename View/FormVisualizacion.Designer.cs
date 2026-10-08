namespace App_CAMPSYS.View
{
    partial class FormVisualizacion
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
            this.btnfiltrar = new System.Windows.Forms.Button();
            this.txtfiltro = new System.Windows.Forms.TextBox();
            this.dgvdatos = new System.Windows.Forms.DataGridView();
            this.lbltitulo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdatos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnfiltrar
            // 
            this.btnfiltrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnfiltrar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnfiltrar.Location = new System.Drawing.Point(843, 102);
            this.btnfiltrar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnfiltrar.Name = "btnfiltrar";
            this.btnfiltrar.Size = new System.Drawing.Size(89, 44);
            this.btnfiltrar.TabIndex = 5;
            this.btnfiltrar.Text = "Filtrar";
            this.btnfiltrar.UseVisualStyleBackColor = true;
            this.btnfiltrar.Click += new System.EventHandler(this.btnfiltrar_Click);
            // 
            // txtfiltro
            // 
            this.txtfiltro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtfiltro.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtfiltro.Location = new System.Drawing.Point(669, 112);
            this.txtfiltro.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtfiltro.Name = "txtfiltro";
            this.txtfiltro.Size = new System.Drawing.Size(168, 27);
            this.txtfiltro.TabIndex = 4;
            this.txtfiltro.Text = "Buscar...";
            // 
            // dgvdatos
            // 
            this.dgvdatos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvdatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdatos.Location = new System.Drawing.Point(40, 162);
            this.dgvdatos.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvdatos.Name = "dgvdatos";
            this.dgvdatos.RowHeadersWidth = 51;
            this.dgvdatos.RowTemplate.Height = 24;
            this.dgvdatos.Size = new System.Drawing.Size(1000, 562);
            this.dgvdatos.TabIndex = 6;
            // 
            // lbltitulo
            // 
            this.lbltitulo.AutoSize = true;
            this.lbltitulo.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lbltitulo.Location = new System.Drawing.Point(40, 38);
            this.lbltitulo.Name = "lbltitulo";
            this.lbltitulo.Size = new System.Drawing.Size(165, 32);
            this.lbltitulo.TabIndex = 7;
            this.lbltitulo.Text = "Visualización";
            // 
            // FormVisualizacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1081, 791);
            this.Controls.Add(this.lbltitulo);
            this.Controls.Add(this.dgvdatos);
            this.Controls.Add(this.btnfiltrar);
            this.Controls.Add(this.txtfiltro);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormVisualizacion";
            this.Text = "Visualización - CAMPSYS";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormVisualizacion_Load);
            this.Resize += new System.EventHandler(this.FormVisualizacion_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.dgvdatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        // Declaraciones de controles
        private System.Windows.Forms.Button btnfiltrar;
        private System.Windows.Forms.TextBox txtfiltro;
        private System.Windows.Forms.DataGridView dgvdatos;
        private System.Windows.Forms.Label lbltitulo;
    }
}