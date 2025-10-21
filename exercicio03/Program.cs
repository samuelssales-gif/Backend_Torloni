    Console.WriteLine("-------------------------------------------------------");
    Console.WriteLine("                  Seja Bem Vindo meu rei"               );
    Console.WriteLine("-------------------------------------------------------");
double TriânguloEquilátero, TriânguloIsóscele, TriânguloEscaleno;

Console.WriteLine("Digite o valor do primeiro lado");
TriânguloEquilátero = double.Parse(Console.ReadLine());

Console.WriteLine("Digite o valor do segundo lado");
TriânguloIsóscele = double.Parse(Console.ReadLine());

Console.WriteLine("Digite o valor do terceiro lado");
TriânguloEscaleno = double.Parse(Console.ReadLine());

if (TriânguloEquilátero == 3)
{
    Console.WriteLine("Triângulo    Equilátero:    possui    os    3    lados    iguais");
}

else if (TriânguloIsóscele == 2)
{
    Console.WriteLine("Triângulo    Isóscele:    possui    2    lados    iguai");
}

else if (TriânguloEscaleno  == 1)
{
    Console.WriteLine("Triângulo    Escaleno:    possui    3    lados    diferentes.");
}