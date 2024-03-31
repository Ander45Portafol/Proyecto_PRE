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

            Determinante = (a * c) - (b * d);

            Determinantex = (r * s) - (b * d);

            Determinantey = (a * c) - (r * s);

            x = Math.Round((Determinantex / Determinante),2);

            y = Math.Round((Determinantey / Determinante),2);

            txtx.Text = x.ToString();

            txty.Text = y.ToString();
        }
    }
}
