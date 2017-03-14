using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    class SavingsAccount : Account
    {
        // Fields
        private int savingsAccountNo;
        private decimal savingsAccountBalance;
        
        // Properties
        public int SavingsAccountNo
        {
            get { return this.savingsAccountNo; }
            set { this.savingsAccountNo = value; }
        }
        public decimal SavingsAccountBalance
        {
            get { return this.savingsAccountBalance; }
            set { this.savingsAccountBalance = value; }
        }
        
        // Constructors
        public SavingsAccount()
        {
        }

        public SavingsAccount(int accountNo, decimal accountBalance) : base(accountNo, accountBalance)
        {
            this.savingsAccountNo = 0003567;
            this.savingsAccountBalance = 4120.55m;
        }

        // Methods
        public override decimal Deposit(decimal dollars)
        {
            this.savingsAccountBalance = savingsAccountBalance += dollars;
            return this.savingsAccountBalance;
        }
        public override decimal Withdrawal(decimal dollars)
        {
            this.savingsAccountBalance = savingsAccountBalance -= dollars;
            return this.savingsAccountBalance;
        }
        public override void AccountBalance()
        {
            Console.WriteLine(" Savings Account Balance: $ {0} ", SavingsAccountBalance);
        }
       
    }
}
