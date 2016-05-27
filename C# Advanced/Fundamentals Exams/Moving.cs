using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovingLetters
{
    class Moving
    {
        static void Main(string[] args)
        {
            //string test = "Fun exam right";
            string[] input = Console.ReadLine().Split(' ');

            //string[] input = test.Split(' ');

            StringBuilder resultWord = new StringBuilder();

            int counter = 1;

            int maxLength = GetMaxLength(input);

            while (true)
            {
                for (int i = 0; i < input.Length; i++)
                {
                    string currentWord = input[i];

                    if (currentWord.Length >= counter)
                    {
                        resultWord.Append(currentWord[currentWord.Length - counter]);
                    }

                    //if (currentWord != "")
                    //{
                    //    resultWord.Append(currentWord[currentWord.Length - 1]);
                    //    input[i] = currentWord.Remove(currentWord.Length - 1);
                    //}
                    //else
                    //{
                    //    counter++;
                    //}
                }

                if (counter == maxLength)
                {
                    break;
                }
                counter++;

                //if (counter == input.Length)
                //{
                //    activeWords = false;
                //}
            }

            for (int i = 0; i < resultWord.Length; i++)
            {
                char letter = resultWord[i];

                int letterPosition = GetLetterPosition(letter);

                int positionToInsert = GetPositionToInsert(i, letterPosition, resultWord.Length);

                resultWord.Remove(i, 1);

                resultWord.Insert(positionToInsert, letter);
                
            }

            Console.WriteLine(resultWord.ToString());
        }

        private static int GetMaxLength(string[] input)
        {
            int max = 0;

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i].Length > max)
                {
                    max = input[i].Length; 
                }
            }
            return max;
        }

        private static int GetPositionToInsert(int start, int letterPosition, int timeToFlip)
        {
            int position = start;

            for (int i = 0; i < letterPosition; i++)
            {
                position++;

                if (position == timeToFlip)
                {
                    position = 0;
                }
            }

            return position;
        }

        private static int GetLetterPosition(char letter)
        {
            int position = 0;

            if (letter >= 'A' && letter <= 'Z')
            {
                position = Convert.ToInt32(letter) - 64;
            }
            else
            {
                position = Convert.ToInt32(letter) - 96;
            }

            return position;
        }
    }
}
