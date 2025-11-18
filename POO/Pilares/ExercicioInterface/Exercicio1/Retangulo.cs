
using Exercicio1;

namespace Exercicio01
{
    public class Retangulo : IForma
    {
        public float Altura;
        public float Largura;
        public void caucularArea()
        {
             Console.WriteLine($"A area do retangulo é:{Largura * Altura}");
        }
    }
}