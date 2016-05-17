using System;

namespace PandaFlag
{
    class PandaFlag
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int letter = 65;
            char diez = '#';
            char tilda = '~';
            char dash = '-';

            string flag = "";
            int diezCounter = n - 2;

            for (int i = 0; i < n/2; i++)
            {
                char let1 = Convert.ToChar(letter);
                letter++;
                if (letter == 91)
                {
                    letter = 65;
                }

                char let2 = Convert.ToChar(letter);
                letter++;
                if (letter == 91)
                {
                    letter = 65;
                }
                
                flag = new string(tilda, i) + let1 + new string(diez, diezCounter) + let2 + new string(tilda, i);
                Console.WriteLine(flag);
                diezCounter -= 2;
            }

            if (letter == 91)
            {
                letter = 65;
            }
            char middleLetter = Convert.ToChar(letter);

            letter++;
            if (letter == 91)
            {
                letter = 65;
            }

            flag = new string(dash, n / 2) + middleLetter + new string(dash, n / 2);
            Console.WriteLine(flag);

            diezCounter = 1;

            for (int i = n/2; i > 0; i--)
            {
                
                char let1 = Convert.ToChar(letter);
                letter++;
                if (letter == 91)
                {
                    letter = 65;
                }

                char let2 = Convert.ToChar(letter);
                letter++;
                if (letter == 91)
                {
                    letter = 65;
                }

                flag = new string(tilda, i - 1) + let1 + new string(diez, diezCounter) + let2 + new string(tilda, i - 1);
                Console.WriteLine(flag);

                diezCounter += 2;
            }
        }
    }
}
