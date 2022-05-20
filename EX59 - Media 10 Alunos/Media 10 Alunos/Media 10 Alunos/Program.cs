//Este programa calcula a média de uma turma de 10 alunos. Utiliza métodos de console, estrutura de repetição while e inicialização de variáveis.

using System;

namespace Media_10_Alunos
{
    public class Program
    {
        static void Main(string[] args)
        {
            int contador;
            double media, nota, total;
            contador = 1;
            total = 0;

            Console.WriteLine("Entre com a {0} a nota: ", contador);
            nota = double.Parse(Console.ReadLine());

            total = nota + total;
            contador = contador++;

            media = total / 10;

            Console.WriteLine("A media da classe é: " + media);
        }
        

    }
}
