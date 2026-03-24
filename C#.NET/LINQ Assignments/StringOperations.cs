using System;
using System.Collections.Generic;
using System.Text;

namespace LINQ_Assignments
{
    internal class StringOperations
    {
        static void Main()
        {
            List<string> names = new List<string> { "Ravi", "Kiran", "Amit", "Raj", "Anil" };

            var res1 = names.Where(n => n.StartsWith("A")).Select(n=>n);
            Console.WriteLine(string.Join(", ", res1));

            var res2 = names.OrderBy(n => n);
            //var res2 = names.OrderByDescending(n => n);
            Console.WriteLine(string.Join(", ", res2));


            var res3 = names.Select(n => n.ToUpper());
            Console.WriteLine(string.Join(", ", res3));

            //var res4 = names.Where(n => n.Length > 4);
            var res4 = from a in names
                       where a.Length > 4
                       select a;
            Console.WriteLine(string.Join(", ", res4));




        }
    }
}

//1.Get names starting with 'A'
//2. Sort names alphabetically
//3. Convert all names to uppercase
//4. Find names with length > 4

