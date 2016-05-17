using System;

namespace _17.Tables
{
    class Tables
    {
        static void Main(string[] args)
        {
            long pack1 = Int64.Parse(Console.ReadLine());
            long pack2 = Int64.Parse(Console.ReadLine());
            long pack3 = Int64.Parse(Console.ReadLine());
            long pack4 = Int64.Parse(Console.ReadLine());

            long top = Int64.Parse(Console.ReadLine());
            long neededTables = Int64.Parse(Console.ReadLine());

            long tablesMade = 0;
            long legs = pack1 * 1 + pack2 * 2 + pack3 * 3 + pack4 * 4;
            long tableLegs = legs / 4;
            long reqTop = neededTables;
            
            long reqLegs = neededTables * 4;

            
            // Tables Made
            if (tableLegs > top)
            {
                tablesMade = top;
            }
            else if (tableLegs < top)
            {
                tablesMade = tableLegs;
            }
            else if (tableLegs == top)
            {
                tablesMade = top;
            }

            // if less
            if (reqLegs <= legs)
            {
                reqLegs = 0;
            }
            else
            {
                reqLegs = reqLegs - legs;
            }
            if (reqTop <= top)
            {
                reqTop = 0;
            }
            else if (reqTop > top)
            {
                reqTop = reqTop - top;
            }

            
            if (tablesMade == neededTables)
            {
                Console.WriteLine("Just enough tables made: {0}", tablesMade);
            }
            else if (tablesMade < neededTables)
            {
                Console.WriteLine("less: {0}", tablesMade - neededTables);
                Console.WriteLine("tops needed: {0}, legs needed: {1}", reqTop, reqLegs);
            }
            else // tablesMade > neededTables
            {
                long leftLegs = legs - (neededTables * 4);
                long topLeft = top - neededTables;
                Console.WriteLine("more: {0}", tablesMade - neededTables);
                Console.WriteLine("tops left: {0}, legs left: {1}", topLeft, leftLegs);
            }
        }
    }
}
