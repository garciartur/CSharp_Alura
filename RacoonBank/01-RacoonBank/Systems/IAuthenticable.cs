using _01_RacoonBank.Employees;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_RacoonBank.Systems
{
    public abstract class Authenticable : Employee
    {
        public string Password { get; set; }

        public Authenticable(double empSalary, string empCPF) : base(empSalary, empCPF) { }

        public bool Authenticate(string password)
        {
            return Password == password;
        }

    }
}
