//Este programa recebe um número com 4 dígitos entre 1000 e 9999 e extrai cada dígito. Utiliza os operadores módulos, métodos de console.

using System;

namespace Numeros_Extrai_Digito
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num, dig1, dig2, dig3, dig4;

            Console.WriteLine("Numero de 0 a 9999: ");
            num = Int32.Parse(Console.ReadLine());

            dig1 = (num / 1000) % 10; 
            dig2 = (num / 100) % 10; 
            dig3 = (num / 10) % 10; 
            dig4 = (num % 10);

            Console.WriteLine("\n\t\tO número fornecido é: " + dig1 + " " + dig2 + " " + dig3 + " " + dig4 + "\n\n");
        }
    }
}
