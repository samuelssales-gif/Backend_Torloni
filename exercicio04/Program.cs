    Console.WriteLine("-------------------------------------------------------");
    Console.WriteLine("                  Seja Bem Vindo meu rei"               );
    Console.WriteLine("-------------------------------------------------------");
double senha;

Console.WriteLine("digite a senha");
senha = double.Parse(Console.ReadLine());

if (senha == 1234)
{
    Console.WriteLine("ACESSO liberado, pode entrar meu Rei");
}

 else
{
    Console.WriteLine("ACESSO negado, tente colocar a senha correta meu chefe");
}
