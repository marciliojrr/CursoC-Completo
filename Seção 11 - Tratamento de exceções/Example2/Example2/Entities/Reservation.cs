using System;

namespace Example2.Entities
{
    internal class Reservation
    {
        // AutoProps
        public int RoomNumber { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }

        // Constructors
        public Reservation() { }

        public Reservation(int roomNumber, DateTime checkIn, DateTime checkOut)
        {
            RoomNumber = roomNumber;
            CheckIn = checkIn;
            CheckOut = checkOut;
        }

        // Methods
        public int Duration()
        {
            TimeSpan duration = CheckOut.Subtract(CheckIn);
            return (int)duration.TotalDays;
        }

        public string UpdateDates(DateTime checkIn, DateTime checkOut)
        {
            DateTime now = DateTime.Now;

            if (checkIn < now || checkOut < now)
            {
                return "Reservation dates for update must be future dates!";
            }
            if (checkOut <= checkIn)
            {
                return "Check-out date must be after check-in date.";
            }

            CheckIn = checkIn;
            CheckOut = checkOut;

            return null; // null indicara que nao houve nenhum erro
        }

        public override string ToString()
        {
            return $"Reservation: Room {RoomNumber}, check-in: {CheckIn.ToString("dd/MM/yyyy")}, check-out: {CheckOut.ToString("dd/MM/yyyy")}, {Duration()} nights.";
        }
    }
}
