//Utilização da estrutura de seleção simples If com estrutura de repetição While. Este programa tem por finalidade ler um número qualquer menor ou igual a 50 e apresentar o valor obtido da multiplicação sucessiva do número por 3 (N * 3) enquanto o produto for menor que 250.

using System;

namespace Lee_NUmeros_Intervalo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num, produto;
            produto = 0;

            Console.WriteLine("Informe um numero: ");
            num = Int32.Parse(Console.ReadLine());
            
            if (num <= 50)
            {
                produto = num * 3;

                while (produto < 250)
                {
                    Console.WriteLine("O produto é {0}", produto);
                    produto = produto * 3;
                }
            }
        }
    }
}
