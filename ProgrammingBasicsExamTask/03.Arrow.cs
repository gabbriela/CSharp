using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrow
{
    class Arrow
    {
        static void Main(string[] args)
        {

            int width = int.Parse(Console.ReadLine());
            int outside = width / 2;
            char dot = '.';
            char diez = '#';

            string arrow = new string(dot, outside) + new string(diez, width) + new string(dot, outside);
            Console.WriteLine(arrow);

             arrow = new string(dot, outside) + diez + new string(dot, width - 2) +
                                diez + new string(dot, outside);
            for (int i = 1; i <= width - 2; i++)
            {
                Console.WriteLine(arrow);
            }

            arrow = new string(diez, outside + 1) + new string(dot, width - 2) + new string(diez, outside + 1);
            Console.WriteLine(arrow);

            for (int i = 1; i < width-1; i++)
            {
                int inside = (width + 2*outside) - 2*i - 2;
                arrow = new string(dot, i) + diez + new string(dot, inside) + diez + new string(dot, i);
                Console.WriteLine(arrow);
            }

            int half = (width + 2 * outside)/2;
            arrow = new string(dot, half) + diez + new string(dot, half);
            Console.WriteLine(arrow);

        }
    }
}
