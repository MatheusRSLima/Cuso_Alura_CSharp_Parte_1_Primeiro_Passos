using System;

namespace P11_CalculaPoupanca2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 11");

            double valorInvestido = 1000;

            for (int i = 0; i <= 12; i++)
            {
                valorInvestido *=  1.0036;
                System.Console.WriteLine("Após " + i + " meses, você terá R$" + valorInvestido);
            }
            
            Console.ReadLine();
        }
    }
}
