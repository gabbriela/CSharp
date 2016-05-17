using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numerology
{
    class Numerology
    {
        static void Main(string[] args)
        {
            string[] inputLine = Console.ReadLine().Split('.' , ' ');
           // string inputLine = "14.03.1990 Panayot";
                          
            int date = Convert.ToInt32(inputLine[0]);
            int month = Convert.ToInt32(inputLine[1]);
            int year = Convert.ToInt32(inputLine[2]);
            long sum = 0;

            long multiply = date * month * year;

            if (month % 2 != 0)
            {
                sum = multiply * multiply;
            }

            string name = Convert.ToString(inputLine[3]);
            for (int k = 0; k < name.Length; k++)
            {                
                char current = name[k];

                if (current >= 'A' && current <= 'Z')
                {
                    int charNum = (int)current - 64;
                    sum += (charNum * 2);
                }
                else if (current >= 'a' && current <= 'z')
                {
                    int charNum = (int)current - 96;
                    sum += charNum;
                }
                else if (current >= '1' && current <= '9')
                {
                    int charNum = (int)current - 48;
                    sum += charNum;
                }
                else if (current == ' ' || current == '0' || current == '\t' || current == '\r' || current == '\n')
                {

                }              
            }
            

            while (sum > 13)
            {
                int result = 0;
                string numToArr = Convert.ToString(sum);
                int[] numbersToMultiply = new int[numToArr.Length];
                
                for (int i = 0; i < numToArr.Length; i++)
                {
                    char current = numToArr[i];
                    if (current >= '1' && current <= '9')
                    {
                        int charNum = (int)current - 48;
                        result += charNum;
                    }
                    else if (current == '0')
	                {
                        result += 0;
	                }                    
                }
                sum = result;                
            }
            Console.WriteLine(sum);
                           
        }
    }
}
