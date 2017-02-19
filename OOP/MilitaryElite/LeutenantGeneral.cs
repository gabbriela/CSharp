
using System;
using System.Collections.Generic;
using System.Text;

namespace _08.MilitaryElite
{
    class LeutenantGeneral : Private, ILeutenantGeneral
    {
        
        public List<Private> ListOfPrivates { get; set; }
        
        public LeutenantGeneral(string id, string firstName, string lastName, double salary, List<Private> listOfPrivates) 
            : base(id, firstName, lastName, salary)
        {
            this.ListOfPrivates = listOfPrivates;
            base.Type = "leutenantgeneral";
        }

        public override string ToString()
        {
            StringBuilder stringToReturn = new StringBuilder();

            stringToReturn.Append($"Name: {base.FirstName} {base.LastName} Id: {base.Id} Salary: {base.Salary:f2}")
                .Append(Environment.NewLine)
                .Append("Privates:");

            foreach (var soldier in this.ListOfPrivates)
            {
                stringToReturn.Append(Environment.NewLine).Append($"  {soldier}");
            }

            return stringToReturn.ToString();
        }
    }
}
