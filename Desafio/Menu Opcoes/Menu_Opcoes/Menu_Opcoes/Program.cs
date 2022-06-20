using System;

namespace Menu_Opcoes
{
    public class Program
    {
        static void Main(string[] args)
        {
            int idade, anoAtual, nascimento;
            double imc, peso, altura;
            string sair;

            Console.Write("Qual ano de seu nascimento: ");
            nascimento = Int32.Parse(Console.ReadLine());
            anoAtual = 2022;
            Console.Write("Qual seu peso: ");
            peso = double.Parse(Console.ReadLine());
            Console.Write("Qual sua altura: ");
            altura = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite uma das opções:");
            Console.WriteLine("1 - Idade ");
            Console.WriteLine("2 - IMC ");
            Console.WriteLine("3 - Sair ");
            var numeroDigitado = Console.ReadLine();
            if (numeroDigitado == "1")
            {
                idade = anoAtual - nascimento;
                Console.WriteLine("Sua idade é: " + idade);
            }
            if (numeroDigitado == "2")
            {
                imc = peso / (altura * altura);
                Console.WriteLine("Seu IMC é: " + imc.ToString("0.00"));
            }
            else
            {
                Console.WriteLine("Sair!");
            }
            Console.ReadKey();
        }
    }
}
