using System;

namespace _8_Condicionais2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 8 - Condicionais 2");

            int idadeJoao = 16;
            //int quantidadePessoas = 2;
            //bool acompanhado = quantidadePessoas >= 2;

            bool acompanhado = true;

            if (idadeJoao >= 18 && acompanhado == true)
            {
                System.Console.WriteLine("Pode entrar.");
            }
            else
            {
                System.Console.WriteLine("Não pode entrar.");
            }

            Console.ReadLine();
        }
    }
}
