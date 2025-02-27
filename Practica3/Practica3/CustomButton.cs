using System;
using System.Windows.Forms;

namespace Practica3
{
    public class CustomButton : Button
    {
        public CustomButton()
        {
            this.Click += CustomButton_Click;
        }

        private void CustomButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Botón clickeado");
        }
    }
}