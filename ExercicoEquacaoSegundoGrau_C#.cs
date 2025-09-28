using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("=== Resolução de Equação do Segundo Grau ===");
        Console.WriteLine("Forma geral: ax² + bx + c = 0\n");

        Console.Write("Digite o valor de a: ");
        double a = Convert.ToDouble(Console.ReadLine());

        Console.Write("Digite o valor de b: ");
        double b = Convert.ToDouble(Console.ReadLine());

        Console.Write("Digite o valor de c: ");
        double c = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine($"\nEquação: {a}x² + {b}x + {c} = 0");

        // Verificação de consistência
        if (a == 0 && b == 0 && c != 0)
        {
            Console.WriteLine("\nCoeficientes informados incorretamente.");
        }
        else if (a == 0 && b != 0)
        {
            double raiz = -c / b;
            Console.WriteLine("\nEssa é uma equação de primeiro grau.");
            Console.WriteLine($"Raiz real: {raiz:F2}");
        }
        else if (a != 0)
        {
            // Cálculo do discriminante
            double delta = (b * b) - (4 * a * c);
            Console.WriteLine($"\nDiscriminante (delta) = {b}² - 4*{a}*{c} = {delta}");

            if (delta < 0)
            {
                Console.WriteLine("\nEsta equação não possui raízes reais.");
            }
            else if (delta == 0)
            {
                double raiz = -b / (2 * a);
                Console.WriteLine("\nEsta equação possui duas raízes reais iguais.");
                Console.WriteLine($"Raiz: {raiz:F2}");
            }
            else // delta > 0
            {
                double raiz1 = (-b + Math.Sqrt(delta)) / (2 * a);
                double raiz2 = (-b - Math.Sqrt(delta)) / (2 * a);

                Console.WriteLine("\nEsta equação possui duas raízes reais diferentes.");
                Console.WriteLine($"Raiz 1: {raiz1:F2}");
                Console.WriteLine($"Raiz 2: {raiz2:F2}");
            }
        }
        else
        {
            Console.WriteLine("\nCoeficientes informados incorretamente.");
        }
    }
}
