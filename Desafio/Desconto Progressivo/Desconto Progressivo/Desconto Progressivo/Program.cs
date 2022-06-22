using System;

namespace Desconto_Progressivo
{
    public class Program
    {
        static void Main(string[] args)
        {
            double valor, desconto, total;
            Console.WriteLine("Qual valor total da compra R$ ");
            valor = double.Parse(Console.ReadLine());

            if ((valor >= 400)&&(valor <= 499))
            {
                total = valor - (valor * 0.01);
                Console.WriteLine("Desconto de 1% - Valor total de R$ " + total.ToString("0.00"));
            }
        }
    }
}
