namespace Hotel.Data
{
    using Models;
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class HotelContext : DbContext
    {

        public HotelContext()
            : base("name=HotelContext")
        {
        }

        public virtual IDbSet<Employee> Employees { get; set; }
        public virtual IDbSet<Customer> Customers { get; set; }
        public virtual IDbSet<RoomStatus> RoomStatus  { get; set; }
        public virtual IDbSet<RoomType> RoomTypes { get; set; }
        public virtual IDbSet<BedType> BedTypes { get; set; }
        public virtual IDbSet<Room> Rooms { get; set; }
        public virtual IDbSet<Payment> Payments { get; set; }
        public virtual IDbSet<Occupancies> Occupancieses { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}