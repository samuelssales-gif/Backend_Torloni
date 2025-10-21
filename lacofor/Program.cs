int soma = 0;

// Exibe as rodadas
for (int i = 2; i >= 0; i--)
{
    Console.WriteLine(i);
}

// Recebe três números e soma
for (int i = 1; i <= 3; i++)
{
    Console.Write("Digite um número: ");
    int n = int.Parse(Console.ReadLine());
    soma += n;
}

Console.WriteLine("A soma total é: " + soma);
