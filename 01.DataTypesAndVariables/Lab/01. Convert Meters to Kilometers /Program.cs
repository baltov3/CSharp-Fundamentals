using System;


namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                int metters = int.Parse(Console.ReadLine());
                float killometers = metters / 1000.0f;
                Console.WriteLine($"{killometers:F2}");
                }
        }
    }
}
