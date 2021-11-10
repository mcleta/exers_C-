using System;

namespace EhParEhImpar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número: ");
            double num = Convert.ToDouble(Console.ReadLine());

            double modulo = num % 2;

            if (modulo == 0)
                Console.WriteLine($"O número {num} é par!");
            else
                Console.WriteLine($"O número {num} é impar!");
        }
    }
}
