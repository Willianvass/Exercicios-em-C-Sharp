using System;

namespace Desconto_Progressivo
{
    public class MyClass
    {
        static void Main(string[] args)
        {
            double valorCompra, desconto, total;
            System.Console.Write("Valor Compra R$ ");
            valorCompra = double.Parse(Console.ReadLine());

            if ((valorCompra >= 300)&&(valorCompra <= 399))
            {
                desconto = 1;
                System.Console.Write("Desconto: " + desconto + "%\n");
                total = valorCompra - ((valorCompra * desconto) / 100);
                System.Console.Write("Total com desconto R$ " + total);
            }
            if ((valorCompra >= 400)&&(valorCompra <= 499))
            {
                desconto = 2;
                System.Console.Write("Desconto: " + desconto + "%\n");
                total = valorCompra - ((valorCompra * desconto) / 100);
                System.Console.Write("Total com desconto R$ " + total);
            }
            if ((valorCompra >= 500)&&(valorCompra <= 599))
            {
                desconto = 3;
                System.Console.Write("Desconto: " + desconto + "%\n");
                total = valorCompra - ((valorCompra * desconto) / 100);
                System.Console.Write("Total com desconto R$ " + total);
            }
            if ((valorCompra >= 600)&&(valorCompra <= 699))
            {
                desconto = 4;
                System.Console.Write("Desconto: " + desconto + "%\n");
                total = valorCompra - ((valorCompra * desconto) / 100);
                System.Console.Write("Total com desconto R$ " + total);
            }
            if ((valorCompra >= 700)&&(valorCompra <= 799))
            {
                desconto = 5;
                System.Console.Write("Desconto: " + desconto + "%\n");
                total = valorCompra - ((valorCompra * desconto) / 100);
                System.Console.Write("Total com desconto R$ " + total);
            }
            if ((valorCompra >= 800)&&(valorCompra <= 899))
            {
                desconto = 6;
                System.Console.Write("Desconto: " + desconto + "%\n");
                total = valorCompra - ((valorCompra * desconto) / 100);
                System.Console.Write("Total com desconto R$ " + total);
            }
            if ((valorCompra >= 900)&&(valorCompra <= 999))
            {
                desconto = 7;
                System.Console.Write("Desconto: " + desconto + "%\n");
                total = valorCompra - ((valorCompra * desconto) / 100);
                System.Console.Write("Total com desconto R$ " + total);
            }
            if ((valorCompra >= 1000)&&(valorCompra <= 1099))
            {
                desconto = 8;
                System.Console.Write("Desconto: " + desconto + "%\n");
                total = valorCompra - ((valorCompra * desconto) / 100);
                System.Console.Write("Total com desconto R$ " + total);
            }
            if ((valorCompra >= 1100)&&(valorCompra <= 1199))
            {
                desconto = 9;
                System.Console.Write("Desconto: " + desconto + "%\n");
                total = valorCompra - ((valorCompra * desconto) / 100);
                System.Console.Write("Total com desconto R$ " + total);
            }
            if ((valorCompra >= 1200)&&(valorCompra <= 1299))
            {
                desconto = 10;
                System.Console.Write("Desconto: " + desconto + "%\n");
                total = valorCompra - ((valorCompra * desconto) / 100);
                System.Console.Write("Total com desconto R$ " + total);
            }
            if ((valorCompra >= 1300)&&(valorCompra <= 1399))
            {
                desconto = 11;
                System.Console.Write("Desconto: " + desconto + "%\n");
                total = valorCompra - ((valorCompra * desconto) / 100);
                System.Console.Write("Total com desconto R$ " + total);
            }
            if ((valorCompra >= 1400)&&(valorCompra <= 1499))
            {
                desconto = 12;
                System.Console.Write("Desconto: " + desconto + "%\n");
                total = valorCompra - ((valorCompra * desconto) / 100);
                System.Console.Write("Total com desconto R$ " + total);
            }
            if ((valorCompra >= 1500)&&(valorCompra <= 1599))
            {
                desconto = 13;
                System.Console.Write("Desconto: " + desconto + "%\n");
                total = valorCompra - ((valorCompra * desconto) / 100);
                System.Console.Write("Total com desconto R$ " + total);
            }
            if ((valorCompra >= 1600)&&(valorCompra <= 1699))
            {
                desconto = 14;
                System.Console.Write("Desconto: " + desconto + "%\n");
                total = valorCompra - ((valorCompra * desconto) / 100);
                System.Console.Write("Total com desconto R$ " + total);
            }
            if ((valorCompra >= 1700)&&(valorCompra <= 1799))
            {
                desconto = 15;
                System.Console.Write("Desconto: " + desconto + "%\n");
                total = valorCompra - ((valorCompra * desconto) / 100);
                System.Console.Write("Total com desconto R$ " + total);
            }
            if ((valorCompra >= 1800)&&(valorCompra <= 1899))
            {
                desconto = 16;
                System.Console.Write("Desconto: " + desconto + "%\n");
                total = valorCompra - ((valorCompra * desconto) / 100);
                System.Console.Write("Total com desconto R$ " + total);
            }
            if ((valorCompra >= 1900)&&(valorCompra <= 1999))
            {
                desconto = 17;
                System.Console.Write("Desconto: " + desconto + "%\n");
                total = valorCompra - ((valorCompra * desconto) / 100);
                System.Console.Write("Total com desconto R$ " + total);
            }
            if (valorCompra <= 299)
            {
                System.Console.WriteLine("Sem desconto!");
            }
            if (valorCompra >= 2000) 
            {
                desconto = 18;
                System.Console.Write("Desconto: " + desconto + "%\n");
                total = valorCompra - ((valorCompra * desconto) / 100);
                System.Console.Write("Total com desconto R$ " + total);
            }
            else
            {
                
            }
        }
    }
}