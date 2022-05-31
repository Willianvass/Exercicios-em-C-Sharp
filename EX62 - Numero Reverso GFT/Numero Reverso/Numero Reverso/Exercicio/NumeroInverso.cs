using System;
using System.Linq;

namespace Numero_Reverso.Exercicio
{
    public class NumeroInverso
    {
        public static void numeroReverso()
        {
            do
            {
                Console.WriteLine("Informe um numero de 4 digitos menor que 9999: ");
                int numero = int.Parse(Console.ReadLine());
                string numeroEmString = numero.ToString();
                string textoInvertido = new string(numeroEmString.Reverse().ToArray());

                if (numero >= 1000 && numero <= 9999)
                {
                    Console.WriteLine(textoInvertido);
                }
                else
                {
                    Console.WriteLine("Numero inválido!!");
                    break;
                }
            } while (true);
        }
    }
}
