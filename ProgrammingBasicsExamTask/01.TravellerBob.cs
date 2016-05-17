using System;

namespace _19.TravellerBob
{
    class TravellerBob
    {
        static void Main(string[] args)
        {
            string year = Console.ReadLine();
            int contractMonth = Int32.Parse(Console.ReadLine());
            int familyMonth = Int32.Parse(Console.ReadLine());
            int normalMonth = 12 - contractMonth - familyMonth;

            int flyContract = ((3 * 4) * contractMonth);
            int flyFamily = (2 * 2) * familyMonth;
            double flyNormalDouble = normalMonth * 12;
            double flyNormal = flyNormalDouble * 0.6;
            double fly = flyContract + flyFamily + flyNormal;

            if (year == "leap")
            {
                double flyDouble = fly + (fly * 0.05);
                fly = Convert.ToInt32(Math.Floor(flyDouble));
                Console.WriteLine(fly);
            }
            else
            {
                fly = Convert.ToInt32(Math.Floor(fly));
                Console.WriteLine(fly);
            }
        }
    }
}
