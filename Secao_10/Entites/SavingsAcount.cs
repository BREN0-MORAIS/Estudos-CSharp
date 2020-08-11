using System;
using System.Collections.Generic;
using System.Text;

namespace Secao_10.Entites
{
    //Sealed -> define que não pode ser Herdada 
   sealed class SavingsAcount : Acount
    {
        public double InteresRate { get; set; }
        public SavingsAcount()
        {

        }
        public SavingsAcount(int number, int holder, double balance, double interesRate) : base(number, holder, balance)
        {
            InteresRate = interesRate;

        }

        public void UpdateBalance()
        {
            Balance += Balance * InteresRate;
        }
    }
}
