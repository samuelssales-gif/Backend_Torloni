using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.WebSockets;
using System.Threading.Tasks;

namespace Encapsulamento
{
    public class ContaBancaria
    {
        private float Saldo;

        public ContaBancaria()
        {
            Saldo = 0;
        }

        public ContaBancaria(float SaldoInicial)
        {
            if (SaldoInicial > 0)
            {
                Saldo = SaldoInicial;
            }
        }

        public void Depositar(float valor)
        {
            if (valor >= 0)
            {
                Saldo += valor;
                return;
            }
        }

        public void Sacar(float valor)
        {
            if (valor < 0 || valor > Saldo)
            {
                Console.WriteLine("Saldo insuficiente ou valor invalido para sacar");
                return;
            }
            else
            {
                Saldo -= valor;
            }
        }

        public float GetSaldo()
        {
            return Saldo;
        }
    }
}
