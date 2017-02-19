namespace XML.Export
{
    using System.Linq;
    using System.Xml.Linq;
    using MassDefect.Data;

    public class StartUpExport
    {
        public static void Main(string[] args)
        {
            var context = new MassDefectContext();

            var exportedAnomalies = context.Anomalies
                .Select(a => new
                {
                    id = a.Id,
                    originPlanetName = a.OriginPlanet.Name,
                    teleportPlanetName = a.TeleportPlanet.Name,
                    victims = a.Victims.Select(v => v.Name)
                })
                .OrderBy(a => a.id);

            var xmlDocument = new XElement("anomalies");

            foreach (var anomaly in exportedAnomalies)
            {
                var anomalyNode = new XElement("anomaly");
                anomalyNode.Add(new XAttribute("id", anomaly.id));
                anomalyNode.Add(new XAttribute("origin-planet", anomaly.teleportPlanetName));
                anomalyNode.Add(new XAttribute("teleport-planet", anomaly.teleportPlanetName));

                var victimsNode = new XElement("victims");

                foreach (var victim in anomaly.victims)
                {
                    var victimNode = new XElement("victims");
                    victimNode.Add(new XAttribute("name", victim));
                    victimsNode.Add(victimNode);
                }
                
                anomalyNode.Add(victimsNode);
                xmlDocument.Add(anomalyNode);

                xmlDocument.Save("../../anomalies.xml");
            }
        }
    }
}
