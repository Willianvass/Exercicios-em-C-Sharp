using System;

namespace Medidas_Triangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal troco;

            troco = decimal.Parse(Console.ReadLine());

            Console.WriteLine("NOTAS:");
            Console.WriteLine("{0} nota(s) de R$ 100.00", (int) troco / 100);
            troco = troco % 100;
            Console.WriteLine("{0} nota(s) de R$ 50.00", (int) troco / 50);
            troco = troco % 50;
            Console.WriteLine("{0} nota(s) de R$ 20.00", (int) troco / 20);
            troco = troco % 20;
            Console.WriteLine("{0} nota(s) de R$ 10.00", (int) troco / 10);
            troco = troco % 10;
            Console.WriteLine("{0} nota(s) de R$ 5.00", (int) troco / 5);
            troco = troco % 5;
            Console.WriteLine("{0} nota(s) de R$ 2.00", (int) troco / 2);
            troco = troco % 2;
            troco = troco * 100;

            Console.WriteLine("MOEDAS:");
            Console.WriteLine("{0} moeda(s) de R$ 1.00", (int)troco / 100);
            troco = troco % 100;
            Console.WriteLine("{0} moeda(s) de R$ 0.50", (int)troco / 50);
            troco = troco % 50;
            Console.WriteLine("{0} moeda(s) de R$ 0.25", (int)troco / 25);
            troco = troco % 25;
            Console.WriteLine("{0} moeda(s) de R$ 0.10", (int)troco / 10);
            troco = troco % 10;
            Console.WriteLine("{0} moeda(s) de R$ 0.05", (int)troco / 5);
            troco = troco % 5;
            Console.WriteLine("{0} moeda(s) de R$ 0.01", (int)troco);
        }
    }
}
