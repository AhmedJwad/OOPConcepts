using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPConcepts.Logic
{
    public class HourlyEmployee : Employee
    {
        private float _workingHours;
        private decimal _hourValue;

        public float WorkingHours {
            get=> _workingHours;
            set=>_workingHours=ValidateworkingHours(value); 
        }
            
        public decimal HourValue { 
            get=> _hourValue;
            set=>_hourValue=Validatehourvalue(value); 
        }

        public override decimal GetValueToPay()
        {
            return (decimal)WorkingHours *  HourValue * 0.88m;
        }
        private float ValidateworkingHours(float value)
        {
            if(value < 0 || value >240)
            {
                throw new ArgumentException("the working hour is not valid");
            }
            return value;
        }
        private decimal Validatehourvalue(decimal value)
        {
            if(value < 30000)
            {
                throw new ArgumentException("the  hour is not valid");
            }
            return value;
        }
        public override string ToString()
        {
            return $"{base.ToString()}\n\t" +
                $" Working of Hours.....{WorkingHours,15:C2}\n\t" +
                 $" value of Hours.....{HourValue,15:C2}\n\t" +
                $"Value of Pay..........{GetValueToPay(), 15:C2}";
        }
    }
}
