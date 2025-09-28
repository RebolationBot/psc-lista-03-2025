using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("=== Sorteio de Número Aleatório ===\n");

        // Entrada dos números
        Console.Write("Digite o primeiro número inteiro: ");
        int num1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Digite o segundo número inteiro: ");
        int num2 = Convert.ToInt32(Console.ReadLine());

        // Descobrindo o menor e o maior
        int menor = Math.Min(num1, num2);
        int maior = Math.Max(num1, num2);

        // Gerando número aleatório no intervalo [menor, maior]
        Random random = new Random();
        int sorteado = random.Next(menor, maior + 1); // +1 porque Next é exclusivo no limite superior

        // Verificando par ou ímpar
        Console.WriteLine($"\nNúmero sorteado: {sorteado}");
        if (sorteado % 2 == 0)
        {
            Console.WriteLine("O número sorteado é PAR.");
        }
        else
        {
            Console.WriteLine("O número sorteado é ÍMPAR.");
        }
    }
}
