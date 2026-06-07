using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite um número: ");
        int numero = int.Parse(Console.ReadLine());

        int contador = 1;

        while (contador <= 10)
        {
            Console.WriteLine($"{numero} x {contador} = {numero * contador}");
            contador++;
        }
    }
}