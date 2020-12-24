using _01_RacoonBank.Systems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_RacoonBank
{
    public class CommercialPartner : IAuthenticable
    {
        public string Password { get; set; }
        public bool Authenticate(string password)
        {
            return Password == password;
        }
    }
}
