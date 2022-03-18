//Calcular a média harmônica das notas de um aluno. Define como utilizar uma console manipulando dados de entrada e saída e declarando variáveis

using System;

namespace Nota_Harmonica_Aluno
{
    public  class Nota_Harmonica_Aluno
    {
        static void Main(string[] args)
        {
            double nota1, nota2, nota3, nota4, mediaHarmonica;

            System.Console.Write("Qual a nota da primeira prova: ");
            nota1 = double.Parse(Console.ReadLine());

            System.Console.Write("Qual a nota da segunda prova: ");
            nota2 = double.Parse(Console.ReadLine());

            System.Console.Write("Qual a nota da terceira prova: ");
            nota3 = double.Parse(Console.ReadLine());

            System.Console.Write("Qual a nota da quarta prova: ");
            nota4 = double.Parse(Console.ReadLine());

            mediaHarmonica = (nota1 + nota2 + nota3 + nota4) / 4;

            //MEDIAH = (4/((1/N1) + (1/N2) + (1/N3) + (1/N4)));
            System.Console.WriteLine("Após as 4 provas voce teve uma média de: "), mediaHarmonica;
        }
    }
}
