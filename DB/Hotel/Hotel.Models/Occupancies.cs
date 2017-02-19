using System;

namespace Hotel.Models
{
    public class Occupancies
    {
        public int Id { get; set; }

        public DateTime DateOccupied { get; set; }

        public string AccountNumber { get; set; }

        public int RoomNumber { get; set; }

        public int RateApplied { get; set; }

        public decimal PhoneCharge { get; set; } 
            
         public string Notes { get; set; }

    }
}
