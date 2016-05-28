namespace _01.DeCatCoding
{
    using System;
    using System.Text;

    class CatCoding
    {
        static void Main(string[] args)
        {
            string[] catMessage = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            StringBuilder decryptedMessage = new StringBuilder();

            for (int i = 0; i < catMessage.Length; i++)
            {
                string currentWord = catMessage[i];
                decimal number21System = 0;
                decimal power = currentWord.Length - 1;

                for (int k = 0; k < currentWord.Length; k++)
                {
                    char letter = currentWord[k];

                    decimal letterNumber = FindNumberFromLetter(letter);

                    decimal powerNumber = FindPowerNumber(power);

                    number21System += letterNumber * powerNumber;

                    power--;
                }
                //decimal number26System = ConvertToTwentySixSystem(number21System);

                decryptedMessage.Append(ConvertToTwentySixSystem(number21System) + " ");
            }

            Console.WriteLine(decryptedMessage.ToString().Trim());
        }

        private static string ConvertToTwentySixSystem(decimal number21System)
        {
            StringBuilder decryptedWord = new StringBuilder();
            long num = Convert.ToInt64(number21System);
            while (num > 0)
            {
                long leftOver = num % 26;

                decryptedWord.Append(FindLetterFromNumber(leftOver));

                num /= 26;
            }

            char[] arr = decryptedWord.ToString().ToCharArray();
            Array.Reverse(arr);

            return new string(arr);
            
        }

        private static char FindLetterFromNumber(long leftOver)
        {
            return Convert.ToChar(leftOver + 97);
        }

        private static decimal FindPowerNumber(decimal power)
        {
            decimal result = 1;
            for (int i = 0; i < power; i++)
            {
                result *= 21;
            }
            return result;
        }

        private static decimal FindNumberFromLetter(char letter)
        {
            switch (letter)
            {
                case 'a': return 0; 
                case 'b': return 1;
                case 'c': return 2;
                case 'd': return 3;
                case 'e': return 4;
                case 'f': return 5;
                case 'g': return 6;
                case 'h': return 7;
                case 'i': return 8;
                case 'j': return 9;
                case 'k': return 10;
                case 'l': return 11;
                case 'm': return 12;
                case 'n': return 13;
                case 'o': return 14;
                case 'p': return 15;
                case 'q': return 16;
                case 'r': return 17;
                case 's': return 18;
                case 't': return 19;
                case 'u': return 20;

                default: throw new NotImplementedException();
            }
            
        }
    }
}
