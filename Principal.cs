﻿using System;
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
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void BtnDeterminante_Click(object sender, EventArgs e)
        {
            Determinantes form_deter = new Determinantes();
            this.Hide();
            form_deter.ShowDialog();
            this.Close();
        }

        private void button9_Click(object sender, EventArgs e)
        {

        }
    }
}