using System;
using System.Collections.Generic;
using System.Text;

namespace ClassAssignment
{
    internal class PatientRecord
    {
        public int PatientId;
        public string PatientName;
        public int Age;
        public string Disease;
        public static string HospitalName;


        public PatientRecord(int patientId, string patientName, int age, string disease)
        {
            PatientId = patientId;
            PatientName = patientName;
            Age = age;
            Disease = disease;
        }

        public void DisplayPatientRecord()
        {
            Console.WriteLine("PatientId: "+ PatientId);
            Console.WriteLine("PatientName: " + PatientName);
            Console.WriteLine("Age: " + Age);
            Console.WriteLine("Disease: " + Disease);
            Console.WriteLine("HospitalName: " + HospitalName);
        }

        static void Main()
        {
            PatientRecord.HospitalName = "KIMS Hospital";
            PatientRecord p1 = new PatientRecord(101,"Subbu",45,"Diabets");
            PatientRecord p2 = new PatientRecord(102, "Mabbu", 67, "Kidneys");
            PatientRecord p3 = new PatientRecord(103, "Tippu", 89, "Cancer");

            p1.DisplayPatientRecord();
            p2.DisplayPatientRecord();
            p3.DisplayPatientRecord();
        }
    }
}
