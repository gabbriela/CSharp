using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.BeerCounter
{
    class Beers
    {
        public static int beerInStock = 0;
        public static int beerDrankCount = 0;

        public static void BuyBeers(int bottlesCount)
        {
            beerInStock += bottlesCount;
        }

        public static void DrinkBeer(int bottlesCount)
        {
            beerInStock -= bottlesCount;
            if (beerInStock < 0)
            {
                bottlesCount -= (beerInStock*-1);
                beerInStock = 0;
            }
            beerDrankCount += bottlesCount;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            string[] beers = Console.ReadLine().Split(' ');

            while (beers[0] != "End")
            {
                int beersForStock = int.Parse(beers[0]);
                int beersForDrink = int.Parse(beers[1]);

                Beers.BuyBeers(beersForStock);
                Beers.DrinkBeer(beersForDrink);

                beers = Console.ReadLine().Split(' ');
            }

            Console.WriteLine($"{Beers.beerInStock} {Beers.beerDrankCount}");
        }
    }
}
