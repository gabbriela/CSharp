using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car
{
    class Car
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());

            int width = n * 3;
            int height = width / 2 - 1;
            int roof = n / 2;
            int wheels = roof - 1;

            char dot = '.';
            char asterisk = '*';

            string car = new string(dot, n) + new string(asterisk, n) + new string(dot, n);
            Console.WriteLine(car);

            int windows = n;
            for (int i = 1; i <= n/2 - 1; i++)
            {
                car = new string(dot, n-i) + asterisk + new string(dot, windows) + asterisk + new string(dot, n-i);
                Console.WriteLine(car);
                windows += 2;
            }

            car = new string(asterisk, (width - windows)/2) + new string(dot, windows) + 
                  new string(asterisk, (width - windows)/2);
            Console.WriteLine(car);

            for (int i = 0; i < n/2 - 2; i++)
            {
                car = asterisk + new string(dot, width - 2) + asterisk;
                Console.WriteLine(car);
            }

            car = new string(asterisk, width);
            Console.WriteLine(car);

            for (int i = 0; i < n / 2 - 2; i++)
            {
                car = new string(dot, n / 2) + asterisk + new string(dot, n/2-1) + asterisk + new string(dot, n-2) +
                    asterisk + new string(dot, n/2-1) + asterisk + new string(dot, n / 2);
                Console.WriteLine(car);
            }

            car = new string(dot, n/2) + new string(asterisk, n/2 + 1) + new string(dot, n -2) +
                  new string(asterisk, n/2+1) + new string(dot, n/2);
            Console.WriteLine(car);
        }
    }
}
