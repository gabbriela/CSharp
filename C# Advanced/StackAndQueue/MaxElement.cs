using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.MaximalElement
{
    class MaxElement
    {
        static void Main(string[] args)
        {
            int queries = int.Parse(Console.ReadLine());

            Stack<int> numbers = new Stack<int>();

            Stack<int> maxValues = new Stack<int>();

            int maxNumber = int.MinValue;

            for (int i = 0; i < queries; i++)
            {
                int[] inputLine = Console.ReadLine().Trim().Split(' ').Select(int.Parse).ToArray();

                if (inputLine[0] == 1)
                {
                    numbers.Push(inputLine[1]);
                    if (maxValues.Count == 0 || inputLine[1] >= maxNumber)
                    {
                        maxNumber = inputLine[1];
                    }
                }
                else if (inputLine[0] == 2 && numbers.Count != 0)
                {
                    int numberAtTop = numbers.Pop();

                    if (maxValues.Count != 0 && numberAtTop == maxValues.Peek())
                    {
                        maxValues.Pop();
                        maxNumber = int.MinValue;
                    }
                }
                else
                {
                    Console.WriteLine(maxValues.Peek());
                }
            }
        }
    }
}
