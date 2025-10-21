int n = 0, contador = 0, n1 = 0, n2 = 0;

Console.WriteLine("Digite o numero de repeticao");
n = int.Parse(Console.ReadLine());

while (contador > 0)

{
    Console.WriteLine("Digite o primeiro numero:");
    n1 = int.Parse(Console.ReadLine());

     Console.WriteLine("Digite o segundo numero:");
    n2 = int.Parse(Console.ReadLine());
    contador++;

    if (n1 > n2)
    {
        Console.WriteLine($"0 numero {n1} e maior que o numero {n2}");
    }
    else if (n1 < n2)

    {
        Console.WriteLine("os dois numeros sao iguais: `{n1} = {n2}");
    }
    contador++;
}