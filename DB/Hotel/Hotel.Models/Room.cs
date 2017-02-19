namespace Hotel.Models
{
    public class Room
    {
        public int Id { get; set; }

        public int RoomNumber { get; set; }

        public int RoomTypeId { get; set; }
        public virtual RoomType RoomType { get; set; }

        public int BedTypeId { get; set; }
        public virtual BedType BedType { get; set; }

        public int RoomStatusId { get; set; }
        public virtual RoomStatus RoomStatus { get; set; }

        public int Rate { get; set; }
        public string Notes { get; set; }
    }
}
