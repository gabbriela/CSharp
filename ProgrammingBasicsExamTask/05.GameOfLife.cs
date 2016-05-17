using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17.GameOfLife
{
    class GameOfLife
    {
        static void Main(string[] args)
        {
            // Board from zeroes
            int[,] board = new int [10,10];
            for (int i = 0; i < 10; i++)
            {
                for (int k = 0; k < 10; k++)
                {
                    board[i, k] = 0;
                }
            }

            //enters 1's coordinates
            int entries = int.Parse(Console.ReadLine());
            for (int i = 0; i < entries; i++)
            {
                int x = int.Parse(Console.ReadLine());
                int y = 9 - int.Parse(Console.ReadLine());

                board[x, y] = 1;
            }

            

            int[,] gameBoard = new int[10,10];

            for (int i = 0; i < 10; i++)
            {
                for (int k = 0; k < 10; k++)
                {
                    gameBoard[i, k] = 0;
                }
            }

            int neighbourCounter = 0;
            for (int i = 0; i < 10; i++)
            {
                for (int k = 0; k < 10; k++)
                {
                    neighbourCounter = 0;
                        if (i == 0 && k == 0)
                        {
                            //(i, k +1) (i+1, k) i+1, k+1 
                            if (board[i, k+1] == 1)
                            {
                                neighbourCounter++;
                            }
                            if (board[i+1, k] == 1)
                            {
                                neighbourCounter++;
                            }
                            if (board[i+1, k+1] == 1)
                            {
                                neighbourCounter++;
                            }
                        }
                        else if (i == 0 && k == 9)
                        {
                            //(i, k-1) (i+1, k) i+1, k-1
                            if (board[i, k-1] == 1)
                            {
                                neighbourCounter++;
                            }
                            if (board[i + 1, k] == 1)
                            {
                                neighbourCounter++;
                            }
                            if (board[i + 1, k - 1] == 1)
                            {
                                neighbourCounter++;
                            }
                        }
                        else if (i == 0 && k != 0 && k!= 9)
                        {
                            //(i, k-1) (i k+1) (i+1, k) (i+1, k-1) (i+1 k+1)
                            if (board[i, k-1] == 1)
                            {
                                neighbourCounter++;
                            }
                            if (board[i, k+1] == 1)
                            {
                                neighbourCounter++;
                            }
                            if (board[i + 1, k] == 1)
                            {
                                neighbourCounter++;
                            }
                            if (board[i+1, k+1] == 1)
                            {
                                neighbourCounter++;
                            }
                        }
                        else if (i == 9 && k == 0)
                        {
                            //(i, k +1) (i-1, k) i-1, k+1
                            if (board[i, k+1] == 1)
                            {
                                neighbourCounter++;
                            }
                            if (board[i-1, k] == 1)
                            {
                                neighbourCounter++;
                            }
                            if (board[i-1, k+1] == 1)
                            {
                                neighbourCounter++;
                            }
                        }
                        else if (i == 9 && k == 9)
                        {
                            //(i, k-1) (i-1, k) i-1, k-1
                            if (board[i, k - 1] == 1)
                            {
                                neighbourCounter++;
                            }
                            if (board[i-1, k] == 1)
                            {
                                neighbourCounter++;
                            }
                            if (board[i-1, k - 1] == 1)
                            {
                                neighbourCounter++;
                            }
                        }
                        else if (i == 9 && k != 0 && k!= 9)
                        {
                             //(i, k-1) (i k+1) (i-1, k) (i-1, k-1) (i-1 k+1)
                            if (board[i, k - 1] == 1)
                            {
                                neighbourCounter++;
                            }
                            if (board[i, k + 1] == 1)
                            {
                                neighbourCounter++;
                            }
                            if (board[i-1, k] == 1)
                            {
                                neighbourCounter++;
                            }
                            if (board[i-1, k - 1] == 1)
                            {
                                neighbourCounter++;
                            }
                            if (board[i - 1, k + 1] == 1)
                            {
                                neighbourCounter++;
                            }
                        }
                        else if (k == 0 && i != 0 && i!= 9 )
                        {
                            //(i k+1) (i+1, k) (i-1 k) (i+1, k+1) (i-1 k+1) 
                            if (board[i, k + 1] == 1)
                            {
                                neighbourCounter++;
                            }
                            if (board[i + 1, k] == 1)
                            {
                                neighbourCounter++;
                            }
                            if (board[i - 1, k] == 1)
                            {
                                neighbourCounter++;
                            }
                            if (board[i + 1, k + 1] == 1)
                            {
                                neighbourCounter++;
                            }
                            if (board[i - 1, k + 1] == 1)
                            {
                                neighbourCounter++;
                            }
                        }
                        else if (k == 9 && i != 0 && i != 9)
                        {
                            //(i k-1) (i+1, k) (i-1 k) (i+1, k-1) (i-1 k-1)
                            if (board[i, k - 1] == 1)
                            {
                                neighbourCounter++;
                            }
                            if (board[i + 1, k] == 1)
                            {
                                neighbourCounter++;
                            }
                            if (board[i - 1, k] == 1)
                            {
                                neighbourCounter++;
                            }
                            if (board[i + 1, k - 1] == 1)
                            {
                                neighbourCounter++;
                            }
                            if (board[i - 1, k - 1] == 1)
                            {
                                neighbourCounter++;
                            }
                        }
                        else
                        {
                            //(i k-1)(i k+1)(i-1 k-1)(i-1 k)(i-1 k+1)(i+1 k)(i+1 k-1)(i+1 k+1)
                            if (board[i, k - 1] == 1)
                            {
                                neighbourCounter++;
                            }
                            if (board[i, k + 1] == 1)
                            {
                                neighbourCounter++;
                            }
                            if (board[i - 1, k - 1] == 1)
                            {
                                neighbourCounter++;
                            }
                            if (board[i - 1, k] == 1)
                            {
                                neighbourCounter++;
                            }
                            if (board[i - 1, k + 1] == 1)
                            {
                                neighbourCounter++;
                            }
                            if (board[i + 1, k] == 1)
                            {
                                neighbourCounter++;
                            }
                            if (board[i + 1, k - 1] == 1)
                            {
                                neighbourCounter++;
                            }
                            if (board[i + 1, k + 1] == 1)
                            {
                                neighbourCounter++;
                            }
                        }

                        //1.	Any live cell with fewer than two live neighbours dies.
                        //2.	Any live cell with two or three live neighbours lives on to the next generation.
                        //3.	Any live cell with more than three live neighbours dies due to overcrowding.
                        //4.	Any dead cell with exactly three live neighbours becomes a live cell, as if by reproduction.

                        if (board[i,k] == 1)
                        {
                            if (neighbourCounter < 2 || neighbourCounter > 3)
                            {
                                gameBoard[i, k] = 0;
                            }
                            else if (neighbourCounter >= 2 && neighbourCounter <= 3)
                            {
                                gameBoard[i, k] = 1;
                            }
                        }
                        else if (board[i,k] == 0)
                        {
                            if (neighbourCounter == 3)
                            {
                                gameBoard[i, k] = 1;
                            }
                        }
                }
            }

            for (int i = 0; i < 10; i++)
            {
                for (int k = 0; k < 10; k++)
                {
                    Console.Write(gameBoard[i,k]);
                }
                Console.WriteLine();
            }

        }
    }
}
