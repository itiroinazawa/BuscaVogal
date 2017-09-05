using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuscaVogal
{
    class Program
    {
        static void Main(string[] args)
        {
            Stream stream = new Stream();
            stream.setMock("aAbBABacfe");

            var resultado = Business.firstChar(stream);

            if (resultado == null)
            {
                Console.WriteLine("Não foi encontrada nenhuma vogal que não se repete após a primeira consoante.");
            }
            else
            {
                Console.WriteLine("Vogal encontrada: " + resultado.Value);
            }
        }
    }
}
