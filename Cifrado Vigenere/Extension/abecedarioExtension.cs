using System.Collections.Generic;

namespace Cifrado_Vigenere
{
    internal static class abecedarioExtension
    {
        /// <summary>
        ///     Funcion para obtener el Abecedario
        /// </summary>
        /// <param name="Abecedario">Lista de caracteres del Abecedario</param>
        /// <returns>String con el Abecedario</returns>
        public static string ToAbc(this List<char> Abecedario)
        {
            var abc = "";

            foreach (var caracter in Abecedario) abc += caracter;

            return abc;
        }

        /// <summary>
        ///     Funcion para igualar una cadena con otra en longitud, manteniendo sus caracteres
        /// </summary>
        /// <param name="shortCad">Cadena que se quiere emparejar</param>
        /// <param name="text">Cadena principal con la que se va a emparejar</param>
        /// <returns>Cadena con misma longitud y caracteres reptidos</returns>
        public static string ToEqualize(this string shortCad, string text)
        {
            while (shortCad.Length < text.Length) shortCad += shortCad;

            shortCad = shortCad.Substring(0, text.Length);

            return shortCad;
        }
    }
}