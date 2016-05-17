using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20.EncryptTheMessage
{
    class Encrypt
    {
        static void Main(string[] args)
        {
            string start = Console.ReadLine();                  //read until the input is start or START
            while (start != "start" && start != "START")
            {
                start = Console.ReadLine();
            }

            string convertedMsg = "";                           //string to put the converted symbols
            string reorderInput = "";                           //string to reorder chars
            List<string> encryptedMsg = new List<string>();     //list to keep decrypted msg

            string inputLine = Console.ReadLine();

            char[] capitalLettersAM = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M' };
            char[] capitalLettersNZ = { 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };

            char[] smallLettersAM = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm' };
            char[] smallLettersNZ = { 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };

            char[] symbolSpecial = { '+', '%', '&', '#', '$' };
            char[] symbolOrdinary = { ' ', ',', '.', '?', '!' };


            while (inputLine == " " || inputLine == "")         //keep reading if the string is empty or space
            {
                inputLine = Console.ReadLine();
            }

            if (inputLine == "END" || inputLine == "end")       //print no messages if there are no msgs
            {
                Console.WriteLine("No messages sent.");
            }
            else
            {
                while (inputLine != "end" && inputLine != "END")
                {
                    for (int k = inputLine.Length - 1; k >= 0; k--)
                    {
                        reorderInput += inputLine[k];
                    }

                    for (int i = 0; i < reorderInput.Length; i++)
                    {

                        char currentChar = reorderInput[i];
                        if (currentChar >= 'A' && currentChar <= 'M')
                        {
                            int index = Array.IndexOf(capitalLettersAM, currentChar);
                            convertedMsg += capitalLettersNZ[index];
                        }
                        else if (currentChar >= 'N' && currentChar <= 'Z')
                        {
                            int index = Array.IndexOf(capitalLettersNZ, currentChar);
                            convertedMsg += capitalLettersAM[index];
                        }
                        else if (currentChar >= 'a' && currentChar <= 'm')
                        {
                            int index = Array.IndexOf(smallLettersAM, currentChar);
                            convertedMsg += smallLettersNZ[index];
                        }
                        else if (currentChar >= 'n' && currentChar <= 'z')
                        {
                            int index = Array.IndexOf(smallLettersNZ, currentChar);
                            convertedMsg += smallLettersAM[index];
                        }
                        else if (currentChar == ' ' || currentChar == ',' || currentChar == '.' ||
                                                                 currentChar == '?' || currentChar == '!')
                        {
                            int index = Array.IndexOf(symbolOrdinary, currentChar);
                            convertedMsg += symbolSpecial[index];
                        }
                        else if (currentChar >= '0' && currentChar <= '9')
                        {
                            convertedMsg += currentChar;
                        }
                    }

                    if (inputLine != " " && inputLine != "")
                    {
                        encryptedMsg.Add(convertedMsg);
                    }

                    inputLine = Console.ReadLine();
                    convertedMsg = "";
                    reorderInput = "";
                }

                Console.WriteLine("Total number of messages: {0}", encryptedMsg.Count);
                encryptedMsg.ForEach(Console.WriteLine);
            }
        }
    }
}
