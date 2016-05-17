using System;
using System.Globalization;

namespace Hospitality
{
    public class Program
    {
        public static void Main(string[] args)
        {
            System.Threading.Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            long builders = long.Parse(Console.ReadLine());
            long receptionist = long.Parse(Console.ReadLine());
            long maid = long.Parse(Console.ReadLine());
            long techSupport = long.Parse(Console.ReadLine());
            long others = long.Parse(Console.ReadLine());
            decimal nikiSalary = decimal.Parse(Console.ReadLine());
            decimal usdRate = decimal.Parse(Console.ReadLine());
            decimal mySalary = decimal.Parse(Console.ReadLine());
            decimal budget = decimal.Parse(Console.ReadLine());

            decimal salaries = builders * 1500.04m + 
                              receptionist * 2102.10m +
                              maid * 1465.46m +
                              techSupport * 2053.33m + 
                              others * 3010.98m + 
                              nikiSalary * usdRate + mySalary;
            Console.WriteLine("The amount is: {0:F2} lv.", salaries);

            if (salaries < budget)
            {
                Console.WriteLine("YES \\ Left: {0:F2} lv.",(budget - salaries));
            }
            else if (salaries == budget)
            {
                Console.WriteLine("YES \\ Left: 0.00 lv.");
            }
            else if (salaries > budget)
            {
                Console.WriteLine("NO \\ Need more: {0:F2} lv.", (salaries - budget));
            }
        }
    }
}