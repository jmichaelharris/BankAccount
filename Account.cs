using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    class Account
    {
        // Fields
        private string fullAccountHolderName;
        private string address;
        private string phoneNo;
        private string socialSecurityNo;
        private int accountNo;
        private decimal accountBalance;
        
        // Propeties
        public string FullAccountHolderName
        {
            get { return this.fullAccountHolderName; }
            set { this.fullAccountHolderName = value; }
        }
        public int AccountNo
        {
            get { return this.accountNo; }
            set { this.accountNo = value; }
        }
       
        // Constructors
        public Account()
        {
        }
        public Account(string address, string phoneNo, string socialSecurityNo)
        {
            this.address =  "123  Cedar Road, Cleveland, OH, 44101";
            this.phoneNo = "216-555-1234";
            this.socialSecurityNo = "123-45-6789"; 
        }
        public Account(int accountNo, decimal accountBalance)
        {
            this.accountNo = accountNo;
            this.accountBalance = accountBalance;
            
        }
        public Account(string accountHolderFirstName, string accountHolderLastName)
        {
            fullAccountHolderName = accountHolderFirstName + "  " + accountHolderLastName;
        }

        // Methods
        public void BankAccountInfo()
        {
            Console.WriteLine(" Customer Name: {0} ", fullAccountHolderName);
            Console.WriteLine(" Customer Address: {0} ", address);
            Console.WriteLine(" Customer Phone Number: {0} ", phoneNo);
            Console.WriteLine(" Customer Social Securty Number: {0} ", socialSecurityNo);
        }
        public virtual decimal Deposit(decimal dollars)
        {
            this.accountBalance = accountBalance += dollars;
            return accountBalance;
        }
        public virtual decimal Withdrawal(decimal dollars)
        {
            this.accountBalance = accountBalance -= dollars;
            return accountBalance;
        }
        public virtual void AccountBalance()
        {
            Console.WriteLine(" Account Balance: {0} ", accountBalance);
        }

    }
}
