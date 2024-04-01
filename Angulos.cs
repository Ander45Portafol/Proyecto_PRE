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
    public partial class Angulos : Form
    {
        public Angulos()
        {
            InitializeComponent();
        }

        private void Angulos_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
        static double[] CalcularAngulosYHipotenusa(double catetoMenor, double catetoMayor)
        {
            // Calcular la hipotenusa usando el teorema de Pitágoras
            double hipotenusa = Math.Sqrt(Math.Pow(catetoMenor, 2) + Math.Pow(catetoMayor, 2));

            // Calcular los ángulos agudos
            double anguloA = Math.Asin(catetoMenor / hipotenusa) * (180 / Math.PI);
            double anguloB = 90 - anguloA;
            return new double[] { hipotenusa, anguloA, anguloB };
        }
        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            double cmenor = Double.Parse(cateto_menortext.Text);
            double cmayor = Double.Parse(cateto_mayortext.Text);

            double[] respuestas = CalcularAngulosYHipotenusa(cmenor, cmayor);

            double hipotenusa = respuestas[0];
            double anguloA = respuestas[1];
            double anguloB = respuestas[2];

            r1.Text = anguloA.ToString("0.00") + "°";
            r2.Text = anguloB.ToString("0.00") + "°";
            r3.Text = hipotenusa.ToString("0.00");
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            r1.Clear();
            r2.Clear();
            r3.Clear();
            cateto_mayortext.Clear();
            cateto_menortext.Clear();
        }

        private void BtnRegresar_Click(object sender, EventArgs e)
        {
            Principal frm_principal=new Principal();
            this.Hide();
            frm_principal.ShowDialog();
            this.Close();
        }
    }
}
