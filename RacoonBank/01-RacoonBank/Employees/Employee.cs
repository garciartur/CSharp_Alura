using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _01_RacoonBank.Employees
{
    public abstract class Employee //As regras estão todas implementadas nos métodos das classes filhas, então a classe mãe pode ser abstrata
    {
        public static int EmployeeQty { get; private set; }
        public string EmpName { get; set; }
        public string EmpCPF { get; private set; }
        public double EmpSalary { get; protected set; } //Protected permite o acesso de classes filhas, mas se mantém private para classes fora da hierarquia 

        public Employee(double empSalary, string empCPF)
        {
            EmployeeQty++;
            EmpCPF = empCPF;
        }

        public abstract void increaseSalary();

        public abstract double GetBonus();
    }
}
