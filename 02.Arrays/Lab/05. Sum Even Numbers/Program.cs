using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int sum = 0;
            foreach (var item in numbers)
            {
                if (item%2==0)
                {
                    sum+=item;

                }

            }
            
            Console.WriteLine(sum);

           
           
        }
    }
}
