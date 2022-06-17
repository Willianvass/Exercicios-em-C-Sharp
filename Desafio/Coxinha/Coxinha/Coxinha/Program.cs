using System;

namespace Coxinha
{
    public class Program
    {
        static void Main(string[] args)
        {
            string[] linha = Console.ReadLine().Split(" ");
            float coxinha = Int32.Parse(linha[0]);
            float participante = Int32.Parse(linha[1]);
            float total = coxinha / participante;

            Console.WriteLine(total.ToString("0.00"));
        }
    }
}
