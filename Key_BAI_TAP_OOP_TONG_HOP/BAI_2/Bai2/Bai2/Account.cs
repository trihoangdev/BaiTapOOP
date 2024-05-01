using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2
{
    public abstract class Account
    {
        public string Id { get; set; }          //Mã tài khoản
        public string Username { get; set; }    //Tài khoản
        public string Password { get; set; }    //Mật khẩu
        public FullName FullName { get; set; }
        public string AvatarPath { get; set; }  //Đường dẫn của Avatar
        public string PhoneNumber { get; set; } //SĐT
        public bool Status { get; set; }        //Trạng thái: 0-offline, 1-online
        public string Type { get; set; }        //Kiểu: kiểu KH/ kiểu xe
        public Account() { }
        public Account(string username, string fullName, string avatarPath, string phone)
        {
            Username = username;
            Password = "123";           //Mật khẩu mặc định
            FullName = new FullName(fullName);
            AvatarPath = avatarPath;
            PhoneNumber = phone;
            Status = false;             //mặc định tạo TK là false
        }
        public Account(string id, string username, string password, FullName fullName,
            string avatarPath, string phone, bool status, string type)
        {
            Id = id;
            Username = username;
            Password = password;
            FullName = fullName;
            AvatarPath = avatarPath;
            PhoneNumber = phone;
            Status = status;
            Type = type;
        }
    }
    public class FullName
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MidName { get; set; }
        public FullName() { }
        public FullName(string fullName)
        {
            var data = fullName.Split(' ');
            FirstName = data[data.Length - 1];
            LastName = data[0];
            var mid = "";
            for (int i = 1; i < data.Length - 1; i++)
                mid += data[i] + " ";
            MidName = mid.Trim();
        }

        public override string ToString() => $"{LastName} {MidName} {FirstName}";
    }

}
