namespace _01_RacoonBank
{
    public class CheckingAccount
    {
        public BankClient AccountHolder { get; set; }
        public int BankBranch { get; set; }
        public int AccountNumber { get; set; }
        public static int CheckingAccountQty { get; private set; }
        public double AccountBalance { get; private set; }

        public CheckingAccount(int accountNumber, int bankBranch)
        {
            this.AccountNumber = accountNumber;
            this.BankBranch = bankBranch;
            CheckingAccountQty++;
            AccountBalance = 100;
        }


        public double SetAccountBalance
        {
            set
            {
                if (value < 0) return;
                AccountBalance = value;
            }               
        }

        public bool Withdraw(double amount)
        {
            if (this.AccountBalance < amount) return false;
            else
            {
                this.AccountBalance -= amount;
                return true;
            }
        }

        public void Deposit(double amount)
        {
            this.AccountBalance += amount;
        }

        public bool Transfer(double amount, CheckingAccount destinationAccount)
        {
            if (this.AccountBalance < amount) return false;
            else
            {
                this.AccountBalance -= amount;
                destinationAccount.Deposit(amount);
                return true;
            }
        }

    }
}
