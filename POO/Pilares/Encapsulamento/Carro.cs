using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Encapsulamento
{
    public class Carro
    {
        private string marca;
        private string modelo;
        private int velocidadeAtual;

        public void DefinirMarca(string valor)
        {
            marca = valor;
        }
   public string ObterMarca()
        {
            return marca;
        }
    public void DefinirModelo(string valor)
        {
            modelo = valor;
        }
        public string Obtermodelo()
        {
            return modelo;
        }
    public int ObterVelocidade()
        {
            return velocidadeAtual;
        }

        public void Acelerar(int valor)
        {
            if (valor > 0)
            {
                velocidadeAtual += valor;
            }
        }

        public void frear(int valor)
        {
            if (valor < 0)
            {
                velocidadeAtual -= valor;
                if (velocidadeAtual < 0)
                {
                     velocidadeAtual = 0;
                }

            }
        }
        
    }
}