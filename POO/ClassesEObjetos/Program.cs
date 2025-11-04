using ClassesEObjetos;
// Pessoa joao = new Pessoa();

// joao.Nome = "joao silva";

// Console.WriteLine($"{joao.Nome}. tem {joao.Idade} anos");

// int novaIdade = joao.Envelhecer(17);

// Console.WriteLine($"{joao.Nome} tem {joao.Idade} anos");

// novaIdade = joao.Envelhecer(-50);

// Console.WriteLine($"{joao.Nome} tem {joao.Idade} anos");

// Garrafa g1 = new Garrafa();
// Console.WriteLine("----------------------------------------------");
// Console.WriteLine("faça os passos abaixo para fazer a sua garrafa");
// Console.WriteLine("----------------------------------------------");

// Console.WriteLine("Primeiro digite o seu nome com letra maioscula por favor!!!");
// Console.ReadLine();

// Console.WriteLine("digite a cor da garrafa!!!");
// g1.cor = Console.ReadLine();

// Console.WriteLine("Digite o material da garrafa!!");
// g1.material = Console.ReadLine();

// Console.WriteLine("Digite a marca da garrafa!!!");
// g1.marca = Console.ReadLine();

// Console.WriteLine("Digite a capacidade da garrafa!!!");
// g1.capacidade = Console.ReadLine();

// Console.WriteLine("-----------------------------");
// Console.WriteLine("---Sua garrafa esta pronta---");
// Console.WriteLine("-----------------------------");
// Console.WriteLine($"Cor: {g1.cor}              ");
// Console.WriteLine($"Material: {g1.material}    ");
// Console.WriteLine($"Marca: {g1.marca}          ");
// Console.WriteLine($"Capacidade: {g1.capacidade}");
// Console.WriteLine("-----------------------------");

//Agência Bancária
AgênciaBancária c1 = new AgênciaBancária();

Console.Clear();
Console.WriteLine("=======================================================");
Console.WriteLine("               SISTEMA BANCÁRIO SIMPLIFICADO           ");
Console.WriteLine("=======================================================");

// Solicita saldo inicial
Console.Write("Informe o saldo inicial da sua conta: ");
c1.saldo = double.Parse(Console.ReadLine());
Console.WriteLine($"Saldo registrado: R$ {c1.saldo:F2}");
Console.WriteLine("-------------------------------------------------------");

// Solicita o nome do titular
Console.Write("Informe o nome do titular da conta: ");
c1.titular = Console.ReadLine();
Console.WriteLine($"Titular cadastrado: {c1.titular}");
Console.WriteLine("-------------------------------------------------------");

// Escolha da operação
Console.Write("Digite a operação desejada (Depositar / Sacar): ");
string operacao = Console.ReadLine();
Console.WriteLine("-------------------------------------------------------");

// Verifica operação
if (operacao.Equals("Depositar", StringComparison.OrdinalIgnoreCase))
{
    Console.Write("Informe o valor que deseja depositar: R$ ");
    c1.valor = double.Parse(Console.ReadLine());

    Console.WriteLine($"Você depositou: R$ {c1.valor:F2}");
    Console.WriteLine($"Saldo atualizado: R$ {c1.Depositar():F2}");
}
else if (operacao.Equals("Sacar", StringComparison.OrdinalIgnoreCase))
{
    Console.Write("Informe o valor que deseja sacar: R$ ");
    c1.valor = double.Parse(Console.ReadLine());

    if (c1.valor > c1.saldo)
    {
        Console.WriteLine("Saldo insuficiente! Tente sacar um valor menor.");
    }
    else
    {
        Console.WriteLine($"Você sacou: R$ {c1.valor:F2}");
        Console.WriteLine($"Saldo atualizado: R$ {c1.Sacar():F2}");
    }
}
else
{
    Console.WriteLine("Operação inválida! Tente novamente digitando 'Depositar' ou 'Sacar'.");
}

Console.WriteLine("=======================================================");
Console.WriteLine("          Obrigado por utilizar nosso banco!           ");
Console.WriteLine("=======================================================");
