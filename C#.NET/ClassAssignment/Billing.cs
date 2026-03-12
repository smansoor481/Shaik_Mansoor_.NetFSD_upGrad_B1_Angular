using System;
using System.Collections.Generic;
using System.Text;

namespace ClassAssignment
{
    internal class Billing
    {
        public string PatientName;
        public int ConsultationFee;
        public int TestCharges;

        public void CalculateTotalBill()
        {  
            int TotalBill = ConsultationFee + TestCharges;
            Console.WriteLine("PatientName: " + PatientName);
            Console.WriteLine("TotalBill: " + TotalBill);
        }

        static void Main()
        {
            Billing b = new Billing();
            b.PatientName = "Ramesh";
            b.ConsultationFee = 100;
            b.TestCharges = 1400;

            b.CalculateTotalBill();

        }
    }
}
