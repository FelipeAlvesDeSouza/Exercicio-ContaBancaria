using System;
using System.Globalization;

namespace Exercicios
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaBancaria conta;
            Console.WriteLine("Bem vindo ao Banco !!!");
            Console.WriteLine("Vamos criar uma conta!");

            Console.Write("Digite o numero da conta que deseja criar: ");
            int numeroConta = int.Parse(Console.ReadLine());


            Console.Write("Digite o nome do titular da conta que deseja criar: ");
            string nomeTitular = Console.ReadLine();


            Console.Write("Digite Sim ou Nao se deseja fazer depósito inicial: ");
            string opcao = Console.ReadLine();


            if (opcao == "Sim")
            
            {
                Console.Write("Digite o valor: ");
                double depositoInicial = double.Parse(Console.ReadLine());
                conta = new ContaBancaria(numeroConta , nomeTitular, depositoInicial);
            }
            else
            {
                conta = new ContaBancaria(numeroConta, nomeTitular);
            }
            
            Console.WriteLine(conta);

            Console.Write("Coloque o valor para depositar em conta: ");
            double deposito = double.Parse(Console.ReadLine());
            conta.Deposito(deposito);

            Console.WriteLine($"Informações atualizadas após o depósito: {conta}");


            Console.Write("Coloque o valor para saque em conta: ");
            double saque = double.Parse(Console.ReadLine());
            conta.Saque(saque);
            
            Console.WriteLine($"Informações atualizadas após o saque: {conta}");
            
        }

    }
}
