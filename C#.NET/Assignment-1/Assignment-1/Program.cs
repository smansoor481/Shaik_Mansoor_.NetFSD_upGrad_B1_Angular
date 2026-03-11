using System.ComponentModel;

namespace Assignment_1
{
    internal class Program
    {
        //Write an algorithm for accepting two numbers divide the first number by second and display their quotient.
        static void Main(string[] args)
        {
            Console.WriteLine("Enter FirstNumber");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter SecondNumber");
            int num2 = Convert.ToInt32(Console.ReadLine());


            int res = num1 / num2;
            Console.WriteLine("The res of num1 and num2 is: " + res);

        }
    }
}
