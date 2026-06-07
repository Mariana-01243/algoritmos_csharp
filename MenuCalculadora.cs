using System;

class Program
{
    static void Main()
    {
        int opcao = -1;

        while (opcao != 0)
        {
            Console.WriteLine("\n=== CALCULADORA ===");
            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("0 - Sair");

            Console.Write("Escolha uma opção: ");
            opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    Console.Write("Primeiro número: ");
                    double n1 = double.Parse(Console.ReadLine());

                    Console.Write("Segundo número: ");
                    double n2 = double.Parse(Console.ReadLine());

                    Console.WriteLine($"Resultado: {n1 + n2}");
                    break;

                case 2:
                    Console.Write("Primeiro número: ");
                    n1 = double.Parse(Console.ReadLine());

                    Console.Write("Segundo número: ");
                    n2 = double.Parse(Console.ReadLine());

                    Console.WriteLine($"Resultado: {n1 - n2}");
                    break;

                case 0:
                    Console.WriteLine("Encerrando...");
                    break;

                default:
                    Console.WriteLine("Opção inválida.");
                    break;
            }
        }
    }
}