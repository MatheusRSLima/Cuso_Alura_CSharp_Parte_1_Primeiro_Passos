using System;

namespace P12_CalculaInvestimentoLongoPrazo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 12");

            double fatorRedimento = 1.0036;
            double valorInvestido = 1.000;

            for (int contadorAno = 0; contadorAno <= 5; contadorAno++)
            {
                for (int contatorMes = 0; contatorMes <= 12; contatorMes++)
                {
                    valorInvestido *= fatorRedimento;
                }
                fatorRedimento =+ 0.0010;
            }

            Console.WriteLine($"Ao término do investimento, você terá R${valorInvestido}");
            
        }
    }
}
