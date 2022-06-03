using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animais.Animal
{
    public class Carnivoro : Animal
    {
        public int idade { get; set; }
        public string habitoAlimentar { get; set; }

        public Carnivoro(string nome, string sexo, string raça, int idade, string habitoAlimentar) : base(nome, sexo, raça)
        {
            this.idade = idade;
            this.habitoAlimentar = habitoAlimentar; 
        }
        public override string ToString()
        {
            return "Nome: " + this.nome + "\n"
                + "Sexo: " + this.sexo + "\n"
                + "Raça: " + this.raça + "\n"
                + "Idade: " + this.idade + "\n"
                + "Alimentação: " + this.habitoAlimentar;
        }
    }
}
