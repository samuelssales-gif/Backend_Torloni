// See https://aka.ms/new-console-template for more information
using Exercicio01;
using Exercicio1;

Console.WriteLine($"=====Bem vindo ao programa Cauculos da geometria ;)=====");
Console.WriteLine();

Console.WriteLine($"Vamos calcular o retangulo");
Console.Write($"Digite a lagura do Retangulo: ");
float l = float.Parse(Console.ReadLine());
Console.Write($"Digite Altura do Retangulo: ");
float a = float.Parse(Console.ReadLine());

Retangulo retangulo = new Retangulo();
retangulo.Altura = a;
retangulo.Largura = l;
retangulo.caucularArea();

Console.WriteLine();
Console.WriteLine($"agora vamos caucular a area do circulo");
float r = float.Parse(Console.ReadLine());

Circulo circulo = new Circulo();
circulo.Raio = r;
circulo.caucularArea();

Console.WriteLine();
Console.WriteLine($"Fim de programa");
Console.WriteLine();