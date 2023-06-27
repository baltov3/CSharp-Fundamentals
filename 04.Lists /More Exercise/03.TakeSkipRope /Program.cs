using System;
using System.Collections.Generic;
using System.Text;

namespace P03.TakeSkipRope
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string message = Console.ReadLine();

            List<char> letters = new List<char>();
            List<int> numbers = new List<int>();
            
        
            foreach (char currChar in message)
            {
                if (char.IsDigit(currChar))
                {
                    numbers.Add(int.Parse(currChar.ToString()));
                }
                else
                {
                    letters.Add(currChar);
                }
            }

            List<int> takeList = new List<int>();
            List<int> skipList = new List<int>();

            
            for (int i = 0; i < numbers.Count; i++)
            {
                if (i % 2 == 0)
                {
                    takeList.Add(numbers[i]);
                }
                else
                {
                    skipList.Add(numbers[i]);
                }
            }

            StringBuilder resultMessage = new StringBuilder();
            int letterIndex = 0;

         
            for (int i = 0; i < takeList.Count; i++)
            {
                for (int j = 0; j < takeList[i]; j++)
                {
                    if (letterIndex >= 0 && letterIndex < letters.Count)
                    {
                        resultMessage.Append(letters[letterIndex]);
                    }

                    letterIndex++;
                }

                for (int j = 0; j < skipList[i]; j++)
                {
                    letterIndex++;
                }
            }

            Console.WriteLine(resultMessage);
        }
    }
}
