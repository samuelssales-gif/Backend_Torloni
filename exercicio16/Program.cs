string cargo;
double salario, novoSalario;

Console.WriteLine("Digite o cargo (producao, administrativa ou diretoria):");
cargo = Console.ReadLine();

Console.WriteLine("Digite o salário:");
salario = double.Parse(Console.ReadLine());

if (cargo == "producao")
{
    novoSalario = salario * 1.065;
}
else if (cargo == "administrativa")
{
    novoSalario = salario * 1.075;
}
else if (cargo == "diretoria")
{
    novoSalario = salario * 1.12;
}
else
{
    Console.WriteLine("Cargo inválido!");
    return;
}

Console.WriteLine("Novo salário: " + novoSalario);
