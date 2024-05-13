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
    public partial class Ordenamiento : Form
    {
        public Ordenamiento()
        {
            InitializeComponent();
        }

        private void BtnVolver_Click(object sender, EventArgs e)
        {
            Principal frm_Prin = new Principal();
            this.Hide();
            frm_Prin.ShowDialog();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtNum1.Clear();
            txtNum2.Clear();
            txtNum3.Clear();
            txtNumMin.Clear();
            txtNumMid.Clear();
            txtNumMax.Clear();
        }

        private void btnOden_Click(object sender, EventArgs e)
        {
            // Variables para almacenar los números enteros
            int num1, num2, num3;

            // Validar que los valores ingresados sean enteros
            if (int.TryParse(txtNum1.Text, out num1) &&
                int.TryParse(txtNum2.Text, out num2) &&
                int.TryParse(txtNum3.Text, out num3))
            {
                // Variables para almacenar los números ordenados
                int min, mid, max;

                // Determinar el mínimo, medio y máximo
                min = Math.Min(num1, Math.Min(num2, num3));
                max = Math.Max(num1, Math.Max(num2, num3));

                // Determinar el número medio
                if ((num1 > num2 && num1 < num3) || (num1 < num2 && num1 > num3))
                    mid = num1;
                else if ((num2 > num1 && num2 < num3) || (num2 < num1 && num2 > num3))
                    mid = num2;
                else
                    mid = num3;

                // Mostrar los resultados en los TextBox correspondientes
                txtNumMin.Text = min.ToString();
                txtNumMid.Text = mid.ToString();
                txtNumMax.Text = max.ToString();
            }
            else
            {
                MessageBox.Show("Por favor, ingrese solo números enteros en todos los campos.", "Error de Entrada", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
