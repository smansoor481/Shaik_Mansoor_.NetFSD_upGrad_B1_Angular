using System;
using System.Collections.Generic;
using System.Text;

namespace ClassAssignment
{
    internal class MedicalTest
    {
        public int TestId;
        public String TestName;
        public int TestCost;

        public MedicalTest(int TestId, String TestName, int TestCost)
        {
            this.TestId = TestId;
            this.TestName = TestName;
            this.TestCost = TestCost;
        }

        public void display()
        {
            Console.WriteLine("TestId: " + TestId);
            Console.WriteLine("TestName: "+ TestName);
            Console.WriteLine("TestCost: " + TestCost);
        }

        static void Main()
        {
            MedicalTest m = new MedicalTest(101, "Blood Test", 500);
            MedicalTest m2 = new MedicalTest(102, "X-Ray", 5000);

            m.display();
            m2.display();
        }
    }
}
