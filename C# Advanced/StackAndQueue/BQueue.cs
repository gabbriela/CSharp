using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.BasicQueue
{
    class BQueue
    {
        static void Main(string[] args)
        {
            int[] commands = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int[] inputLine = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            Queue<int> numbers = new Queue<int>();

            for (int i = 0; i < commands[0]; i++)
            {
                numbers.Enqueue(inputLine[i]);
            }

            for (int i = 0; i < commands[1]; i++)
            {
                numbers.Dequeue();
            }

            bool contains = numbers.Contains(commands[2]);

            if (contains)
            {
                Console.WriteLine("true");
            }
            else if (numbers.Count != 0)
            {
                int minNumber = int.MaxValue;

                foreach (int num in numbers)
                {
                    int compare = num;
                    if (compare < minNumber)
                    {
                        minNumber = num;
                    }   
                }

                Console.WriteLine(minNumber);
            }
            else
            {
                Console.WriteLine("0");
            }


        }
    }
}
