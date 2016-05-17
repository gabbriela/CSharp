using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.CalculateSequence
{
    class Sequence
    {
        static void Main(string[] args)
        {
            /*   S1 = N
                 S2 = S1 + 1
                 S3 = 2*S1 + 1
                 S4 = S1 + 2 
             
                 S5 = S2 + 1    */

            long s1 = long.Parse(Console.ReadLine());

            Queue<long> numbers = new Queue<long>();

            numbers.Enqueue(s1);

            List<long> s = new List<long>();
            s.Add(s1);

            for (int i = 0; i < 16; i++)
            {
                long current = s[i];

                long s2 = s[i] + 1;
                numbers.Enqueue(s2);
                s.Add(s2);

                long s3 = 2 * s[i] + 1;
                numbers.Enqueue(s3);
                s.Add(s3);

                long s4 = s[i] + 2;
                numbers.Enqueue(s4);
                s.Add(s4);
            }
            long lastOne = s[16] + 1;
            numbers.Enqueue(lastOne);
            s.Add(lastOne);

            while (numbers.Count != 0)
            {
                Console.Write(numbers.Dequeue());
                if (numbers.Count != 0)
                {
                    Console.Write(" ");
                }
            }
            Console.WriteLine();

        }
    }
}
