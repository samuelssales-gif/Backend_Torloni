
namespace ClassesEObjetos
{
    public class Pessoa
    {
        public string Nome = "";

        public int Idade = 0;

        public void Falar()
        {
            Console.WriteLine($"ola, meu nome e {Nome}");
        }
        public int Envelhecer(int _anos)
        {
            if (_anos <= 0)
            {
                Console.WriteLine($"Idade tem que ser positiva");
                return Idade;
            }
            Idade += _anos;

            return Idade;
        }

    }

}