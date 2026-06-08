// Esse algoritmo fornece a informação se a pessoa já pode tirar a cnh ou não

Console.Write("Qual o ano do seu nascimento ?");
int anoNascimento = int.Parse(Console.ReadLine());

int idade = 2026 - anoNascimento;

if (idade >= 18)
{
    Console.WriteLine("Você já pode tirar a sua CNH !!");
}
else 
{
    Console.WriteLine("Não alcançou a maioridade!!");
    Console.WriteLine($"faltam{18 - idade}anos");sssss
}
