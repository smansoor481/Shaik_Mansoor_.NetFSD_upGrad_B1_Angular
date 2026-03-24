using LINQ_Assignments;
using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace LINQ_Assignments
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Department { get; set; }
        public double salary { get; set; }


    }
    internal class EmployeeMang
    {
        static void Main()
        {
            List<Employee> emp = new List<Employee>()
             {
                 new Employee { Id = 1,Name="Swathi", Department="ECE", salary=45000 },
                 new Employee { Id = 2,Name="Maruthi", Department="IT", salary=23000 },
                 new Employee { Id = 3,Name="Bindu", Department="ECE", salary=56000 },
                 new Employee { Id = 4,Name="Isha", Department="Mech", salary=78000 }
             };

            var res1 = emp.Where(n => n.Department=="IT").ToList();
            foreach (var e in res1)
            {
                Console.WriteLine($"{e.Id}, {e.Name}, {e.Department}, {e.salary}");
            }

            //var maxSalary = emp.Max(e => e.salary);
            //var highest = emp.First(e => e.salary == maxSalary);
            var highest = emp.OrderByDescending(e => e.salary).First();

            Console.WriteLine($"{highest.Name} : {highest.salary}");


            var res2 = emp.Average(n => n.salary);
            Console.WriteLine("Average: "+res2);

            var res3 = emp.GroupBy(n => n.Department);
            foreach (var group in res3)
            {
                Console.WriteLine("Department: " + group.Key);

                foreach (var e in group)
                {
                    Console.WriteLine($"{e.Name} - {e.salary}");
                }
            }
            var res = emp.GroupBy(e => e.Department)
                         .Select(g => new { g.Key, Count = g.Count() });

            foreach (var item in res)
            {
                Console.WriteLine($"{item.Key} - {item.Count}");
            }


        }
    }
}
//1.Get employees from "IT" department
//2. Get highest salary employee
//3. Get average salary
//4. Group employees by Department
//5. Count employees in each department

