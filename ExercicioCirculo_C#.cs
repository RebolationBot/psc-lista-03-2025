using System;

class Program
{
    static void Main(string[] args)
    {
        const double PI = 3.141592;

        Console.WriteLine("=== Cálculos com Círculo e Esfera ===\n");
        Console.WriteLine("Operações possíveis:");
        Console.WriteLine("1 - Perímetro do círculo");
        Console.WriteLine("2 - Área do círculo");
        Console.WriteLine("3 - Volume da esfera\n");

        // Leitura dos dados
        Console.Write("Digite o código da operação (1, 2 ou 3): ");
        int codigo = Convert.ToInt32(Console.ReadLine());

        Console.Write("Digite o valor do raio: ");
        double raio = Convert.ToDouble(Console.ReadLine());

        double resultado;

        // Estrutura de decisão
        switch (codigo)
        {
            case 1:
                resultado = 2 * PI * raio;
                Console.WriteLine($"\nPerímetro do círculo: {resultado:F4}");
                break;

            case 2:
                resultado = PI * Math.Pow(raio, 2);
                Console.WriteLine($"\nÁrea do círculo: {resultado:F4}");
                break;

            case 3:
                resultado = (4.0 / 3.0) * PI * Math.Pow(raio, 3);
                Console.WriteLine($"\nVolume da esfera: {resultado:F4}");
                break;

            default:
                Console.WriteLine("\nErro: código da operação inválido.");
                break;
        }
    }
}
