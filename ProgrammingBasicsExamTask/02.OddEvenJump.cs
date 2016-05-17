using System;

namespace OddAndEvenJump
{
    class OddEvenJump
    {
        static void Main(string[] args)
        {
            string inputLine = Console.ReadLine();
            int oddJump = Int32.Parse(Console.ReadLine());
            int evenJump = Int32.Parse(Console.ReadLine());

            string oddLine = "";
            string evenLine = "";

            int counterLetters = 0;
            int counterOddEven = 1;

            
            
            for (int i = 0; i < inputLine.Length; i++)
			{
                char letter = inputLine[counterLetters];
                if (letter != ' ')
                  {
                    if (counterOddEven % 2 != 0)
                    {
                        string convertLetter = Convert.ToString(inputLine[i]).ToLower();
                        oddLine += convertLetter;
                    }
                    else if (counterOddEven % 2 == 0)
                    {
                        string convertLetter = Convert.ToString(inputLine[i]).ToLower();
                        evenLine += convertLetter;
                    }
                    counterOddEven++;
                }
                counterLetters++;                
			}

            long oddSum = 0;
            long evenSum = 0;
            
            for (int i = 1; i <= oddLine.Length; i++)
            {
                int number = (int)oddLine[i-1];
                if (i % oddJump != 0)
                {
                    oddSum += number;
                }
                else if ( i % oddJump == 0)
                {
                    oddSum *= number;
                }                
            }

            for (int i = 1; i <= evenLine.Length; i++)
            {
                int number = (int)evenLine[i - 1];
                if (i % evenJump != 0)
                {
                    evenSum += number;
                }
                else if (i % evenJump == 0)
                {
                    evenSum *= number;
                }
            }

            Console.WriteLine("Odd: {0:X}", oddSum);
            Console.WriteLine("Even: {0:X}", evenSum);
            
        }
    }
}
