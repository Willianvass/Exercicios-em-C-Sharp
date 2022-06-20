using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vida_Academica.Entities
{
    public class ColaboradorEnsinoSuperior : Colaborador
    {
        public string universidade { get; set; }
        public ColaboradorEnsinoSuperior(string universidade)
        {
            this.universidade = universidade;
        }
        public override string ToString()
        {
            return "Universidade: " + this.universidade;
        }

    }
}
