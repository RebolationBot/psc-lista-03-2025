using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Digite o valor da compra: R$ ");
        int valorCompra = Convert.ToInt32(Console.ReadLine());

        Console.Write("Digite o valor pago: R$ ");
        int valorPago = Convert.ToInt32(Console.ReadLine());

        if (valorPago < valorCompra)
        {
            Console.WriteLine("\nQuantia insuficiente para realizar a compra.");
        }
        else
        {
            int troco = valorPago - valorCompra;
            Console.WriteLine($"\nValor pago: R$ {valorPago}");
            Console.WriteLine($"Valor da compra: R$ {valorCompra}");
            Console.WriteLine($"Troco: R$ {troco}");

            // Cálculo das notas
            int notas50 = troco / 50;
            troco %= 50;

            int notas20 = troco / 20;
            troco %= 20;

            int notas10 = troco / 10;
            troco %= 10;

            int notas5 = troco / 5;
            troco %= 5;

            int notas2 = troco / 2;
            troco %= 2;

            int notas1 = troco / 1;
            troco %= 1;

            Console.WriteLine($"\nNotas de R$ 50,00: {notas50}");
            Console.WriteLine($"Notas de R$ 20,00: {notas20}");
            Console.WriteLine($"Notas de R$ 10,00: {notas10}");
            Console.WriteLine($"Notas de R$ 5,00: {notas5}");
            Console.WriteLine($"Notas de R$ 2,00: {notas2}");
            Console.WriteLine($"Notas de R$ 1,00: {notas1}");
        }
    }
}
