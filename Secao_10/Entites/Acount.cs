using System;
using System.Collections.Generic;
using System.Text;

namespace Secao_10.Entites
{
    public class Acount
    {
        public int Number { get; protected set; }
        public int Holder { get; protected set; }
        public double Balance { get; protected set; }
        public Acount()
        {
            
        }
        public Acount(int number, int holder, double balance)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
        }
        public void WitchDraw(double amount)
        {
            Balance -= amount;

        }

        public void Deposit(double amount)
        {
            Balance += amount;
        }
    }
}
