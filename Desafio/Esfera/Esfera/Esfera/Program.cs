using System;

namespace Esfera
{
    public class Program
    {
        static void Main(string[] args)
        {
            double pi, raio, esfera;
            pi = 3.14159;
            Console.Write("Qual o raio: ");
            raio = double.Parse(Console.ReadLine());

            esfera = (pi * (4.0/3) * (raio * raio * raio));
            Console.WriteLine("VOLUME = " + esfera.ToString("N3"));
                             //VOLUME = {0:F3}               
        }
    }
}
