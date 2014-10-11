namespace AppCheckBox
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
            this.chkIngles = new System.Windows.Forms.CheckBox();
            this.chkFrances = new System.Windows.Forms.CheckBox();
            this.chkAleman = new System.Windows.Forms.CheckBox();
            this.btMostrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // chkIngles
            // 
            this.chkIngles.AutoSize = true;
            this.chkIngles.Location = new System.Drawing.Point(56, 12);
            this.chkIngles.Name = "chkIngles";
            this.chkIngles.Size = new System.Drawing.Size(65, 17);
            this.chkIngles.TabIndex = 0;
            this.chkIngles.Text = "INGLES";
            this.chkIngles.UseVisualStyleBackColor = true;
            // 
            // chkFrances
            // 
            this.chkFrances.AutoSize = true;
            this.chkFrances.Location = new System.Drawing.Point(56, 44);
            this.chkFrances.Name = "chkFrances";
            this.chkFrances.Size = new System.Drawing.Size(76, 17);
            this.chkFrances.TabIndex = 1;
            this.chkFrances.Text = "FRANCES";
            this.chkFrances.UseVisualStyleBackColor = true;
            // 
            // chkAleman
            // 
            this.chkAleman.AutoSize = true;
            this.chkAleman.Location = new System.Drawing.Point(56, 78);
            this.chkAleman.Name = "chkAleman";
            this.chkAleman.Size = new System.Drawing.Size(70, 17);
            this.chkAleman.TabIndex = 2;
            this.chkAleman.Text = "ALEMAN";
            this.chkAleman.UseVisualStyleBackColor = true;
            // 
            // btMostrar
            // 
            this.btMostrar.Location = new System.Drawing.Point(156, 44);
            this.btMostrar.Name = "btMostrar";
            this.btMostrar.Size = new System.Drawing.Size(124, 23);
            this.btMostrar.TabIndex = 3;
            this.btMostrar.Text = "Mostrar Idioma";
            this.btMostrar.UseVisualStyleBackColor = true;
            this.btMostrar.Click += new System.EventHandler(this.btMostrar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 124);
            this.Controls.Add(this.btMostrar);
            this.Controls.Add(this.chkAleman);
            this.Controls.Add(this.chkFrances);
            this.Controls.Add(this.chkIngles);
            this.Name = "Form1";
            this.Text = "PROGRAMA IDIOMAS";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkIngles;
        private System.Windows.Forms.CheckBox chkFrances;
        private System.Windows.Forms.CheckBox chkAleman;
        private System.Windows.Forms.Button btMostrar;
    }
}

