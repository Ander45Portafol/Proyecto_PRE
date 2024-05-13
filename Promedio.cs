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
    public partial class Promedio : Form
    {
        public Promedio()
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
            txtVenta1.Clear();
            txtVenta2.Clear();
            txtVenta3.Clear();
            txtPromedio.Clear();
        }

        private void Promedio_Load(object sender, EventArgs e)
        {

        }

        private void btnPromedio_Click(object sender, EventArgs e)
        {
            // Variables para almacenar los valores numéricos de las ventas
            Double venta1, venta2, venta3;

            // Verifica que las entradas sean números no negativos
            if (Double.TryParse(txtVenta1.Text, out venta1) && venta1 >= 0 &&
                Double.TryParse(txtVenta2.Text, out venta2) && venta2 >= 0 &&
                Double.TryParse(txtVenta3.Text, out venta3) && venta3 >= 0)
            {
                // Calcular el promedio
                Double promedio = (venta1 + venta2 + venta3) / 3;

                // Mostrar el promedio en el TextBox txtPromedio
                txtPromedio.Text = promedio.ToString("F2");

                // Verificar si el promedio es mayor o igual a 500
                if (promedio >= 500)
                {
                    MessageBox.Show("Se ha ganado un regalito", "¡Felicidades!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Lo esperamos pronto", "Vuelva Pronto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                // Mensaje de error si alguna de las entradas no es válida
                MessageBox.Show("Por favor, ingrese números válidos y no negativos en todas las cajas de venta.");
            }
        }
    }
}
