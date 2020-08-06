using Secao_09.Entites.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace Secao_09.Entites
{
     class Order
    {
        public int Id { get; set; }
        public DateTime Moment { get; set; }
        public OrderStatus Status {get; set;}
    }
}
