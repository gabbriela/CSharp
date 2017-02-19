using FootballBookmarker.Data;
using System.Data.Entity;
using System.Linq;
using FootballBookmarker.Data.Migrations;

namespace FootballBookmarker.ConsoleClient
{
    public class StartUp
    {
        public static void Main()
        {
            Database.SetInitializer(
                new MigrateDatabaseToLatestVersion<FootballBookmarkerContext, Configuration>());

            using (var db = new FootballBookmarkerContext())
            {
                var count = db.Players.Count();
            }
        }
    }
}
