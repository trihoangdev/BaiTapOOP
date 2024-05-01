using System;
using System.Collections.Generic;

namespace Bai2
{
    public class DriverAccount : Account
    {
        private static int IdInt;
        public float DriverReceived { get; set; }   //Số tiền tài xế nhận được
        public float BookingFee { get; set; }       //Số tiền thuế đã nộp
        public float Bonus {  get; set; }           //Số tiền thưởng
        public DriverAccount() : base() { }
        public DriverAccount(string username, string fullName,
            string avatarPath, string phone, string type)
            : base(username, fullName, avatarPath, phone)
        {
            Id = GetId();
            Type = type; //Kiểu xe
        }
        private string GetId()
        {
            return "DR" + ++IdInt;
        }
        public static void SetLastId(List<DriverAccount> drivers)
        {
            if (drivers.Count > 0)
            {
                IdInt = int.Parse(drivers[drivers.Count - 1].Id.Substring(2));
            }
            else
            {
                IdInt = 0; // Khởi tạo IdInt nếu không có người dùng nào trong danh sách
            }
        }
    }
}
