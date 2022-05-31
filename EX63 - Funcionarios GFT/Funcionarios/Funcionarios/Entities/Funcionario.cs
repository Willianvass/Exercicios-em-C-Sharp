using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funcionarios.Entities
{
    public class Funcionario
    {
        public string nome { get; set; }
        public long cpf { get; set; }
        public double salarioMinimo = 1000.00;
        public Funcionario(string nome, long cpf)
        {
            this.nome = nome;
            this.cpf = cpf;
        }
        public virtual double calcularSalario()
        {
            return salarioMinimo;
        }
    }
}
