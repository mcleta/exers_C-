using System;

namespace ReajusteSalarial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double salario = 0;
            double novoSalario = 0;

            for (int cont = 0; cont <= 10; cont++)
            {
                Console.WriteLine("Digite o valor do sálario: ");

                salario = Convert.ToDouble(Console.ReadLine());

                if (salario <= 300)
                {
                    novoSalario = salario * 1.5;
                    Console.WriteLine($"Salário reajustado: {novoSalario} \n");
                }
                else
                {
                    novoSalario = salario * 0.3;
                    Console.WriteLine($"Salário reajustado: {novoSalario} \n");
                }
            }

        }
    }
}
