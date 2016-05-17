using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace _08.Electricity
{
    class Electricity
    {
        static void Main(string[] args)
        {

            
            System.Threading.Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            int floors = Int32.Parse(Console.ReadLine());
            int flats = Int32.Parse(Console.ReadLine());
            TimeSpan timeOfDay = TimeSpan.Parse(Console.ReadLine());

            int allFlats = floors * flats;
            
            TimeSpan a = System.TimeSpan.Parse("14:00");
            TimeSpan b = System.TimeSpan.Parse("18:59");
            TimeSpan c = System.TimeSpan.Parse("19:00");
            TimeSpan d = System.TimeSpan.Parse("23:59");
            TimeSpan e = System.TimeSpan.Parse("00:00");
            TimeSpan f = System.TimeSpan.Parse("08:59");

            double lampConsuming = 100.53;
            double computerConsuming = 125.90;

            if (timeOfDay >= a && b >= timeOfDay)
            {
                //•	From 14:00 to 18:59  2 lamps + 2 computers are running
                double powerForFlat = 2 * lampConsuming + 2 * computerConsuming;
                double notRoundElectricity = allFlats * powerForFlat;
                double electricity = Math.Floor(notRoundElectricity);
                Console.WriteLine("{0} Watts", electricity);
            }
            else if (timeOfDay >= c && d >= timeOfDay)
            {
                //•	From 19:00 to 23:59  7 lamps + 6 computers are running 
                double powerForFlat = 7 * lampConsuming + 6 * computerConsuming;
                double notRoundElectricity = allFlats * powerForFlat;
                double electricity = Math.Floor(notRoundElectricity);
                Console.WriteLine("{0} Watts", electricity);
            }
            else if (timeOfDay >= e && f >= timeOfDay)
            {
                //•	From 00:00 to 08:59  1 lamp + 8 computers are running
                double powerForFlat = 1 * lampConsuming + 8 * computerConsuming;
                double notRoundElectricity = allFlats * powerForFlat;
                double electricity = Math.Floor(notRoundElectricity);
                Console.WriteLine("{0} Watts", electricity);
            }
            else
            {
                Console.WriteLine("0 Watts");
            }
            
        }
    }
}
