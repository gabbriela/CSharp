using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.Melons_and_Watermelons
{
    class Melons
    {
        static void Main(string[] args)
        {
            int startDay = Int32.Parse(Console.ReadLine());
            int daysEnd = Int32.Parse(Console.ReadLine());

            int melonsCount = 0;
            int waterMelonsCount = 0;
          
            //1 Watermelon
            //2 Melons  
            //1 Watermelon and 1 Melon
            //2 Watermelons
            //2 Watermelons and 2 Melons
            //1 Watermelon and 2 Melons
            //Didko takes a break

            int[] watermelon = { 0, 1, 0, 1, 2, 2, 1, 0};
            int[] melons = {0, 0, 2, 1, 0, 2, 2, 0};

            for (int i = 0; i < daysEnd; i++)
            {
                if (startDay >= watermelon.Length)
                {
                    startDay = 1;
                }
                    waterMelonsCount += watermelon[startDay];
                    melonsCount += melons[startDay];
                    startDay++;
            }

            if (melonsCount == waterMelonsCount)
            {
                Console.WriteLine("Equal amount: {0}", melonsCount);
            }
            if (melonsCount > waterMelonsCount)
            {
                Console.WriteLine("{0} more melons", melonsCount - waterMelonsCount);
            }
            if (melonsCount < waterMelonsCount)
            {
                Console.WriteLine("{0} more watermelons", waterMelonsCount - melonsCount);
            }
        }
    }
}
