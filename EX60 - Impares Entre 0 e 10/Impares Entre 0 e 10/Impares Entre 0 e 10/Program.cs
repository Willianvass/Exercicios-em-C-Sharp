//Este programa tem por finalidade apresentar os números ímpares situados na faixa de 0 a 10. Demonstra a utilização da estrutura de repetição while, contadores e incremento.

using System;

namespace Impares_Entre_0_e_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, contador;
            contador = 1;
            n = 1;

            Console.WriteLine("Exibe impares entre 0 e 10.");

            while (n < 10)
            {
                Console.WriteLine("\n\t\t\t\tO {0}º número ímpar é: {1}", contador, n);
                n += 2;
                contador++;
            }
        }
    }
}
