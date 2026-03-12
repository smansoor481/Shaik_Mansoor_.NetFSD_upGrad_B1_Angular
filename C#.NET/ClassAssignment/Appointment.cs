using System;
using System.Collections.Generic;
using System.Text;

namespace ClassAssignment
{
    internal class Appointment
    {
        public int AppointmentId;
        public String PatientName;
        public String DoctorName;
        public DateOnly AppointmentDate;

        public Appointment()
        {
            DoctorName = "General Physician";
            AppointmentDate = new DateOnly(2026, 03, 12);
        }

        public void display()
        {
            Console.WriteLine("AppointId: "+AppointmentId);
            Console.WriteLine("PatientName: "+PatientName);
            Console.WriteLine("DoctorName: "+DoctorName);
            Console.WriteLine("AppointmentDate: "+ AppointmentDate);
        }

        static void Main()
        {
            Appointment a = new Appointment();
            a.AppointmentId = 101;
            a.PatientName = "Mufasa";
            a.display();
        }
    }
}
