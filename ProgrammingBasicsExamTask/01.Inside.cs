using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Inside_the_Building
{
    class Inside
    {
        static void Main(string[] args)
        {
            int h = Int32.Parse(Console.ReadLine());
            int x1 = Int32.Parse(Console.ReadLine());
            int y1 = Int32.Parse(Console.ReadLine());
            int x2 = Int32.Parse(Console.ReadLine());
            int y2 = Int32.Parse(Console.ReadLine());
            int x3 = Int32.Parse(Console.ReadLine());
            int y3 = Int32.Parse(Console.ReadLine());
            int x4 = Int32.Parse(Console.ReadLine());
            int y4 = Int32.Parse(Console.ReadLine());
            int x5 = Int32.Parse(Console.ReadLine());
            int y5 = Int32.Parse(Console.ReadLine());


            if (y1 >= 0 && y1 <= h && x1 >= 0 && x1 <= 3*h)
            {
                Console.WriteLine("inside"); 
                 
            }
            else if (x1 >= h && x1 <= h*2 && y1 >=0 && y1 <= 4*h)
            {
                Console.WriteLine("inside");
            }
            else
            {
                Console.WriteLine("outside");
            }
            


            if (y2 >= 0 && y2 <= h && x2 >= 0 && x2 <= 3 * h)
            {
                Console.WriteLine("inside");
            }
            else if (x2 >= h && x2 <= h * 2 && y2 >= 0 && y2 <= 4 * h)
            {
                Console.WriteLine("inside");
            }
            else
            {
                Console.WriteLine("outside");
            }
            



            if (y3 >= 0 && y3 <= h && x3 >= 0 && x3 <= 3 * h)
            {
                Console.WriteLine("inside");
            }
            else if (x3 >= h && x3 <= h * 2 && y3 >= 0 && y3 <= 4 * h)
            {
                Console.WriteLine("inside");
            }
            else
            {
                Console.WriteLine("outside");
            }
            


            if (y4 >= 0 && y4 <= h && x4 >= 0 && x4 <= 3 * h)
            {
                Console.WriteLine("inside");
            }
            else if (x4 >= h && x4 <= h * 2 && y4 >= 0 && y4 <= 4 * h)
            {
                Console.WriteLine("inside");
            }
            else
            {
                Console.WriteLine("outside");
            }
            


            if (y5 >= 0 && y5 <= h && x5 >= 0 && x5 <= 3 * h)
            {
                Console.WriteLine("inside");
            }
            else if (x5 >= h && x5 <= h * 2 && y5 >= 0 && y5 <= 4 * h)
            {
                Console.WriteLine("inside");
            }
            else
            {
                Console.WriteLine("outside");
            }
            
        }
    }
}
