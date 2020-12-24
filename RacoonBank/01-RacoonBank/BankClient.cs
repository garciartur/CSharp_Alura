using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_RacoonBank
{
    public class BankClient
    {
        public string AccountHolder { get; set; }
        public string HolderProfession { get; set; }
        private string _holderCPF;

        public string HolderCPF
        {
            get
            {
                return _holderCPF;
            }

            set
            {
                _holderCPF = value;
            }
        }
    }
}
