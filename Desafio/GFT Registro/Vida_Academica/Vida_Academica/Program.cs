using System;
using Vida_Academica.Entities;

namespace Vida_Academica
{
    public class Program
    {
        static void Main(string[] args)
        {
            Colaborador João = new Colaborador(); // INSTANCIAR ENCAPSULAMENTO
            João.nomeMatricula();

            ColaboradorEnsinoBasico escolaPublica = new ColaboradorEnsinoBasico("ETEC"); 
            Console.WriteLine(escolaPublica); // INSTANCIAR POLIMORFISMO

            ColaboradorEnsinoSuperior universidade = new ColaboradorEnsinoSuperior("UNIP");
            Console.WriteLine(universidade); // INSTANCIAR POLIMORFISMO
        }
    }
}
