using System;
using System.Collections.Generic;
using System.Text;

namespace Secao_14.Entites
{
    class CardRental
    {

        public  DateTime Start { get; set; }
        public  DateTime Finish { get; set; }
        public Vehice Vehice { get; set; }
        public Invoice Invoice { get; set; }

        public CardRental(DateTime start, DateTime finish, Vehice vehice)
        {
            Start = start;
            Finish = finish;
            Vehice = vehice;
        }
    }
}
