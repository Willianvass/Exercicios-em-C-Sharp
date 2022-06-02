using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pessoas.Entities;

namespace Pessoas.Entities 
{
    public class PessoaFisica : Pessoa
    {
        public long cpf { get; set; }
        public string Datanascimento { get; set; }
        public PessoaFisica(string nome, string endereço, string telefone, long cpf, string datanascimento) : base(nome, endereço, telefone)
        {
            this.cpf = cpf;
            this.Datanascimento = datanascimento;   
        }
    }
}
