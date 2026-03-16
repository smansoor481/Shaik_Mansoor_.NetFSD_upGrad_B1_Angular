using System;
using System.Collections.Generic;
using System.Text;

namespace MyInheritance
{
    internal class Asign6
    {
        static void Main()
        {
            furniture f;

            Console.WriteLine("Select Furniture Type");
            Console.WriteLine("1. Chair");
            Console.WriteLine("2. Cot");

            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    f = new Chair();
                    break;

                case 2:
                    f = new Cot();
                    break;

                default:
                    Console.WriteLine("Invalid Choice");
                    return;
            }

            f.GetData();
            f.ShowData();
        }
    }
}

// Base Class
public class furniture
{
    public int OrderId;
    public string OrderDate;
    public string FurnitureType;
    public int Qty;
    public double TotalAmt;
    public string PaymentMode;

    public virtual void GetData()
    {
        Console.Write("Enter Order Id: ");
        OrderId = int.Parse(Console.ReadLine());

        Console.Write("Enter Order Date: ");
        OrderDate = Console.ReadLine();

        Console.Write("Enter Quantity: ");
        Qty = int.Parse(Console.ReadLine());

        Console.WriteLine("Select Payment Mode");
        Console.WriteLine("1. Credit Card");
        Console.WriteLine("2. Debit Card");

        int p = int.Parse(Console.ReadLine());

        switch (p)
        {
            case 1:
                PaymentMode = "Credit Card";
                break;

            case 2:
                PaymentMode = "Debit Card";
                break;
        }
    }

    public virtual void ShowData()
    {
        Console.WriteLine("\nOrder Id: " + OrderId);
        Console.WriteLine("Order Date: " + OrderDate);
        Console.WriteLine("Quantity: " + Qty);
        Console.WriteLine("Payment Mode: " + PaymentMode);
        Console.WriteLine("Total Amount: " + TotalAmt);
    }
}

// Chair Class
public class Chair : furniture
{
    public string ChairType;
    public string Purpose;
    public string MaterialType;
    public double Rate;

    public override void GetData()
    {
        base.GetData();

        FurnitureType = "Chair";

        Console.WriteLine("Select Chair Type");
        Console.WriteLine("1. Wood");
        Console.WriteLine("2. Steel");
        Console.WriteLine("3. Plastic");

        int c = int.Parse(Console.ReadLine());

        switch (c)
        {
            case 1:
                ChairType = "Wood";
                Console.WriteLine("1. Teak Wood");
                Console.WriteLine("2. Rose Wood");
                int w = int.Parse(Console.ReadLine());
                MaterialType = w == 1 ? "Teak Wood" : "Rose Wood";
                break;

            case 2:
                ChairType = "Steel";
                Console.WriteLine("1. Gray Steel");
                Console.WriteLine("2. Green Steel");
                Console.WriteLine("3. Brown Steel");
                int s = int.Parse(Console.ReadLine());

                switch (s)
                {
                    case 1: MaterialType = "Gray Steel"; break;
                    case 2: MaterialType = "Green Steel"; break;
                    case 3: MaterialType = "Brown Steel"; break;
                }
                break;

            case 3:
                ChairType = "Plastic";
                Console.WriteLine("1. Green");
                Console.WriteLine("2. Red");
                Console.WriteLine("3. Blue");
                Console.WriteLine("4. White");
                int p = int.Parse(Console.ReadLine());

                switch (p)
                {
                    case 1: MaterialType = "Green"; break;
                    case 2: MaterialType = "Red"; break;
                    case 3: MaterialType = "Blue"; break;
                    case 4: MaterialType = "White"; break;
                }
                break;
        }

        Console.Write("Enter Purpose (Home/Office): ");
        Purpose = Console.ReadLine();

        Console.Write("Enter Rate: ");
        Rate = double.Parse(Console.ReadLine());

        TotalAmt = Rate * Qty;
    }

    public override void ShowData()
    {
        base.ShowData();

        Console.WriteLine("Furniture Type: " + FurnitureType);
        Console.WriteLine("Chair Type: " + ChairType);
        Console.WriteLine("Material: " + MaterialType);
        Console.WriteLine("Purpose: " + Purpose);
        Console.WriteLine("Rate: " + Rate);
    }
}

// Cot Class
public class Cot : furniture
{
    public string CotType;
    public string MaterialType;
    public string Capacity;
    public double Rate;

    public override void GetData()
    {
        base.GetData();

        FurnitureType = "Cot";

        Console.WriteLine("Select Cot Type");
        Console.WriteLine("1. Wood");
        Console.WriteLine("2. Steel");

        int c = int.Parse(Console.ReadLine());

        switch (c)
        {
            case 1:
                CotType = "Wood";
                Console.WriteLine("1. Teak Wood");
                Console.WriteLine("2. Rose Wood");
                int w = int.Parse(Console.ReadLine());
                MaterialType = w == 1 ? "Teak Wood" : "Rose Wood";
                break;

            case 2:
                CotType = "Steel";
                Console.WriteLine("1. Gray Steel");
                Console.WriteLine("2. Green Steel");
                Console.WriteLine("3. Brown Steel");
                int s = int.Parse(Console.ReadLine());

                switch (s)
                {
                    case 1: MaterialType = "Gray Steel"; break;
                    case 2: MaterialType = "Green Steel"; break;
                    case 3: MaterialType = "Brown Steel"; break;
                }
                break;
        }

        Console.WriteLine("Select Capacity");
        Console.WriteLine("1. Single");
        Console.WriteLine("2. Double");

        int cap = int.Parse(Console.ReadLine());

        Capacity = cap == 1 ? "Single" : "Double";

        Console.Write("Enter Rate: ");
        Rate = double.Parse(Console.ReadLine());

        TotalAmt = Rate * Qty;
    }

    public override void ShowData()
    {
        base.ShowData();

        Console.WriteLine("Furniture Type: " + FurnitureType);
        Console.WriteLine("Cot Type: " + CotType);
        Console.WriteLine("Material: " + MaterialType);
        Console.WriteLine("Capacity: " + Capacity);
        Console.WriteLine("Rate: " + Rate);
    }
}