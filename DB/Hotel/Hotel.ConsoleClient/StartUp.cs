
namespace Hotel.ConsoleClient
{
    using System;
    using System.Data.Entity;
    using Hotel.Data.Migrations;
    using Hotel.Models;
    using Data;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            Database.SetInitializer(
                new MigrateDatabaseToLatestVersion<HotelContext, Configuration>());

            var db = new HotelContext();

            //var status = new RoomStatus()
            //{
            //    Status = "busy",
            //    Notes = "busy"
            //};

            //var type = new RoomType()
            //{
            //    Type = "big",
            //    Notes = "2 beds"
            //};

            //var bedType = new BedType()
            //{
            //    Type = "big",
            //    Notes = "2 persons"
            //};

            //db.BedTypes.Add(bedType);
            //db.RoomStatus.Add(status);
            //db.RoomTypes.Add(type);

            //var room = new Room()
            //{
            //    RoomNumber = 102,
            //    RoomTypeId = 1,
            //    RoomStatusId = 1,
            //    BedTypeId = 1,
            //    Rate = 12,
            //    Notes = "sea view"
            //};

            //db.Rooms.Add(room);
            db.SaveChanges();


            var test = db.Rooms.Select(r => r.BedType.Type == "big").Count();

            Console.WriteLine(test);
        }
    }
}
