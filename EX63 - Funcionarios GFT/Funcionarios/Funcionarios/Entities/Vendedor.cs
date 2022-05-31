using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funcionarios.Entities
{
    public class Vendedor : Funcionario
    {
        public double comissao { get; set; }
        public long numeroVendas { get; set; }
        public Vendedor(string nome, long cpf, double comissao, long numeroVendas) : base(nome, cpf)
        {
            this.comissao = comissao;
            this.numeroVendas = numeroVendas;
        }
        public override double calcularSalario()
        {
            return salarioMinimo + (comissao * numeroVendas);
        }
        public override string ToString()
        {
            return "Nome" + this.nome + "\n"
            + "CPF: " + this.cpf + "\n"
            + "Comissão: " + this.comissao + "\n"
            + "Numero de vendas: " + this.numeroVendas + "\n"
            + "Salário: " + this.calcularSalario();
        }
    }
}
