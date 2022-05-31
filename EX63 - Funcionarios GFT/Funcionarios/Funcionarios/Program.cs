using Funcionarios.Entities;
using System;

namespace Funcionarios
{
    public class Program
    {
        static void Main(string[] args)
        {
            Vendedor joao = new Vendedor("Joao", 12346567, 100, 50);
            Consultor ana = new Consultor("Ana", 12548798, 40, 200);
            Console.WriteLine(joao.calcularSalario());
            Console.WriteLine(ana.calcularSalario());
            Console.WriteLine(joao);
        }
    }
}
