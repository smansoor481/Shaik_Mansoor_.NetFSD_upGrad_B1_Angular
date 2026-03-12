namespace ClassAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            Patient p = new Patient();
            p.PatientID = 101;
            p.PatientName = "Ravi Kumar";
            p.Age = 45;
            p.Disease = "Diabets";

            p.display();
        }
    }

    class Patient
    {
        public int PatientID;
        public string PatientName;
        public int Age;
        public String Disease;

        public void display()
        {
            Console.WriteLine("Patient Id: " + PatientID);
            Console.WriteLine("Patient Name: " + PatientName);
            Console.WriteLine("Age: " + Age);
            Console.WriteLine("Disease: " + Disease);
        }
    }
}
