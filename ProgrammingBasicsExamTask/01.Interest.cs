using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace _07.Compound_interest
{
    class Interest
    {
        static void Main(string[] args)
        {
            System.Threading.Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            double priseTV = double.Parse(Console.ReadLine());
            double termBank = double.Parse(Console.ReadLine());
            double bankInterest = double.Parse(Console.ReadLine());
            double friendInterest = double.Parse(Console.ReadLine());

            double bankLoan = priseTV * Math.Pow((1 + bankInterest), termBank);
            double friendLoan = priseTV * (1 + friendInterest);

            if (bankLoan > friendLoan)
            {
                Console.WriteLine("{0:F2} Friend", friendLoan);
            }
            else
            {
                Console.WriteLine("{0:F2} Bank", bankLoan);
            }
        }
    }
}
