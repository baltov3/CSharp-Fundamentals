using System;


namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                double sum = double.Parse(Console.ReadLine());
                double num = sum * 1.31;
                Console.WriteLine($"{num:f3}");
                }
        }
    }
}
