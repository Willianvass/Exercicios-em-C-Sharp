using System;

namespace Media_Peso
{
    public class Program
    {
        static void Main(string[] args)
        {
            double A, B, C, nota1, nota2, nota3, media;
            A = 0.2;
            B = 0.3;
            C = 0.5;
            Console.Write("Primeira nota: ");
            nota1 = double.Parse(Console.ReadLine());
            Console.Write("Segunda nota: ");
            nota2 = double.Parse(Console.ReadLine());
            Console.Write("Terceira nota: ");
            nota3 = double.Parse(Console.ReadLine());
            media = ((nota1 * A) + (nota2 * B) + (nota3 * C));    
            Console.WriteLine("MEDIA = " + media.ToString("N1"));
        }
    }
}
