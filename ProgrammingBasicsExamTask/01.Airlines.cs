using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.BabaTincheAirlines
{
    class Airlines
    {
        static void Main(string[] args)
        {
            int[] firstClass = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] businessClass = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] economyClass = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();


            double firstClassIncome = ((firstClass[0]-firstClass[1])*7000) + 
                                       (firstClass[1]*2100) + (firstClass[2]*35);

            double businessClassIncome = ((businessClass[0] - businessClass[1]) * 3500) +
                                       (businessClass[1] * 1050) + (businessClass[2] * 17.5);

            double economyClassIncome = ((economyClass[0] - economyClass[1]) * 1000) +
                                       (economyClass[1] * 300) + (economyClass[2] * 5);

            double totalIncome = firstClassIncome + businessClassIncome + economyClassIncome;
            double roundTotal = Math.Floor(totalIncome);


            int income = Convert.ToInt32(roundTotal);
            int maxIncome = 233160;

            int diff = maxIncome - income;

            Console.WriteLine(income);
            Console.WriteLine(diff);


            //int income = Convert.ToInt32(totalIncome);
            //int maxIncome = 233160;
            //Console.WriteLine(income);
            //int diff = maxIncome - income;
            //Console.WriteLine(diff);

        }
    }
}
