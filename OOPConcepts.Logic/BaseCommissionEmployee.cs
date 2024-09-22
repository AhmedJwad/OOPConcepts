using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPConcepts.Logic
{
    public class BaseCommissionEmployee:CommissionEmployee
    {
        private decimal _salary;
        public decimal Salary { 
            get=> _salary;
            set=>_salary=ValidateSalary(value); 
        }
        public override decimal GetValueToPay()
        {
            return base.GetValueToPay() + Salary;
        }
        private decimal ValidateSalary(decimal value)
        {
            if(value > 300000)
            {
                return value;
            }
            throw new ArgumentException("the salary islower than minimuim salary");
        }
        public override string ToString()
        {
            return $"{base.ToString()}\n\t" +               
                 $" salary.....{Salary,15:C2}\n\t" +
                $"Value of salary..........{GetValueToPay(),15:C2}";
        }
    }
}
