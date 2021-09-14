using System;

namespace CondicionaisDois
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando CondicionaisDois");

            int idadeJoao = 18;
            //int quantidadePessoas = 2;
            //bool acompanhado = quantidadePessoas >= 2;
            bool acompanhado = true;

            if (idadeJoao >= 18 && acompanhado == true)
            {
                Console.WriteLine("Entrada permitida.");
            }
            else
            {
                Console.WriteLine("Entrada proíbida.");

            }

            Console.ReadLine();
        }
    }
}
