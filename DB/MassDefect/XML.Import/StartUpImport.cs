namespace XML.Import
{
    using System;
    using System.Linq;
    using System.Xml.Linq;
    using System.Xml.XPath;
    using MassDefect.Data;
    using MassDefect.Models;

    public class StartUpImport
    {
        private const string NewAnomaliesPath = "../../../datasets/new-anomalies.xml";

        private const string ErrorMsg = "Error: Invalid data.";

        public static void Main(string[] args)
        {
            var xml = XDocument.Load(NewAnomaliesPath);
            var anomalies = xml.XPathSelectElements("anomalies/anomaly");

            var context = new MassDefectContext();

            foreach (var anomaly in anomalies)
            {
                ImportAnomalyAndVictims(anomaly, context);
            }
        }

        private static void ImportAnomalyAndVictims(XElement anomalyNode, MassDefectContext context)
        {
            var originPlanetName = anomalyNode.Attribute("origin-planet");
            var teleportPlanetName = anomalyNode.Attribute("teleport-planet");

            if (originPlanetName != null && teleportPlanetName != null)
            {
                var anomalyEntity = new Anomaly()
                {
                    OriginPlanet = GetPlanetByName(originPlanetName.Value, context),
                    TeleportPlanet = GetPlanetByName(teleportPlanetName.Value, context)
                };

                if (anomalyEntity.OriginPlanet != null && anomalyEntity.TeleportPlanet != null)
                {
                    context.Anomalies.Add(anomalyEntity);

                    var victims = anomalyNode.XPathSelectElements("victims/victim");
                    foreach (var victim in victims)
                    {
                        ImportVictim(victim, context, anomalyEntity);
                    }

                    context.SaveChanges();
                    Console.WriteLine("Successfully imported anomaly.");
                }
                else
                {
                    Console.WriteLine(ErrorMsg);
                }
            }
            else
            {
                Console.WriteLine(ErrorMsg);
            }
        }

        private static void ImportVictim(XElement victimNode, MassDefectContext context, Anomaly anomalyEntity)
        {
            var name = victimNode.Attribute("name");

            if (name != null)
            {
                var personEntity = GetPersonByName(name.Value, context);

                if (personEntity != null)
                {
                    anomalyEntity.Victims.Add(personEntity);
                }
                else
                {
                    Console.WriteLine(ErrorMsg);
                }
            }
            else
            {
                Console.WriteLine(ErrorMsg);
            }
        }

        private static Person GetPersonByName(string name, MassDefectContext context)
        {
            return context.Persons
                .FirstOrDefault(p => p.Name == name);
        }

        private static Planet GetPlanetByName(string name, MassDefectContext context)
        {
            return context.Planets
                .FirstOrDefault(p => p.Name == name);
        }
    }
}
