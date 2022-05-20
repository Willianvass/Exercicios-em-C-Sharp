//Este programa tem por finalidade verificar o sexo de uma pessoa. Demonstra como utilizar operadores lógicos, relacionais e declarar strings.

using System;

namespace Genero_Sexual
{
    public class Program
    {
        static void Main(string[] args)
        {
            string sexo;
            Console.WriteLine("Qual seu sexo: ");
            sexo = Console.ReadLine();

            if ((sexo == "MASCULINO") || (sexo == "Masculino") || (sexo == "masculino") || (sexo == "FEMININO") || (sexo == "Feminino") || (sexo == "feminino"))
                {
                Console.WriteLine("Seu genero é valido!!");
            }
            else
            {
                Console.WriteLine("Seu sexo é inválido!!");
            }
        }
    }
}
