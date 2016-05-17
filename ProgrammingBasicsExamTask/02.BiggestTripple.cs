using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiggestTripple
{
    class BiggestTripple
    {
        static void Main(string[] args)
        {
            int[] numberLine = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            //int[] numberLine = { 3, 7, 2, 8, 1, 4, 6, 9 };
            int leftOver = numberLine.Length % 3;
            int middleSum = Int32.MinValue;
            int biggestSum = Int32.MinValue;
            int finalSum = Int32.MinValue;
            int num1 = Int32.MinValue;
            int num2 = Int32.MinValue;
            int num3 = Int32.MinValue;

            for (int i = 0; i < numberLine.Length - leftOver; i+=3)
            {
                middleSum = numberLine[i] + numberLine[i + 1] + numberLine[i + 2];
                if (middleSum > biggestSum)
                {
                    biggestSum = middleSum;
                    num1 = numberLine[i];
                    num2 = numberLine[i + 1];
                    num3 = numberLine[i + 2];
                }                
            }

            finalSum = biggestSum;
            

            if (leftOver == 1 && numberLine[numberLine.Length-1] > biggestSum)
            {
                biggestSum = numberLine[numberLine.Length - 1];
                if (biggestSum == finalSum)
                {
                    Console.WriteLine("{0} {1} {2}", num1, num2, num3);
                }
                else
                {
                    num1 = numberLine[numberLine.Length - 1];
                    Console.WriteLine(num1);
                }               
            }
            else if (leftOver == 2 && ( numberLine[numberLine.Length - 1] + numberLine[numberLine.Length - 2]  ) > biggestSum)
            {
                biggestSum = (numberLine[numberLine.Length - 1] + numberLine[numberLine.Length - 2]);
                if (finalSum == biggestSum)
                {
                    Console.WriteLine("{0} {1} {2}", num1, num2, num3);
                }
                else
                {
                    num1 = numberLine[numberLine.Length - 2];
                    num2 = numberLine[numberLine.Length - 1];
                    Console.WriteLine("{0} {1}", num1, num2);
                }                
            }
            else
            {
                Console.WriteLine("{0} {1} {2}", num1, num2, num3);
            }


        }
    }
}
