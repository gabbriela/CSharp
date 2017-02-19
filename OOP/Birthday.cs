using System.CodeDom;

namespace _06.BirthdayCelebrations
{

    namespace _05.BorderControl
    {
        using System;
        using System.Collections.Generic;

        interface IIdentifiable
        {
            string Id { get; set; }
        }

        interface IBirthdayable
        {
            string Birthday { get; set; }
        }

        public abstract class CityMembers : IIdentifiable
        {
            private string name;

            protected CityMembers(string name, string id)
            {
                this.Name = name;
                this.Id = id;
            }

            public string Id { get; set; }

            public string Name
            {
                get
                {
                    return name;
                }

                set
                {
                    name = value;
                }
            }

        }

        public class Citizen : CityMembers, IBirthdayable
        {
            private int age;

            public Citizen(string name, int age, string id, string birthday)
                : base(name, id)
            {
                this.Age = age;
                this.Birthday = birthday;
            }

            public int Age
            {
                get
                {
                    return age;
                }

                set
                {
                    age = value;
                }
            }

            public string Birthday { get; set; }
        }

        public class Robot : CityMembers
        {
            public Robot(string name, string id) : base(name, id)
            {
            }
        }

        public class Pet : IBirthdayable
        {
            public Pet(string name, string birthday)
            {
                this.Birthday = birthday;
                this.Name = name;
            }
            public string Birthday { get; set; }

            public string Name { get; set; }
        }

        public class StartUp
        {
            static void Main(string[] args)
            {
                List<IIdentifiable> entranceList = new List<IIdentifiable>();
                List<IBirthdayable> entranceWithBirthday = new List<IBirthdayable>();

                string entrance = Console.ReadLine();

                while (entrance != "End")
                {
                    string[] entranceDetiails = entrance.Split(' ');
                    string type = entranceDetiails[0];
                    string name = entranceDetiails[1];

                    if (type == "Citizen")
                    {
                        int age = int.Parse(entranceDetiails[2]);
                        string id = entranceDetiails[3];
                        string birthday = entranceDetiails[4];
                        Citizen currentCitizen = new Citizen(name, age, id, birthday);
                        entranceList.Add(currentCitizen);
                        entranceWithBirthday.Add(currentCitizen);
                    }
                    else if (type == "Pet")
                    {
                        string birthday = entranceDetiails[2];
                        Pet currentPet = new Pet(name, birthday);
                        entranceWithBirthday.Add(currentPet);
                    }
                    else  //Robot
                    {
                        string id = entranceDetiails[1];
                        Robot currentRobot = new Robot(name, id);
                        entranceList.Add(currentRobot);
                    }
                    entrance = Console.ReadLine();
                }

                string birthdayYear = Console.ReadLine();

                foreach (var entered in entranceWithBirthday)
                {
                    if (entered.Birthday.EndsWith(birthdayYear))
                    {
                        Console.WriteLine(entered.Birthday);
                    }
                }
            }
        }
    }

}
