Console.WriteLine($"Digite seu nome");
string nome = Console.ReadLine();
Console.WriteLine($"Digite seu sobrenome");
string sobrenome = Console.ReadLine();
Thread.Sleep(1000);
Console.WriteLine($"ok, {nome}! Agora vamos dar boas vindas a você!!");
Console.WriteLine($"por favor escolha uma opção abaixo:");
Console.WriteLine($"1 - Saudar com nome");
Console.WriteLine($"2 - Saudar com sobrenome");
Console.WriteLine($"3 - Saudar com nome completo");
Console.WriteLine($"0 - Apenas saudação genérica");
    int opcao = int.Parse(Console.ReadLine());
    Console.Clear();

switch (opcao)
{
    case 0:
        SaudacaoGenerica();
        break;
    case 1:
        SaudarComNome(nome);
        break;
    case 2:
        SaudacaoSobrenome();
        break;
    case 3:
        string nomeCompleto = DelvolveNomeCompleto(nome, sobrenome);
        Console.WriteLine($"Seja bem vindo {nomeCompleto}");
        break;
    default:
        OpcaoInvalida();
        break;
}
void SaudacaoGenerica()
{
    Console.WriteLine($"Olá, seja bem vindo ao nosso programa, tenha um ótimo dia :)");
}

void SaudarComNome(string nomeRecebido)
{
    Console.WriteLine($"Seja bem vindo, {nomeRecebido}");
}

void SaudacaoSobrenome()
{
    Console.WriteLine($"Olá {sobrenome}, seja bem vindo ao nosso programa, tenha um ótimo dia :)");
}


string DelvolveNomeCompleto(string nomeRecebido, string sobrenomeRecebido)
{
    return $"{nomeRecebido} {sobrenomeRecebido}";
}

void OpcaoInvalida()
{
    Console.WriteLine($"Erro, opção inválida");
}