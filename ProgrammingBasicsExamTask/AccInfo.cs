using System;

namespace _01.Account_Info
{
    class AccInfo
    {
        static void Main(string[] args)
        {
            string firstName = Console.ReadLine();
            string lastName = Console.ReadLine();
            int clientID = Int32.Parse(Console.ReadLine());
            decimal balance = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Hello, {0} {1}", firstName, lastName);
            Console.WriteLine("Client id: {0}", clientID);
            Console.WriteLine("Total balance: {0:F2}", balance);

            if (balance >= 0)
            {
                Console.WriteLine("Active: yes");
            }
            else
            {
                Console.WriteLine("Active: no");
            }

        }
    }
}
