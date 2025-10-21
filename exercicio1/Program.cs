    Console.WriteLine("-------------------------------------------------------");
    Console.WriteLine("                  Seja Bem Vindo meu rei"               );
    Console.WriteLine("-------------------------------------------------------");
    
double salario, gasto, Total;

Console.WriteLine("digite o valor do salario");
salario = double.Parse(Console.ReadLine());

Console.WriteLine("digite o valor gasto");
gasto = double.Parse(Console.ReadLine());

Total = (salario - gasto) / 2;

if (gasto < salario)
{
    Console.WriteLine("Gastos dentro do orçamento");
}

else if (gasto > salario)
{
  Console.WriteLine("Orçamento estourado");  
}