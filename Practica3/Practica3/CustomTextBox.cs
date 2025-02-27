using Practica3;
using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Practica3
{
    public class CustomTextBox : TextBox
    {
        public CustomTextBox()
        {
            this.KeyPress += CustomTextBox_KeyPress;
            this.Validating += CustomTextBox_Validating;
            this.MaxLength = 13; // Establecer el límite de caracteres a 13
        }

        private void CustomTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir teclas de control como retroceso
            if (char.IsControl(e.KeyChar))
            {
                return;
            }

            // Validar RFC en tiempo real
            string currentText = this.Text + e.KeyChar;

            if (currentText.Length <= 4)
            {
                // Solo permitir letras mayúsculas en las primeras 4 posiciones
                if (!Regex.IsMatch(e.KeyChar.ToString(), @"[A-Z&Ñ]"))
                {
                    e.Handled = true; // No permitir caracteres no válidos
                    MessageBox.Show("Solo se permiten letras mayúsculas en las primeras 4 posiciones.");
                }
            }
            else if (currentText.Length > 4 && currentText.Length <= 10)
            {
                // Solo permitir números en las siguientes 6 posiciones
                if (!char.IsDigit(e.KeyChar))
                {
                    e.Handled = true; // No permitir caracteres no válidos
                    MessageBox.Show("Solo se permiten números en las posiciones 5 a 10.");
                }
            }
            else if (currentText.Length > 10 && currentText.Length <= 13)
            {
                // Solo permitir letras y números en las últimas 2-3 posiciones
                if (!Regex.IsMatch(e.KeyChar.ToString(), @"[A-Z0-9]"))
                {
                    e.Handled = true; // No permitir caracteres no válidos
                    MessageBox.Show("Solo se permiten letras y números en las últimas posiciones.");
                }
            }
        }

        private void CustomTextBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            string rfc = this.Text;
            if (!RFCValidator.EsRFCValido(rfc))
            {
                MessageBox.Show("RFC no válido");
            }
            else
            {
                MessageBox.Show("RFC validado");
            }
        }
    }
}
