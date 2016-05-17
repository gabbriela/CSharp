using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Budget
{
    class Budget
    {
        static void Main(string[] args)
        {

            int n = Int32.Parse(Console.ReadLine());
            int p = Int32.Parse(Console.ReadLine());
            int h = Int32.Parse(Console.ReadLine());

            int rent = 150;
            int weekendsSpends = ((4 - h) * 2) * 20;
            int weekDaysSpends = (22 - p) * 10;

            double goingOut = 0.03 * n;
            double goingOutFloor = Math.Floor(goingOut);
            int roundGoingOut = Convert.ToInt32(goingOutFloor);
            int goingOutSpends = (roundGoingOut + 10 ) * p;

            int totalSpends = rent + weekendsSpends + weekDaysSpends + goingOutSpends;

            if (n > totalSpends)
            {
                Console.WriteLine("Yes, leftover {0}.", n - totalSpends);
            }
            else if (n == totalSpends)
            {
                Console.WriteLine("Exact Budget.");
            }
            else if (n < totalSpends)
            {
                Console.WriteLine("No, not enough {0}.", totalSpends - n);
            }

        }
    }
}
