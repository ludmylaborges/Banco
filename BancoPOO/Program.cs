using System;
using BancoPOO.Service;

namespace BancoPOO
{
    class Program
    {
        static void Main(string[] args)
        {
          
            Console.WriteLine("Digite seu nome: " + "\n");
            var nome = Console.ReadLine();
            Console.WriteLine(" ..:: Selecione uma opção ::..");
            Console.WriteLine();
            Console.WriteLine("1 - Acessar conta corrente");
            Console.WriteLine("2 - Acessar conta investimento");
            var opcaoconta = Console.ReadKey();

            switch (opcaoconta.KeyChar)
            {
                case '1':

                    Console.WriteLine(" ..:: Selecione uma opção ::..");
                    Console.WriteLine();
                    Console.WriteLine("1 - Sacar");
                    Console.WriteLine("2 - Depositar");
                    Console.WriteLine("3 - Transferir");
                    var opcao = Console.ReadKey();
                    Console.WriteLine();

                    switch (opcao.KeyChar)
                    {
                        case '1':
                            new ContaCorrenteService().OperacaoSaque();
                            break;

                        case '2':
                            new ContaCorrenteService().OperacaoDeposito();
                            break;

                        case '3':
                            new ContaCorrenteService().OperacaoTransferencia();
                            break;
                    }
                    break;

                case '2':

                    Console.WriteLine(" ..:: Selecione uma opção ::..");
                    Console.WriteLine();
                    Console.WriteLine("1 - Sacar");
                    Console.WriteLine("2 - Depositar");
                    Console.WriteLine("3 - Transferir");
                    var opcao2 = Console.ReadKey();
                    Console.WriteLine();

                    switch (opcao2.KeyChar)
                    {
                        case '1':
                            new ContaInvestimentoService().OperacaoSaque();
                            break;

                        case '2':
                            new ContaInvestimentoService().OperacaoDeposito();
                            break;

                        case '3':
                            new ContaInvestimentoService().OperacaoTransferencia();
                            break;
                    }
                    break;
            }

         }
    }
}
