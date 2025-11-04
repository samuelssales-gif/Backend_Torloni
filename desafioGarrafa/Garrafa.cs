using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace desafioGarrafa
{
    public class Garrafa
    {
        public string marca;
        public string material;
        public string cor;
        public string capacidade;
        //metodos//
        public void Abrir()
        {
            Console.WriteLine("abrir a garrafa");
        }

        public void fechar()
        {
            Console.WriteLine("fechar a garrafa");
        }
    }
}