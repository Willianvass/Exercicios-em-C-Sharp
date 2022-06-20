using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vida_Academica.Entities
{
    public class Colaborador
    {
        private string nome, matricula; // ENCAPSULAMENTO

        public void nomeMatricula()
        {
            Console.Write("Nome: ");
            nome = Console.ReadLine();
            Console.Write("Matricula: ");
            matricula = Console.ReadLine();

            Console.WriteLine($"Nome: {nome} e Matricula: {matricula}");
        }

    }
}
