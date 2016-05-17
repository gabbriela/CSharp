using System;

namespace Boat
{
    class Boat
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            char dot = '.';
            char asterisk = '*';

            string boat = "";
            int asteriskCount = 1;
            int dotsCount = n - 1;
            for (int i = 1; i <= n/2 + 1; i++)
            {
                boat = new string(dot, dotsCount) + new string(asterisk, asteriskCount) + new string(dot, n);
                Console.WriteLine(boat);
                asteriskCount += 2;
                dotsCount -= 2;
            }

            asteriskCount -= 4;
            dotsCount = 2;
            for (int i = 1; i <= n / 2; i++)
            {
                boat = new string(dot, dotsCount) + new string(asterisk, asteriskCount) + new string(dot, n);
                Console.WriteLine(boat);
                asteriskCount -= 2;
                dotsCount += 2;
            }
            for (int i = 0; i < (n-1) / 2; i++)
            {
                boat = new string(dot, i) + new string(asterisk, n*2 - i*2) + new string(dot, i);
                Console.WriteLine(boat);
            }

        }
    }
}
