using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] items = Console.ReadLine().Split();
            Array.Reverse(items);
            Console.WriteLine(string.Join(" ",items));
           
           
        }
    }
}
