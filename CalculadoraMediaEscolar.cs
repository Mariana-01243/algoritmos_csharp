using System;

class Program
{
    static void Main()
    {
        double nota1, nota2, nota3, nota4, media;

        Console.Write("Nota 1: ");
        nota1 = double.Parse(Console.ReadLine());

        Console.Write("Nota 2: ");
        nota2 = double.Parse(Console.ReadLine());

        Console.Write("Nota 3: ");
        nota3 = double.Parse(Console.ReadLine());

        Console.Write("Nota 4: ");
        nota4 = double.Parse(Console.ReadLine());

        media = (nota1 + nota2 + nota3 + nota4) / 4;

        Console.WriteLine($"Média: {media:F2}");

        if (media >= 7)
        {
            Console.WriteLine("Aprovado");
        }
        else if (media >= 5)
        {
            Console.WriteLine("Recuperação");
        }
        else
        {
            Console.WriteLine("Reprovado");
        }
    }
}