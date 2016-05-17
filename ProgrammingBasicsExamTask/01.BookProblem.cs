using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.BookProblem
{
    class BookProblem
    {
        static void Main(string[] args)
        {

            double pages = double.Parse(Console.ReadLine());
            double campingDays = double.Parse(Console.ReadLine());
            double pagesInNormalDay = double.Parse(Console.ReadLine());

            if (campingDays == 30 || pagesInNormalDay == 0)
            {
                Console.WriteLine("never");
            }
            else
            {
                double neededDays = pages / pagesInNormalDay;
                double readingDays = 30 - campingDays;

                double neededMonths = neededDays / readingDays;
                double round = Math.Ceiling(neededMonths);
                double neededYears = round / 12;

                double leftMonths = neededMonths % 12;
                double roundMonths = Math.Ceiling(leftMonths);

                int finalYears = Convert.ToInt32(neededYears);
                int finalMonths = Convert.ToInt32(roundMonths);

                Console.WriteLine("{0} years {1} months", finalYears, finalMonths);



            //int pages = Int32.Parse(Console.ReadLine());
            //int campingDays = Int32.Parse(Console.ReadLine());
            //int pagesInNormalDay = Int32.Parse(Console.ReadLine());

            //if (campingDays == 30 || pagesInNormalDay == 0)
            //{
            //    Console.WriteLine("never");
            //}
            //else
            //{
            //    int neededDays = pages / pagesInNormalDay;
            //    int readingDays = 30 - campingDays;

            //    double neededMonths = neededDays / readingDays;
            //    double roundn = Math.Ceiling(neededMonths);
            //    int roundINT = Convert.ToInt32(roundn);
            //    int neededYears = roundINT / 12;

            //    double leftMonths = neededMonths % 12;
            //    double roundMonths = Math.Ceiling(leftMonths);
            //    int finalMonths = Convert.ToInt32(roundMonths);

            //    Console.WriteLine("{0} years {1} months", neededYears, finalMonths);
            }

        }
    }
}
