using System;
using System.Collections.Generic;
using System.Text;

namespace BancoPOO.Model
{
   public class ContaCorrente
    {
        public ContaCorrente(string titular, int agencia, int numero, double saldo)
        {
            Titular = titular;
            Agencia = agencia;
            Numero = numero;
            Saldo = saldo;
        }

        public string Titular { get; set; }
        public int Agencia { get; set; }
        public int Numero { get; set; }
        public double Saldo { get; set; }

    }
}
