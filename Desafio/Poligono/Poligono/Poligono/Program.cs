using System;

namespace Poligono
{
    public class Program
    {
        static void Main(string[] args)
        {
            string[] perimetro = Console.ReadLine().Split();
            Console.WriteLine(int.Parse(perimetro[0]) * (int.Parse(perimetro[1]))); 
        }
    }
}
