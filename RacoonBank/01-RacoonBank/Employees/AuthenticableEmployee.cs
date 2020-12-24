using _01_RacoonBank.Systems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_RacoonBank.Employees
{
    public abstract class AuthenticableEmployee : Employee, IAuthenticable
    {
        public string Password { get; set; }

        public AuthenticableEmployee(double empSalary, string empCPF) : base(empSalary, empCPF) { }
        
        public bool Authenticate(string password)
        {
            return Password == password;
        }
    }
}
