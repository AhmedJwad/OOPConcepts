using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPConcepts.Logic
{
    public class SalaryEmployee:Employee
    {
        private decimal _salary;

        public decimal Salary
        {
            get => _salary;
            set=> _salary=ValidateSalary(value);
        }

        private decimal ValidateSalary(decimal value)
        {
            if(value > 1000000)
            {
                return value;
            }
            throw new ArgumentException("the salary is lower than minimuim salary");
        }

        public override decimal GetValueToPay()
        {
           return Salary;
        }

        public override string ToString()
        {
            return $"{base.ToString()}\n\t" +
                $" Salary.....{GetValueToPay(),15:C2}";
        }
    }
}

