using _01_RacoonBank.Employees;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_RacoonBank.Systems
{
    public interface IAuthenticable
    {
        bool Authenticate(string password);
    }
}
