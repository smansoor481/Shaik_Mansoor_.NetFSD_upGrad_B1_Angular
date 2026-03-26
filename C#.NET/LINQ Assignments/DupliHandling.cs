using System;
using System.Collections.Generic;
using System.Text;

namespace LINQ_Assignments
{
    internal class DupliHandling
    {
        static void Main()
        {
            List<int> numbers = new List<int> { 1, 2, 3, 2, 4, 5, 3, 6 };

            var res1 = numbers.ToHashSet();
            foreach (var item in res1)
            {
                Console.WriteLine(item);
            }


        }
    }
}

//1.Remove duplicates
//2. Find duplicate values
//3. Count occurrence of each number