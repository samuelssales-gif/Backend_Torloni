using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MetodoConstrutor
{
    public class Pessoa3Sobrecargas
    {
        public string Nome;
        public int Idade;

        //metodo contrutor de pessoa, possuindo parametros
        /*possui parametros - representam os valores de nome e idade
        ou seja, estamos inicializando valores para as props nome e idade*/
        public Pessoa3Sobrecargas()
        {
            Nome = "Desconhecido";
            Idade = 0;
        }
        public Pessoa3Sobrecargas(string n)
        {
            Nome = n;
            Idade = 0;
        }
        public Pessoa3Sobrecargas(string n, int i)
        {
            Nome = n;
            Idade = i;
        }
        public void ExibirDados()
        {
            Console.WriteLine($"Nome: {Nome}, Idade: {Idade}");
        }
    }
}