namespace Proyecto_final
{
    partial class Promedio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Promedio));
            this.label2 = new System.Windows.Forms.Label();
            this.txtVenta1 = new System.Windows.Forms.TextBox();
            this.txtVenta2 = new System.Windows.Forms.TextBox();
            this.txtVenta3 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnPromedio = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPromedio = new System.Windows.Forms.TextBox();
            this.BtnVolver = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Cornsilk;
            this.label2.Location = new System.Drawing.Point(-3, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1467, 149);
            this.label2.TabIndex = 32;
            this.label2.Text = "Promedio ventas ADOC";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtVenta1
            // 
            this.txtVenta1.Location = new System.Drawing.Point(254, 267);
            this.txtVenta1.Name = "txtVenta1";
            this.txtVenta1.Size = new System.Drawing.Size(272, 26);
            this.txtVenta1.TabIndex = 34;
            // 
            // txtVenta2
            // 
            this.txtVenta2.Location = new System.Drawing.Point(254, 364);
            this.txtVenta2.Name = "txtVenta2";
            this.txtVenta2.Size = new System.Drawing.Size(272, 26);
            this.txtVenta2.TabIndex = 35;
            // 
            // txtVenta3
            // 
            this.txtVenta3.Location = new System.Drawing.Point(254, 471);
            this.txtVenta3.Name = "txtVenta3";
            this.txtVenta3.Size = new System.Drawing.Size(272, 26);
            this.txtVenta3.TabIndex = 36;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(141, 261);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 30);
            this.label1.TabIndex = 37;
            this.label1.Text = "Venta 1:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(141, 355);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 30);
            this.label3.TabIndex = 38;
            this.label3.Text = "Venta 2:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(141, 465);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 30);
            this.label4.TabIndex = 39;
            this.label4.Text = "Venta 3:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.PaleVioletRed;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(667, 677);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(288, 84);
            this.button1.TabIndex = 40;
            this.button1.Text = "Limpiar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnPromedio
            // 
            this.btnPromedio.BackColor = System.Drawing.Color.PaleVioletRed;
            this.btnPromedio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPromedio.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPromedio.Location = new System.Drawing.Point(238, 677);
            this.btnPromedio.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnPromedio.Name = "btnPromedio";
            this.btnPromedio.Size = new System.Drawing.Size(288, 84);
            this.btnPromedio.TabIndex = 41;
            this.btnPromedio.Text = "Calcular Promedio";
            this.btnPromedio.UseVisualStyleBackColor = false;
            this.btnPromedio.Click += new System.EventHandler(this.btnPromedio_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(787, 305);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 30);
            this.label5.TabIndex = 42;
            this.label5.Text = "Promedio:";
            // 
            // txtPromedio
            // 
            this.txtPromedio.Location = new System.Drawing.Point(731, 361);
            this.txtPromedio.Name = "txtPromedio";
            this.txtPromedio.ReadOnly = true;
            this.txtPromedio.Size = new System.Drawing.Size(224, 26);
            this.txtPromedio.TabIndex = 43;
            // 
            // BtnVolver
            // 
            this.BtnVolver.Image = ((System.Drawing.Image)(resources.GetObject("BtnVolver.Image")));
            this.BtnVolver.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnVolver.Location = new System.Drawing.Point(40, 63);
            this.BtnVolver.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnVolver.Name = "BtnVolver";
            this.BtnVolver.Size = new System.Drawing.Size(140, 59);
            this.BtnVolver.TabIndex = 33;
            this.BtnVolver.Text = "Regresar";
            this.BtnVolver.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnVolver.UseVisualStyleBackColor = true;
            this.BtnVolver.Click += new System.EventHandler(this.BtnVolver_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1039, 191);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(640, 537);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Promedio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1740, 916);
            this.Controls.Add(this.txtPromedio);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnPromedio);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtVenta3);
            this.Controls.Add(this.txtVenta2);
            this.Controls.Add(this.txtVenta1);
            this.Controls.Add(this.BtnVolver);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Promedio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Promedio ventas ADOC";
            this.Load += new System.EventHandler(this.Promedio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnVolver;
        private System.Windows.Forms.TextBox txtVenta1;
        private System.Windows.Forms.TextBox txtVenta2;
        private System.Windows.Forms.TextBox txtVenta3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnPromedio;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPromedio;
    }
}