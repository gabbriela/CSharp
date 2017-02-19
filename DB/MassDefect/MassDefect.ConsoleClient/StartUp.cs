namespace MassDefect.ConsoleClient
{
    using System.Linq;
    using Data;

    public class StartUp
    {
        public static void Main()
        {
            var db = new MassDefectContext();

            var count = db.Anomalies.Count();
        }
    }
}
