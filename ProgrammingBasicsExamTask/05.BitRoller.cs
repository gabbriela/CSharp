using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitRoller
{
    class BitRoller
    {
        static void Main(string[] args)
        {
            uint number = uint.Parse(Console.ReadLine());
            int fPosition = int.Parse(Console.ReadLine());
            int rotations = int.Parse(Console.ReadLine());

            // 1. Take bit at f position - save it  bitFposition
            uint bitFposition = 0;

            uint mask = 1;
            mask = mask << fPosition;
            uint result = number & mask;
            if (result != 0)
            {
                bitFposition = 1;
            }

            string fpos = Convert.ToString(number,2);

            // for rotations times

            for (int i = 0; i < rotations; i++)
            {
                // 2. Save bit at 0 position - firstBit
                uint firstBit = 0;
                mask = 1 ;        
                result = number & mask;
                if (result != 0)
                {
                    firstBit = 1;
                }

                // 3. move number >> 1
                number = number >> 1;
                string move = Convert.ToString(number, 2).PadLeft(19, '0');

                // 4. set firstBit at position 18
                mask = 1; 						
                mask = mask << 18; 					
                mask = ~(mask); 			        
                number = number & mask;
                string newset = Convert.ToString(number, 2).PadLeft(19, '0');

                if (firstBit == 1)
                {
                    firstBit = firstBit << 18;
                    number = number | firstBit;
                    string numbin = Convert.ToString(number, 2).PadLeft(19, '0');
                }
                else
                {
                    firstBit = firstBit << 18;
                    number = number & firstBit;
                    string numbin = Convert.ToString(number, 2).PadLeft(19, '0');
                }


                // 5. set bitFposition at f - 1 position, and f + 1 to f position - switch f and f + 1 bits
                //switch places bit fposition and f - 1 position

                //Bit at f position
                int p1 = fPosition;             
                uint bitAtFposition = number >> p1;      // 00000000 00001001
                uint bit1 = bitAtFposition & 1;

                //Bit at f - 1 position
                int p2 = fPosition - 1;
                uint bitBeforeFposition = number >> p2;      // 00000000 00001001
                uint bit2 = bitBeforeFposition & 1;

                if (bit1 == 0)
                {
                    int p = fPosition - 1;   
                    mask = (uint)~(1 << p);     
                    number = number & mask;


                    string numbin2 = Convert.ToString(number, 2).PadLeft(19, '0');
                }
                else
                {
                    int p = fPosition - 1;            
                    mask = (uint)1 << p;       
                    number = number | mask;


                    string numbin2 = Convert.ToString(number, 2).PadLeft(19, '0');
                }


                if (bitFposition == 0)
                {
                    int p = fPosition;
                    mask = (uint)~(1 << p);
                    number = number & mask;


                    string numbin2 = Convert.ToString(number, 2).PadLeft(19, '0');

                }
                else
                {
                    int p = fPosition;
                    mask = (uint)1 << p;
                    number = number | mask;


                    string numbin2 = Convert.ToString(number, 2).PadLeft(19, '0');
                }





















            }


            string checkagain = Convert.ToString(number, 2).PadLeft(19, '0');
            Console.WriteLine(number);

        }
    }
}



