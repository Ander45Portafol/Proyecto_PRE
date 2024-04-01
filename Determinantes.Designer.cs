namespace Proyecto_final
{
    partial class Determinantes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Determinantes));
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbla = new System.Windows.Forms.Label();
            this.btncalcular = new System.Windows.Forms.Button();
            this.btnlimpiar = new System.Windows.Forms.Button();
            this.lblb = new System.Windows.Forms.Label();
            this.lblr = new System.Windows.Forms.Label();
            this.lblc = new System.Windows.Forms.Label();
            this.lbld = new System.Windows.Forms.Label();
            this.lbls = new System.Windows.Forms.Label();
            this.txta = new System.Windows.Forms.TextBox();
            this.txtb = new System.Windows.Forms.TextBox();
            this.txtr = new System.Windows.Forms.TextBox();
            this.txtc = new System.Windows.Forms.TextBox();
            this.txtd = new System.Windows.Forms.TextBox();
            this.txts = new System.Windows.Forms.TextBox();
            this.lblx = new System.Windows.Forms.Label();
            this.lbly = new System.Windows.Forms.Label();
            this.txtx = new System.Windows.Forms.TextBox();
            this.txty = new System.Windows.Forms.TextBox();
            this.BtnVolver = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(163, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(757, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Escriba un programa que resuelva el determinante de un sistema de ecuaciones con " +
    "dos incógnitas\r\n";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(166, 94);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(218, 133);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lbla
            // 
            this.lbla.AutoSize = true;
            this.lbla.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbla.Location = new System.Drawing.Point(476, 96);
            this.lbla.Name = "lbla";
            this.lbla.Size = new System.Drawing.Size(201, 18);
            this.lbla.TabIndex = 2;
            this.lbla.Text = "Asignar valor al coeficiente\"a\"";
            this.lbla.Click += new System.EventHandler(this.lbla_Click);
            // 
            // btncalcular
            // 
            this.btncalcular.BackColor = System.Drawing.Color.Chocolate;
            this.btncalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncalcular.Location = new System.Drawing.Point(151, 264);
            this.btncalcular.Name = "btncalcular";
            this.btncalcular.Size = new System.Drawing.Size(127, 43);
            this.btncalcular.TabIndex = 3;
            this.btncalcular.Text = "Calcular";
            this.btncalcular.UseVisualStyleBackColor = false;
            this.btncalcular.Click += new System.EventHandler(this.btncalcular_Click);
            // 
            // btnlimpiar
            // 
            this.btnlimpiar.BackColor = System.Drawing.Color.SandyBrown;
            this.btnlimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlimpiar.Location = new System.Drawing.Point(284, 264);
            this.btnlimpiar.Name = "btnlimpiar";
            this.btnlimpiar.Size = new System.Drawing.Size(127, 40);
            this.btnlimpiar.TabIndex = 4;
            this.btnlimpiar.Text = "Limpiar";
            this.btnlimpiar.UseVisualStyleBackColor = false;
            this.btnlimpiar.Click += new System.EventHandler(this.btnlimpiar_Click);
            // 
            // lblb
            // 
            this.lblb.AutoSize = true;
            this.lblb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblb.Location = new System.Drawing.Point(476, 182);
            this.lblb.Name = "lblb";
            this.lblb.Size = new System.Drawing.Size(205, 18);
            this.lblb.TabIndex = 5;
            this.lblb.Text = "Asignar valor al coeficiente \"b\"";
            this.lblb.Click += new System.EventHandler(this.lblb_Click);
            // 
            // lblr
            // 
            this.lblr.AutoSize = true;
            this.lblr.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblr.Location = new System.Drawing.Point(476, 261);
            this.lblr.Name = "lblr";
            this.lblr.Size = new System.Drawing.Size(216, 18);
            this.lblr.TabIndex = 6;
            this.lblr.Text = "Asignar valor al resultado de  \"r\"";
            this.lblr.Click += new System.EventHandler(this.lblr_Click);
            // 
            // lblc
            // 
            this.lblc.AutoSize = true;
            this.lblc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblc.Location = new System.Drawing.Point(724, 96);
            this.lblc.Name = "lblc";
            this.lblc.Size = new System.Drawing.Size(205, 18);
            this.lblc.TabIndex = 7;
            this.lblc.Text = "Asignar valor al coeficiente \"c\"";
            this.lblc.Click += new System.EventHandler(this.lblc_Click);
            // 
            // lbld
            // 
            this.lbld.AutoSize = true;
            this.lbld.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbld.Location = new System.Drawing.Point(724, 182);
            this.lbld.Name = "lbld";
            this.lbld.Size = new System.Drawing.Size(205, 18);
            this.lbld.TabIndex = 8;
            this.lbld.Text = "Asignar valor al coeficiente \"d\"";
            this.lbld.Click += new System.EventHandler(this.lbld_Click);
            // 
            // lbls
            // 
            this.lbls.AutoSize = true;
            this.lbls.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbls.Location = new System.Drawing.Point(724, 261);
            this.lbls.Name = "lbls";
            this.lbls.Size = new System.Drawing.Size(215, 18);
            this.lbls.TabIndex = 9;
            this.lbls.Text = "Asignar valor al resultado de \"s\"";
            this.lbls.Click += new System.EventHandler(this.lbls_Click);
            // 
            // txta
            // 
            this.txta.Location = new System.Drawing.Point(479, 117);
            this.txta.Name = "txta";
            this.txta.Size = new System.Drawing.Size(220, 22);
            this.txta.TabIndex = 10;
            this.txta.TextChanged += new System.EventHandler(this.txta_TextChanged);
            // 
            // txtb
            // 
            this.txtb.Location = new System.Drawing.Point(479, 205);
            this.txtb.Name = "txtb";
            this.txtb.Size = new System.Drawing.Size(220, 22);
            this.txtb.TabIndex = 11;
            this.txtb.TextChanged += new System.EventHandler(this.txtb_TextChanged);
            // 
            // txtr
            // 
            this.txtr.Location = new System.Drawing.Point(479, 285);
            this.txtr.Name = "txtr";
            this.txtr.Size = new System.Drawing.Size(220, 22);
            this.txtr.TabIndex = 12;
            this.txtr.TextChanged += new System.EventHandler(this.txtr_TextChanged);
            // 
            // txtc
            // 
            this.txtc.Location = new System.Drawing.Point(727, 117);
            this.txtc.Name = "txtc";
            this.txtc.Size = new System.Drawing.Size(220, 22);
            this.txtc.TabIndex = 13;
            this.txtc.TextChanged += new System.EventHandler(this.txtc_TextChanged);
            // 
            // txtd
            // 
            this.txtd.Location = new System.Drawing.Point(727, 205);
            this.txtd.Name = "txtd";
            this.txtd.Size = new System.Drawing.Size(220, 22);
            this.txtd.TabIndex = 14;
            this.txtd.TextChanged += new System.EventHandler(this.txtd_TextChanged);
            // 
            // txts
            // 
            this.txts.Location = new System.Drawing.Point(727, 285);
            this.txts.Name = "txts";
            this.txts.Size = new System.Drawing.Size(220, 22);
            this.txts.TabIndex = 15;
            this.txts.TextChanged += new System.EventHandler(this.txts_TextChanged);
            // 
            // lblx
            // 
            this.lblx.AutoSize = true;
            this.lblx.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblx.Location = new System.Drawing.Point(684, 338);
            this.lblx.Name = "lblx";
            this.lblx.Size = new System.Drawing.Size(108, 18);
            this.lblx.TabIndex = 16;
            this.lblx.Text = "El valor de x es";
            this.lblx.Click += new System.EventHandler(this.lblx_Click);
            // 
            // lbly
            // 
            this.lbly.AutoSize = true;
            this.lbly.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbly.Location = new System.Drawing.Point(684, 405);
            this.lbly.Name = "lbly";
            this.lbly.Size = new System.Drawing.Size(108, 18);
            this.lbly.TabIndex = 17;
            this.lbly.Text = "El valor de y es";
            this.lbly.Click += new System.EventHandler(this.lbly_Click);
            // 
            // txtx
            // 
            this.txtx.Location = new System.Drawing.Point(684, 359);
            this.txtx.Name = "txtx";
            this.txtx.ReadOnly = true;
            this.txtx.Size = new System.Drawing.Size(220, 22);
            this.txtx.TabIndex = 18;
            this.txtx.TextChanged += new System.EventHandler(this.txtx_TextChanged);
            // 
            // txty
            // 
            this.txty.Location = new System.Drawing.Point(684, 426);
            this.txty.Name = "txty";
            this.txty.ReadOnly = true;
            this.txty.Size = new System.Drawing.Size(220, 22);
            this.txty.TabIndex = 19;
            this.txty.TextChanged += new System.EventHandler(this.txty_TextChanged);
            // 
            // BtnVolver
            // 
            this.BtnVolver.Image = ((System.Drawing.Image)(resources.GetObject("BtnVolver.Image")));
            this.BtnVolver.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnVolver.Location = new System.Drawing.Point(12, 12);
            this.BtnVolver.Name = "BtnVolver";
            this.BtnVolver.Size = new System.Drawing.Size(124, 47);
            this.BtnVolver.TabIndex = 30;
            this.BtnVolver.Text = "Regresar";
            this.BtnVolver.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnVolver.UseVisualStyleBackColor = true;
            this.BtnVolver.Click += new System.EventHandler(this.BtnVolver_Click);
            // 
            // Determinantes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(1163, 576);
            this.Controls.Add(this.BtnVolver);
            this.Controls.Add(this.txty);
            this.Controls.Add(this.txtx);
            this.Controls.Add(this.lbly);
            this.Controls.Add(this.lblx);
            this.Controls.Add(this.txts);
            this.Controls.Add(this.txtd);
            this.Controls.Add(this.txtc);
            this.Controls.Add(this.txtr);
            this.Controls.Add(this.txtb);
            this.Controls.Add(this.txta);
            this.Controls.Add(this.lbls);
            this.Controls.Add(this.lbld);
            this.Controls.Add(this.lblc);
            this.Controls.Add(this.lblr);
            this.Controls.Add(this.lblb);
            this.Controls.Add(this.btnlimpiar);
            this.Controls.Add(this.btncalcular);
            this.Controls.Add(this.lbla);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "Determinantes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Determinantes";
            this.Load += new System.EventHandler(this.Determinantes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbla;
        private System.Windows.Forms.Button btncalcular;
        private System.Windows.Forms.Button btnlimpiar;
        private System.Windows.Forms.Label lblb;
        private System.Windows.Forms.Label lblr;
        private System.Windows.Forms.Label lblc;
        private System.Windows.Forms.Label lbld;
        private System.Windows.Forms.Label lbls;
        private System.Windows.Forms.TextBox txta;
        private System.Windows.Forms.TextBox txtb;
        private System.Windows.Forms.TextBox txtr;
        private System.Windows.Forms.TextBox txtc;
        private System.Windows.Forms.TextBox txtd;
        private System.Windows.Forms.TextBox txts;
        private System.Windows.Forms.Label lblx;
        private System.Windows.Forms.Label lbly;
        private System.Windows.Forms.TextBox txtx;
        private System.Windows.Forms.TextBox txty;
        private System.Windows.Forms.Button BtnVolver;
    }
}