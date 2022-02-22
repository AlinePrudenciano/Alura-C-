using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Condicional
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("testando condicionais");

            int idade = 20;
            int quantidadePessoas = 3;

            if (idade >= 18)
            
            {
                Console.WriteLine("Você tem mais de 18 anos");
                Console.WriteLine("Seja bem-vindo!");    
             }
            
            else
            {
                Console.WriteLine("Infelizmente você não pode entrar.");
            }

                if (quantidadePessoas >= 2);
                {
                    Console.WriteLine("Você nao tem 18, mas pode entrar, pois está acompanhado");
                }
            
                else
                {
                    Console.WriteLine("Infelizmente você não pode entrar.");
                }

            Console.ReadLine();
        }
    }
}
