using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animais.Animal
{
    public class Mamifero : Animal
    {
        public int velocidade { get; set; }
        public Mamifero(string nome, string sexo, string raça, int velocidade) : base(nome, sexo, raça)
        {
            this.velocidade = (int)velocidade;
        }
        public override string ToString()
        {
            return "\n" + "Nome: " + this.nome + "\n"
                + "Sexo: " + this.sexo + "\n"
                + "Raça: " + this.raça + "\n"
                + "Velocidade: " + this.velocidade;
        }
    }
}
