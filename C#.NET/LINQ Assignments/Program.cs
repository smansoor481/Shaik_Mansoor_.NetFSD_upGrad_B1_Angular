using System.Xml.Linq;

namespace LINQ_Assignments
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            List<Student> st = new List<Student>()
            {
                new Student(1, "Mansoor", 22, 90),
                new Student(2, "Navya", 18, 75),
                new Student(3,"Mahesh", 45, 89),
                new Student(4, "Swathi", 23, 90),
                new Student(5,"Bindu", 19, 88),
                new Student(6,"Isha", 19, 74)

            };

            var res = from a in st
                      where a.marks > 75
                      select a;

            //Console.WriteLine(string.Join(", ", res));
            foreach (var item in res)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            //Get students whose age is between 18 and 25
            var res2 = from a in st
                       where a.age >=18 && a.age<25
                       select a;
            foreach (var item in res2)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();
            //Sort students by Marks(descending)
            var res3 = st.OrderByDescending(a => a.marks);
            Console.WriteLine(string.Join(",",res3));

            //Select only Name and Marks
            var res4 = st.Select(a => new {a.name, a.marks});
            Console.WriteLine(string.Join(",", res4));



        }
    }

    class Student
    {
        public int id { get; set; }
        public string name { get; set; }
        public int age {  get; set; }
        public int marks{  get; set; }

        public Student(int id,  string name, int age, int marks)
        {
            this.id = id;
            this.name = name;
            this.age = age;
            this.marks = marks;
        }

        public override string ToString()
        {
            return $"ID: {id}, Name: {name}, Marks: {marks}";
        }
    }
}
