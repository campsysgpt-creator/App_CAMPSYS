using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_CAMPSYS.View
{
    public partial class FrmMensaje : Form
    {
        public FrmMensaje()
        {
            InitializeComponent();
        }

        public FrmMensaje(string mensaje, bool esExito = false) : this()
        {
            lblMensaje.Text = mensaje;

            if (esExito)
            {
                lblTitulo.Text = "Operación exitosa";
                lblIcono.Text = "✓";
                lblIcono.ForeColor = Color.Green;
                panelLinea.BackColor = Color.Green;
            }
            else
            {
                lblTitulo.Text = "Error de validación";
                lblIcono.Text = "⚠";
                lblIcono.ForeColor = Color.OrangeRed;
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmMensaje_Load(object sender, EventArgs e)
        {

        }
    }
}
