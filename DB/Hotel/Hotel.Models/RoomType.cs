using System.Collections.Generic;

namespace Hotel.Models
{
    public class RoomType
    {
        private ICollection<Room> rooms;

        public RoomType()
        {
            this.rooms = new HashSet<Room>();
        }

        public int Id { get; set; }

        public string Type { get; set; }

        public string Notes { get; set; }

        public virtual ICollection<Room> Rooms
        {
            get { return this.rooms; }
            set { this.rooms = value; }
        }
    }
}
