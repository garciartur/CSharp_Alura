using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_RacoonBank.Employees
{
    public class Assistant : Employee
    {
        public Assistant(double empSalary, string empCPF) : base(empSalary, empCPF) { }

        public override void increaseSalary()
        {
            EmpSalary *= 1.1;
        }

        public override double GetBonus()
        {
            return EmpSalary * 0.2;
        }
        
    }
}
