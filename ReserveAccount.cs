using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    class ReserveAccount : Account
    {
        // Fields
        private int reserveAccountNo;
        private decimal reserveAccountBalance;

         // Properties
        public int ReserveAccountNo
        {
            get { return this.reserveAccountNo; }
            set { this.reserveAccountNo = value; }
        }
        public decimal ReserveAccountBalance
        {
            get { return this.reserveAccountBalance; }
            set { this.reserveAccountBalance = value; }
        }
        
        
        // Constructors
        public ReserveAccount()
        {
        }
        public ReserveAccount(int accountNo, decimal accountBalance) : base(accountNo, accountBalance)
        {
            this.reserveAccountNo = 0009924;
            this.reserveAccountBalance = 3000.00m;
        }

        // Methods
        public override decimal Deposit(decimal dollars)
        {
            this.reserveAccountBalance = reserveAccountBalance += dollars;
            return this.reserveAccountBalance;
        }
        public override decimal Withdrawal(decimal dollars)
        {
            this.reserveAccountBalance = reserveAccountBalance -= dollars;
            return this.reserveAccountBalance;
        }
        public override void AccountBalance()
        {
            Console.WriteLine(" Reserve Account Balance: $ {0} ", ReserveAccountBalance);
        }
       
    }
}
