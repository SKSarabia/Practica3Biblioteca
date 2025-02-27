namespace Practica3
{
    partial class UserControl1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.customButton1 = new Practica3.CustomButton();
            this.customTextBox1 = new Practica3.CustomTextBox();
            this.SuspendLayout();
            // 
            // customButton1
            // 
            this.customButton1.Location = new System.Drawing.Point(194, 143);
            this.customButton1.Name = "customButton1";
            this.customButton1.Size = new System.Drawing.Size(75, 23);
            this.customButton1.TabIndex = 0;
            this.customButton1.Text = "Validar";
            this.customButton1.UseVisualStyleBackColor = true;
            // 
            // customTextBox1
            // 
            this.customTextBox1.Location = new System.Drawing.Point(182, 105);
            this.customTextBox1.MaxLength = 13;
            this.customTextBox1.Name = "customTextBox1";
            this.customTextBox1.Size = new System.Drawing.Size(100, 20);
            this.customTextBox1.TabIndex = 1;
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.customTextBox1);
            this.Controls.Add(this.customButton1);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(495, 289);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomButton customButton1;
        private CustomTextBox customTextBox1;
    }
}
