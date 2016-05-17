using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Beers
{
    class Beers
    {
        static void Main(string[] args)
        {

            int quantity = 0;
            string measure = "";
            int singleBeers = 0;

            while (true)
            {
               
                string[] input = Console.ReadLine().Split(' ').ToArray();

                bool endCheck = Array.Exists(input, element => element == "End");
                if (endCheck)
                {
                    break;
                }

                quantity = Convert.ToInt32(input[0]);
                measure = input[1];

                if (measure == "stacks")
                {
                    quantity *= 20;
                }

                singleBeers += quantity;
            }

            int stacks = singleBeers / 20;
            int beers = singleBeers % 20;

            Console.WriteLine("{0} stacks + {1} beers", stacks, beers);

        }
    }
}
