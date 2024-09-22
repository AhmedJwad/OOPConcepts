using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPConcepts.Logic
{
    public abstract class Employee
    {
        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public Date? BornDate { get; set; }
        public Date? HireDate { get; set; }

        public bool isActive { get; set; }

        public abstract decimal GetValueToPay();

        public override string ToString()
        {
            return $"{Id}- {FirstName}, {LastName} , Birth:{BornDate}" +
                $"hireDate:{HireDate}, isActive{isActive}";
        }

    }
}
