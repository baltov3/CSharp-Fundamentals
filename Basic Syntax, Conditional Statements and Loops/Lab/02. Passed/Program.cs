using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
           
            double grade = double.Parse(Console.ReadLine());
            if (grade>=3.00)
            {
                Console.WriteLine("Passed!");
            }
        }
    }
}
