using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XBits
{
    class XBits
    {
        static void Main(string[] args)
        {
            char[,] board = new char[8,32];

            int xCounter = 0;

            List<int> inputNumbers = new List<int>(8);
            for (int i = 0; i < 8; i++)
            {
                int number = int.Parse(Console.ReadLine());
                inputNumbers.Add(number);
            }

            for (int i = 0; i < 8; i++)
            {
                string binary = Convert.ToString(inputNumbers[i], 2).PadLeft(31, '0');

                for (int k = 30; k >= 0; k--)
                {
                    board[i, k] = binary[k];
                }
            }

            for (int i = 0; i <= 5; i++)
            {
                for (int k = 0; k <= 29; k++)
                {
                    bool upRow = false;
                    bool middleRow = false;
                    bool downRow = false;

                    #region up row check 101
                    if (board[i,k] == '1')
                    {
                        if (board[i, k + 1] == '0')
                        {
                            if (board[i, k + 2] == '1')
                            {
                                upRow = true;
                            }
                        }
                    }
                    #endregion
                    #region middle row check 010
                    if (board[i + 1, k] == '0')
                    {
                        if (board[i + 1, k + 1] == '1')
                        {
                            if (board[i + 1, k + 2] == '0')
                            {
                                middleRow = true;
                            }
                        }
                    }
                    #endregion
                    #region down row check 101
                    if (board[i + 2, k] == '1')
                    {
                        if (board[i + 2, k + 1] == '0')
                        {
                            if (board[i + 2, k + 2] == '1')
                            {
                                downRow = true;
                            }
                        }
                    }
                    #endregion

                    if (upRow && middleRow && downRow)
                    {
                        xCounter++;
                    }

                }
            }



            Console.WriteLine(xCounter);
        }
    }
}
