using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_final
{
    public partial class cajero : Form
    {
        public cajero()
        {
            InitializeComponent();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cajero_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txta.Text, out int monto))
            {
                MessageBox.Show("Ingrese una cantidad válida.");
                return;
            }

            int[] denominaciones = { 100, 20, 10, 5, 1 };
            Dictionary<int, int> cantidadBilletes = CalcularCantidadBilletes(monto, denominaciones);

            MostrarResultado(cantidadBilletes);
        }

        private Dictionary<int, int> CalcularCantidadBilletes(int monto, int[] denominaciones)
        {
            Dictionary<int, int> cantidadBilletes = new Dictionary<int, int>();

            foreach (int denominacion in denominaciones)
            {
                if (monto >= denominacion)
                {
                    int cantidad = monto / denominacion;
                    cantidadBilletes.Add(denominacion, cantidad);
                    monto %= denominacion;
                }
            }

            return cantidadBilletes;
        }

        private void MostrarResultado(Dictionary<int, int> cantidadBilletes)
        {
            txtb.Text = cantidadBilletes.ContainsKey(100) ? cantidadBilletes[100].ToString() : "0";
            txtc.Text = cantidadBilletes.ContainsKey(20) ? cantidadBilletes[20].ToString() : "0";
            txtd.Text = cantidadBilletes.ContainsKey(10) ? cantidadBilletes[10].ToString() : "0";
            txte.Text = cantidadBilletes.ContainsKey(5) ? cantidadBilletes[5].ToString() : "0";
            txtf.Text = cantidadBilletes.ContainsKey(1) ? cantidadBilletes[1].ToString() : "0";
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            txta.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Principal frm_Prin = new Principal();
            this.Hide();
            frm_Prin.ShowDialog();
            this.Close();
        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }
    }
}
