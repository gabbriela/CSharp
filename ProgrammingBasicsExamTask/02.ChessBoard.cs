using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessBoardGame
{
    class ChessBoard
    {
        static void Main(string[] args)
        {
            //The size of the chessboard is n*n 
            int size = Int32.Parse(Console.ReadLine());
            int white = 0;
            int black = 0;
            int convert = 0;

            string inputString = Console.ReadLine();

            for (int i = 1; i <= inputString.Length; i++)
            {
                // If i is bigger than size of the board (n*n) the loop should break
                if (i == size*size + 1)
                {
                    break;
                }



                char currentChar = inputString[i-1];
                if (currentChar >= 'A' && currentChar <= 'Z' || currentChar >= '0' && currentChar <= '9' || currentChar >= 'a' && currentChar <= 'z')
                {     
                    // Letters and numbers
                    convert = Convert.ToInt32(inputString[i-1]);
                }
                
                else
                {
                    // Symbols
                    convert = 0;
                }


                
                // Count black team points. If upper letter ->> white team point
                if (i % 2 != 0)
                {
                    if (char.IsUpper(inputString[i-1]))
                    {
                        white += convert;
                    }
                    else
                    {
                        black += convert;
                    }
                }

                //Count white team points. If upper letter --> black team point
                if (i % 2 == 0)
                {
                    if (char.IsUpper(inputString[i-1]))
                    {
                        black += convert;
                    }
                    else
                    {
                        white += convert;
                    }
                }

            }

            if (black > white)
            {
                Console.WriteLine("The winner is: black team");
                Console.WriteLine(black - white);
            }
            else if (white > black)
            {
                Console.WriteLine("The winner is: white team");
                Console.WriteLine(white - black);
            }
            else if (white == black)
            {
                Console.WriteLine("Equal result: " + white);
            }
        }
    }
}
