using System;

namespace Eclipse
{
    class Eclipse
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            char asterix = '*';
            char glass = '/';
            char middle = ' ';
            char bridge = '-';

            string top = new string(middle, 1) + new string(asterix, n * 2 - 2) + new string(middle, n + 1) +
                new string(asterix, n * 2 - 2) + new string(middle, 1);
            Console.WriteLine(top);

            for (int i = 1; i <= n - 2; i++)
            {
                string leftGlasses = new string(asterix, 1) + new string(glass, n * 2 - 2) + new string(asterix, 1);   
                Console.Write(leftGlasses);

                if (i == n/2 )
                {
                    string noseArea = new string(bridge, n - 1);
                    Console.Write(noseArea);
                }
                else
                {
                    string noseArea = new string(middle, n - 1);
                    Console.Write(noseArea);
                }

                string rightGlasses = new string(asterix, 1) + new string(glass, n * 2 - 2) + new string(asterix, 1);
                Console.Write(rightGlasses);
                Console.WriteLine();
            }

            Console.WriteLine(top);
        }
    }
}
