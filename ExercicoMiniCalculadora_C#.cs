using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("=== Mini Calculadora ===\n");

        // Entrada de dados
        Console.Write("Digite o primeiro número: ");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Digite o segundo número: ");
        double num2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Digite a operação (+, -, *, /, ^): ");
        char operacao = Convert.ToChar(Console.ReadLine());

        double resultado;

        // Estrutura de decisão
        switch (operacao)
        {
            case '+':
                resultado = num1 + num2;
                Console.WriteLine($"\nResultado: {num1} + {num2} = {resultado}");
                break;

            case '-':
                resultado = num1 - num2;
                Console.WriteLine($"\nResultado: {num1} - {num2} = {resultado}");
                break;

            case '*':
                resultado = num1 * num2;
                Console.WriteLine($"\nResultado: {num1} * {num2} = {resultado}");
                break;

            case '/':
                if (num2 == 0)
                {
                    Console.WriteLine("\nErro: Divisão por zero não é permitida.");
                }
                else
                {
                    resultado = num1 / num2;
                    Console.WriteLine($"\nResultado: {num1} / {num2} = {resultado}");
                }
                break;

            case '^':
                resultado = Math.Pow(num1, num2);
                Console.WriteLine($"\nResultado: {num1} ^ {num2} = {resultado}");
                break;

            default:
                Console.WriteLine("\nErro: Símbolo de operação inválido.");
                break;
        }
    }
}

