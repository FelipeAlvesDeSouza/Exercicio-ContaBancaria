using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios
{
    public class ContaBancaria
    {
        public int NumeroConta { get; private set; }
        public string NomeTitularConta { get; set; }
        public double Saldo { get; private set; }

        public ContaBancaria()
        {

        }

        public ContaBancaria(int numeroConta, string nomeTitular)
        {
            NumeroConta = numeroConta;
            NomeTitularConta = nomeTitular;
        }

        public ContaBancaria(int numeroConta, string nomeTitular, double depositoInicial) : this(numeroConta, nomeTitular)
        {
            Deposito(depositoInicial);
        }


        public void Deposito(double deposito)
        {
            Saldo += deposito;
        }

        public void Saque(double saque)
        {
            Saldo -= saque + 5;
        }

        public override string ToString()
        {
            return $"Conta: {NumeroConta}, Titular: {NomeTitularConta}, Saldo: $ {Saldo.ToString("F2")}";
        }
    }
}
