using System;

namespace MediaIdade
{
    //algoritmo que calcule a idade média de 5 alunos
    internal class Program
    {
        static void Main(string[] args)
        {
            double idade = 0;

            for ( int cont = 1; cont <= 5; cont++)
            {
                Console.WriteLine("Digite a idade: ");
                idade += Convert.ToDouble(Console.ReadLine());
            }

            double mediaIdade = idade / 5;

            Console.WriteLine($"A idade média é {mediaIdade}");
        }
    }
}
