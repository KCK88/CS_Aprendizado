﻿using System;

namespace CaracteresETextos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto - Caracteres e textos.");

            char primeiraLetra = ' ';
            Console.WriteLine(primeiraLetra);

            primeiraLetra = (char)65;
            Console.WriteLine(primeiraLetra);

            primeiraLetra = (char)(primeiraLetra + 1);
            Console.WriteLine(primeiraLetra);

            string titulo = "Alura cursos de tecnologia " + 2020;
            string cursosProgramacao = 
                @" - .NET +
 - Java +
 - JavaScript";
             
            Console.WriteLine(titulo);
            Console.WriteLine(cursosProgramacao);

            

            Console.ReadLine();
        }
    }
}
