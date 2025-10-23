Console.Clear(); // limpa tela
Console.WriteLine($"Digite seu nome:"); // pede o nome do usuário
string nomeUsuario = Console.ReadLine(); // guarda o nome na variável
Cumprimento(nomeUsuario); // chama a função e passa o nome

int opcao = -1;

// =====================================================
// ===================== EXERCÍCIO 1 ====================
// =====================================================
void opcao1()
{
    Console.WriteLine($"Você escolheu a opção 1 - exercicio 01");
    Console.WriteLine("-------------------------------------------------------");
    Console.WriteLine("                  Seja Bem Vindo meu rei");
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
}

// =====================================================
// ===================== EXERCÍCIO 2 ====================
// =====================================================
void opcao2()
{
    Console.WriteLine($"Você escolheu a opção 2 - exercicio 02");
    Console.WriteLine("-------------------------------------------------------");
    Console.WriteLine("                  Seja Bem Vindo meu rei");
    Console.WriteLine("-------------------------------------------------------");

    double Palmeiras, Flamengo, Empate;

    Console.WriteLine("Palmeiras fez quantos gols?");
    Palmeiras = double.Parse(Console.ReadLine());

    Console.WriteLine("Flamengo fez quantos gols?");
    Flamengo = double.Parse(Console.ReadLine());

    Empate = (Palmeiras - Flamengo) / 2;

    if (Palmeiras > Flamengo)
    {
        Console.WriteLine("Palmeiras vence a partida!");
    }
    else if (Flamengo > Palmeiras)
    {
        Console.WriteLine("Flamengo vence a partida!");
    }
    else
    {
        Console.WriteLine("Jogo empatado entre o rubro-negro e o alviverde!");
    }
}

// =====================================================
// ===================== EXERCÍCIO 3 ====================
// =====================================================
void opcao3()
{
    Console.WriteLine($"Você escolheu a opção 3 - exercicio 03");
    Console.WriteLine("-------------------------------------------------------");
    Console.WriteLine("                  Seja Bem Vindo meu rei");
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
        Console.WriteLine("Triângulo Equilátero: possui os 3 lados iguais");
    }
    else if (TriânguloIsóscele == 2)
    {
        Console.WriteLine("Triângulo Isóscele: possui 2 lados iguais");
    }
    else if (TriânguloEscaleno == 1)
    {
        Console.WriteLine("Triângulo Escaleno: possui 3 lados diferentes.");
    }
}

// =====================================================
// ===================== EXERCÍCIO 4 ====================
// =====================================================
void opcao4()
{
    Console.WriteLine($"Você escolheu a opção 4 - exercicio 04");
    Console.WriteLine("-------------------------------------------------------");
    Console.WriteLine("                  Seja Bem Vindo meu rei");
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
}

// =====================================================
// ===================== EXERCÍCIO 5 ====================
// =====================================================
void opcao5()
{
    Console.WriteLine($"Você escolheu a opção 5 - exercicio 05");
    Console.WriteLine("-------------------------------------------------------");
    Console.WriteLine("                  Seja Bem Vindo meu rei");
    Console.WriteLine("-------------------------------------------------------");

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
}

// =====================================================
// ===================== EXERCÍCIO 6 ====================
// =====================================================
void opcao6()
{
    Console.WriteLine($"Você escolheu a opção 6 - exercicio 06");
    Console.WriteLine("-------------------------------------------------------");
    Console.WriteLine("                  Seja Bem Vindo meu rei");
    Console.WriteLine("-------------------------------------------------------");

    Console.Write("Digite a média do aluno: ");
    double media = double.Parse(Console.ReadLine());

    Console.Write("Digite a frequência do aluno (em %): ");
    double frequencia = double.Parse(Console.ReadLine());

    if (frequencia < 75)
    {
        Console.WriteLine("Aluno REPROVADO por frequência.");
    }
    else if (media >= 7.0)
    {
        Console.WriteLine("Aluno APROVADO.");
    }
    else if (media >= 3.0)
    {
        Console.WriteLine("Aluno em RECUPERAÇÃO.");
    }
    else
    {
        Console.WriteLine("Aluno REPROVADO por média.");
    }
}

// =====================================================
// ===================== SAIR / OPÇÕES ==================
// =====================================================
void opcao0()
{
    Console.WriteLine($"Você escolheu sair - volte sempre");
}

void opcaoinvalida()
{
    Console.WriteLine($"tem esta opção aqui nao cara {opcao} !!");
}

// =====================================================
// ===================== MENU PRINCIPAL =================
// =====================================================
do
{
    // todo o programa aqui dentro
    // desenha um menu de opções
    Console.WriteLine("Escolha uma opção no menu abaixo:");
    Console.WriteLine(" 1 - exercicio 01");
    Console.WriteLine(" 2 - exercicio 02");
    Console.WriteLine(" 3 - exercicio 03");
    Console.WriteLine(" 4 - exercicio 04");
    Console.WriteLine(" 5 - exercicio 05");
    Console.WriteLine(" 6 - exercicio 06");
    Console.WriteLine(" 0 - Sair");

    // captura a opção do usuário
    opcao = int.Parse(Console.ReadLine());

    switch (opcao)
    {
        case 1:
            opcao1();
            break;
        case 2:
            opcao2();
            break;
        case 3:
            opcao3();
            break;
        case 4:
            opcao4();
            break;
        case 5:
            opcao5();
            break;
        case 6:
            opcao6();
            break;
        case 0:
            opcao0();
            break;
        default:
            opcaoinvalida();
            break;
    }

} while (opcao != 0);

Console.Clear();
Console.WriteLine($"fim do atendimento");

// =====================================================
// ===================== FUNÇÃO CUMPRIMENTO =============
// =====================================================
void Cumprimento(string n)
{
    Console.WriteLine($"Opa todo bom???, {n}");
}
