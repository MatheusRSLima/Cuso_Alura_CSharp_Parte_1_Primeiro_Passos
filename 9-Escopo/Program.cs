using System;

namespace _9_Escopo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 9 - Escopo");

            int idadeJoao = 16;
            bool acompanhado = true;
            string mensagemAdicional;

            if (acompanhado == true)
            {
                mensagemAdicional = "João está acompanhado!";
            } else
            {
                mensagemAdicional = "João não está acompanhado!";
            }

            if (idadeJoao >= 18 || acompanhado == true)
            {
                System.Console.WriteLine("Pode entrar.");
                System.Console.WriteLine(mensagemAdicional);
            }
            else
            {
                System.Console.WriteLine("Não pode entrar.");
            }

            Console.ReadLine();
        }
    }
}
