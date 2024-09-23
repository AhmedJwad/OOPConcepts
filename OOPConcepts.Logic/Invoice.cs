using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPConcepts.Logic
{
    public class Invoice : Ipay
    {
        public int Id { get; set;}
        public string? Description { get; set; }
        public decimal  Price { get; set; }

        public float Quantity { get; set; }
        public decimal GetValuetoPay()
        {
            return Price * (decimal)Quantity;
        }

        public override string ToString()
        {
            return $"{Id}\t{Description}\n\t Quantity.........{Quantity}\t\n" +
                $"Price.......{Price}/n/t" +
                $"Value to Pay ........{GetValuetoPay()}";
        }
    }
}
