namespace InterfaceAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            //TCS
            TCS t = new TCS(101, "Mansoor", "Developer", "Junior", 50000);
            t.DisplayDetails();


            //Accenture
            Accenture a = new Accenture(102, "Mysore", "Testing", "Senior", 80000);
            a.DisplayDetails();

            





        }

        // Helper method to display details using interface


    }

    interface GovtRules
    {
        public double EmployeePF(double basicSalary);
        public string LeaVeDetails();
        public double gratuityAmount(float serviceCompleted, double basicSalary);

    }

    class TCS : GovtRules
    {

        public int empid;
        public string name;
        public string dept;
        public string desg;
        public double basicSalary;

        public TCS(int empid, string name, string dept, string desg, double basicSalary)
        {
            this.empid = empid;
            this.name = name;
            this.dept = dept;
            this.desg = desg;
            this.basicSalary = basicSalary;
        }

        public double EmployeePF(double basicSalary)
        {
            double pf = (basicSalary * 0.12);
            return pf;
        }

        public string LeaVeDetails()
        {
            return "1 day of Casual Leave per month, 12 days of Sick Leave per year, 10 days of Previlage Leave per year.";
        }

        public double gratuityAmount(float serviceCompleted, double basicSalary)
        {
            if (serviceCompleted > 20)
                return 3 * basicSalary;
            else if (serviceCompleted > 10)
                return 2 * basicSalary;
            else if (serviceCompleted > 5)
                return 1 * basicSalary;
            else
                return 0;
        }

        public void DisplayDetails()
        {
            Console.WriteLine("Company: TCS");
            Console.WriteLine("ID: " + empid + ", Name: " + name + ", Dept: " + dept + ", Desg: " + desg + ", Basic: " + basicSalary);
            Console.WriteLine("Employee PF: " + EmployeePF(basicSalary));
            Console.WriteLine("Leave Details: " + LeaVeDetails());
            //Console.WriteLine("Gratuity: " + gratuityAmount(serviceCompleted, basicSalary));
        }


    }


    class Accenture : GovtRules
    {
        public int empid;
        public string name;
        public string dept;
        public string desg;
        public double basicSalary;

        public Accenture(int empid, string name, string dept, string desg, double basicSalary)
        {
            this.empid = empid;
            this.name = name;
            this.dept = dept;
            this.desg = desg;
            this.basicSalary = basicSalary;
        }

        public double EmployeePF(double basicSalary)
        {
            return basicSalary * 0.12;
        }

        public string LeaVeDetails()
        {
            return "2 day of Casual Leave per month, 5 days of Sick Leave per year, 5 days of Previlage Leave per year";
        }

        public double gratuityAmount(float serviceCompleted, double basicSalary)
        {
            return 0;
        }

        public void DisplayDetails()
        {
            Console.WriteLine("Company: Accenture");
            Console.WriteLine("ID: " + empid + ", Name: " + name + ", Dept: " + dept + ", Desg: " + desg + ", Basic: " + basicSalary);
            Console.WriteLine("Employee PF: " + EmployeePF(basicSalary));
            Console.WriteLine("Leave Details: " + LeaVeDetails());
            //Console.WriteLine("Gratuity: " + gratuityAmount(serviceCompleted, basicSalary));
        }

    }
}
