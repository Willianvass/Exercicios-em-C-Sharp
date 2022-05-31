using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funcionarios.Entities
{
    public class Consultor : Funcionario
    {
        public double valorHora { get; set; }
        public long horasTrabalhadas { get; set; }
        public Consultor(string nome, long cpf, double valorHora, long horasTrabalhadas) : base(nome, cpf)
        {
            this.valorHora = valorHora;
            this.horasTrabalhadas = horasTrabalhadas;
        }
        public override double calcularSalario()
        {
            return valorHora * horasTrabalhadas;
        }
    }
}
