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
        long cnpj { get; set; }
        long inscriçãoEstadual { get; set; }
        long inscriçãoMunicipal { get; set;}    
        public PessoaJuridica(string nome, string endereço, string telefone, long cnpj, long inscriçãoEstadual, long inscriçãoMunicipal) : base(nome, endereço, telefone)
        {
            this.cnpj = cnpj;
            this.inscriçãoMunicipal = inscriçãoMunicipal;
            this.inscriçãoMunicipal = inscriçãoEstadual;
        }
    }
}
