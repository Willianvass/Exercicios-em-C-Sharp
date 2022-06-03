using Animais.Animal;
using System;

namespace Animais
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Carnivoro Tigre = new Carnivoro("Tigre", "Masculino", "Felino", 15, "Carnes");
            Console.WriteLine(Tigre);

            Herbivoro Panda = new Herbivoro("Panda", "Femea", "Urso", "Bambu");
            Console.WriteLine(Panda);
        }
    }
}
