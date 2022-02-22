using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestaCondicional2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("testando condicionais");

            int idade = 16;
            int quantidadePessoas = 3;

            if (idade >= 18 || quantidadePessoas >= 2)

            {
                Console.WriteLine("Você tem mais de 18 anos");
                Console.WriteLine("Seja bem-vindo!");
            }
            else
            {
                Console.WriteLine("Infelizmente você não pode entrar.");
            }
            Console.Read();
        }
    }
}
