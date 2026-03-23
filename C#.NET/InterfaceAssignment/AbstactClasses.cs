using System;

namespace InterfaceAssignment
{
    public abstract class Sales
    {
        public abstract int CalculateMonthlySales();

        public int GetDailySales()
        {
            return 400;
        }
    }

    interface AnnualSales
    {
        int CalculateAnnualSales();
    }

    public class MainSales : Sales, AnnualSales
    {
        public override int CalculateMonthlySales()
        {
            return GetDailySales() * 30;
        }

        public int CalculateAnnualSales()
        {
            return CalculateMonthlySales() * 12;
        }
    }

    internal class AbstractClasses
    {
        static void Main(string[] args)
        {
            MainSales sales = new MainSales();

            Console.WriteLine("Daily sales: Rs." + sales.GetDailySales());
            Console.WriteLine("Monthly sales: Rs." + sales.CalculateMonthlySales());
            Console.WriteLine("Annual sales: Rs." + sales.CalculateAnnualSales());
        }
    }
}