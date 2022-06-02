using Pessoas.Entities;
using System;

namespace Pessoas
{
    public class Program
    {
        static void Main(string[] args)
        {
            PessoaFisica Joao = new PessoaFisica("João", "Rua Almas - 155", "016999422778", 27243546803, "27/10/1978");
            PessoaJuridica Ramiro = new PessoaJuridica("Ramiro", "Rua Hum - 100", "01633924053", 24956887000111, 101215589, 14785324);
            Console.WriteLine(Joao);
            Console.WriteLine(Ramiro);
        }
    }   
}
