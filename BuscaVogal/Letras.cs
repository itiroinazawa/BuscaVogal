using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuscaVogal
{
    public static class Letras
    {
        private static string Consoantes = "bcdfghjklmnpqrstvwxyz";
        private static string Vogais = "aeiou";

        /// <summary>
        /// Metodo responsavel por verificar se o caracter é consoante
        /// </summary>
        /// <param name="letra">Caracter enviado</param>
        /// <returns>Resultado da comparacao</returns>
        public static bool IsConsoante(char? letra)
        {
            return Consoantes.Contains(letra.ToString().ToLower());
        }

        /// <summary>
        /// Metodo responsavel por verificar se o caracter é vogal
        /// </summary>
        /// <param name="letra">Caracter enviado</param>
        /// <returns>Resultado da comparacao</returns>
        public static bool IsVogal(char? letra)
        {
            return Vogais.Contains(letra.ToString().ToLower());
        }
    }    
}
