using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPConcepts.Logic
{
    public class CommissionEmployee : Employee
    {

        private float _commissionPercentage;
        private decimal _sales;
        public float CommissionPercentage {
            get => _commissionPercentage;
            set=>_commissionPercentage= validatecommissionPercentage(value);
        }        

        public decimal Sales { 
            get => _sales;
            set=> _sales=ValidateSale(value);
        }
             

        public override decimal GetValueToPay()
        {
            return (decimal)CommissionPercentage * Sales;
        }

        private float validatecommissionPercentage(float value)
        {
            if(value > 0)
            {
                return value;
            }
           throw new ArgumentException("the commission of Percentage should be greate than zero ");
        }
        private decimal ValidateSale(decimal value)
        {
            if (value > 0)
            {
                return value;
            }
            throw new ArgumentException("the value should be postive number ");
        }
        
        public override string ToString()
        {
            return $"{base.ToString()}\n\t" +
                $" commercial percentage.....{CommissionPercentage, 15:C2}\n\t" +
                 $" Sales.....{Sales,15:C2}\n\t" +
                $"Value of Pay..........{GetValueToPay(),15:C2}";
        }
    }
}
