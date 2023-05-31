using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                int a = int.Parse(Console.ReadLine());
                if (a%2!=0)
                {
                    Console.WriteLine("Please write an even number.");
                }
                if (a%2==0)
                {
                    Console.WriteLine($"The number is: {Math.Abs(a)}");
                    break;
                }

            }
           
        }
    }
}
