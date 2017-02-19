using System;

namespace _08.MilitaryElite
{
    public abstract class SpecialisedSoldier : Soldier, IPrivate
    {
        private string corpsType;
        
        public string CorpsType
        {
            get
            {
                return corpsType;
            }
            set
            {
                if (value != "Airforces" && value != "Marines")
                {
                    throw new ArgumentException("");
                }
                corpsType = value;
            }
        }

        protected SpecialisedSoldier(string id, string firstName, string lastName, double salary, string corpsType) 
            : base(id, firstName, lastName)
        {
            this.CorpsType = corpsType;
            this.Salary = salary;
            
        }

        public double Salary { get; set; }
    }
}
