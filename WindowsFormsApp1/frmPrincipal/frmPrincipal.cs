using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }


        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            pnl1.BackColor = Color.FromArgb(0,92,181);
            pnl2.BackColor = Color.FromArgb(26,117,207);
            lblRebajas.BackColor = Color.FromArgb(252,237,52);
            pnl3.BackColor = Color.FromArgb(0,92,181);
            btnCompra1.BackColor = Color.FromArgb(25,128,215);
            btnCompra2.BackColor = Color.FromArgb(25,128,215);
            btnCompra3.BackColor = Color.FromArgb(255, 255, 255);
            btnCompra4.BackColor = Color.FromArgb(255, 255, 255);

        }

        private void btnCompra1_Click(object sender, EventArgs e)
        {
            string mensaje = "Usted ha comprado una secadora.";
            MessageBox.Show(mensaje, "Walmart", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        private void btnCompra2_Click(object sender, EventArgs e)
        {
            string mensaje = "Usted ha comprado raid para zancudos.";
            MessageBox.Show(mensaje, "Walmart", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnCompra3_Click(object sender, EventArgs e)
        {
            string mensaje = "Usted ha comprado un telefono con 10 meses sin intereses.";
            MessageBox.Show(mensaje, "Walmart", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        private void btnCompra4_Click(object sender, EventArgs e)
        {
            string mensaje = "Usted ha obtenido rebajas.";
            MessageBox.Show(mensaje, "Walmart", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}