using System.Text.RegularExpressions;

namespace Practica3
{
    public static class RFCValidator
    {
        public static bool EsRFCValido(string rfc)
        {
            string pattern = @"^[A-Z&Ñ]{4}\d{6}[A-Z0-9]{2,3}$";
            return Regex.IsMatch(rfc, pattern);
        }
    }
}
