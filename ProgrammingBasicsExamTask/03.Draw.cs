using System;

namespace DrawFigure
{
    class Draw
    {
        static void Main(string[] args)
        {
            int height = int.Parse(Console.ReadLine());
            char dot = '.';
            char asterisk = '*';
            string sandClock = "";

            for (int i = 0; i < (height / 2 + 1); i++)
            {
                sandClock = new string(dot, i) + new string(asterisk, height - (i * 2)) + new string(dot, i);
                Console.WriteLine(sandClock);
            }
            int asteriskCount = 3;
            for (int i = 1; i <= height/2; i++)
            {
                sandClock = new string(dot, (height-asteriskCount) / 2) + new string(asterisk, asteriskCount) + 
                            new string(dot, (height - asteriskCount)/ 2);
                Console.WriteLine(sandClock);
                asteriskCount += 2;
            }
        }
    }
}
