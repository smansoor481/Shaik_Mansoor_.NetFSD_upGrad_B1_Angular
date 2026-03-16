using System;
using System.Collections.Generic;
using System.Text;

namespace MyInheritance
{
    internal class BankSystem
    {
        static void Main()
        {
            Account acc = new SavingsAccount();
            acc.CalculateInterest();
        }
    }
}

public class Account
{
    public int AccountNumber;
    public int Balance;

    public void CalculateInterest()
    {
        Console.WriteLine("Base account interest calculation");
    }
}

public class SavingsAccount : Account
{
    public new void CalculateInterest()
    {
        Console.WriteLine("Base SavingsAccount interest calculation");
    }
}

public class CurrentAccount : Account
{
    public new void CalculateInterest()
    {
        Console.WriteLine("Base CalculateInterest interest calculation");
    }
}

