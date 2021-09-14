using System;

namespace Condicionais
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando Condicionais");

            int idadeJoao = 16;
            int quantidadePessoas = 2;

            if(idadeJoao >= 18)
            {
                Console.WriteLine("Entrada permitida.");
            }
            else
            {
                if(quantidadePessoas >= 2) 
                {
                    Console.WriteLine("Entrada com acompanhante permitida.");
                }
                else
                {
                    Console.WriteLine("Entrada proíbida, menor sem acompanhante.");
                }
            }

            Console.ReadLine();
        }
    }
}
