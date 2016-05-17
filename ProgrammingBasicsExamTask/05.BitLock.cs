using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitLock
{
    class BitLock
    {
        static void Main(string[] args)
        {
            char[,] board = new char[8, 12];

            int[] inputNumbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            
            // Fill the board with bits
            for (int i = 0; i < inputNumbers.Length; i++)
            {
                int currentNumber = inputNumbers[i];

                string convertCurrentNum = Convert.ToString(currentNumber, 2).PadLeft(32,'0');

                int index = convertCurrentNum.Length - 1;
                for (int k = 0; k < 12; k++)
                {
                    board[i, k] = convertCurrentNum[index];
                    index--;
                }
            }

            //  Reverse the board 
            char[,] reversedBoard = new char[8, 12];
            for (int i = 0; i < 8; i++)
            {
                for (int k = 0; k < 12; k++)
                {
                    reversedBoard[i, k] = board[i, 11 - k];
                }
            }


            //Read commands
            //List<int> oneCounters = new List<int>();
            List<string> commands = Console.ReadLine().Split(' ').ToList();
            while (commands[0] != "end")
            {
                if (commands[0] == "check")
                {
                    int col = int.Parse(commands[1]);

                    int localCol = 0;
                    switch (col)
                    {
                        case 0: localCol = 11; break;
                        case 1: localCol = 10; break;
                        case 2: localCol = 9; break;
                        case 3: localCol = 8; break;
                        case 4: localCol = 7; break;
                        case 5: localCol = 6; break;
                        case 6: localCol = 5; break;
                        case 7: localCol = 4; break;
                        case 8: localCol = 3; break;
                        case 9: localCol = 2; break;
                        case 10: localCol = 1; break;
                        case 11: localCol = 0; break;
                    }

                    int oneCounter = 0;
                    for (int i = 0; i < 8; i++)
                    { 
                        if (reversedBoard[i,localCol] == '1')
                        {
                            oneCounter++;
                        }
                    }
                    Console.WriteLine(oneCounter);
                    //oneCounters.Add(oneCounter);
                }
                else
                {
                    //command is [row] [direction] [rotations]
                    int row = int.Parse(commands[0]);
                    string direction = commands[1];
                    int rotations = int.Parse(commands[2]);

                    List<char> currentRow = new List<char>(12);
                    for (int i = 0; i < 12; i++)
                    {
                        currentRow.Insert(i, reversedBoard[row, i]);
                    }

                    if (direction == "left")
                    {
                        for (int i = 0; i < rotations; i++)
                        {
                            char firstBit = currentRow[i];
                            currentRow.RemoveAt(i);
                            currentRow.Insert(currentRow.Count - 1, firstBit);
                        }
                    }
                    else
                    {
                        for (int i = 0; i < rotations; i++)
                        {
                            char lastBit = currentRow[currentRow.Count - 1];
                            currentRow.RemoveAt(currentRow.Count - 1);
                            currentRow.Insert(0, lastBit);
                        }
                    }
                    

                    for (int i = 0; i < 12; i++)
                    {
                        reversedBoard[row, i] = currentRow[i];
                    }
                }

                commands = Console.ReadLine().Split(' ').ToList();
            }

            // Print the bit counter
            //for (int i = 0; i < oneCounters.Count; i++)
            //{
            //    Console.WriteLine(oneCounters[i]);
            //}

            
            //  Print numbers from the board
            for (int i = 0; i < 8; i++)
            {
                string resultNumber = "";
                int printNumber = 0;
                for (int k = 0; k < 12; k++)
                {
                    resultNumber += reversedBoard[i, k];

                    printNumber = Convert.ToInt32(resultNumber, 2);
                }

                Console.Write("{0} ", printNumber);
            }

            
        }
    }
}
