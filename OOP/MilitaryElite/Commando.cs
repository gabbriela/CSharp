using System;
using System.Collections.Generic;
using System.Text;

namespace _08.MilitaryElite
{
    class Commando : SpecialisedSoldier, ICommando
    {
        private Dictionary<string, string> missions;

        public Dictionary<string, string> Missions
        {
            get { return this.missions; }
            set
            {
                this.missions = value;
            }
        }

        public void CompleteMission()
        {
            throw new System.NotImplementedException();
        }

        public Commando(string id, string firstName, string lastName, double salary, string corpsType, Dictionary<string, string> missions) 
            : base(id, firstName, lastName, salary, corpsType)
        {
            this.Missions = missions;
            base.Type = "commando";
        }

        public override string ToString()
        {
            StringBuilder stringToReturn = new StringBuilder();

            stringToReturn.Append($"Name: {base.FirstName} {base.LastName} Id: {base.Id} Salary: {base.Salary:f2}")
                .Append(Environment.NewLine)
                .Append($"Corps: {base.CorpsType}").Append(Environment.NewLine)
                .Append("Missions:");

            if (this.Missions == null)
            {
                return stringToReturn.ToString();
            }

            foreach (var currentMission in this.Missions)
            {
                stringToReturn.Append(Environment.NewLine).Append($"  Code Name: {currentMission.Key} State: {currentMission.Value}");
            }

            return stringToReturn.ToString();
        }
    }
}
