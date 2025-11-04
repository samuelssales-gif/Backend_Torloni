using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContrutorMetodoContrutor
{
    public class Carro
    {
        public string Modelo = "";

        public string Marca = "";

        public int Ano;

        public Carro(String mo, string ma, int a)
        {
            Modelo = mo;
            Marca = ma;
            Ano = a;
        }
        public void exibirDados()
        {
            Console.WriteLine($"carro: {Marca} {Modelo}, Ano: {Ano}");
        }
    }


}