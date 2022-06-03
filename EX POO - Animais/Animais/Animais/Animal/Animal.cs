using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animais.Animal
{
    public class Animal
    {
        public string nome { get; set; }
        public string sexo { get; set; }
        public string raça { get; set; }
        public Animal(string nome, string sexo, string raça)
        {
            this.nome = nome;
            this.sexo = sexo;
            this.raça = raça;
        }
    }
}
