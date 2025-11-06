using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExerciciosMetodoConstrutor
{
    public class ContaBancaria
    {
        public string Titular;
        public double Saldo;
        public ContaBancaria(string titular, double saldoInicial = 0)
        {
            Titular = titular;
            Saldo = saldoInicial;
        }
        public void Depositar(double valor)
        {
            if (valor > 0)
            {
                Saldo += valor;
                Console.WriteLine($"Déposito no valor de R$ {valor:F2} realizado");
            }
            else
            {
                Console.WriteLine($"O valor depositado deve ser maior que 0.");
            }
        }
        public void Sacar(double valor)
        {
            if (valor > 0 && valor <= Saldo)
            {
                Saldo -= valor;
                Console.WriteLine($"Saque no valor de R$ {Saldo:F2} realizado");
            }
            else {}
        }
    }
    
}

public class ContaBancaria
{
    private double saldo; // dado protegido
    public double Saldo //propriedade
    {
        get { return saldo; }          // Permite ler o valor
        private set                   // Só pode ser alterado dentro da classe
        {
            if (value >= 0)            // Garante que o saldo nunca seja negativo
                saldo = value;
        }
    }
    public void Depositar(double valor)
    {
        if (valor > 0)
            saldo += valor;
    }

    public double ConsultarSaldo()
    {
        return saldo;
    }
}