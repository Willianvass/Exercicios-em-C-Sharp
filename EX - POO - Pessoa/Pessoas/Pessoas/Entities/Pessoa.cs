using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pessoas.Entities
{
    public class Pessoa
    {
        public string nome { get; set; }
        public string endereço { get; set; }
        public string telefone { get; set; }

        public Pessoa(string nome, string endereço, string telefone)
        {
            this.nome = nome;
            this.endereço = endereço;
            this.telefone = telefone;
        }
    }
}
