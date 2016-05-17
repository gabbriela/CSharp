using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.FitBox_in_Box
{
    class BoxInBox
    {
        static void Main(string[] args)
        {
            int w1 = Int32.Parse(Console.ReadLine());
            int h1 = Int32.Parse(Console.ReadLine());
            int d1 = Int32.Parse(Console.ReadLine());

            int w2 = Int32.Parse(Console.ReadLine());
            int h2 = Int32.Parse(Console.ReadLine());
            int d2 = Int32.Parse(Console.ReadLine());

            if (w1==0 && h1==0 && d1==0)
            {
                Console.WriteLine(); 
            }
            if (w2 == 0 && h2 == 0 && d2 == 0)
            {
                Console.WriteLine();
            }

            //w1 h1 d1 w2 h2 d2
            //w1 h1 d1 w2 d2 h2
            if (w1 < w2 )
            {
                if (h1 < h2 && d1 < d2)
                {
                    Console.WriteLine("({0}, {1}, {2}) < ({3}, {4}, {5})", w1, h1, d1, w2, h2, d2);
                }
                if (h1 < d2 && d1 < h2)
                {
                    Console.WriteLine("({0}, {1}, {2}) < ({3}, {4}, {5})", w1, h1, d1, w2, d2, h2);
                }  
            }

            //w1 h1 d1 d2 w2 h2
            //w1 h1 d1 d2 h2 w2
            if (w1 < d2)
            {
                if (h1 < w2 && d1 < h2)
                {
                    Console.WriteLine("({0}, {1}, {2}) < ({3}, {4}, {5})", w1, h1, d1, d2, w2, h2);
                }
                if (h1 < h2 && d1 < w2)
                {
                    Console.WriteLine("({0}, {1}, {2}) < ({3}, {4}, {5})", w1, h1, d1, d2, h2, w2);
                }
            }

            //w1 h1 d1     h2 w2 d2
            //w1 h1 d1     h2 d2 w2
            if (w1 < h2)
            {
                if (h1 < w2 && d1 < d2)
                {
                    Console.WriteLine("({0}, {1}, {2}) < ({3}, {4}, {5})", w1, h1, d1, h2, w2, d2);
                }
                if (h1 < d2 && d1 < w2)
                {
                    Console.WriteLine("({0}, {1}, {2}) < ({3}, {4}, {5})", w1, h1, d1, h2, d2, w2);
                }
            }


            //SecondBox

            // w2 h2 d2    w1 h1 d1
            // w2 h2 d2    w1 d1 h1
            if (w2 < w1)
            {
                if (h2 < h1 && d2 < d1)
                {
                    Console.WriteLine("({0}, {1}, {2}) < ({3}, {4}, {5})", w2, h2, d2, w1, h1, d1);
                }
                if (h2 < d1 && d2 < h1)
                {
                    Console.WriteLine("({0}, {1}, {2}) < ({3}, {4}, {5})", w2, h2, d2, w1, d1, h1);
                }
            }

            //  h2 d2     h1 w1
            //  h2 d2     w1 h1
            if (w2 < d1)
            {
                if (h2 < h1 && d2 < w1)
                {
                    Console.WriteLine("({0}, {1}, {2}) < ({3}, {4}, {5})", w2, h2, d2, d1, h1, w1);
                }
                if (h2 < w1 && d2 < h1)
                {
                    Console.WriteLine("({0}, {1}, {2}) < ({3}, {4}, {5})", w2, h2, d2, d1, w1, h1);
                }
            }

            //  h2 d2     w1 d1
            //  h2 d2     d1 w1
            if (w2 < h1)
            {
                if (h2 < w1 && d2 < d1)
                {
                    Console.WriteLine("({0}, {1}, {2}) < ({3}, {4}, {5})", w2, h2, d2, h1, w1, d1);
                }
                if (h2 < d1 && d2 < w1)
                {
                    Console.WriteLine("({0}, {1}, {2}) < ({3}, {4}, {5})", w2, h2, d2, h1, d1, w1);
                }
            }
          

        }
    }
}
