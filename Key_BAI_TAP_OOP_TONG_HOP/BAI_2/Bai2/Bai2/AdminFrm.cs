using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.IO;

namespace Bai2
{
    public partial class AdminFrm : Form
    {
        public List<UserAccount> Users = new List<UserAccount>();
        public List<DriverAccount> Drivers = new List<DriverAccount>();
        public List<Booking> Bookings = new List<Booking>();
        public AdminFrm(List<UserAccount> users, List<DriverAccount> drivers, List<Booking> bookings)
        {
            InitializeComponent();
            Users = users;
            Drivers = drivers;
            Bookings = bookings;
            FirstLoadData();
        }

        private void FirstLoadData()
        {
            AddUserDataToTable(Users);
            FillDataToManageUserBox(Users);
        }

        //Ghi File JSON
        private void SaveToFile()
        {
            var root = new
            {
                Users,
                Drivers,
            };
            var stringJson = JsonConvert.SerializeObject(root, Formatting.Indented);
            try
            {
                var filePath = "D:\\BVU\\OOP\\BaiTapTongHopOOP\\Key_BAI_TAP_OOP_TONG_HOP\\BAI_2\\Bai2\\Bai2\\accounts.json";
                File.WriteAllText(filePath, string.Empty);
                File.WriteAllText(filePath, stringJson);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        //tạo mới tài khoản
        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            var fullName = txtFullName.Text;
            var username = txtUsername.Text;
            var phone = txtPhone.Text;
            var type = comboType.SelectedItem as string;
            if (radioTypeDriver.Checked)
            {
                //Tạo tài khoản tài xế
                var driver = new DriverAccount(username, fullName, "", phone, type);
                Drivers.Add(driver);
            }
            else
            {
                //Tạo tài khoản khách hàng
                var user = new UserAccount(username, fullName, "", phone, type);
                Users.Add(user);
            }
            SaveToFile();
            MessageBox.Show("Tạo tài khoản thành công!");
        }

        private void radioTypeDriver_CheckedChanged(object sender, EventArgs e)
        {
            if (radioTypeDriver.Checked)
            {
                var types = new List<String>
                { "Xe gắn máy","Xe ô tô (4 chỗ)",
                    "Xe ô tô (7 chỗ)",
                    "Xe ô tô tải (<=3 tấn)",
                    "Xe ô tô tải (>3 tấn)"};
                comboType.DataSource = types;
            }
        }

        private void radioTypeUser_CheckedChanged(object sender, EventArgs e)
        {
            if (radioTypeUser.Checked)
            {
                var types = new List<String> { "Thường" };
                comboType.DataSource = types;
            }
        }

        //Đẩy dữ liệu User vào bảng
        public void AddUserDataToTable(List<UserAccount> users)
        {
            dtgvUser.Rows.Clear(); //Xóa Data hiện tại
            // Thêm dữ liệu từ danh sách người dùng vào DataGridView
            foreach (var user in users)
            {
                dtgvUser.Rows.Add(user.Id, user.FullName, user.Type, user.PhoneNumber, user.TotalPrice + "đ");
            }
        }
        //Đẩy dữ liệu Tài xế vào bảng
        public void AddDriverDataToTable(List<DriverAccount> drivers)
        {
            dtgvDriver.Rows.Clear(); //Xóa Data hiện tại
            // Thêm dữ liệu từ danh sách người dùng vào DataGridView
            foreach (var driver in drivers)
            {
                dtgvDriver.Rows.Add(driver.Id, driver.FullName, driver.PhoneNumber, driver.Type, driver.BookingFee + "đ", 0);
            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Lấy chỉ mục của tab hiện tại
            int selectedIndex = tabControl1.SelectedIndex;

            // Kiểm tra xem tab nào đang được chọn và gọi phương thức tương ứng
            switch (selectedIndex)
            {
                case 0:
                    AddUserDataToTable(Users);
                    FillDataToManageUserBox(Users);
                    break;
                case 1:
                    AddDriverDataToTable(Drivers);
                    break;
                case 2:
                    AddBookingDataToTable(Bookings);
                    FillDataToManageBookingBox();
                    break;
                default:
                    break;
            }
        }

        private void FillDataToManageUserBox(List<UserAccount> users)
        {
            txtTotalUser.Text = users.Count.ToString();
        }

        //Điền các thông tin vào ô thống kê
        private void FillDataToManageBookingBox()
        {
            txtTotalBooking.Text = Bookings.Count.ToString();
        }

        //Đẩy dữ liệu chuyến đi vào bảng
        private void AddBookingDataToTable(List<Booking> bookings)
        {
            dtgvBooking.Rows.Clear();
            foreach (var booking in bookings)
            {
                dtgvBooking.Rows.Add(booking.Id, booking.Driver.Id, booking.Driver.FullName.ToString(),
                    booking.Driver.Type, booking.User.Id, booking.User.FullName.ToString(),
                    booking.Distance + " km", booking.StartTime.ToString("dd/MM/yyyy"),
                    booking.TotalPrice + " đ", booking.BookingFee + " đ");
            }

        }

        private void btnFindUser_Click(object sender, EventArgs e)
        {
            //Lấy lựa chọn
            var choice = comboUserSearch.SelectedItem as string;
            switch (choice)
            {
                case "Khách hàng \"VIP\"":
                    var vipUser = FindVIPUser(Users);
                    AddUserDataToTable(vipUser);
                    FillDataToManageUserBox(vipUser);
                    break;
                case "Khách hàng \"Thường\"":
                    var normalUser = FindNormalUser(Users);
                    AddUserDataToTable(normalUser);
                    FillDataToManageUserBox(normalUser);
                    break;
                case "Khách hàng có số chuyến đi nhiều nhất":
                    var bestUser = FindUserByBestBooking(Users, Bookings);
                    AddUserDataToTable(bestUser);
                    FillDataToManageUserBox(bestUser);
                    break;
            }
        }
        // Tìm khách hàng có chuyến đi nhiều nhất
        private static List<UserAccount> FindUserByBestBooking(List<UserAccount> users, List<Booking> bookings)
        {
            // Tạo Dictionary để đếm số lần xuất hiện của mỗi người dùng
            Dictionary<string, int> userCounts = new Dictionary<string, int>();

            // Đếm số lần xuất hiện của mỗi người dùng
            foreach (var booking in bookings)
            {
                string userId = booking.User.Id;

                if (userCounts.ContainsKey(userId))
                {
                    userCounts[userId]++;
                }
                else
                {
                    userCounts[userId] = 1;
                }
            }

            // Tìm số lần xuất hiện nhiều nhất
            int maxCount = userCounts.Values.Max();

            // Tạo danh sách người dùng có số lần xuất hiện nhiều nhất
            List<UserAccount> mostFrequentUsers = new List<UserAccount>();
            foreach (var kvp in userCounts)
            {
                if (kvp.Value == maxCount)
                {
                    // Tìm người dùng tương ứng với ID
                    UserAccount user = users.FirstOrDefault(u => u.Id == kvp.Key);
                    if (user != null)
                    {
                        mostFrequentUsers.Add(user);
                    }
                }
            }
            return mostFrequentUsers;
        }


        //Phương thức tìm những khách hàng Thường
        private List<UserAccount> FindNormalUser(List<UserAccount> users)
        {
            var normalUser = new List<UserAccount>();
            foreach (var user in users)
            {
                if (user.Type == "Thường")
                    normalUser.Add(user);
            }
            return normalUser;
        }

        //Phương thức tìm những khách hàng VIP
        private List<UserAccount> FindVIPUser(List<UserAccount> users)
        {
            var vipUser = new List<UserAccount>();
            foreach (var user in users)
            {
                if (user.Type == "VIP")
                    vipUser.Add(user);
            }
            return vipUser;
        }

        private void comboManage_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Lấy lựa chọn:
            int choice = comboManage.SelectedIndex;
            switch (choice)
            {
                //Tổng số xe máy
                case 0:
                    var drivers1 = FindDriverByType("Xe gắn máy", Drivers);
                    txtManageResult.Text = drivers1.Count.ToString();
                    AddDriverDataToTable(drivers1);
                    break;
                //Tổng số xe 4 chỗ
                case 1:
                    var drivers2 = FindDriverByType("Xe ô tô (4 chỗ)", Drivers);
                    txtManageResult.Text = drivers2.Count.ToString();
                    AddDriverDataToTable(drivers2);
                    break;
                //Tổng số xe 7 chỗ
                case 2:
                    var drivers3 = FindDriverByType("Xe ô tô (7 chỗ)", Drivers);
                    txtManageResult.Text = drivers3.Count.ToString();
                    AddDriverDataToTable(drivers3);
                    break;
                //Tổng số xe tải <= 3 tấn
                case 3:
                    var drivers4 = FindDriverByType("Xe ô tô tải (<=3 tấn)", Drivers);
                    txtManageResult.Text = drivers4.Count.ToString();
                    AddDriverDataToTable(drivers4);
                    break;
                //Tổng số xe tải > 3 tấn
                case 4:
                    var drivers5 = FindDriverByType("Xe ô tô tải (>3 tấn)", Drivers);
                    txtManageResult.Text = drivers5.Count.ToString();
                    AddDriverDataToTable(drivers5);
                    break;
                //Tổng số tài xế
                case 5:
                    txtManageResult.Text = Drivers.Count.ToString();
                    AddDriverDataToTable(Drivers);
                    break;
            }
        }

        //Tìm số tài xế theo kiểu
        private List<DriverAccount> FindDriverByType(string type, List<DriverAccount> drivers)
        {
            var driverResult = new List<DriverAccount>();
            foreach (var driver in drivers)
                if (driver.Type == type)
                    driverResult.Add(driver);
            return driverResult;
        }
        //Tìm tài xế theo kiểu và có bonus
        private List<DriverAccount> FindDriverByTypeAndBonus(string type, List<DriverAccount> drivers)
        {
            var driverResult = new List<DriverAccount>();
            foreach (var driver in drivers)
                if (driver.Type == type && driver.Bonus > 0)
                    driverResult.Add(driver);
            return driverResult;
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            var choice = comboSearch.SelectedIndex;
            switch (choice)
            {
                //Tài xế đi xe máy được thưởng
                case 0:
                    var drivers1 = FindDriverByTypeAndBonus("Xe gắn máy", Drivers);
                    txtManageResult.Text = drivers1.Count.ToString();
                    AddDriverDataToTable(drivers1);
                    break;
                //Tài xế đi xe máy được thưởng
                case 1:
                    var drivers2 = FindDriverByTypeAndBonus("Xe ô tô (4 chỗ)", Drivers);
                    txtManageResult.Text = drivers2.Count.ToString();
                    AddDriverDataToTable(drivers2);
                    break;
                //Tài xế đi xe 4 chỗ được thưởng
                case 2:
                    var drivers3 = FindDriverByTypeAndBonus("Xe ô tô (7 chỗ)", Drivers);
                    txtManageResult.Text = drivers3.Count.ToString();
                    AddDriverDataToTable(drivers3);
                    break;
                //Tài xế đi xe 7 chỗ được thưởng
                case 3:
                    var drivers4 = FindDriverByTypeAndBonus("Xe ô tô tải (<=3 tấn)", Drivers);
                    txtManageResult.Text = drivers4.Count.ToString();
                    AddDriverDataToTable(drivers4);
                    break;
                //Tài xế đi xe tải được thưởng
                case 4:
                    var drivers5 = FindDriverByTypeAndBonus("Xe ô tô tải (>3 tấn)", Drivers);
                    txtManageResult.Text = drivers5.Count.ToString();
                    AddDriverDataToTable(drivers5);
                    break;
                //Tài xế chạy cho doanh thu cao nhất.
                case 5:
                    var driver6 = FindBestDriver(Drivers);
                    txtManageResult.Text = driver6.Count.ToString();
                    AddDriverDataToTable(driver6);
                    break;
            }
        }
        //Tìm tx có doanh thu cao nhất
        private List<DriverAccount> FindBestDriver(List<DriverAccount> drivers)
        {
            var maxPrice = 0f;
            foreach (var driver in drivers)
                if (driver.DriverReceived > maxPrice) maxPrice = driver.DriverReceived;
            var list = new List<DriverAccount>();
            foreach (var driver in drivers)
                if (driver.DriverReceived == maxPrice)
                {
                    list.Add(driver);
                }
            return list;
        }

        private void dateTimeManageDay_ValueChanged(object sender, EventArgs e)
        {
            var day = dateTimeManageDay.Value.ToString("dd/MM/yyyy");
            var books = FindBookingByDay(day, Bookings);
            AddBookingDataToTable(books);
            txtTotalBooking.Text = books.Count.ToString();
            txtTotalBookingPrice.Text = CalculateTotalBookingPriceDate(books).ToString();
        }

        //Tính tổng số tiền book trong danh sách
        private float CalculateTotalBookingPriceDate(List<Booking> books)
        {
            float total = 0f;
            foreach (Booking book in books)
                total += book.TotalPrice;
            return total;
        }

        //Tìm những chuyến đi có ngày được truyền vào
        private List<Booking> FindBookingByDay(string day, List<Booking> bookings)
        {
            var listBook = new List<Booking>();
            foreach (Booking book in bookings)
            {
                if (book.StartTime.ToString("dd/MM/yyyy").CompareTo(day) == 0)
                    listBook.Add(book);
            }
            return listBook;
        }

        private void btnSearchBooking_Click(object sender, EventArgs e)
        {
            var choice = comboSearchBooking.SelectedIndex;
            switch (choice)
            {
                //Chuyến xe có tiền cước nhiều nhất đối với xe máy.
                case 0:
                    var books1 = FindBookingWithMostPriceAndType("Xe gắn máy", "", Bookings);
                    AddBookingDataToTable(books1);
                    break;
                //Chuyến xe có tiền cước nhiều nhất đối với xe ô tô.
                case 1:
                    var books2 = FindBookingWithMostPriceAndType("Xe ô tô (4 chỗ)", "Xe ô tô (7 chỗ)", Bookings);
                    AddBookingDataToTable(books2);
                    break;
                //Chuyến xe có tiền cước nhiều nhất đối với xe tải
                case 2:
                    var books3 = FindBookingWithMostPriceAndType("Xe ô tô tải (<=3 tấn)", "Xe ô tô tải (>3 tấn)", Bookings);
                    AddBookingDataToTable(books3);
                    break;
            }
        }

        //Tìm chuyến đi có doanh thu cao nhất theo kiểu xe được truyền vào
        private List<Booking> FindBookingWithMostPriceAndType(string type1, string type2, List<Booking> bookings)
        {
            var bestPrice = 0f;
            foreach (Booking book in bookings)
            {
                if ((book.Driver.Type == type1 || book.Driver.Type == type2) && book.TotalPrice > bestPrice)
                    bestPrice = book.TotalPrice;
            }
            var list = new List<Booking>();
            foreach (Booking book in bookings)
            {
                if ((book.Driver.Type == type1 || book.Driver.Type == type2) && book.TotalPrice == bestPrice)
                {
                    list.Add(book);
                    break;
                }
            }
            return list;
        }
    }
}
