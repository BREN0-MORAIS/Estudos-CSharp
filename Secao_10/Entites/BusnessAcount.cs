using System;
using System.Collections.Generic;
using System.Text;

namespace Secao_10.Entites
{
    class BusnessAcount : Acount
    {
        public double LoanLimit { get; set; }
        public BusnessAcount()
        {

        }

        //pode se chamar o construtor a super classe que é a classe que esta sendo herdada aproveitando o Costrutor 
        public BusnessAcount(int number, int holder, double balance, double loanLimit) : base(number, holder, balance)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
            LoanLimit = LoanLimit;
        }

        public void Loan()
        {


        }

    }
}
