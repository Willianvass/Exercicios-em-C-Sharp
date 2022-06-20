using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vida_Academica.Entities
{
    public class ColaboradorEnsinoBasico : Colaborador
    {
        public string EscolaPublica { get; set; }

        public ColaboradorEnsinoBasico(string escolaPublica)
        {
            this.EscolaPublica = escolaPublica;
        }
        public override string ToString()
        {
            return "Escola Publica: " + this.EscolaPublica + "\n";
        }
    } 
}
