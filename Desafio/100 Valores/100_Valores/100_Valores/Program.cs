using System;

namespace _100_Valores
{
    public class Program
    {
        static void Main(string[] args)
        {
            int numero;
            int maior = 0;
            int posicao = 0;
            for (int i = 1; i <= 100; i++)
            {
                numero = Convert.ToInt32(Console.ReadLine());
                if (numero > maior)
                {
                    maior = numero;
                    posicao = i;
                }
            }
            Console.WriteLine(maior);
            Console.WriteLine(posicao);
        }
    }
}
