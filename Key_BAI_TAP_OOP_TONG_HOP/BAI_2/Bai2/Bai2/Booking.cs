using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2
{
    public class Booking
    {
        private static int IdInt;
        public string Id { get; set; }
        public DriverAccount Driver { get; set; }
        public UserAccount User { get; set; }
        public string StartPosition { get; set; }
        public string EndPosition { get; set; }
        public int Distance { get; set; }
        public DateTime StartTime { get; set; }
        public float TotalPrice { get; set; }
        public float BookingFee { get; set; }
        public Booking() { }
        public Booking(DriverAccount driver, UserAccount user, string startPosition,
            string endPosition, int distance, float totalPrice, float bookingFee, DateTime startTime
           )
        {
            Id = GetId();
            Driver = driver;
            User = user;
            StartPosition = startPosition;
            EndPosition = endPosition;
            Distance = distance;
            StartTime = startTime;
            TotalPrice = totalPrice;
            BookingFee = bookingFee;
        }

        private string GetId() => "BO" + ++IdInt;
        public static void SetLastId(List<Booking> bookings)
        {
            if (bookings.Count > 0)
            {
                IdInt = int.Parse(bookings[bookings.Count - 1].Id.Substring(2));
            }
            else
            {
                IdInt = 0; // Khởi tạo IdInt nếu không có người dùng nào trong danh sách
            }
        }
    }
}
