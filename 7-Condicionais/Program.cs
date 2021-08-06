using System;

namespace _7_Condicionais
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 7 - Condicionais");

            int idadeJoao = 16;
            int quantidadePessoas = 2;

            if (idadeJoao >= 18)
            {
                System.Console.WriteLine("João possui mais de 18 anos de idade. Pode entrar.");
            }
            else
            {
                if (quantidadePessoas >= 2)
                {
                    System.Console.WriteLine("João não possui mais de 18 anos, mais está acompanhado. Pode entrar.");
                }
                else
                {
                    System.Console.WriteLine("João não possiu mais de 18 anos, não pdoe entrar.");
                }
            }

            Console.ReadLine();
        }
    }
}
