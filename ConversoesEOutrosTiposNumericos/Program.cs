using System;

namespace ConversoesEOutrosTiposNumericos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ConversoesEOutrosTiposNumericos");

            double salario;
            salario = 1200.5;

            int salarioInteiro = (int)salario;

            Console.WriteLine(salarioInteiro);

            long idade = 13000000000;
            Console.WriteLine(idade);

            short quantidadeProduto = 15000;
            Console.WriteLine(quantidadeProduto);

            float altuta = 1.80f;
            Console.WriteLine(altuta);


            Console.WriteLine("Execução finalizada, tecle enter");
            Console.ReadLine();
        }
    }
}
