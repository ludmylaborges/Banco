using System;
using System.Collections.Generic;
using System.Text;

namespace BancoPOO.Model
{
    public class ContaInvestimento : ContaCorrente
    {
        public string CodigoInvestidor { get; set; }

        public ContaInvestimento(string titular, int agencia, int numero, double saldo, string CodigoInvestidor) : base(titular, agencia, numero, saldo)
        {

        }
    }
}
