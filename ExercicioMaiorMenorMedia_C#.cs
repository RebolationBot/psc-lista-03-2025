using System;

class Program
{
    static void Main(string[] args)
    {
        // Leitura dos três números
        Console.Write("Digite o primeiro número: ");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Digite o segundo número: ");
        double num2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Digite o terceiro número: ");
        double num3 = Convert.ToDouble(Console.ReadLine());

        // Encontrando o maior e o menor
        double maior = Math.Max(num1, Math.Max(num2, num3));
        double menor = Math.Min(num1, Math.Min(num2, num3));

        // Calculando a média
        double media = (num1 + num2 + num3) / 3;

        // Saída dos resultados
        Console.WriteLine($"\nMaior número: {maior}");
        Console.WriteLine($"Menor número: {menor}");
        Console.WriteLine($"Média aritmética: {media}");
    }
}
