// Esse algoritmo calcula a média do aluno

Console.Write("Primeira nota: ");
double n1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Segunda nota: ");
double n2 = Convert.ToDouble(Console.ReadLine());

Console.Write("Terceira nota: ");
double n3 = Convert.ToDouble(Console.ReadLine());

Console.Write("Quarta nota: ");
double n4 = Convert.ToDouble(Console.ReadLine());

double media = (n1 + n2 + n3 + n4)/4;

if (media >= 6)
{
    Console.WriteLine("Aprovado!!");
}
else if (media >= 5)
{
    Console.WriteLine("Recuperação!!");
}
else {
    Console.WriteLine("REPROVADO!!");
}
