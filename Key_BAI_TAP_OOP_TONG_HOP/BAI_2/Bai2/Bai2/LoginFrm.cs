using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;
using System.IO;

namespace Bai2
{
    public partial class LoginFrm : Form
    {
        public List<UserAccount> Users = new List<UserAccount>();
        public List<DriverAccount> Drivers = new List<DriverAccount>();
        public List<Booking> Bookings = new List<Booking>();
        public LoginFrm()
        {
            InitializeComponent();
            ReadFile();
        }

        private void ReadFile()
        {
            //Đọc data người dùng
            var data = File.ReadAllText("D:\\BVU\\OOP\\BaiTapTongHopOOP\\Key_BAI_TAP_OOP_TONG_HOP\\BAI_2\\Bai2\\Bai2\\accounts.json");
            if (data != "")
            {
                var jObject = JObject.Parse(data);
                var users = jObject["Users"].ToObject<List<UserAccount>>(); // Chuyển đổi thành danh sách UserAccount
                var drivers = jObject["Drivers"].ToObject<List<DriverAccount>>(); // Tương tự cho Drivers
                Users.AddRange(users); // Thêm danh sách người dùng vào Users
                Drivers.AddRange(drivers); // Thêm danh sách tài xế vào Drivers
            }
            UserAccount.SetLastId(Users); // Cập nhật IdInt sau khi đã thêm danh sách người dùng
            DriverAccount.SetLastId(Drivers); // Cập nhật IdInt sau khi đã thêm danh sách tài xế

            //Đọc data Booking
            var dataBooking = File.ReadAllText("D:\\BVU\\OOP\\BaiTapTongHopOOP\\Key_BAI_TAP_OOP_TONG_HOP\\BAI_2\\Bai2\\Bai2\\bookings.json");
            if(dataBooking !="")
            {
                var jObject = JObject.Parse(dataBooking);
                var bookings = jObject["Bookings"].ToObject<List<Booking>>(); // Chuyển đổi thành danh sách Booking
                Bookings.AddRange(bookings);//Thêm danh sách chuyến đi
            }
            Booking.SetLastId(Bookings);// Cập nhật IdInt sau khi đã thêm danh sách chuyến đi

        }

        //Sự kiện đăng nhập
        private void btnLogin_Click(object sender, EventArgs e)
        {
            var username = txtUsername.Text;
            var password = txtPassword.Text;
            if (IsAdmin(username, password))
            {
                AdminFrm f = new AdminFrm(Users, Drivers, Bookings);
                f.ShowDialog();
            }
            else
            {
                var user = FindUser(username, password);
                if (user != null) //tìm thấy user
                {
                    UserFrm f = new UserFrm(Users, Drivers, user, Bookings);
                    f.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Sai tài khoản hoặc mật khẩu, vui lòng kiểm tra lại", "Thông báo",
                        MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                }
            }
        }

        //Tìm tài khoản mật khẩu có tồn tại chưa
        private UserAccount FindUser(string username, string password)
        {
            foreach (var user in Users)
                if (user.Username == username && user.Password == password)
                    return user;
            return null;
        }

        //Kiểm tra có phải admin ko
        private bool IsAdmin(string username, string password)
        {
            return username == "admin" && password == "123" && checkAdmin.Checked == true;
        }
    }
}
