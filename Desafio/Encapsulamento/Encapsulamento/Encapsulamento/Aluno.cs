using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulamento
{
    class Aluno
    {
        // Atributos Privados
        private double nota1, nota2;

        // Media
        private double media()// Apenas Aluno tera acesso
        {
            return (nota1 + nota2) / 2;
        }
        public void mensagem()
        {
            Console.Write("Primeira nota: ");
            nota1 = double.Parse(Console.ReadLine());
            Console.Write("Segunda nota: ");
            nota2 = double.Parse(Console.ReadLine());
            Console.WriteLine("A Média é: " + media());
        }
    }
}
