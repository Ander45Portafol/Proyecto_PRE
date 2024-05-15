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
    public partial class Plano_Cartesiano : Form
    {
        public Plano_Cartesiano()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtY.Clear();
            txtX.Clear();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (txtX.Text.Equals("") && txtY.Text.Equals(""))
            {
                MessageBox.Show("No se permiten valores vacios", "Campos vacios", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else {
                if (int.Parse(txtX.Text) > 0 && int.Parse(txtY.Text) > 0)
                {
                    MessageBox.Show("La coordernadas ingresadas, se encuentran en el primer cuadrante", "¡Felicidades!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (int.Parse(txtX.Text) < 0 && int.Parse(txtY.Text) > 0)
                {
                    MessageBox.Show("La coordernadas ingresadas, se encuentran en el segundo cuadrante", "¡Felicidades!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (int.Parse(txtX.Text) > 0 && int.Parse(txtY.Text) < 0)
                {
                    MessageBox.Show("La coordernadas ingresadas, se encuentran en el cuarto cuadrante", "¡Felicidades!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (int.Parse(txtX.Text) < 0 && int.Parse(txtY.Text) < 0) {
                    MessageBox.Show("La coordernadas ingresadas, se encuentran en el tercer cuadrante", "¡Felicidades!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            Principal frm_Principal = new Principal();
            this.Hide();
            frm_Principal.ShowDialog();
            this.Close();
        }
    }
}
