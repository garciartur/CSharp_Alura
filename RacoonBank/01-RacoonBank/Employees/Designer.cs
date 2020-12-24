using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_RacoonBank.Employees
{
    public class Designer : Employee
    {
        public Designer(double empSalary, string empCPF) : base(empSalary, empCPF) { }

        public override void increaseSalary()
        {
            EmpSalary *= 1.11;
        }

        public override double GetBonus()
        {
            return EmpSalary * 0.17;
        }
    }
}
