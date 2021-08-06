using System;

namespace P10_CalculaPoupanca
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 10 - Calcula poupança");

            double valorInvestido = 1000;
            int contatoMes = 1;

            while (contatoMes <= 12) 
            {
                valorInvestido = valorInvestido + valorInvestido * 0.0036;
                Console.WriteLine("Após " + contatoMes +" mês, você terá R$ " + valorInvestido);
                //contatoMes = contatoMes + 1;
                //contatoMes += 1;
                contatoMes++;
            }
            // 0.36% = 0.0036%

            Console.ReadLine();   
        }
    }
}
