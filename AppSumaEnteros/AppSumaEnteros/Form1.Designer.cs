namespace AppSumaEnteros
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
            this.Lb1Valor = new System.Windows.Forms.Label();
            this.Lb2valor = new System.Windows.Forms.Label();
            this.txtNumero1 = new System.Windows.Forms.TextBox();
            this.txtNumero2 = new System.Windows.Forms.TextBox();
            this.SUMAR = new System.Windows.Forms.Button();
            this.lbResultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Lb1Valor
            // 
            this.Lb1Valor.AutoSize = true;
            this.Lb1Valor.Location = new System.Drawing.Point(35, 24);
            this.Lb1Valor.Name = "Lb1Valor";
            this.Lb1Valor.Size = new System.Drawing.Size(100, 13);
            this.Lb1Valor.TabIndex = 0;
            this.Lb1Valor.Text = "Ingrese Primer valor";
            // 
            // Lb2valor
            // 
            this.Lb2valor.AutoSize = true;
            this.Lb2valor.Location = new System.Drawing.Point(35, 58);
            this.Lb2valor.Name = "Lb2valor";
            this.Lb2valor.Size = new System.Drawing.Size(115, 13);
            this.Lb2valor.TabIndex = 1;
            this.Lb2valor.Text = "Ingrese Segundo Valor";
            // 
            // txtNumero1
            // 
            this.txtNumero1.Location = new System.Drawing.Point(187, 24);
            this.txtNumero1.Name = "txtNumero1";
            this.txtNumero1.Size = new System.Drawing.Size(100, 20);
            this.txtNumero1.TabIndex = 2;
            // 
            // txtNumero2
            // 
            this.txtNumero2.Location = new System.Drawing.Point(187, 58);
            this.txtNumero2.Name = "txtNumero2";
            this.txtNumero2.Size = new System.Drawing.Size(100, 20);
            this.txtNumero2.TabIndex = 3;
            // 
            // SUMAR
            // 
            this.SUMAR.Location = new System.Drawing.Point(202, 98);
            this.SUMAR.Name = "SUMAR";
            this.SUMAR.Size = new System.Drawing.Size(75, 42);
            this.SUMAR.TabIndex = 4;
            this.SUMAR.Text = "SUMAR";
            this.SUMAR.UseVisualStyleBackColor = true;
            this.SUMAR.Click += new System.EventHandler(this.SUMAR_Click);
            // 
            // lbResultado
            // 
            this.lbResultado.AutoSize = true;
            this.lbResultado.Location = new System.Drawing.Point(322, 113);
            this.lbResultado.Name = "lbResultado";
            this.lbResultado.Size = new System.Drawing.Size(76, 13);
            this.lbResultado.TabIndex = 5;
            this.lbResultado.Text = "RESULTADO:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 159);
            this.Controls.Add(this.lbResultado);
            this.Controls.Add(this.SUMAR);
            this.Controls.Add(this.txtNumero2);
            this.Controls.Add(this.txtNumero1);
            this.Controls.Add(this.Lb2valor);
            this.Controls.Add(this.Lb1Valor);
            this.Name = "Form1";
            this.Text = "PROGRAMA SUMA ENTEROS";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lb1Valor;
        private System.Windows.Forms.Label Lb2valor;
        private System.Windows.Forms.TextBox txtNumero1;
        private System.Windows.Forms.TextBox txtNumero2;
        private System.Windows.Forms.Button SUMAR;
        private System.Windows.Forms.Label lbResultado;
    }
}

