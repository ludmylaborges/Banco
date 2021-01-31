using System;
using System.Collections.Generic;
using System.Text;
using BancoPOO.Model;

namespace BancoPOO.Service
{
   public class ContaCorrenteService
    {
        ContaCorrente origem = new ContaCorrente("Ludmyla", 1, 889, 500);
        ContaCorrente destino = new ContaCorrente("Michel", 2, 152, 200);

        public virtual void OperacaoSaque()
        {
            Console.WriteLine("Digite o valor que deseja sacar: " + "\n");
            var valor = double.Parse(Console.ReadLine());
            Sacar(valor, origem.Saldo);
        }

        public virtual void OperacaoDeposito()
        {
            Console.WriteLine("Digite o valor que deseja depositar: " + "\n");
            var valor = double.Parse(Console.ReadLine());
            Depositar(valor, origem.Saldo);
        }

        public virtual void OperacaoTransferencia()
        {
            Console.WriteLine("Digite o valor que deseja transferir: " + "\n");
            var valor = double.Parse(Console.ReadLine());
            Transferir(valor, origem.Saldo, destino);
        }

        private double Sacar(double valor, double saldo)
        {
            if (saldo < valor)
            {
                Console.WriteLine("Não foi possível concluir a transação. Seu saldo é inferior ao valor do saque!");
            }
            else
            {
                saldo -= valor;
                Console.WriteLine("Operação realizada com sucesso!");
                return saldo;
            }
                return saldo;
        }

        private double Depositar(double valor, double saldo)
        {
            saldo += valor;
            Console.WriteLine("Operação realizada com sucesso!");
            return saldo;
        }

        private void Transferir(double valor, double saldo, ContaCorrente contaDestino)
        {

            if (origem.Saldo < valor)
            {
                Console.WriteLine("Não foi possível concluir a transação. Seu saldo é inferior ao valor que deseja transferir!");
            }
            else
            {
                origem.Saldo -= valor;
                contaDestino.Saldo = Depositar(valor, contaDestino.Saldo);
            }

        }

    }
}
