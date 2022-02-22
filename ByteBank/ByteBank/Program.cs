using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            string texto = "Gustavo Silva";

            texto.Substring(8);
            string texto2 = texto.Substring(1);

            Console.WriteLine("Sobrenome: " + texto);
            Console.WriteLine(texto2);

            Console.ReadLine();
        }
    }
}
