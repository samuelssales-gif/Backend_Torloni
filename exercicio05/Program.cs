
int quantidade;
double preco;
Console.WriteLine("Digite o numero de maças");
quantidade = int.Parse(Console.ReadLine());

if (quantidade >= 12)
{
    preco = 0.25;
}
else
{
    preco = 0.30;
}

 double total = quantidade * preco;

Console.WriteLine($"O valor total da compra é: R$ {total}");