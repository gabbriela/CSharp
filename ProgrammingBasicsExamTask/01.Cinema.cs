using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace _06.Cinema
{
    class Cinema
    {
        static void Main(string[] args)
        {
            System.Threading.Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            string projectionType = Console.ReadLine();
            double rows = double.Parse(Console.ReadLine());
            double cols = double.Parse(Console.ReadLine());
            double seats = rows * cols;

            if (projectionType == "Premiere")
            {
                double income = seats * 12.00;
                Console.WriteLine("{0:F2} leva", income);
            }
            else if (projectionType == "Normal")
            {
                double income = seats * 7.50;
                Console.WriteLine("{0:F2} leva", income);
            }
            else if (projectionType == "Discount")
            {
                double income = seats * 5.00;
                Console.WriteLine("{0:F2} leva", income);
            }
        }
    }
}
