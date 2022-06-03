using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pessoas.Entities;

namespace Pessoas.Entities
{
    public class PessoaJuridica : Pessoa
    {
        public long cnpj { get; set; }
        public long inscriçãoEstadual { get; set; }
        public long inscriçãoMunicipal { get; set;}    
        public PessoaJuridica(string nome, string endereço, string telefone, long cnpj, long inscriçãoEstadual, long inscriçãoMunicipal) : base(nome, endereço, telefone)
        {
            this.cnpj = cnpj;
            this.inscriçãoMunicipal = inscriçãoMunicipal;
            this.inscriçãoEstadual = inscriçãoEstadual;
        }
        public override string ToString()
        {
            return "\n" + "Nome: " + this.nome + "\n"
                + "Endereço: " + this.endereço + "\n"
                + "Fone: " + this.telefone + "\n"
                + "CNPJ: " + this.cnpj + "\n"
                + "Inscrição Estadual: " + this.inscriçãoEstadual + "\n"
                + "Inscrição Municipal: " + this.inscriçãoMunicipal;
        }
    }
}
