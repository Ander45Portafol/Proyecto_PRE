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
    public partial class Herencia : Form
    {
        double herenciaTotal, juan, luis, rosa, abogadoJuan, abogadoLuis, abogadoRosa, totalAbogado;

        public Herencia()
        {
            InitializeComponent();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            Principal principal = new Principal();
            this.Hide();
            principal.ShowDialog();
            this.Close();
        }
        private void calcular_herencia(double cantidad_herencia) {
            // Cálculo de la herencia para cada hijo
            juan = cantidad_herencia / 3;
            luis = (4 * cantidad_herencia) / 9;
            rosa = (2 * cantidad_herencia) / 9;

            // Cálculo del monto que recibe el abogado de cada hijo
            abogadoJuan = (juan < cantidad_herencia / 3) ? juan * 0.03 : juan * 0.05;
            abogadoLuis = (luis < cantidad_herencia / 3) ? luis * 0.03 : luis * 0.05;
            abogadoRosa = (rosa < cantidad_herencia / 3) ? rosa * 0.03 : rosa * 0.05;

            // Cálculo del monto total que recibe el abogado
            totalAbogado = abogadoJuan + abogadoLuis + abogadoRosa;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            calcular_herencia(double.Parse(txtHerencia.Text));
            //Imprimiendo los datos
            txtJuan.Text = "$" + Math.Round(juan, 2);
            txtLuis.Text = "$" + Math.Round(luis, 2);
            txtRosa.Text = "$" + Math.Round(rosa, 2);
            txtAbogado.Text = "$" + Math.Round(totalAbogado, 2);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
