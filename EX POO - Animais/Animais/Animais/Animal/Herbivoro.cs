using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animais.Animal
{
    public class Herbivoro : Animal
    {
        public string alimentoFavorito {get; set;}
        public Herbivoro(string nome, string sexo, string raça, string alimentoFavorito) : base(nome, sexo, raça)
        {
            this.alimentoFavorito = alimentoFavorito;
        }
        public override string ToString()
        {
            return "\n" + "Nome: " + this.nome + "\n"
                + "Sexo: " + this.sexo + "\n"
                + "Raça: " + this.raça + "\n"
                + "Alimentação: " + this.alimentoFavorito;
        }

    }
}
