namespace MyInheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Doctor d = new Doctor();
            d.staffId = 1;
            d.Name = "Dr. Ravi";
            d.baseSalary = 50000;
            d.consulationFee = 10000;

            Nurse n = new Nurse();
            n.staffId = 2;
            n.Name = "Anita";
            n.baseSalary = 30000;
            n.NightShiftAllowance = 5000;

            LabTech l = new LabTech();
            l.staffId = 3;
            l.Name = "Rahul";
            l.baseSalary = 25000;
            l.EquipmentAllowance = 3000;


            Console.WriteLine("Doctor Salary: " + d.CalculateSalary());
            Console.WriteLine("Nurse Salary: " + n.CalculateSalary());
            Console.WriteLine("Lab Technician Salary: " + l.CalculateSalary());

        }
    }
}

public class Staff
{
    public int staffId;
    public string Name;
    public int baseSalary;

    public virtual int CalculateSalary()
    {
        return baseSalary;
    }
}
public class Doctor : Staff
{
    public int consulationFee;
    public override int CalculateSalary()
    {
        return baseSalary + consulationFee;
    }
}
public class Nurse : Staff
{
    public int NightShiftAllowance;
    public override int CalculateSalary()
    {
        return baseSalary + NightShiftAllowance;
    }
}
public class LabTech : Staff
{
    public int EquipmentAllowance;
    public override int CalculateSalary()
    {
        return baseSalary + EquipmentAllowance;
    }
}
