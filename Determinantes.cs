using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_final
{
    public partial class Determinantes : Form
    {
        public Determinantes()
        {
            InitializeComponent();


        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            txta.Clear();
            txtb.Clear();
            txtr.Clear();
            txtc.Clear();
            txtd.Clear();
            txts.Clear();

        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            CalcularDet();
        }

        public void CalcularDet()
        {
            double a, b, r, c, d, s, x, y, Determinantex, Determinantey, Determinante;

            a = Double.Parse(txta.Text);

            b = Double.Parse(txtb.Text);

            r = Double.Parse(txtr.Text);

            c = Double.Parse(txtc.Text);

            d = Double.Parse(txtd.Text);

            s = Double.Parse(txts.Text);

            Determinante = (a * d) - (c * b);

            Determinantex = (r * d) - (s * b);

            Determinantey = (a * s) - (c * r);

            x = Math.Round((Determinantex / Determinante),2);

            y = Math.Round((Determinantey / Determinante),2);

            txtx.Text = x.ToString();

            txty.Text = y.ToString();
        }

        private void txty_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtx_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblx_Click(object sender, EventArgs e)
        {

        }

        private void lbly_Click(object sender, EventArgs e)
        {

        }

        private void txts_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbls_Click(object sender, EventArgs e)
        {

        }

        private void txtd_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbld_Click(object sender, EventArgs e)
        {

        }

        private void lblb_Click(object sender, EventArgs e)
        {

        }

        private void Determinantes_Load(object sender, EventArgs e)
        {

        }

        private void txtb_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblr_Click(object sender, EventArgs e)
        {

        }

        private void txtr_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void txta_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbla_Click(object sender, EventArgs e)
        {

        }

        private void lblc_Click(object sender, EventArgs e)
        {

        }

        private void txtc_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BtnVolver_Click(object sender, EventArgs e)
        {
            Principal frm_Prin=new Principal();
            this.Hide();
            frm_Prin.ShowDialog();
            this.Close();
        }
    }
}
