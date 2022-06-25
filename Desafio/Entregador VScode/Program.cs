using System;

namespace Entregador
{
    public class Entregador
    {
        static void Main(string[] args)
        {
            string não;
            int proximoNumero;
            proximoNumero = 1;
            int numeroCasa, i, par, impar;
            i = 1;
            par = 0;
            impar = 0;
            System.Console.Write("Tem cachorro: ");
            não = Console.ReadLine();
            System.Console.Write("Qual o numero da casa: ");
            numeroCasa = Int32.Parse(Console.ReadLine());

            if ((não == "não")||(não == "nao")||(não == "Não")||(não == "Nao"))
            {
                if (numeroCasa % 2 != 0)
                {
                    impar = 1;
                }
                else{
                    par = 1;
                }
                while (proximoNumero <= 999999)
                {                    
                    System.Console.Write("Proximo numero de casa: ");
                    proximoNumero = Int32.Parse(Console.ReadLine());
                    proximoNumero = proximoNumero++;
                    if (proximoNumero % 2 != 0)
                    {
                        impar = impar++;
                        System.Console.WriteLine("Casas impar: " + impar);
                    }
                    else
                    {
                        par = par++;
                    }
                }
            }
            else
            {
                System.Console.Write("Pode entregar!");
            }
        }
    }
}
