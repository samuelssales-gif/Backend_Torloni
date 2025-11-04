using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Construtor
{
    public class Pessoa
    {
        public string Nome = "";

        public int Idade;


        //Metodo contrutor de pessoas, possuindo parametros 
        /*parametros representam valores para as suas respectivas props 
        ou seja, estamos inicializando valores para as props nome e idade*/
        public Pessoa(string n, int i)
        {
            Nome = n;
            Idade = i;
        }

        public void ExibirDados()
        {
            Console.WriteLine($"nome: {Nome}, idade: {Idade}");
        }
    }
}