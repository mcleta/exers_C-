using System;

namespace MaiorQ18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cont = 0;

            int quantidade = 0;

            int idade = 0;

            while (cont < 10)
            {
                Console.Write("Informe a idade da pessoa: ");

                idade = Convert.ToInt32(Console.ReadLine());

                if (idade >= 18)
                    quantidade = quantidade + 1;

                cont++;
            }

            Console.WriteLine($"Existem {quantidade} pessoas com mais de 18 anos");
        }
    }
}
