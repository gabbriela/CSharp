using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.Basic
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] commands = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            //Pop
            int[] inputLine = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            Stack<int> numbers = new Stack<int>();

            for (int i = 0; i < inputLine.Length; i++)
            {
                numbers.Push(inputLine[i]);
            }

            //Pop
            for (int i = 0; i < commands[1]; i++)
            {
                numbers.Pop();
            }

            //Contains
            if (numbers.Contains(commands[2]))
            {
                Console.WriteLine("true");
            }
            else if (numbers.Count != 0)
            {
                int smallestelement = int.MaxValue;

                foreach (int num in numbers)
                {
                    if (num < smallestelement)
                    {
                        smallestelement = num;
                    }
                }

                Console.WriteLine(smallestelement);
            }
            else
            {
                Console.WriteLine("0");
            }

        }
    }
}
