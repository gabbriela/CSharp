using System;
using System.Globalization;

namespace BookOrder
{
    class BookOrder
    {
        static void Main(string[] args)
        {
            System.Threading.Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            int orders = Int32.Parse(Console.ReadLine());

            int allBooks = 0;
            decimal allPrice = 0m;

            for (int i = 0; i < orders; i++)
			{
                int packets = Int32.Parse(Console.ReadLine());
                int booksPerPack = Int32.Parse(Console.ReadLine());
                decimal price = decimal.Parse(Console.ReadLine());
                int currentBooks = booksPerPack * packets;
                allBooks += currentBooks;

                if (packets >= 10 && packets <= 19)
                {
                    price *= 0.95m;
                }
                else if (packets >= 20 && packets <= 29)
                {
                    price *= 0.94m;
                }
                else if (packets >= 30 && packets <= 39)
                {
                    price *= 0.93m;
                }
                else if (packets >= 40 && packets <= 49)
                {
                    price *= 0.92m;
                }
                else if (packets >= 50 && packets <= 59)
                {
                    price *= 0.91m;
                }
                else if (packets >= 60 && packets <= 69)
                {
                    price *= 0.90m;
                }
                else if (packets >= 70 && packets <= 79)
                {
                    price *= 0.89m;
                }
                else if (packets >= 80 && packets <= 89)
                {
                    price *= 0.88m;
                }
                else if (packets >= 90 && packets <= 99)
                {
                    price *= 0.87m;
                }
                else if (packets >= 100 && packets <= 109)
                {
                    price *= 0.86m;
                }
                else if (packets > 110)
                {
                    price *= 0.85m;
                }

                decimal currentPrice = currentBooks * price;
                allPrice += currentPrice;
                packets += packets;
			}
            Console.WriteLine(allBooks);
            Console.WriteLine("{0:F2}", allPrice);

            



            //if (allBooks < 10)
            //{
            //    Console.WriteLine(allPrice);
            //}
            //else if (allBooks > 110)
            //{
            //    allPrice = allPrice * 0.85;
            //}
            //else
            //{
            //    int position = allBooks / 10;
            //    while (position > 10)
            //    {
            //        position = allBooks / 10;
            //    }
            //    int discountPercent = (position - 2) + 5;
            //    double discPrice = allPrice * (1 - discountPercent / 10);
            //    Console.WriteLine("{0:F2}", discPrice);
            //}
            
            
            

            

        }
    }
}
