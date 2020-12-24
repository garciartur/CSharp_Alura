namespace _01_RacoonBank
{
    public class CheckingAccount
    {
        public BankClient AccountHolder { get; set; }
        public int BankBranch { get; set; }
        public int AccountNumber { get; set; }
        public static int CheckingAccountQty { get; private set; }
        private double _accountBalance = 100;

        public CheckingAccount(int accountNumber, int bankBranch)
        {
            this.AccountNumber = accountNumber;
            this.BankBranch = bankBranch;
            CheckingAccountQty++;
        }


        public double AccountBalance
        {
            get
            {
                return _accountBalance;
            }
            
            set
            {
                if (value < 0) return;
                _accountBalance = value;
            }
                
        }

        public double GetAccountBalance()
        {
            return _accountBalance;
        }

        public bool ToWithdraw(double amount)
        {
            if (this._accountBalance < amount) return false;
            else
            {
                this._accountBalance -= amount;
                return true;
            }
        }

        public void ToDeposit(double amount)
        {
            this._accountBalance += amount;
        }

        public bool ToTransfer(double amount, CheckingAccount destinationAccount)
        {
            if (this._accountBalance < amount) return false;
            else
            {
                this._accountBalance -= amount;
                destinationAccount.ToDeposit(amount);
                return true;
            }
        }

    }
}
