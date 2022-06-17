using System;

namespace Produto
{
    public class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, produto;
            num1 = Int32.Parse(Console.ReadLine());
            num2 = Int32.Parse(Console.ReadLine());

            produto = num1 * num2;

            Console.WriteLine("PROD = " + produto);
        }
    }
}
