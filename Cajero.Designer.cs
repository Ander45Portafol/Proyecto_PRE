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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(cajero));
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
            this.BtnVolver = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Cornsilk;
            this.label1.Location = new System.Drawing.Point(139, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1273, 91);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bienvenido a su Cajero Automático";
            // 
            // txta
            // 
            this.txta.Location = new System.Drawing.Point(219, 336);
            this.txta.Margin = new System.Windows.Forms.Padding(4);
            this.txta.Name = "txta";
            this.txta.Size = new System.Drawing.Size(335, 22);
            this.txta.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Cornsilk;
            this.label2.Location = new System.Drawing.Point(214, 259);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(340, 52);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ingrese su cantidad de dinero (en \r\nDólares).\r\n";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Calcular
            // 
            this.Calcular.BackColor = System.Drawing.Color.PaleVioletRed;
            this.Calcular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Calcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Calcular.Location = new System.Drawing.Point(155, 382);
            this.Calcular.Margin = new System.Windows.Forms.Padding(4);
            this.Calcular.Name = "Calcular";
            this.Calcular.Size = new System.Drawing.Size(256, 67);
            this.Calcular.TabIndex = 3;
            this.Calcular.Text = "Calcular su devolución en billetes.";
            this.Calcular.UseVisualStyleBackColor = false;
            this.Calcular.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            this.label3.ForeColor = System.Drawing.Color.Cornsilk;
            this.label3.Location = new System.Drawing.Point(256, 117);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(979, 52);
            this.label3.TabIndex = 4;
            this.label3.Text = "Este cajero funciona de tal manera que si usted posee una gran cantidad de dinero" +
    " y quiere retirarla \r\nen billetes pequeños, acá se muestra cuantos billetes de c" +
    "ada uno serían.";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtb
            // 
            this.txtb.Location = new System.Drawing.Point(1031, 303);
            this.txtb.Margin = new System.Windows.Forms.Padding(4);
            this.txtb.Name = "txtb";
            this.txtb.ReadOnly = true;
            this.txtb.Size = new System.Drawing.Size(124, 22);
            this.txtb.TabIndex = 5;
            // 
            // txtd
            // 
            this.txtd.Location = new System.Drawing.Point(1031, 416);
            this.txtd.Margin = new System.Windows.Forms.Padding(4);
            this.txtd.Name = "txtd";
            this.txtd.ReadOnly = true;
            this.txtd.Size = new System.Drawing.Size(124, 22);
            this.txtd.TabIndex = 6;
            // 
            // txtc
            // 
            this.txtc.Location = new System.Drawing.Point(1031, 362);
            this.txtc.Margin = new System.Windows.Forms.Padding(4);
            this.txtc.Name = "txtc";
            this.txtc.ReadOnly = true;
            this.txtc.Size = new System.Drawing.Size(124, 22);
            this.txtc.TabIndex = 7;
            // 
            // txte
            // 
            this.txte.Location = new System.Drawing.Point(1031, 475);
            this.txte.Margin = new System.Windows.Forms.Padding(4);
            this.txte.Name = "txte";
            this.txte.ReadOnly = true;
            this.txte.Size = new System.Drawing.Size(124, 22);
            this.txte.TabIndex = 9;
            // 
            // txtf
            // 
            this.txtf.Location = new System.Drawing.Point(1031, 534);
            this.txtf.Margin = new System.Windows.Forms.Padding(4);
            this.txtf.Name = "txtf";
            this.txtf.ReadOnly = true;
            this.txtf.Size = new System.Drawing.Size(124, 22);
            this.txtf.TabIndex = 8;
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.ForeColor = System.Drawing.Color.Cornsilk;
            this.lbl1.Location = new System.Drawing.Point(918, 298);
            this.lbl1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(60, 26);
            this.lbl1.TabIndex = 10;
            this.lbl1.Text = "$100";
            // 
            // lbl5
            // 
            this.lbl5.AutoSize = true;
            this.lbl5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl5.ForeColor = System.Drawing.Color.Cornsilk;
            this.lbl5.Location = new System.Drawing.Point(918, 529);
            this.lbl5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl5.Name = "lbl5";
            this.lbl5.Size = new System.Drawing.Size(36, 26);
            this.lbl5.TabIndex = 12;
            this.lbl5.Text = "$1";
            // 
            // lbl4
            // 
            this.lbl4.AutoSize = true;
            this.lbl4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl4.ForeColor = System.Drawing.Color.Cornsilk;
            this.lbl4.Location = new System.Drawing.Point(918, 471);
            this.lbl4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl4.Name = "lbl4";
            this.lbl4.Size = new System.Drawing.Size(36, 26);
            this.lbl4.TabIndex = 13;
            this.lbl4.Text = "$5";
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl3.ForeColor = System.Drawing.Color.Cornsilk;
            this.lbl3.Location = new System.Drawing.Point(918, 412);
            this.lbl3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(48, 26);
            this.lbl3.TabIndex = 14;
            this.lbl3.Text = "$10";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2.ForeColor = System.Drawing.Color.Cornsilk;
            this.lbl2.Location = new System.Drawing.Point(918, 357);
            this.lbl2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(48, 26);
            this.lbl2.TabIndex = 15;
            this.lbl2.Text = "$20";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Cornsilk;
            this.label5.Location = new System.Drawing.Point(880, 214);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(355, 26);
            this.label5.TabIndex = 16;
            this.label5.Text = "Denominación//Cantidad de billetes";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.PaleVioletRed;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(449, 382);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(256, 67);
            this.button1.TabIndex = 17;
            this.button1.Text = "Limpiar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // BtnVolver
            // 
            this.BtnVolver.Image = ((System.Drawing.Image)(resources.GetObject("BtnVolver.Image")));
            this.BtnVolver.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnVolver.Location = new System.Drawing.Point(12, 25);
            this.BtnVolver.Name = "BtnVolver";
            this.BtnVolver.Size = new System.Drawing.Size(124, 47);
            this.BtnVolver.TabIndex = 31;
            this.BtnVolver.Text = "Regresar";
            this.BtnVolver.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnVolver.UseVisualStyleBackColor = true;
            this.BtnVolver.Click += new System.EventHandler(this.BtnVolver_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Cornsilk;
            this.label4.Location = new System.Drawing.Point(37, 688);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(189, 26);
            this.label4.TabIndex = 32;
            this.label4.Text = "Fernando Gamero";
            // 
            // cajero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.ClientSize = new System.Drawing.Size(1547, 733);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BtnVolver);
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
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "cajero";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cajero";
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
        private System.Windows.Forms.Button BtnVolver;
        private System.Windows.Forms.Label label4;
    }
}