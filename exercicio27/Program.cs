int numero, i = 1, quantidade = 0;

Console.WriteLine("Quantos numeros vc quer digitar");
quantidade = int.Parse(Console.ReadLine());

while (i <= quantidade)

{
    Console.WriteLine($"qual numero vc quer digitar");
    numero = int.Parse(Console.ReadLine());
    if (numero % 2 == 0)
    {
        Console.WriteLine($"numero ditado e par: {numero}");

    }
    numero++;
}