using Exercicio02;
using Exercicio2;

List<IImprimivel> documentos = new List<IImprimivel>();
int opcao;
do
{
Console.Clear();
System.Console.WriteLine($"Menu de Opções");
System.Console.WriteLine($@"
1) Cadastrar Fatura
2) Cadastrar Relatorio
3) Cadastrar Contrato
4) Lista Faturas
5) Lista Relatorio
6) Lista Contrato
0)Sair
Escola a opção :");
opcao = int.Parse(Console.ReadLine());

switch (opcao)
{
    case 1:
    System.Console.WriteLine($"Cadastrar Fatura");
    CadastrarFatura();
    ListarFaturas();
    break;
    case 2:
    System.Console.WriteLine($"Cadastrar Relatorio");
    CadastrarRelatorio();
    ListarRelatorio();
    break;
    case 3:
    System.Console.WriteLine($"Cadastrar Contrato");
    CadastrarContato();
    ListarContrato();
    break;
    case 4:
    System.Console.WriteLine($"Lista Fatura");
    break;
    case 5:
    System.Console.WriteLine($"Lista Relatorio");
    break;
    case 6:
    System.Console.WriteLine($"Lista Contrato");
    break;
    case 0:
    System.Console.WriteLine($"sair do progama");
    break;
    default:
    break;
}

System.Console.WriteLine($"Digite <Enter> para Continuar");
Console.ReadLine();    
}while (opcao != 0);

void CadastrarFatura()
{
    System.Console.WriteLine($"Digite o Nome do Devedor:");
    string dev = Console.ReadLine();
    System.Console.WriteLine($"Digite o Nome da Credor");
    string cred = Console.ReadLine();
    System.Console.WriteLine($"Digite o valor da Fatura");
    float valor = float.Parse(Console.ReadLine());
    System.Console.WriteLine($"Quantos dias a fatura está em atraso?");
    int DiasDeAtraso = int.Parse(Console.ReadLine());


    Fatura f = new Fatura(dev,cred, valor, DiasDeAtraso);
    documentos.Add(f);
}

void CadastrarRelatorio()
{
    System.Console.WriteLine($"Digite o Nome do Relatorio");
    string Responsavel = Console.ReadLine();
    System.Console.WriteLine($"Digite o Texto que esta no Relatorio");
    string txtClausulas = Console.ReadLine();

    Relatorio r = new Relatorio(Responsavel, txtClausulas);
    documentos.Add(r);
}
void CadastrarContato()
{
    System.Console.WriteLine($"Digite o nome do Contratante");
    string contratante = Console.ReadLine();
    System.Console.WriteLine($"Digite o Prestador de Serviço");
    string contratada = Console.ReadLine();
    System.Console.WriteLine($"Digite as Clausulas");
    string txtClausulas = Console.ReadLine();

    Contrato c = new Contrato(contratante, contratada,txtClausulas);
    documentos.Add(c);
}

void ListarFaturas()
{
    System.Console.WriteLine($"Listando as Faturas:");
    foreach (var item in documentos)
    {
        if (item is Fatura)
        {
            item.Imprimir();
        }
    }

}
void ListarRelatorio()
{
    System.Console.WriteLine($"Listando os Relatorios:");
        foreach (var item in documentos)
    {
        if (item is Relatorio)
        {
            item.Imprimir();
        }
    }
    
}
void ListarContrato()
{
    System.Console.WriteLine($"Listando os Contratos:");
        foreach (var item in documentos)
    {
        if (item is Contrato)
        {
            item.Imprimir();
        }
    }
    
}