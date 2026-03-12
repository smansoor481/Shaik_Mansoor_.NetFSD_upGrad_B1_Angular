using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace ClassAssignment
{
    internal class Doctor
    {
        public int DoctorID;
        public String DoctorName;
        public String specilization;
        public double ConsultationFee;

        public void Display()
        {
            Console.WriteLine("Doctor ID: " + DoctorID);
            Console.WriteLine("Doctor Name: " + DoctorName);
            Console.WriteLine("Specialization: " + specilization);
            Console.WriteLine("Consultation Fee: " + ConsultationFee);
            Console.WriteLine();
        }
        static void Main()
        {
            Doctor d = new Doctor();
            d.DoctorID = 101;
            d.DoctorName = "Mansoor";
            d.specilization = "MBBS";
            d.ConsultationFee = 100;

            Doctor d2 = new Doctor();
            d2.DoctorID = 102;
            d2.DoctorName = "Munaf";
            d2.specilization = "RMP";
            d2.ConsultationFee = 1000;

            d.Display();
            d2.Display();

            
        }
    }

    
}
