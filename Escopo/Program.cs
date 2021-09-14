using System;

namespace Escopo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando Escopo.");

            int idadeJoao = 18;
            bool acompanhado = true;
            string mensagemAdcional;

            if (acompanhado == true)
            {
                mensagemAdcional = "João está acompanhado";
            }
            else
            {
                mensagemAdcional = "João não está acompanhado";
            }

            if (idadeJoao >= 18 || acompanhado == true)
            {
                Console.WriteLine("Entrada permitida.");
                Console.WriteLine(mensagemAdcional);
            }
            else
            {
                Console.WriteLine("Entrada proíbida.");

            }

            Console.ReadLine();
        }
    }
}
