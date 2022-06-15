using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animais.Animal
{
    public class Onivoro : Animal
    {
        public int gestação { get; set; }
        public Onivoro(string nome, string sexo, string raça, int gestação) : base(nome, sexo, raça)
        {
            this.gestação = gestação;
        }
        public override string ToString()
        {
            return "Nome: " + this.nome + "\n"
                + "Sexo: " + this.sexo + "\n"
                + "Raça: " + this.raça + "\n"
                + "Gestação: " + this.gestação;
        }
    }
}
