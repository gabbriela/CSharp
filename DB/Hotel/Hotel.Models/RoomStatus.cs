using System.Collections.Generic;

namespace Hotel.Models
{
    public class RoomStatus
    {
        private ICollection<Room> rooms;

        public RoomStatus()
        {
            this.rooms = new HashSet<Room>();
        }
        
        public int Id { get; set; }

        public string Status { get; set; }

        public string Notes { get; set; }

        public virtual ICollection<Room> Rooms
        {
            get { return this.rooms; }
            set { this.rooms = value; }
        }
    }
}
