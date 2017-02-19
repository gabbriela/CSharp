using System;

namespace Hotel.Models
{
    public class Payment
    {
        public int Id { get; set; }

        public DateTime PaymentDate { get; set; }

        public string AccountNumber { get; set; }

        public DateTime FirstDateOccupied { get; set; }

        public DateTime LastDateOccupied { get; set; }

        public int TotalDays { get; set; }

        public decimal AmountCharged { get; set; }

        public double TaxRate { get; set; }

        public decimal TaxAmount { get; set; }

        public decimal PaymentTotal { get; set; }

        public string Notes { get; set; }
    }
}
