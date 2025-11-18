using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Exercicio2;

namespace Exercicio02
{
    public class Relatorio : IImprimivel
    {
        public string Nome;
        public string TextoRelatorio = "";
        public Relatorio(string Responsavel, string txtRelatorio)
        {
            Nome = Responsavel;
            TextoRelatorio = txtRelatorio;
        }
        public void Imprimir()
        {
            System.Console.WriteLine($"Responsavel:{Nome}...");
            System.Console.WriteLine(TextoRelatorio);
            System.Console.WriteLine($"--");
        } 
    }
}