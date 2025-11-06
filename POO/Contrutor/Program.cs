using Construtor;
using MetodoConstrutor;

Console.Clear();

// Instâncias utilizando construtor sem parâmetros
Pessoa3Sobrecargas primeiraPessoa = new Pessoa3Sobrecargas();
Pessoa3Sobrecargas segundaPessoa = new Pessoa3Sobrecargas();
Pessoa3Sobrecargas terceiraPessoa = new Pessoa3Sobrecargas();

Console.WriteLine(@$"
Primeira pessoa cadastrada:
    Nome:  {primeiraPessoa.Nome}
    Idade: {primeiraPessoa.Idade}
");

Console.WriteLine(@$"
Segunda pessoa cadastrada:
    Nome:  {segundaPessoa.Nome}
    Idade: {segundaPessoa.Idade}
");

Console.WriteLine(@$"
Terceira pessoa cadastrada:
    Nome:  {terceiraPessoa.Nome}
    Idade: {terceiraPessoa.Idade}
");

Console.WriteLine("-------------------------------------------------------");

// Cadastro via usuário
Console.Write("Digite o nome do usuário: ");
string nome3 = Console.ReadLine();

Console.Write("Digite a idade do usuário: ");
int idade3 = int.Parse(Console.ReadLine());

// Instância utilizando construtor com parâmetros
Pessoa3Sobrecargas pessoaComDados = new Pessoa3Sobrecargas(nome3, idade3);

Console.WriteLine(@$"
Pessoa cadastrada com dados informados:
    Nome:  {pessoaComDados.Nome}
    Idade: {pessoaComDados.Idade}
");
