using System.Linq;

namespace Practica3
{
    public static class InputValidator
    {
        /// <summary>
        /// Valida si el texto contiene solo números.
        /// </summary>
        /// <param name="texto">Texto a validar</param>
        /// <returns>Verdadero si solo contiene números, falso de lo contrario</returns>
        public static bool EsSoloNumeros(string texto)
        {
            return texto.All(char.IsDigit);
        }

        /// <summary>
        /// Valida si el texto contiene solo letras.
        /// </summary>
        /// <param name="texto">Texto a validar</param>
        /// <returns>Verdadero si solo contiene letras, falso de lo contrario</returns>
        public static bool EsSoloLetras(string texto)
        {
            return texto.All(char.IsLetter);
        }
    }
}