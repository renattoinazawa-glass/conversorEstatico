using System;

namespace Conversor
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal dolar, brl, cotacaodolar;
            Console.WriteLine("=============");
            Console.WriteLine("Hoje , dia 23/04/2026 o dólar ( US$ ) está a 4,97 !"); // TODO: Implementar consumo de API para cotação em tempo real.
            Console.WriteLine("=============");
            Console.WriteLine("Converta o valor de reais para dólar !");
            Console.WriteLine("Escreva o valor em reais: ");
            brl = decimal.Parse(Console.ReadLine());
            cotacaodolar = 4.97m;
            dolar = brl / cotacaodolar;
            if (dolar > brl)
            {
                Console.WriteLine("Seu código ta errado :P");
            }
            else
            {
                Console.WriteLine($"O valor em dólar é: R${dolar:F2}");
            }
            Console.WriteLine("Pressione qualquer tecla para fechar");
            Console.ReadKey();


        }
    }

}