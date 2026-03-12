using System;
using System.Collections.Generic;
using System.Text;

namespace ClassAssignment
{
    internal class Nurse
    {
        // Auto-implemented properties
        public int NurseId { get; set; }
        public string NurseName { get; set;  }
        public string Department { get; set; }

        public void Display()
        {
            Console.WriteLine("Nurse ID: " + NurseId);
            Console.WriteLine("Nurse Name: " + NurseName);
            Console.WriteLine("Department: " + Department);
        }

        static void Main()
        {
            Nurse n = new Nurse
            {
                NurseId = 1,
                NurseName = "Anitha",
                Department = "ICU"
            };

            n.Display();
        }
    }
}
