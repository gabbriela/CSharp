namespace JSON.Export
{
    using System.IO;
    using System.Linq;
    using MassDefect.Data;
    using Newtonsoft.Json;

    public class StartUpExport
    {
        public static void Main()
        {
            var context = new MassDefectContext();

            ExportPlanetsWhichAreNotAnomalyOrigins(context);

            ExportPeopleWhichAreNotBeenVictims(context);

            ExportTopAnomaly(context);
        }

        private static void ExportTopAnomaly(MassDefectContext context)
        {
            var exportedAnomalies = context.Anomalies
                .OrderByDescending(a => a.Victims.Count)
                .Take(1)
                .Select(a => new
                {
                    id = a.Id,
                    originPlanet = a.OriginPlanet.Name,
                    teleportPlanet = a.TeleportPlanet.Name,
                    victimsCount = a.Victims.Count
                }).ToList();
            
            var anomalyToJson = JsonConvert.SerializeObject(exportedAnomalies, Formatting.Indented);
            File.WriteAllText("../../anomalies.json", anomalyToJson);
        }

        private static void ExportPeopleWhichAreNotBeenVictims(MassDefectContext context)
        {
            var exportedPeople = context.Persons
               .Where(person => !person.Anomalies.Any())
               .Select(person => new
               {
                   name = person.Name,
                   homePlanet = person.HomePlanet.Name
               }).ToList();

            var personAsJson = JsonConvert.SerializeObject(exportedPeople, Formatting.Indented);
            File.WriteAllText("../../people.json", personAsJson);
        }

        private static void ExportPlanetsWhichAreNotAnomalyOrigins(MassDefectContext context)
        {
            var exportedPlanets = context.Planets
                .Where(planet => !planet.AnomalyFromPlanet.Any())
                .Select(pl => new
                {
                    name = pl.Name
                }).ToList();
            
            var planetsAsJson = JsonConvert.SerializeObject(exportedPlanets, Formatting.Indented);
            File.WriteAllText("../../planets.json", planetsAsJson);
        }
    }
}
