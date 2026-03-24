using System;
using System.Collections.Generic;
using System.Text;

namespace LINQ_Assignments
{
    internal class NumCollection
    {
        static void Main()
        {
            List<int> numbers = new List<int> { 5, 10, 15, 20, 25, 30 };

            var res1 = numbers.Where(n => n % 2 == 0);
            Console.WriteLine(string.Join(",",res1));

            var res2 = numbers.Where(n => n > 15);
            Console.WriteLine(string.Join(",", res2));

            var res3 = numbers.Select(n => n * n);
            Console.WriteLine(string.Join(",", res3));

            var res4 = numbers.Where(n => n % 3 == 0).Count();
            Console.WriteLine("Count: "+res4);

        }
    }
}
//1.Get even numbers
//2.Get numbers greater than 15
//3. Find square of each number
//4. Count how many numbers are divisible by 5