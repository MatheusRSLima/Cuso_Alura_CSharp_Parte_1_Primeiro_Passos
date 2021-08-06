using System;

namespace _4_ConversaoEOutrosTiposNumericos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 4");

            double salario = 1200.50;

            // o int é uma variavel de 32 bits
            int salarioEmInteiro = (int)salario;

            Console.WriteLine(salarioEmInteiro);
            
            // o longo é uma variavel de 64 bits
            long idade = 1300000000;
            Console.WriteLine(idade);


            // o short é uma variavel de 16 bits
            short quatidadeProdutos = 15000;
            Console.WriteLine(quatidadeProdutos);

            float altura  = 1.80f;
    	    Console.WriteLine(altura);
            
            Console.WriteLine("A execução acabou. Tecle enter para sair...");
            Console.ReadLine();
        }
    }
}
