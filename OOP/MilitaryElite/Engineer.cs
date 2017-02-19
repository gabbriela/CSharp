
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace _08.MilitaryElite
{
    class Engineer : SpecialisedSoldier, IEngineer
    {
        public Dictionary<string, int> RepairedParts { get; set; }

        public Engineer(string id, string firstName, string lastName, double salary, string corpsType, Dictionary<string, int> repairedParts) 
            : base(id, firstName, lastName, salary, corpsType)
        {
            this.RepairedParts = repairedParts;
            base.Type = "engineer";
        }

        public override string ToString()
        {
            StringBuilder stringToReturn = new StringBuilder();

            stringToReturn.Append($"Name: {base.FirstName} {base.LastName} Id: {base.Id} Salary: {base.Salary:f2}")
                .Append(Environment.NewLine)
                .Append($"Corps: {base.CorpsType}").Append(Environment.NewLine)
                .Append("Repairs:");

            if (this.RepairedParts == null)
            {
                return stringToReturn.ToString();
            }

            foreach (var repairedPart in this.RepairedParts)
            {
                stringToReturn.Append(Environment.NewLine).Append($"  Part Name: {repairedPart.Key} Hours Worked: {repairedPart.Value}");
            }

            return stringToReturn.ToString();
        }
    }
}
