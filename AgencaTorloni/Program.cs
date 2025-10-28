string[] nomes = new string[4];
double[] saldo = new double[4];
int opcao = -1, totalClientes = 0;

do
{
    Console.WriteLine("========================================");
    Console.WriteLine("            MENU PRINCIPAL              ");
    Console.WriteLine("========================================");
    Console.WriteLine("1) Cadastrar clientes");
    Console.WriteLine("2) Depositar");
    Console.WriteLine("3) Sacar");
    Console.WriteLine("4) Transferir");
    Console.WriteLine("5) Listar clientes");
    Console.WriteLine("0) Sair");
    Console.WriteLine("========================================");
    Console.Write("Digite uma opção: ");
    opcao = int.Parse(Console.ReadLine());

    switch (opcao)
    {
        case 0:
            Console.WriteLine("Encerrando...");
            Console.WriteLine("Pressione <Enter> para encerrar...");
            Console.ReadLine();
            break;

        case 1:
            CadastrarCliente();
            break;

        case 2:
            Depositar();
            Console.WriteLine($"Clique em <Enter> para continuar");
            Console.ReadLine();
            break;

        case 3:
            Sacar();
            break;

        case 4:
            Transferir();
            break;

        case 5:
            ListarClientes();
            break;

        default:
            Console.WriteLine("Opção inválida. Pressione <Enter> para continuar...");
            Console.ReadLine();
            break;
    }

    Console.WriteLine("Pressione <Enter> para encerrar...");

} while (opcao != 0);


// ====================== FUNÇÕES ======================

void CadastrarCliente()
{
    if (totalClientes >= 4)
    {
        Console.WriteLine("Limite de ocupação atingido.");
        Console.WriteLine("Pressione <Enter> para continuar...");
        Console.ReadLine();
        return;
    }

    Console.Write("Digite o nome do cliente: ");
    string n = Console.ReadLine();

    Console.Write($"Digite o saldo inicial de {n}: ");
    double i = double.Parse(Console.ReadLine());

    nomes[totalClientes] = n;
    saldo[totalClientes] = i;
    totalClientes++;

    Console.WriteLine("Cliente cadastrado com sucesso!");
    Console.WriteLine($"Há {totalClientes} cliente(s) cadastrado(s) no sistema!");
    Console.WriteLine("Pressione <Enter> para continuar...");
    Console.ReadLine();
}


void ListarClientes()
{
    Console.WriteLine();
    Console.WriteLine("========== LISTA DE CLIENTES ==========");

    for (int i = 0; i < totalClientes; i++)
    {
        Console.WriteLine($"[{i}] Nome: {nomes[i],-10} | Saldo: R$ {saldo[i]:0.00}");
    }

    Console.WriteLine("========================================");
    Console.WriteLine("Pressione <Enter> para continuar...");
    Console.ReadLine();
}


// ====================== DEPÓSITO ======================

void Depositar()
{
    int idCliente = BuscarCliente();
    if (idCliente == -1)
    {
        return;
    }

    Console.Write($"Valor para depósito: ");
    double valorDeposito = double.Parse(Console.ReadLine());

    saldo[idCliente] += valorDeposito;
    Console.WriteLine($"Depósito de R$ {valorDeposito:0.00} realizado!");
    Console.WriteLine($"Novo saldo de {nomes[idCliente]}: R$ {saldo[idCliente]:0.00}");
    Console.WriteLine($"Clique em <Enter> para continuar");
}


// ====================== OUTRAS FUNÇÕES ======================

void Sacar()
{
    void Sacar()
    {
        int idCliente = BuscarCliente();
        if (idCliente == -1)
        {
            return;
        }

        Console.Write($"Valor do saque: ");
        double valorSolicitado = double.Parse(Console.ReadLine());

        if (saldo[idCliente] >= valorSolicitado)
        {
            saldo[idCliente] -= valorSolicitado;
            Console.WriteLine($"Saque realizado com sucesso!");
        }
        else
        {
            Console.WriteLine($"Saldo Insuficiente");
        }

        Console.WriteLine($"Clique em <Enter para continuar>");
        Console.ReadLine();
    }
}


void Transferir()
{
    Console.WriteLine($"== Transferência ==");
    Console.WriteLine($"Conta de origem: ");
    int idClienteOrigem = BuscarCliente();
    if (idClienteOrigem == -1)
    {
        return;
    }

    Console.Write($"Conta destino: ");
    int idClienteDestino = BuscarCliente();
    if (idClienteDestino == -1)
    {
        return;
    }

    Console.Write($"Valor para transferir: ");
    double valor = double.Parse(Console.ReadLine());

    if (saldo[idClienteOrigem] >= valor)
    {
        saldo[idClienteOrigem] -= valor;
        saldo[idClienteDestino] += valor;
        Console.WriteLine($"Transferencia comcluida");
    }
    else
    {
        Console.WriteLine($"saldo insuficiente!");
    }
}


// ====================== BUSCAR CLIENTE ======================

int BuscarCliente()
{
    ListarClientes();
    Console.Write("Digite o número do cliente: ");

    int idCliente = int.Parse(Console.ReadLine());

    if (idCliente < 0 || idCliente >= totalClientes)
    {
        Console.WriteLine("Cliente não encontrado.");
        return -1;
    }

    return idCliente; // retorna o índice do cliente
}
