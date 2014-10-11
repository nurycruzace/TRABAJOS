namespace AppCalculadora
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtbPantalla = new System.Windows.Forms.TextBox();
            this.bt7 = new System.Windows.Forms.Button();
            this.bt4 = new System.Windows.Forms.Button();
            this.bt1 = new System.Windows.Forms.Button();
            this.bt0 = new System.Windows.Forms.Button();
            this.bt8 = new System.Windows.Forms.Button();
            this.bt5 = new System.Windows.Forms.Button();
            this.bt2 = new System.Windows.Forms.Button();
            this.btPunto = new System.Windows.Forms.Button();
            this.bt9 = new System.Windows.Forms.Button();
            this.bt6 = new System.Windows.Forms.Button();
            this.bt3 = new System.Windows.Forms.Button();
            this.btIgual = new System.Windows.Forms.Button();
            this.btMas = new System.Windows.Forms.Button();
            this.btMenos = new System.Windows.Forms.Button();
            this.btPor = new System.Windows.Forms.Button();
            this.btDivision = new System.Windows.Forms.Button();
            this.btC = new System.Windows.Forms.Button();
            this.btRetroceso = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtbPantalla
            // 
            this.txtbPantalla.BackColor = System.Drawing.SystemColors.Info;
            this.txtbPantalla.Enabled = false;
            this.txtbPantalla.Font = new System.Drawing.Font("Kristen ITC", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbPantalla.Location = new System.Drawing.Point(52, 13);
            this.txtbPantalla.Name = "txtbPantalla";
            this.txtbPantalla.ReadOnly = true;
            this.txtbPantalla.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtbPantalla.Size = new System.Drawing.Size(248, 33);
            this.txtbPantalla.TabIndex = 0;
            this.txtbPantalla.Text = "0";
            this.txtbPantalla.TextChanged += new System.EventHandler(this.txtbPantalla_TextChanged);
            // 
            // bt7
            // 
            this.bt7.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.bt7.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.bt7.Font = new System.Drawing.Font("Kristen ITC", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bt7.Location = new System.Drawing.Point(47, 87);
            this.bt7.Name = "bt7";
            this.bt7.Size = new System.Drawing.Size(48, 33);
            this.bt7.TabIndex = 1;
            this.bt7.Text = "7";
            this.bt7.UseVisualStyleBackColor = false;
            this.bt7.Click += new System.EventHandler(this.bt7_Click);
            // 
            // bt4
            // 
            this.bt4.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.bt4.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.bt4.Font = new System.Drawing.Font("Kristen ITC", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bt4.Location = new System.Drawing.Point(47, 130);
            this.bt4.Name = "bt4";
            this.bt4.Size = new System.Drawing.Size(48, 33);
            this.bt4.TabIndex = 2;
            this.bt4.Text = "4";
            this.bt4.UseVisualStyleBackColor = false;
            this.bt4.Click += new System.EventHandler(this.bt4_Click);
            // 
            // bt1
            // 
            this.bt1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.bt1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.bt1.Font = new System.Drawing.Font("Kristen ITC", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bt1.Location = new System.Drawing.Point(47, 175);
            this.bt1.Name = "bt1";
            this.bt1.Size = new System.Drawing.Size(48, 33);
            this.bt1.TabIndex = 3;
            this.bt1.Text = "1";
            this.bt1.UseVisualStyleBackColor = false;
            this.bt1.Click += new System.EventHandler(this.bt1_Click);
            // 
            // bt0
            // 
            this.bt0.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.bt0.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.bt0.Font = new System.Drawing.Font("Kristen ITC", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt0.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bt0.Location = new System.Drawing.Point(47, 219);
            this.bt0.Name = "bt0";
            this.bt0.Size = new System.Drawing.Size(48, 33);
            this.bt0.TabIndex = 4;
            this.bt0.Text = "0";
            this.bt0.UseVisualStyleBackColor = false;
            this.bt0.Click += new System.EventHandler(this.bt0_Click);
            // 
            // bt8
            // 
            this.bt8.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.bt8.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.bt8.Font = new System.Drawing.Font("Kristen ITC", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bt8.Location = new System.Drawing.Point(106, 87);
            this.bt8.Name = "bt8";
            this.bt8.Size = new System.Drawing.Size(48, 33);
            this.bt8.TabIndex = 5;
            this.bt8.Text = "8";
            this.bt8.UseVisualStyleBackColor = false;
            this.bt8.Click += new System.EventHandler(this.bt8_Click);
            // 
            // bt5
            // 
            this.bt5.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.bt5.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.bt5.Font = new System.Drawing.Font("Kristen ITC", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bt5.Location = new System.Drawing.Point(106, 130);
            this.bt5.Name = "bt5";
            this.bt5.Size = new System.Drawing.Size(48, 33);
            this.bt5.TabIndex = 6;
            this.bt5.Text = "5";
            this.bt5.UseVisualStyleBackColor = false;
            this.bt5.Click += new System.EventHandler(this.bt5_Click);
            // 
            // bt2
            // 
            this.bt2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.bt2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.bt2.Font = new System.Drawing.Font("Kristen ITC", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bt2.Location = new System.Drawing.Point(106, 175);
            this.bt2.Name = "bt2";
            this.bt2.Size = new System.Drawing.Size(48, 33);
            this.bt2.TabIndex = 7;
            this.bt2.Text = "2";
            this.bt2.UseVisualStyleBackColor = false;
            this.bt2.Click += new System.EventHandler(this.bt2_Click);
            // 
            // btPunto
            // 
            this.btPunto.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btPunto.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btPunto.Font = new System.Drawing.Font("Kristen ITC", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btPunto.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btPunto.Location = new System.Drawing.Point(106, 219);
            this.btPunto.Name = "btPunto";
            this.btPunto.Size = new System.Drawing.Size(48, 33);
            this.btPunto.TabIndex = 8;
            this.btPunto.Text = ".";
            this.btPunto.UseVisualStyleBackColor = false;
            this.btPunto.Click += new System.EventHandler(this.btPunto_Click);
            // 
            // bt9
            // 
            this.bt9.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.bt9.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.bt9.Font = new System.Drawing.Font("Kristen ITC", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bt9.Location = new System.Drawing.Point(172, 87);
            this.bt9.Name = "bt9";
            this.bt9.Size = new System.Drawing.Size(48, 33);
            this.bt9.TabIndex = 9;
            this.bt9.Text = "9";
            this.bt9.UseVisualStyleBackColor = false;
            this.bt9.Click += new System.EventHandler(this.bt9_Click);
            // 
            // bt6
            // 
            this.bt6.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.bt6.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.bt6.Font = new System.Drawing.Font("Kristen ITC", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bt6.Location = new System.Drawing.Point(172, 130);
            this.bt6.Name = "bt6";
            this.bt6.Size = new System.Drawing.Size(48, 33);
            this.bt6.TabIndex = 10;
            this.bt6.Text = "6";
            this.bt6.UseVisualStyleBackColor = false;
            this.bt6.Click += new System.EventHandler(this.bt6_Click);
            // 
            // bt3
            // 
            this.bt3.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.bt3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.bt3.Font = new System.Drawing.Font("Kristen ITC", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bt3.Location = new System.Drawing.Point(172, 175);
            this.bt3.Name = "bt3";
            this.bt3.Size = new System.Drawing.Size(48, 33);
            this.bt3.TabIndex = 11;
            this.bt3.Text = "3";
            this.bt3.UseVisualStyleBackColor = false;
            this.bt3.Click += new System.EventHandler(this.bt3_Click);
            // 
            // btIgual
            // 
            this.btIgual.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btIgual.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btIgual.Font = new System.Drawing.Font("Kristen ITC", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btIgual.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btIgual.Location = new System.Drawing.Point(172, 219);
            this.btIgual.Name = "btIgual";
            this.btIgual.Size = new System.Drawing.Size(48, 33);
            this.btIgual.TabIndex = 12;
            this.btIgual.Text = "=";
            this.btIgual.UseVisualStyleBackColor = false;
            this.btIgual.Click += new System.EventHandler(this.btIgual_Click);
            // 
            // btMas
            // 
            this.btMas.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btMas.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btMas.Font = new System.Drawing.Font("Kristen ITC", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btMas.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btMas.Location = new System.Drawing.Point(233, 89);
            this.btMas.Name = "btMas";
            this.btMas.Size = new System.Drawing.Size(51, 33);
            this.btMas.TabIndex = 13;
            this.btMas.Text = "+";
            this.btMas.UseVisualStyleBackColor = false;
            this.btMas.Click += new System.EventHandler(this.btMas_Click);
            // 
            // btMenos
            // 
            this.btMenos.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btMenos.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btMenos.Font = new System.Drawing.Font("Kristen ITC", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btMenos.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btMenos.Location = new System.Drawing.Point(236, 132);
            this.btMenos.Name = "btMenos";
            this.btMenos.Size = new System.Drawing.Size(48, 33);
            this.btMenos.TabIndex = 14;
            this.btMenos.Text = "-";
            this.btMenos.UseVisualStyleBackColor = false;
            this.btMenos.Click += new System.EventHandler(this.btMenos_Click);
            // 
            // btPor
            // 
            this.btPor.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btPor.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btPor.Font = new System.Drawing.Font("Kristen ITC", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btPor.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btPor.Location = new System.Drawing.Point(236, 177);
            this.btPor.Name = "btPor";
            this.btPor.Size = new System.Drawing.Size(48, 33);
            this.btPor.TabIndex = 15;
            this.btPor.Text = "*";
            this.btPor.UseVisualStyleBackColor = false;
            this.btPor.Click += new System.EventHandler(this.btPor_Click);
            // 
            // btDivision
            // 
            this.btDivision.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btDivision.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btDivision.Font = new System.Drawing.Font("Kristen ITC", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDivision.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btDivision.Location = new System.Drawing.Point(238, 217);
            this.btDivision.Name = "btDivision";
            this.btDivision.Size = new System.Drawing.Size(48, 33);
            this.btDivision.TabIndex = 16;
            this.btDivision.Text = "/";
            this.btDivision.UseVisualStyleBackColor = false;
            this.btDivision.Click += new System.EventHandler(this.btDivision_Click);
            // 
            // btC
            // 
            this.btC.Font = new System.Drawing.Font("Kristen ITC", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btC.Location = new System.Drawing.Point(47, 56);
            this.btC.Name = "btC";
            this.btC.Size = new System.Drawing.Size(48, 23);
            this.btC.TabIndex = 17;
            this.btC.Text = "C";
            this.btC.UseVisualStyleBackColor = true;
            this.btC.Click += new System.EventHandler(this.btC_Click);
            // 
            // btRetroceso
            // 
            this.btRetroceso.Font = new System.Drawing.Font("Kristen ITC", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRetroceso.Location = new System.Drawing.Point(101, 56);
            this.btRetroceso.Name = "btRetroceso";
            this.btRetroceso.Size = new System.Drawing.Size(99, 23);
            this.btRetroceso.TabIndex = 18;
            this.btRetroceso.Text = "Retroceso";
            this.btRetroceso.UseVisualStyleBackColor = true;
            this.btRetroceso.Click += new System.EventHandler(this.btRetroceso_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(330, 278);
            this.Controls.Add(this.btRetroceso);
            this.Controls.Add(this.btC);
            this.Controls.Add(this.btDivision);
            this.Controls.Add(this.btPor);
            this.Controls.Add(this.btMenos);
            this.Controls.Add(this.btMas);
            this.Controls.Add(this.btIgual);
            this.Controls.Add(this.bt3);
            this.Controls.Add(this.bt6);
            this.Controls.Add(this.bt9);
            this.Controls.Add(this.btPunto);
            this.Controls.Add(this.bt2);
            this.Controls.Add(this.bt5);
            this.Controls.Add(this.bt8);
            this.Controls.Add(this.bt0);
            this.Controls.Add(this.bt1);
            this.Controls.Add(this.bt4);
            this.Controls.Add(this.bt7);
            this.Controls.Add(this.txtbPantalla);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "MI CALCULADORA";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtbPantalla;
        private System.Windows.Forms.Button bt7;
        private System.Windows.Forms.Button bt4;
        private System.Windows.Forms.Button bt1;
        private System.Windows.Forms.Button bt0;
        private System.Windows.Forms.Button bt8;
        private System.Windows.Forms.Button bt5;
        private System.Windows.Forms.Button bt2;
        private System.Windows.Forms.Button btPunto;
        private System.Windows.Forms.Button bt9;
        private System.Windows.Forms.Button bt6;
        private System.Windows.Forms.Button bt3;
        private System.Windows.Forms.Button btIgual;
        private System.Windows.Forms.Button btMas;
        private System.Windows.Forms.Button btMenos;
        private System.Windows.Forms.Button btPor;
        private System.Windows.Forms.Button btDivision;
        private System.Windows.Forms.Button btC;
        private System.Windows.Forms.Button btRetroceso;
    }
}

