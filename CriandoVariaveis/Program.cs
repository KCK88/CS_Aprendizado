using System;

namespace CriandoVariaveis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Criando variáveis");

            int idade = 32;
            Console.WriteLine(idade);

            idade = 10;
            Console.WriteLine(idade);

            idade = 10+5;
            Console.WriteLine(idade);

            idade = 10+5*2;
            Console.WriteLine(idade);

            idade = (10 + 5) * 2;
            Console.WriteLine("sua idade é: " + idade + " anos");



            Console.WriteLine("Execução finalizada, tecle enter");
            Console.ReadLine();
        }
    }
}
