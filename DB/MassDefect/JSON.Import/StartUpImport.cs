namespace JSON.Import
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using DTO;
    using MassDefect.Data;
    using MassDefect.Models;
    using Newtonsoft.Json;

    public class StartUpImport
    {
        private const string SolarSystemPath = "../../../datasets/solar-systems.json";
        private const string StartsPath = "../../../datasets/stars.json";
        private const string PlanetsPath = "../../../datasets/planets.json";
        private const string PersonsPath = "../../../datasets/persons.json";
        private const string AnomaliesPath = "../../../datasets/anomalies.json";
        private const string AnomalyVictimsPath = "../../../datasets/anomaly-victims.json";

        private const string ErrorMsg = "Error: Invalid data.";

        public static void Main()
        {
            ImportSolarSystems();
            ImportStars();
            ImportPlanets();
            ImportPersons();
            ImportAnomalies();
            ImportAnomalyVictims();
        }

        private static void ImportAnomalyVictims()
        {
            var context = new MassDefectContext();
            var json = File.ReadAllText(AnomalyVictimsPath);
            var anomalyVictims = JsonConvert.DeserializeObject<IEnumerable<AnomalyVictimsDTO>>(json);

            foreach (var anomalyVictim in anomalyVictims)
            {
                if (anomalyVictim.Person == null || anomalyVictim.Id == null)
                {
                    Console.WriteLine(ErrorMsg);
                    continue;
                }

                Anomaly anomalyEntity = GetAnomalyById(anomalyVictim.Id, context);
                Person personEntity = GetPersonById(anomalyVictim.Person, context);

                if (anomalyEntity == null || personEntity == null)
                {
                    Console.WriteLine(ErrorMsg);
                    continue;
                }

                 anomalyEntity.Victims.Add(personEntity);
            }

            context.SaveChanges();
        }

        private static void ImportAnomalies()
        {
            var context = new MassDefectContext();
            var json = File.ReadAllText(AnomaliesPath);
            var anomalies = JsonConvert.DeserializeObject<IEnumerable<AnomalyDTO>>(json);

            foreach (var anomaly in anomalies)
            {
                if (anomaly.OriginPlanet == null || anomaly.TeleportPlanet == null)
                {
                    Console.WriteLine(ErrorMsg);
                    continue;
                }

                var anomalyEntity = new Anomaly()
                {
                    OriginPlanet = GetPlanetByName(anomaly.OriginPlanet, context),
                    TeleportPlanet = GetPlanetByName(anomaly.TeleportPlanet, context)
                };

                if (anomalyEntity.TeleportPlanet == null || anomalyEntity.OriginPlanet == null)
                {
                    Console.WriteLine(ErrorMsg);
                    continue;
                }

                context.Anomalies.Add(anomalyEntity);
                Console.WriteLine("Successfully imported anomaly.");
            }

            context.SaveChanges();
        }

        private static void ImportPersons()
        {
            var context = new MassDefectContext();
            var json = File.ReadAllText(PersonsPath);
            var persons = JsonConvert.DeserializeObject<IEnumerable<PersonDTO>>(json);

            foreach (var person in persons)
            {
                if (person.Name == null || person.HomePlanet == null)
                {
                    Console.WriteLine(ErrorMsg);
                    continue;
                }

                var personEntity = new Person()
                {
                    Name = person.Name,
                    HomePlanet = GetPlanetByName(person.HomePlanet, context)
                };

                if (personEntity.HomePlanet == null)
                {
                    Console.WriteLine(ErrorMsg);
                    continue;
                }

                context.Persons.Add(personEntity);
                Console.WriteLine($"Successfully imported Person {personEntity.Name}.");
            }

            context.SaveChanges();
        }

        private static void ImportPlanets()
        {
            var context = new MassDefectContext();
            var json = File.ReadAllText(PlanetsPath);
            var planets = JsonConvert.DeserializeObject<IEnumerable<PlanetDTO>>(json);

            foreach (var planet in planets)
            {
                if (planet.Name == null || planet.SolarSystem == null || planet.Sun == null)
                {
                    Console.WriteLine("Error: Invalid data.");
                    continue;
                }

                var planetEntity = new Planet()
                {
                    Name = planet.Name,
                    Sun = GetSunByName(planet.Sun, context), 
                    SolarSystem = GetSolarSystemByName(planet.SolarSystem, context)
                };

                if (planetEntity.Sun == null || planetEntity.SolarSystem == null)
                {
                    Console.WriteLine(ErrorMsg);
                    continue;
                }

                context.Planets.Add(planetEntity);

                Console.WriteLine($"Successfully imported Planet {planetEntity.Name}.");
            }

            context.SaveChanges();
        }
        
        private static void ImportStars()
        {
            var context = new MassDefectContext();
            var json = File.ReadAllText(StartsPath);
            var stars = JsonConvert.DeserializeObject<IEnumerable<StarDTO>>(json);

            foreach (var star in stars)
            {
                if (star.Name == null || star.SolarSystem == null)
                {
                    Console.WriteLine(ErrorMsg);
                    continue;
                }

                var starEntity = new Star()
                {
                    Name = star.Name,
                    SolarSystem = GetSolarSystemByName(star.SolarSystem, context)
                };

                if (starEntity.SolarSystem == null)
                {
                    Console.WriteLine("Error: Invalid data.");
                    continue;
                }

                context.Stars.Add(starEntity);
                Console.WriteLine($"Successfully imported Star {starEntity.Name}.");
            }

            context.SaveChanges();
        }

        private static void ImportSolarSystems()
        {
            var context = new MassDefectContext();
            var json = File.ReadAllText(SolarSystemPath);
            var solarSystems = JsonConvert.DeserializeObject<IEnumerable<SolarSystemDTO>>(json);

            foreach (var solarSystem in solarSystems)
            {
                if (solarSystem.Name == null)
                {
                    Console.WriteLine(ErrorMsg);
                    continue;
                }

                var solarSystemEntity = new SolarSystem()
                {
                    Name = solarSystem.Name
                };

                context.SolarSystems.Add(solarSystemEntity);
                Console.WriteLine($"Successfully imported Solar System {solarSystemEntity.Name}.");  
            }

            context.SaveChanges();
        }
        
        private static Planet GetPlanetByName(string homePlanet, MassDefectContext context)
        {
            Planet planet = context.Planets
                .FirstOrDefault(p => p.Name == homePlanet);

            return planet;
        }

        private static Star GetSunByName(string sun, MassDefectContext context)
        {
            Star star = context.Stars
                .FirstOrDefault(s => s.Name == sun);

            return star;
        }
        
        private static SolarSystem GetSolarSystemByName(string solarSystem, MassDefectContext context)
        {
            SolarSystem system = context.SolarSystems
                .FirstOrDefault(s => s.Name == solarSystem);

            return system;
        }
        
        private static Person GetPersonById(string person, MassDefectContext context)
        {
            return context.Persons
                .FirstOrDefault(p => p.Name == person);
        }

        private static Anomaly GetAnomalyById(int? id, MassDefectContext context)
        {
            Anomaly anomaly = context.Anomalies
                .FirstOrDefault(a => a.Id == id);

            return anomaly;
        }
    }
}
