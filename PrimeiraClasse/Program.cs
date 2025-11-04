class Hello
{
    public string textoHello = "";

    public void SaldarUsuario()
    {
        System.Console.WriteLine(this.textoHello);
    }
}

class Program
{
    static void Main()
    {
        System.Console.WriteLine("Hello, World!");

        Hello cumprimento = new Hello();
        cumprimento.textoHello = "Olá, usuário!";

        cumprimento.SaldarUsuario();

        string nome = "Eduardo Costa";
        System.Console.WriteLine($"Bem-vindo, {nome}!");
    }
}
