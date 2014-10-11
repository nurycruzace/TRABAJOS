namespace AppNavegadores
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
            this.chkExplorer = new System.Windows.Forms.CheckBox();
            this.chkMozilla = new System.Windows.Forms.CheckBox();
            this.chkChrome = new System.Windows.Forms.CheckBox();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // chkExplorer
            // 
            this.chkExplorer.AutoSize = true;
            this.chkExplorer.Location = new System.Drawing.Point(57, 13);
            this.chkExplorer.Name = "chkExplorer";
            this.chkExplorer.Size = new System.Drawing.Size(103, 17);
            this.chkExplorer.TabIndex = 0;
            this.chkExplorer.Text = "Internet Explorer";
            this.chkExplorer.UseVisualStyleBackColor = true;
            // 
            // chkMozilla
            // 
            this.chkMozilla.AutoSize = true;
            this.chkMozilla.Location = new System.Drawing.Point(57, 50);
            this.chkMozilla.Name = "chkMozilla";
            this.chkMozilla.Size = new System.Drawing.Size(58, 17);
            this.chkMozilla.TabIndex = 1;
            this.chkMozilla.Text = "Mozilla";
            this.chkMozilla.UseVisualStyleBackColor = true;
            // 
            // chkChrome
            // 
            this.chkChrome.AutoSize = true;
            this.chkChrome.Location = new System.Drawing.Point(57, 89);
            this.chkChrome.Name = "chkChrome";
            this.chkChrome.Size = new System.Drawing.Size(62, 17);
            this.chkChrome.TabIndex = 2;
            this.chkChrome.Text = "Chrome";
            this.chkChrome.UseVisualStyleBackColor = true;
            // 
            // btnMostrar
            // 
            this.btnMostrar.Location = new System.Drawing.Point(83, 153);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(75, 23);
            this.btnMostrar.TabIndex = 3;
            this.btnMostrar.Text = "Mostrar";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.chkChrome);
            this.Controls.Add(this.chkMozilla);
            this.Controls.Add(this.chkExplorer);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkExplorer;
        private System.Windows.Forms.CheckBox chkMozilla;
        private System.Windows.Forms.CheckBox chkChrome;
        private System.Windows.Forms.Button btnMostrar;
    }
}

