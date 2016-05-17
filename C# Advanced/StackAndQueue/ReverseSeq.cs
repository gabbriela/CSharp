using System;
using System.Collections.Generic;
using System.Linq;


namespace _01.Reverse
{
    class ReverseSeq
    {
        static void Main(string[] args)
        {
            //int[] inputLine = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            string[] inputLine = Console.ReadLine().Trim().Split(' ').ToArray();

            Stack<int> numbers = new Stack<int>();

            for (int i = 0; i < inputLine.Length; i++)
			{
                numbers.Push(int.Parse(inputLine[i]));
			}

            int count = numbers.Count;

            //Console.WriteLine(string.Join(" ", numbers));
            //Console.WriteLine(numbers.Count);

            for (int i = 0; i < count; i++)
            {
                int toPrint = numbers.Pop();

                Console.Write(toPrint);

                if (i != count - 1)
                {
                    Console.Write(" ");
                }
            }

            Console.WriteLine();

        }
    }
}
