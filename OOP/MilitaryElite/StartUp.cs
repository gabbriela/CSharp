
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace _08.MilitaryElite
{
    class StartUp
    {
        static void Main(string[] args)
        {
            Dictionary<string, Soldier> soldiers = new Dictionary<string, Soldier>();

            string[] inputSoldier = Console.ReadLine().Split(' ');

            while (inputSoldier[0] != "End")
            {
                string soldierType = inputSoldier[0];
                string id = inputSoldier[1];
                string firstName = inputSoldier[2];
                string secondName = inputSoldier[3];

                if (soldierType == "Private")
                {
                    soldiers[id] = CreatePrivate(inputSoldier);
                }
                else if (soldierType == "LeutenantGeneral")
                {
                    soldiers[id] = CreateLeutanant(inputSoldier, soldiers); 
                }
                else if (soldierType == "Engineer")
                {
                    try
                    {
                        soldiers[id] = CreateEngineer(inputSoldier, soldiers);   
                    }
                    catch (ArgumentException ae)
                    {
                        
                    }
                }
                else if (soldierType == "Commando")
                {
                    try
                    {
                        soldiers[id] = CreateCommando(inputSoldier, soldiers);  
                    }
                    catch (ArgumentException ae)
                    {
                        
                    }
                }
                else if (soldierType == "Spy")
                {
                    int codeNumber = int.Parse(inputSoldier[4]);

                    soldiers[id] = new Spy(id, firstName, secondName, codeNumber);
                }

                inputSoldier = Console.ReadLine().Split(' ');
            }

            Print(soldiers);
        }

        private static Commando CreateCommando(string[] inputSoldier, Dictionary<string, Soldier> soldiers)
        {
            string id = inputSoldier[1];
            string firstName = inputSoldier[2];
            string secondName = inputSoldier[3];
            double salary = double.Parse(inputSoldier[4]);
            string corpsType = inputSoldier[5];

            Dictionary<string, string> missions = new Dictionary<string, string>();

            if (inputSoldier.Length > 6)
            {
                for (int i = 6; i < inputSoldier.Length; i += 2)
                {
                    if (inputSoldier[i + 1] == "Finished" || inputSoldier[i + 1] == "inProgress")
                    {
                        missions[inputSoldier[i]] = inputSoldier[i + 1];
                    }
                }
            }

            return new Commando(id, firstName, secondName, salary, corpsType, missions);
        }

        private static Engineer CreateEngineer(string[] inputSoldier, Dictionary<string, Soldier> soldiers)
        {
            string id = inputSoldier[1];
            string firstName = inputSoldier[2];
            string secondName = inputSoldier[3];
            double salary = double.Parse(inputSoldier[4]);
            string corpsType = inputSoldier[5];

            Dictionary<string, int> repair = new Dictionary<string, int>();

            if (inputSoldier.Length > 6)
            {
                for (int i = 6; i < inputSoldier.Length; i += 2)
                {
                    repair.Add(inputSoldier[i], int.Parse(inputSoldier[i + 1]));
                }
            }

            return new Engineer(id, firstName, secondName, salary, corpsType, repair);
        }

        private static LeutenantGeneral CreateLeutanant(string[] inputSoldier, Dictionary<string, Soldier> soldiers)
        {
            string id = inputSoldier[1];
            string firstName = inputSoldier[2];
            string secondName = inputSoldier[3];
            double salary = double.Parse(inputSoldier[4]);

            List<Private> idList = new List<Private>();

            if (inputSoldier.Length > 5)
            {
                for (int i = 5; i < inputSoldier.Length; i++)
                {
                    idList.Add((Private)soldiers[inputSoldier[i]]);
                }
            }

            return new LeutenantGeneral(id, firstName, secondName, salary, idList);
        }
        
        private static Private CreatePrivate(string[] inputSoldier)
        {
            string id = inputSoldier[1];
            string firstName = inputSoldier[2];
            string secondName = inputSoldier[3];
            double salary = double.Parse(inputSoldier[4]);

            return new Private(id, firstName, secondName, salary);
        }


        private static void Print(Dictionary<string, Soldier> soldiers)
        {
            foreach (var soldier in soldiers.Values)
            {
                if (soldier.Type == "private")
                {
                    Console.WriteLine(soldiers[soldier.Id]);
                }
                else if (soldier.Type == "engineer")
                {
                    Console.WriteLine(soldiers[soldier.Id]);
                }
                else if (soldier.Type == "commando")
                {
                    Console.WriteLine(soldiers[soldier.Id]);

                }
                else if (soldier.Type == "leutenantgeneral")
                {
                    Console.WriteLine(soldiers[soldier.Id]);
                }
                else if (soldier.Type == "spy")
                {
                    Spy current = (Spy)soldier;
                    Console.WriteLine($"Name: {soldier.FirstName} {soldier.LastName} Id: {soldier.Id}");
                    Console.WriteLine($"Code Number: {current.CodeNumber}");

                }
            }
        }
    }
}
