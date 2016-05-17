using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.PiggyBank
{
    class PiggyBank
    {
        static void Main(string[] args)
        {
            // 90 points


            double price = double.Parse(Console.ReadLine());
            double party = double.Parse(Console.ReadLine()); ;

            double saveDays = 30 - party;
            double savedMoney = saveDays * 2;
            double spendMoney = party * 5;
            double leftMoney = savedMoney - spendMoney;

            if (spendMoney > savedMoney)
            {
                Console.WriteLine("never");
            }
            else
            {
                double neededMonths = price / leftMoney;
                double neededYears = Math.Floor(neededMonths / 12);
                double leftMonths = neededMonths - (neededYears * 12);

                int years = Convert.ToInt32(Math.Floor(neededYears));
                int months = Convert.ToInt32(Math.Ceiling(leftMonths));

                Console.WriteLine("{0} years, {1} months", years, months);

            }
        }
    }
}
