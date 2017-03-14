using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace BankAccount
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of each Account / Instantiate Accounts
            CheckingAccount Checking = new CheckingAccount();
            ReserveAccount Reserve = new ReserveAccount();
            SavingsAccount Savings = new SavingsAccount();

            //  Instantiate StreamWriter for each account & to write to a file
            StreamWriter wChecking = new StreamWriter("CheckingAccount.txt");
            StreamWriter wReserve = new StreamWriter("ReserveAccount.txt");
            StreamWriter wSavings = new StreamWriter("SavingsAccount.txt");

            Console.WriteLine("Welcome to My Bank Account");
            Console.WriteLine("Type your First Name");
            string accountHolderFirstName = Console.ReadLine();
            Console.WriteLine("Type your Last Name");
            string accountHolderLastName = Console.ReadLine();
            string fullAccountHolderName = string.Concat(accountHolderFirstName, "  ", accountHolderLastName);

            {   // do-while loop
                int usersNumber = 0;
                do
                {
                    Console.WriteLine(" View Customer Information: choose 1 ");
                    Console.WriteLine(" View Checking Account Balance: choose 2 ");
                    Console.WriteLine(" View Reserve Account Balance: choose 3 ");
                    Console.WriteLine(" View Savings Account Balance: choose 4 ");
                    Console.WriteLine(" Make a Deposit into an Account: choose 5 ");
                    Console.WriteLine(" Make a Withdrawal from an Account: choose 6 ");
                    Console.WriteLine(" QUIT / EXIT Bank Account Program: choose 7 ");
                    Console.WriteLine(" TYPE your choice as a number 1, 2, 3, 4, 5, 6, or 7 ");
                    string usersResponse = Console.ReadLine();
                    usersNumber = Convert.ToInt32(usersResponse);

                    switch (usersNumber)
                    {
                        case 1:
                            Checking.BankAccountInfo();
                            break;

                        case 2:
                            Checking.AccountBalance();
                            break;

                        case 3:
                            Reserve.AccountBalance();
                            break;

                        case 4:
                            Savings.AccountBalance();
                            break;

                        case 5:
                            Console.WriteLine(" Which Account would you like to make a Deposit ");
                            Console.WriteLine(" Checking Account (Deposit): choose 1 ");
                            Console.WriteLine(" Reserve Account (Deposit): choose 2 ");
                            Console.WriteLine(" Savings Account (Deposit): choose 3 ");
                            int userChoice = Convert.ToInt32(Console.ReadLine());
                            
                            Console.WriteLine("How Much would you like to Deposit");
                            decimal deposit = Convert.ToDecimal(Console.ReadLine());
                            switch (userChoice)
                            {
                                case 1:
                                   Checking.Deposit(deposit);
                                    Console.WriteLine(" Checking Account New Balance: ${0} ", Checking.CheckingAccountBalance);
                                    using (wChecking)
                                    { 
                                        wChecking.WriteLine(fullAccountHolderName);
                                        wChecking.WriteLine(" Checking Account No.: {0} ",Checking.CheckingAccountNo);
                                        wChecking.WriteLine(DateTime.Now);
                                        wChecking.WriteLine(" + :$ {0}",deposit);
                                        wChecking.WriteLine(" Checking Account New Balance: {0} ", Checking.CheckingAccountBalance);
                                    }
                                   break;

                                case 2:
                                    Reserve.Deposit(deposit);
                                    Console.WriteLine(" Reserve Account New Balance: ${0} ", Reserve.ReserveAccountBalance);
                                    using (wReserve)
                                    {
                                        wReserve.WriteLine(fullAccountHolderName);
                                        wReserve.WriteLine(" Reserve Account No.: {0} ", Reserve.ReserveAccountNo);
                                        wReserve.WriteLine(DateTime.Now);
                                        wReserve.WriteLine(" + :$ {0}", deposit);
                                        wReserve.WriteLine(" Reserve Account New Balance: ${0} ", Reserve.ReserveAccountBalance);
                                    }
                                    break;

                                case 3:
                                    Savings.Deposit(deposit);
                                    Console.WriteLine(" Savings Account New Balance: ${0} ", Savings.SavingsAccountBalance);
                                    using (wSavings)
                                    {
                                        wSavings.WriteLine(fullAccountHolderName);
                                        wSavings.WriteLine(" Reserve Account No.: {0} ", Savings.SavingsAccountNo);
                                        wSavings.WriteLine(DateTime.Now);
                                        wSavings.WriteLine(" + :$ {0}", deposit);
                                        wSavings.WriteLine(" Savings Account New Balance: ${0} ", Savings.SavingsAccountBalance);
                                    }
                                    break;

                                default:

                                    Console.WriteLine(" Invalid selection ");
                                    Console.WriteLine(" Please choose Deposit option 1, 2, or, 3 ");
                                    break;

                            }
                            break;
                        case 6:
                            Console.WriteLine(" Which Account would you like to make a Withdrawal from ");
                            Console.WriteLine(" Checking Account (Withdrawal): choose 1 ");
                            Console.WriteLine(" Reserve Account (Withdrawal): choose 2 ");
                            Console.WriteLine(" Savings Account (Withdrawal): choose 3 ");
                            int userOption = Convert.ToInt32(Console.ReadLine());

                            Console.WriteLine("How Much would you like to Withdraw");
                            decimal withdrawal = Convert.ToDecimal(Console.ReadLine());
                            switch (userOption)
                            {
                                case 1:
                                    Checking.Withdrawal(withdrawal);
                                    Console.WriteLine(" Check Account New Balance: ${0} ", Checking.CheckingAccountBalance);
                                    using (wChecking)
                                    {
                                        wChecking.WriteLine(fullAccountHolderName);
                                        wChecking.WriteLine(" Checking Account No.: {0} ", Checking.CheckingAccountNo);
                                        wChecking.WriteLine(DateTime.Now);
                                        wChecking.WriteLine(" - :$ {0}", withdrawal);
                                        wChecking.WriteLine(" Check Account New Balance: {0} ", Checking.CheckingAccountBalance);
                                    }
                                    break;

                                case 2:
                                    Reserve.Withdrawal(withdrawal);
                                    Console.WriteLine(" Reserve Account New Balance: ${0} ", Reserve.ReserveAccountBalance);
                                    using (wReserve)
                                    {
                                        wReserve.WriteLine(fullAccountHolderName);
                                        wReserve.WriteLine(" Reserve Account No.: {0} ", Reserve.ReserveAccountNo);
                                        wReserve.WriteLine(DateTime.Now);
                                        wReserve.WriteLine(" + :$ {0}", withdrawal);
                                        wReserve.WriteLine(" Reserve Account New Balance: ${0} ", Reserve.ReserveAccountBalance);
                                    }
                                    break;

                                case 3:
                                    Savings.Withdrawal(withdrawal);
                                    Console.WriteLine(" Savings Account New Balance: ${0} ", Savings.SavingsAccountBalance);
                                    using (wSavings)
                                    {
                                        wSavings.WriteLine(fullAccountHolderName);
                                        wSavings.WriteLine(" Savings Account No.: {0} ", Savings.SavingsAccountNo);
                                        wSavings.WriteLine(DateTime.Now);
                                        wSavings.WriteLine(" + :$ {0}", withdrawal);
                                        wSavings.WriteLine(" Savings Account New Balance: ${0} ", Savings.SavingsAccountBalance);
                                    }
                                    break;

                                default:

                                    Console.WriteLine(" Invalid selection ");
                                    Console.WriteLine(" Please choose Deposit option 1, 2, or, 3 ");
                                    break;

                            }
                            break;

                        case 7:
                            Console.WriteLine(" Thank you for using My Bank Account Program "); 
                            Console.WriteLine(" , use our program anytime ");
                            Environment.Exit(0);
                            break; 

                        default:
                            Console.WriteLine(" Invalid Selection ");
                            Console.WriteLine(" Please choose number 1, 2, 3, 4, 5, 6, or, 7 ");
                            break;
                    }

                }while (usersNumber != 7);
            } 
        }
    }
}

