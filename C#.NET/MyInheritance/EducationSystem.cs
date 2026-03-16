using System;
using System.Collections.Generic;
using System.Text;

namespace MyInheritance
{
    internal class EducationSystem
    {
        static void Main()
        {
            Student[] students = new Student[]
           {
                new SchoolStudent { StudentId = 1, Name = "Alice", Marks = 45 },
                new CollegeStudent { StudentId = 2, Name = "Bob", Marks = 55 },
                new OnlineStudent { StudentId = 3, Name = "Charlie", Marks = 65 }
           };

            foreach (var student in students)
            {
                //Console.Write($"{student.Name} ({student.GetType().Name}) - Marks: {student.Marks} -> ");
                Console.WriteLine("Student Name: "+student.Name +""+"Student Marks: "+student.Marks);
                student.CalculateGrade(student.Marks);
            }

        }
    }
}

public class Student
{
    public int StudentId { get; set; }
    public string Name { get; set; }
    public int Marks { get; set; }

    public virtual void CalculateGrade(int Marks)
    {
        if (Marks > 50)
        {
            Console.WriteLine("Pass");
        }
        else
        {
            Console.WriteLine("Fail");
        }
    }
}

public class SchoolStudent : Student
{
    public override void CalculateGrade(int Marks)
    {
        if (Marks > 40)
        {
            Console.WriteLine("Pass");
        }
        else
        {
            Console.WriteLine("Fail");
        }
    }
}

public class CollegeStudent : Student
{
    public override void CalculateGrade(int Marks)
    {
        if (Marks > 50)
        {
            Console.WriteLine("Pass");
        }
        else
        {
            Console.WriteLine("Fail");
        }
    }
}

public class OnlineStudent : Student
{
    public override void CalculateGrade(int Marks)
    {
        if (Marks > 60)
        {
            Console.WriteLine("Pass");
        }
        else
        {
            Console.WriteLine("Fail");
        }
    }
}

