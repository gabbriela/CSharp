using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.IncreasingAbsoluteDifferences
{
    class Increasing
    {
        static void Main(string[] args)
        {
            int sequences = int.Parse(Console.ReadLine());

            for (int i = 0; i < sequences; i++)
            {
                int[] originalSequence = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

                int[] poweredSequence = new int[originalSequence.Length - 1];

                for (int k = 0; k < poweredSequence.Length; k++)
                {

                    int power = Math.Abs(originalSequence[k] - originalSequence[k+1]);

                    poweredSequence[k] = power;
                    
                }
                CheckIfIncreasing(poweredSequence);

            }
            
        }

        private static void CheckIfIncreasing(int[] poweredSequence)
        {
            bool isIncreasing = true;

            for (int i = 0; i < poweredSequence.Length - 1; i++)
            {
                bool diff = Math.Abs(poweredSequence[i] - poweredSequence[i+1]) < 2;
                bool equal = poweredSequence[i] <= poweredSequence[i + 1];

                if (!(equal && diff))
                {
                    isIncreasing = false;
                    break;
                }
            }



            Console.WriteLine(isIncreasing);
        }

        
    }
}
