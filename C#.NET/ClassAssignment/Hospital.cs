using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ClassAssignment
{
    internal class Hospital
    {
        public static String HospitalName;
        public static String HospitalAddress;
        public String PatientName;


        public void display()
        {
            Console.WriteLine("Hospital Name: " + HospitalName);
            Console.WriteLine("Hospital Address: " + HospitalAddress);
            Console.WriteLine("Patient Name: " + PatientName);
            Console.WriteLine();
        }
        static void Main()
        {
            Hospital.HospitalName = "Applo";
            Hospital.HospitalAddress = "Hyderaded";


            Hospital h1 = new Hospital();
            Hospital h2 = new Hospital();
            Hospital h3 = new Hospital();

            h1.PatientName = "Madhu";
            h2.PatientName = "Mahesh";
            h3.PatientName = "pavan";
            h1.display();
            h2.display();
            h3.display();
        }
    }
}
