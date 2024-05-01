using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2
{
    public class UserAccount : Account
    {
        private static int IdInt ;
        public float TotalPrice { get; set; }
        public UserAccount() : base() { }
        public UserAccount(string username, string fullName,
            string avatarPath, string phone, string type)
            : base(username, fullName, avatarPath, phone)
        {
            Id = GetId();
            Type = type;
        }
        public UserAccount(string id, string username, string password, FullName fullName,
            string avatarPath, string phone, bool status, string type) :
            base(id, username, password, fullName,
             avatarPath, phone, status, type)
        {
        }

        private string GetId()
        {
            return "KH" + ++IdInt;
        }
        public static void SetLastId(List<UserAccount> users)
        {
            if (users.Count > 0)
            {
                IdInt = int.Parse(users[users.Count - 1].Id.Substring(2));
            }
            else
            {
                IdInt = 0; // Khởi tạo IdInt nếu không có người dùng nào trong danh sách
            }
        }
    }
}
