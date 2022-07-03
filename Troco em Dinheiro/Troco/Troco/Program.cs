using System;

namespace Troco
{
    class MyClass
    {
        static void Main(string[] args)
        {
            double valorVenda, c100, c50, c20, c10, c5, c2, c1, c050, c025, c010, c005 ,c001;
            Console.Write(" ");
            valorVenda = double.Parse(Console.ReadLine());

            c100 = valorVenda / 100;
            c50 = valorVenda / 50;
            c20 = valorVenda / 20;
            c10 = valorVenda / 10;
            c5 = valorVenda / 5;
            c2 = valorVenda / 2;
            c1 = valorVenda / 1;
            c050 = valorVenda / 0.5;
            c025 = valorVenda / 0.25;
            c010 = valorVenda / 0.10;
            c005 = valorVenda / 0.05;
            c001 = valorVenda / 0.01;

            Console.WriteLine("{0} nota(s) de R$ 100,00", Math.Truncate(c100));
            Console.WriteLine("{0} nota(s) de R$ 50,00", Math.Truncate(c50));
            Console.WriteLine("{0} nota(s) de R$ 20,00", Math.Truncate(c20));
            Console.WriteLine("{0} nota(s) de R$ 10,00", Math.Truncate(c10));
            Console.WriteLine("{0} nota(s) de R$ 5,00", Math.Truncate(c5));
            Console.WriteLine("{0} nota(s) de R$ 2,00", Math.Truncate(c2));
            Console.WriteLine("{0} nota(s) de R$ 1,00", Math.Truncate(c1));
            Console.WriteLine("MOEDAS:");
            Console.WriteLine("{0} moeda(s) de R$ 0,50", Math.Truncate(c050));
            Console.WriteLine("{0} moeda(s) de R$ 0,25", Math.Truncate(c025));
            Console.WriteLine("{0} moeda(s) de R$ 0,10", Math.Truncate(c010));
            Console.WriteLine("{0} moeda(s) de R$ 0,05", Math.Truncate(c005));
            Console.WriteLine("{0} moeda(s) de R$ 0,01", Math.Truncate(c001));

        }
    }
}