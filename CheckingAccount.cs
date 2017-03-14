using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    class CheckingAccount : Account
    {
        // Fields
        private int checkingAccountNo;
        private decimal checkingAccountBalance;
      
        // Properties
        public int CheckingAccountNo
        {
            get { return this.checkingAccountNo; }
            set { this.checkingAccountNo = value; }
        }
        public decimal CheckingAccountBalance
        {
            get { return this.checkingAccountBalance; }
            set { this.checkingAccountBalance = value; }
        }
        
        // Constructors
        public CheckingAccount() : base()
        {
        }
        public CheckingAccount(int accountNo, decimal accountBalance) : base(accountNo, accountBalance)
        {
           this.checkingAccountNo = 0007911;
           this.checkingAccountBalance = 5090.64m;
        }
        
        // Methods
        public override decimal Deposit(decimal dollars)
        {
            this.checkingAccountBalance = checkingAccountBalance += dollars;
            return this.checkingAccountBalance;
        }
        public override decimal Withdrawal(decimal dollars)
        {
            this.checkingAccountBalance = checkingAccountBalance -= dollars;
            return this.checkingAccountBalance;
        }
        public override void AccountBalance()
        {
            Console.WriteLine(" Checking Account Balance: $ {0} ", CheckingAccountBalance);
        }
        
    }
}
