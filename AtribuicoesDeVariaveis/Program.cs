﻿using System;

namespace AtribuicoesDeVariaveis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto - atribuições de variaveis");

            int idade = 32;
            int idadeGustavo = idade;

            idade = 20;
            
            Console.WriteLine(idade);
            Console.WriteLine(idadeGustavo);



            Console.ReadLine();
        }
    }
}
