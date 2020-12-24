using _01_RacoonBank.Employees;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_RacoonBank.Systems
{
    public class InternalSystem
    {
        public bool Login(Authenticable authenticable, string password)
        {
            bool authenticatedUser = authenticable.Authenticate(password);

            if(authenticatedUser)
            {
                Console.WriteLine("Welcome to the Raccon Bank System!");
                return true;
            }
            else
            {
                Console.WriteLine("Wrong password!");
                return false;
            }
        }
    }
}
