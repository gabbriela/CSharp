using System;
using System.Globalization;
using System.Linq;

namespace OddEvenElements
{
    class OddEvenElements
    {
        static void Main(string[] args)
        {

            System.Threading.Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            //        OddSum=…, OddMin=…, OddMax=…, EvenSum=…, EvenMin=…, EvenMax=…
            string[] inputLine = Console.ReadLine().Split(' ').ToArray();

            if (inputLine[0] == "")
            {
                Console.WriteLine("OddSum=No, OddMin=No, OddMax=No, EvenSum=No, EvenMin=No, EvenMax=No");
            }
            else
            {
                decimal oddSum = 0;
                decimal oddMin = decimal.MaxValue;
                decimal oddMax = decimal.MinValue;

                decimal evenSum = 0;
                decimal evenMin = decimal.MaxValue;
                decimal evenMax = decimal.MinValue;

                for (int i = 1; i <= inputLine.Length; i++)
                {
                    if (inputLine[i - 1] == "")
                    {
                        break;
                    }
                    decimal number = decimal.Parse(inputLine[i - 1]);
                    if (i % 2 != 0)
                    {
                        oddSum += number;
                        if (number > oddMax)
                        {
                            oddMax = number;
                        }
                        if (number < oddMin)
                        {
                            oddMin = number;
                        }
                    }

                    if (i % 2 == 0)
                    {
                        evenSum += number;
                        if (number > evenMax)
                        {
                            evenMax = number;
                        }
                        if (number < evenMin)
                        {
                            evenMin = number;
                        }
                    }
                }
                if (inputLine.Length == 1)
                {
                    Console.WriteLine("OddSum={0}, OddMin={1}, OddMax={2}, EvenSum=No, EvenMin=No, EvenMax=No",
                                                             (double)oddSum, (double)oddMin, (double)oddMax);
                }
                else
                {
                    Console.WriteLine("OddSum={0}, OddMin={1}, OddMax={2}, EvenSum={3}, EvenMin={4}, EvenMax={5}",
                                                             (double)oddSum, (double)oddMin, (double)oddMax,
                                                             (double)evenSum, (double)evenMin, (double)evenMax);
                }
            }
        }
    }
}
