using System;

namespace ExceptionsApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BankAccount acc = new BankAccount(101, "Mansoor", 1000);

            try
            {
                acc.Withdraw(600);
                acc.Display();
            }
            catch (CheckBalanceException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }

    class CheckBalanceException : Exception
    {
        public CheckBalanceException(string msg) : base(msg) { }
    }

    class BankAccount
    {
        public double AccountNumber;
        public string Name;
        public static double balance;

        public BankAccount(double accNo, string name, double bal)
        {
            AccountNumber = accNo;
            Name = name;
            balance = bal;
        }

        public void Withdraw(double amount)
        {
            if (balance - amount < 500)
            {
                throw new CheckBalanceException("Balance cannot go below 500");
            }
            else
            {
                balance -= amount;
            }
        }

        public void Deposit(double amount)
        {
            balance += amount;
        }

        public void Display()
        {
            Console.WriteLine(AccountNumber + " " + Name + " " + balance);
        }
    }
}