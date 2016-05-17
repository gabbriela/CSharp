using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace _11.FruitMarket
{
    class FruitMarket
    {
        static void Main(string[] args)
        {
            System.Threading.Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            string day = Console.ReadLine();
            double q1 = double.Parse(Console.ReadLine());
            string p1 = Console.ReadLine();
            double q2 = double.Parse(Console.ReadLine());
            string p2 = Console.ReadLine();
            double q3 = double.Parse(Console.ReadLine());
            string p3 = Console.ReadLine();

            //•	banana  1.80
            //•	cucumber  2.75
            //•	tomato  3.20
            //•	orange  1.60
            //•	apple  0.86

            //•	Friday  10% off for all products
            if (day == "Friday")
            {
                if (p1 == "banana")
                {
                    q1 *= 1.80;
                }
                if (p1 == "cucumber")
                {
                    q1 *= 2.75;
                }
                if (p1 == "tomato")
                {
                    q1 *= 3.20;
                }
                if (p1 == "orange")
                {
                    q1 *= 1.60;
                }
                if (p1 == "apple")
                {
                    q1 *= 0.86;
                }

                //p2
                if (p2 == "banana")
                {
                    q2 *= 1.80;
                }
                if (p2 == "cucumber")
                {
                    q2 *= 2.75;
                }
                if (p2 == "tomato")
                {
                    q2 *= 3.20;
                }
                if (p2 == "orange")
                {
                    q2 *= 1.60;
                }
                if (p2 == "apple")
                {
                    q2 *= 0.86;
                }

                //p3
                if (p3 == "banana")
                {
                    q3 *= 1.80;
                }
                if (p3 == "cucumber")
                {
                    q3 *= 2.75;
                }
                if (p3 == "tomato")
                {
                    q3 *= 3.20;
                }
                if (p3 == "orange")
                {
                    q3 *= 1.60;
                }
                if (p3 == "apple")
                {
                    q3 *= 0.86;
                }
                double sum = q1 + q2 + q3;
                double finalSum = sum - (sum * 0.1);
                Console.WriteLine("{0:F2}",finalSum);
            }

  
            //•	Sunday  5% off for all products
            else if (day == "Sunday")
            {
                if (p1 == "banana")
                {
                    q1 *= 1.80;
                }
                if (p1 == "cucumber")
                {
                    q1 *= 2.75;
                }
                if (p1 == "tomato")
                {
                    q1 *= 3.20;
                }
                if (p1 == "orange")
                {
                    q1 *= 1.60;
                }
                if (p1 == "apple")
                {
                    q1 *= 0.86;
                }

                //p2
                if (p2 == "banana")
                {
                    q2 *= 1.80;
                }
                if (p2 == "cucumber")
                {
                    q2 *= 2.75;
                }
                if (p2 == "tomato")
                {
                    q2 *= 3.20;
                }
                if (p2 == "orange")
                {
                    q2 *= 1.60;
                }
                if (p2 == "apple")
                {
                    q2 *= 0.86;
                }

                //p3
                if (p3 == "banana")
                {
                    q3 *= 1.80;
                }
                if (p3 == "cucumber")
                {
                    q3 *= 2.75;
                }
                if (p3 == "tomato")
                {
                    q3 *= 3.20;
                }
                if (p3 == "orange")
                {
                    q3 *= 1.60;
                }
                if (p3 == "apple")
                {
                    q3 *= 0.86;
                }
                double sum = q1 + q2 + q3;
                double finalSum = sum - (sum * 0.05);
                Console.WriteLine("{0:F2}", finalSum);
            }
            
            //•	Tuesday  20% off for fruits
            else if (day == "Tuesday")
            {
                if (p1 == "banana")
                {
                    q1 *= 1.80;
                    q1 = q1 - (q1*0.2);
                }
                if (p1 == "cucumber")
                {
                    q1 *= 2.75;
                }
                if (p1 == "tomato")
                {
                    q1 *= 3.20;
                }
                if (p1 == "orange")
                {
                    q1 *= 1.60;
                    q1 = q1 - (q1 * 0.2);
                }
                if (p1 == "apple")
                {
                    q1 *= 0.86;
                    q1 = q1 - (q1 * 0.2);
                }

                //p2
                if (p2 == "banana")
                {
                    q2 *= 1.80;
                    q2 = q2 - (q2 * 0.2);
                }
                if (p2 == "cucumber")
                {
                    q2 *= 2.75;
                }
                if (p2 == "tomato")
                {
                    q2 *= 3.20;
                }
                if (p2 == "orange")
                {
                    q2 *= 1.60;
                    q2 = q2 - (q2 * 0.2);
                }
                if (p2 == "apple")
                {
                    q2 *= 0.86;
                    q2 = q2 - (q2 * 0.2);
                }

                //p3
                if (p3 == "banana")
                {
                    q3 *= 1.80;
                    q3 = q3 - (q3 * 0.2);
                }
                if (p3 == "cucumber")
                {
                    q3 *= 2.75;
                }
                if (p3 == "tomato")
                {
                    q3 *= 3.20;
                }
                if (p3 == "orange")
                {
                    q3 *= 1.60;
                    q3 = q3 - (q3 * 0.2);
                }
                if (p3 == "apple")
                {
                    q3 *= 0.86;
                    q3 = q3 - (q3 * 0.2);
                }
                double sum = q1 + q2 + q3;
                Console.WriteLine("{0:F2}", sum);
            }

            //•	Wednesday  10% off for vegetables
            else if (day == "Wednesday")
            {
                if (p1 == "banana")
                {
                    q1 *= 1.80;
                }
                if (p1 == "cucumber")
                {
                    q1 *= 2.75;
                    q1 = q1 - (q1 * 0.1);
                }
                if (p1 == "tomato")
                {
                    q1 *= 3.20;
                    q1 = q1 - (q1 * 0.1);
                }
                if (p1 == "orange")
                {
                    q1 *= 1.60;
                }
                if (p1 == "apple")
                {
                    q1 *= 0.86;
                }

                //p2
                if (p2 == "banana")
                {
                    q2 *= 1.80;
                }
                if (p2 == "cucumber")
                {
                    q2 *= 2.75;
                    q2 = q2 - (q2 * 0.1);
                }
                if (p2 == "tomato")
                {
                    q2 *= 3.20;
                    q2 = q2 - (q2 * 0.1);
                }
                if (p2 == "orange")
                {
                    q2 *= 1.60;
                }
                if (p2 == "apple")
                {
                    q2 *= 0.86;
                }

                //p3
                if (p3 == "banana")
                {
                    q3 *= 1.80;
                }
                if (p3 == "cucumber")
                {
                    q3 *= 2.75;
                    q3 = q3 - (q3 * 0.1);
                }
                if (p3 == "tomato")
                {
                    q3 *= 3.20;
                    q3 = q3 - (q3 * 0.1);
                }
                if (p3 == "orange")
                {
                    q3 *= 1.60;
                }
                if (p3 == "apple")
                {
                    q3 *= 0.86;
                }
                double sum = q1 + q2 + q3;
                Console.WriteLine("{0:F2}", sum);
            }

            //•	Thursday  30% off for bananas\
            else if (day == "Thursday")
            {
                if (p1 == "banana")
                {
                    q1 *= 1.80;
                    q1 = q1 - (q1*0.3);
                }
                if (p1 == "cucumber")
                {
                    q1 *= 2.75;
                }
                if (p1 == "tomato")
                {
                    q1 *= 3.20;
                }
                if (p1 == "orange")
                {
                    q1 *= 1.60;
                }
                if (p1 == "apple")
                {
                    q1 *= 0.86;
                }

                //p2
                if (p2 == "banana")
                {
                    q2 *= 1.80;
                    q2 = q2 - (q2 * 0.3);
                }
                if (p2 == "cucumber")
                {
                    q2 *= 2.75;
                }
                if (p2 == "tomato")
                {
                    q2 *= 3.20;
                }
                if (p2 == "orange")
                {
                    q2 *= 1.60;
                }
                if (p2 == "apple")
                {
                    q2 *= 0.86;
                }

                //p3
                if (p3 == "banana")
                {
                    q3 *= 1.80;
                    q3 = q3 - (q3 * 0.3);
                }
                if (p3 == "cucumber")
                {
                    q3 *= 2.75;
                }
                if (p3 == "tomato")
                {
                    q3 *= 3.20;
                }
                if (p3 == "orange")
                {
                    q3 *= 1.60;
                }
                if (p3 == "apple")
                {
                    q3 *= 0.86;
                }
                double sum = q1 + q2 + q3;
                Console.WriteLine("{0:F2}", sum);
            }
            else
            {
                if (p1 == "banana")
                {
                    q1 *= 1.80;
                }
                if (p1 == "cucumber")
                {
                    q1 *= 2.75;
                }
                if (p1 == "tomato")
                {
                    q1 *= 3.20;
                }
                if (p1 == "orange")
                {
                    q1 *= 1.60;
                }
                if (p1 == "apple")
                {
                    q1 *= 0.86;
                }

                //p2
                if (p2 == "banana")
                {
                    q2 *= 1.80;
                }
                if (p2 == "cucumber")
                {
                    q2 *= 2.75;
                }
                if (p2 == "tomato")
                {
                    q2 *= 3.20;
                }
                if (p2 == "orange")
                {
                    q2 *= 1.60;
                }
                if (p2 == "apple")
                {
                    q2 *= 0.86;
                }

                //p3
                if (p3 == "banana")
                {
                    q3 *= 1.80;
                }
                if (p3 == "cucumber")
                {
                    q3 *= 2.75;
                }
                if (p3 == "tomato")
                {
                    q3 *= 3.20;
                }
                if (p3 == "orange")
                {
                    q3 *= 1.60;
                }
                if (p3 == "apple")
                {
                    q3 *= 0.86;
                }
                double sum = q1 + q2 + q3;
                Console.WriteLine("{0:F2}",sum);
            }
        }
    }
}
