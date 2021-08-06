using System;
using System.Reflection.Metadata;

namespace _5_CaracteresETextos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executanto o projeto 5 - Caracteres e Textos");
            
            // character
            char primeiraLetra = 'a';
            Console.WriteLine(primeiraLetra);

            primeiraLetra = (char) 65;
            Console.WriteLine(primeiraLetra);

            primeiraLetra = (char)(primeiraLetra + 1);
            Console.WriteLine(primeiraLetra);

            string titulo = "Alura Cursos de tecnologia " + 2020;
            string cursosProgramacao = " - .NET" +
                " - Java" +
                " - Javascript";
            Console.WriteLine(titulo);
            System.Console.WriteLine(cursosProgramacao);
            
            Console.ReadLine();
        }
    }
}
