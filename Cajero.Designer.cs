namespace Proyecto_final
{
    partial class cajero
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txta = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Calcular = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtb = new System.Windows.Forms.TextBox();
            this.txtd = new System.Windows.Forms.TextBox();
            this.txtc = new System.Windows.Forms.TextBox();
            this.txte = new System.Windows.Forms.TextBox();
            this.txtf = new System.Windows.Forms.TextBox();
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl5 = new System.Windows.Forms.Label();
            this.lbl4 = new System.Windows.Forms.Label();
            this.lbl3 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(209, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(387, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bienvenido a su Cajero Automático";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txta
            // 
            this.txta.Location = new System.Drawing.Point(300, 140);
            this.txta.Name = "txta";
            this.txta.Size = new System.Drawing.Size(177, 20);
            this.txta.TabIndex = 1;
            this.txta.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(287, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(225, 34);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ingrese su cantidad de dinero (en \r\nDólares).\r\n";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Calcular
            // 
            this.Calcular.Location = new System.Drawing.Point(290, 183);
            this.Calcular.Name = "Calcular";
            this.Calcular.Size = new System.Drawing.Size(200, 38);
            this.Calcular.TabIndex = 3;
            this.Calcular.Text = "Calcular su devolución en billetes.";
            this.Calcular.UseVisualStyleBackColor = true;
            this.Calcular.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            this.label3.Location = new System.Drawing.Point(3, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(173, 78);
            this.label3.TabIndex = 4;
            this.label3.Text = "Este cajero funciona de tal \r\nmanera que si usted posee\r\nuna gran cantidad de din" +
    "ero\r\ny quiere retirarla en billetes \r\npequeños, acá se muestra cuantos\r\nbilletes" +
    " de cada uno serían.";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtb
            // 
            this.txtb.Enabled = false;
            this.txtb.Location = new System.Drawing.Point(389, 269);
            this.txtb.Name = "txtb";
            this.txtb.Size = new System.Drawing.Size(51, 20);
            this.txtb.TabIndex = 5;
            this.txtb.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtd
            // 
            this.txtd.Enabled = false;
            this.txtd.Location = new System.Drawing.Point(389, 347);
            this.txtd.Name = "txtd";
            this.txtd.Size = new System.Drawing.Size(51, 20);
            this.txtd.TabIndex = 6;
            this.txtd.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // txtc
            // 
            this.txtc.Enabled = false;
            this.txtc.Location = new System.Drawing.Point(389, 307);
            this.txtc.Name = "txtc";
            this.txtc.Size = new System.Drawing.Size(51, 20);
            this.txtc.TabIndex = 7;
            this.txtc.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // txte
            // 
            this.txte.Enabled = false;
            this.txte.Location = new System.Drawing.Point(389, 385);
            this.txte.Name = "txte";
            this.txte.Size = new System.Drawing.Size(51, 20);
            this.txte.TabIndex = 9;
            this.txte.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // txtf
            // 
            this.txtf.Enabled = false;
            this.txtf.Location = new System.Drawing.Point(389, 425);
            this.txtf.Name = "txtf";
            this.txtf.Size = new System.Drawing.Size(51, 20);
            this.txtf.TabIndex = 8;
            this.txtf.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(334, 272);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(31, 13);
            this.lbl1.TabIndex = 10;
            this.lbl1.Text = "$100";
            this.lbl1.Click += new System.EventHandler(this.label4_Click);
            // 
            // lbl5
            // 
            this.lbl5.AutoSize = true;
            this.lbl5.Location = new System.Drawing.Point(334, 428);
            this.lbl5.Name = "lbl5";
            this.lbl5.Size = new System.Drawing.Size(19, 13);
            this.lbl5.TabIndex = 12;
            this.lbl5.Text = "$1";
            // 
            // lbl4
            // 
            this.lbl4.AutoSize = true;
            this.lbl4.Location = new System.Drawing.Point(334, 388);
            this.lbl4.Name = "lbl4";
            this.lbl4.Size = new System.Drawing.Size(19, 13);
            this.lbl4.TabIndex = 13;
            this.lbl4.Text = "$5";
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Location = new System.Drawing.Point(334, 350);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(25, 13);
            this.lbl3.TabIndex = 14;
            this.lbl3.Text = "$10";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Location = new System.Drawing.Point(334, 310);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(25, 13);
            this.lbl2.TabIndex = 15;
            this.lbl2.Text = "$20";
            this.lbl2.Click += new System.EventHandler(this.label9_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(313, 241);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(177, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Denominación//Cantidad de billetes";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 215);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(139, 26);
            this.button1.TabIndex = 17;
            this.button1.Text = "Limpiar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(13, 259);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(139, 26);
            this.button2.TabIndex = 18;
            this.button2.Text = "Volver";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Enabled = false;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(7, 452);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Fernando Gamero";
            this.label4.Click += new System.EventHandler(this.label4_Click_1);
            // 
            // cajero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(705, 474);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lbl3);
            this.Controls.Add(this.lbl4);
            this.Controls.Add(this.lbl5);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.txte);
            this.Controls.Add(this.txtf);
            this.Controls.Add(this.txtc);
            this.Controls.Add(this.txtd);
            this.Controls.Add(this.txtb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Calcular);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txta);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "cajero";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cajero";
            this.Load += new System.EventHandler(this.cajero_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Calcular;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtb;
        private System.Windows.Forms.TextBox txtd;
        private System.Windows.Forms.TextBox txtc;
        private System.Windows.Forms.TextBox txte;
        private System.Windows.Forms.TextBox txtf;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl5;
        private System.Windows.Forms.Label lbl4;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label4;
    }
}