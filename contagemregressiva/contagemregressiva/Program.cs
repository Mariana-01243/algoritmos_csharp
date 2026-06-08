// Esse algoritmo faz contagem regressiva

Console.Write("Digite um numero: ");
int numero = int.Parse(Console.ReadLine());

while (numero >= 0)
{
    Console.WriteLine(numero);
    numero--;
}
Console.WriteLine("FIM!!");
