using _01_RacoonBank.Systems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_RacoonBank.Employees
{
    public class Director : Authenticable
    {
        public Director(double empSalary, string empCPF) : base(empSalary, empCPF) { }

        public override void increaseSalary()
        {
            EmpSalary *= 1.15;
        }

        public override double GetBonus()
        {
            return EmpSalary;
        }


    }
}
