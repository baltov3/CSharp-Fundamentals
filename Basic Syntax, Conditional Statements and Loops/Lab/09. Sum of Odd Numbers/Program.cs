using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 1; i <= a*2; i++)
            {
                if (i%2!=0)
                {
                    Console.WriteLine(i);
                    sum += i;
                }
             }
            Console.WriteLine($"Sum: {sum}");
        }
    }
}
