using Newtonsoft.Json;
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
    public partial class UserFrm : Form
    {
        public List<UserAccount> Users = new List<UserAccount>();
        public List<DriverAccount> Drivers = new List<DriverAccount>();
        public List<Booking> Bookings = new List<Booking>();
        public UserAccount User;
        public UserFrm(List<UserAccount> users, List<DriverAccount> drivers, UserAccount user, List<Booking> bookings)
        {
            InitializeComponent();
            Users.AddRange(users);
            Drivers.AddRange(drivers);
            User = user;
            Bookings = bookings;
            FillDataTabUser();//Load data tab user trong lần đầu load lên
        }

        private void btnBooking_Click(object sender, EventArgs e)
        {
            if (allFieldsFilled)
            {
                if (txtDriverId != null)
                {
                    var driver = FindDriverById(Drivers, txtDriverId.Text);
                    string startPositon = txtStartPosition.Text;
                    string endPosition = txtEndPosition.Text;
                    int distance = int.Parse(txtDistance.Text.Substring(0, txtDistance.Text.Length - 2));
                    var startTime = DateTime.Now;
                    var totalPrice = float.Parse(txtBookingPrice.Text.Substring(0, txtBookingPrice.Text.Length - 1));
                    var bookingFee = CalculateBookingFee(totalPrice, driver);
                    Booking booking = new Booking(driver, User, startPositon, endPosition,
                        distance, totalPrice, bookingFee, startTime);
                    Bookings.Add(booking);
                    if (IsVIP(Bookings))
                    {
                        User.Type = "VIP";
                    }
                    //Cộng dồn phí của khách và tài xế
                    UserPriceHandler(totalPrice);
                    DriverPriceHandler(bookingFee, driver, totalPrice);
                    SaveAccountToFile();
                    SaveBookingToFile();
                    MessageBox.Show("Đặt xe thành công! Chúc quý khách có một chuyến đi an toàn");
                }
                else
                {
                    MessageBox.Show("Xe quý khách đang yêu cầu hiện đang không còn trống, vui lòng chọn loại xe khác!");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin chuyến đi!");
            }
        }
        private void SaveAccountToFile()
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

        //Kiểm tra xem khách hàng đó đủ điều kiện VIP chưa
        private bool IsVIP(List<Booking> bookings)
        {
            int cnt = 0;
            foreach (Booking booking in bookings)
            {
                if (booking.User.Id == User.Id)
                {
                    cnt++;
                }
            }
            if (cnt > 10) return true;
            return false;
        }

        private void DriverPriceHandler(float bookingFee, DriverAccount driver, float totalPrice)
        {
            //Cộng dồn số tiền thuế đã nộp
            driver.BookingFee += bookingFee;
            //Cộng tiền nhận được
            driver.DriverReceived = totalPrice - bookingFee;
        }

        private void UserPriceHandler(float totalPrice)
        {
            User.TotalPrice += totalPrice;
        }

        //Ghi Booking vào File JSON
        private void SaveBookingToFile()
        {
            var root = new
            {
                Bookings
            };
            var stringJson = JsonConvert.SerializeObject(root, Formatting.Indented);
            try
            {
                var filePath = "D:\\BVU\\OOP\\BaiTapTongHopOOP\\Key_BAI_TAP_OOP_TONG_HOP\\BAI_2\\Bai2\\Bai2\\bookings.json";
                File.WriteAllText(filePath, string.Empty);
                File.WriteAllText(filePath, stringJson);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        //Phương thức tính thuế của tài xế
        private float CalculateBookingFee(float totalPrice, DriverAccount driver)
        {
            switch (driver.Type)
            {
                case "Xe gắn máy":
                    return totalPrice * 0.05f;
                case "Xe ô tô (4 chỗ)":
                case "Xe ô tô (7 chỗ)":
                    return totalPrice * 0.1f;
                case "Xe ô tô tải (<=3 tấn)":
                case "Xe ô tô tải (>3 tấn)":
                    return totalPrice * 0.15f;
            }
            return 0;
        }

        private bool allFieldsFilled = false; //Cờ kiểm soát địa điểm bắt đầu, địa điểm kết thúc và loại xe
        private void txtStartPosition_TabIndexChanged(object sender, EventArgs e)
        {
            CheckFieldsFilled();
        }

        private void txtEndPosition_TextAlignChanged(object sender, EventArgs e)
        {
            CheckFieldsFilled();
        }

        private void comboDriverType_SelectedIndexChanged(object sender, EventArgs e)
        {
            CheckFieldsFilled();
        }
        //Kiểm tra các ô text box và combo đã được chọn chưa
        private void CheckFieldsFilled()
        {
            bool checkStartPositionFilled = !string.IsNullOrWhiteSpace(txtStartPosition.Text);
            bool checkEndPositionFilled = !string.IsNullOrWhiteSpace(txtEndPosition.Text);
            bool comboDeliveryFilled = comboDriverType.SelectedIndex != -1;

            // Gắn cờ cho biết liệu tất cả các ô đã được điền đầy đủ hay không
            allFieldsFilled = checkStartPositionFilled && checkEndPositionFilled && comboDeliveryFilled;

            if (allFieldsFilled)
            {
                //Lấy kiểu xe được chọn
                var driverType = comboDriverType.SelectedItem as string;
                // Xử lý tính khoảng cách, Tính giá tiền, Giảm giá
                var startPosition = GenerateMinRandomNumber(0);//Vị trí bắt đầu
                var endPosition = GenerateMinRandomNumber(startPosition); //Vị trí kết thúc: > Vị trí ban đầu
                var distance = (endPosition - startPosition);
                var time = DateTime.Now;
                var price = CalculatePrice(distance, driverType, time);
                var discount = GetDiscount(User, price);
                var bookingPrice = CalculateBookingPrice(price, discount);

                //Đẩy data thông tin giá tiền xe
                txtDistance.Text = distance + " km";
                txtPrice.Text = FormatNumber(price) + "đ";
                txtDiscount.Text = FormatNumber(discount * price) + "đ";
                txtBookingPrice.Text = FormatNumber(bookingPrice) + "đ";

                //đẩy Data của tài xế
                var idRandom = GenerateMaxRandomDriver(driverType);
                if (idRandom != "")
                {
                    var driver = FindDriverById(Drivers, idRandom);
                    txtDriverId.Text = driver.Id;
                    txtDriverName.Text = driver.FullName.ToString();
                    txtDriverType.Text = driver.Type;
                }
            }
        }
        private string FormatNumber(float number)
        {
            string formattedNumber = string.Format("{0:N0}", number); // Định dạng theo dạng ngăn cách hàng nghìn

            // Nếu có phần thập phân thì tách bằng dấu phẩy
            if (number.ToString().Contains("."))
            {
                string[] parts = formattedNumber.Split('.');
                formattedNumber = string.Join(",", parts);
            }

            return formattedNumber;
        }
        //Tìm tài xế bằng Id
        private DriverAccount FindDriverById(List<DriverAccount> drivers, string idRandom)
        {
            foreach (var driver in drivers)
            {
                if (driver.Id == idRandom)
                    return driver;
            }
            return null;
        }

        //Tính tiền xe
        private float CalculateBookingPrice(int price, float discount)
        {
            return price * (1 - discount);
        }

        private float GetDiscount(UserAccount user, int price)
        {
            if (user.Type == "VIP" && price > 200_000)
                return 0.1f;
            return 0;
        }

        //Phương thức tính tiền chuyến đi
        private int CalculatePrice(int distance, string driverType, DateTime time)
        {
            int price = 0;

            switch (driverType)
            {
                case "Xe gắn máy":
                    int hour = time.Hour;
                    //Tính tiền cho 2km đầu
                    price += Math.Min(distance, 2) * 8000;
                    //Giá cước cho mỗi km tiếp theo
                    if (distance > 2)
                        price += (distance - 2) * 5000;
                    //Tính phụ thu nếu đi trong khoảng 22h-5h sáng
                    if (hour >= 22 || hour < 5)
                        price += distance * 3000;
                    break;
                case "Xe ô tô (4 chỗ)":
                    //Tính tiền cho 2km đầu
                    price += Math.Min(distance, 2) * 15000;
                    //Giá cước cho mỗi km tiếp theo
                    if (distance > 2)
                    {
                        //Tính tiền cho 5km tiếp
                        price += Math.Min(distance - 2, 5) * 12000;
                        if (distance > 7)
                        {
                            price += (distance - 7) * 8000;
                            // Tính phụ thu cho từng km đường đi sau 7km
                            price += (distance - 7) * 500;
                        }
                    }
                    break;
                case "Xe ô tô (7 chỗ)":
                    //Tính tiền cho 2km đầu
                    price += Math.Min(distance, 2) * 17000;
                    //Giá cước cho mỗi km tiếp theo
                    if (distance > 2)
                    {
                        //Tính tiền cho 5km tiếp
                        price += Math.Min(distance - 2, 5) * 15000;
                        if (distance > 7)
                        {
                            price += (distance - 7) * 10000;
                            // Tính phụ thu cho từng km đường đi sau 7km
                            price += (distance - 7) * 500;
                        }
                    }
                    break;
                case "Xe ô tô tải (<=3 tấn)":
                    //Tính tiền cho 2km đầu
                    price += Math.Min(distance, 2) * 60000;
                    //Giá cước cho mỗi km tiếp theo
                    if (distance > 2)
                    {
                        //Tính tiền cho 5km tiếp
                        price += Math.Min(distance - 2, 5) * 50000;
                        if (distance > 7)
                        {
                            price += (distance - 7) * 30000;
                            // Tính phụ thu cho từng km đường đi sau 7km
                            price += (distance - 7) * 5000;
                        }
                    }
                    break;
                case "Xe ô tô tải (>3 tấn)":
                    //Tính tiền cho 2km đầu
                    price += Math.Min(distance, 2) * 70000;
                    //Giá cước cho mỗi km tiếp theo
                    if (distance > 2)
                    {
                        //Tính tiền cho 5km tiếp
                        price += Math.Min(distance - 2, 5) * 60000;
                        if (distance > 7)
                        {
                            price += (distance - 7) * 40000;
                            // Tính phụ thu cho từng km đường đi sau 7km
                            price += (distance - 7) * 5000;
                        }
                    }
                    break;
            }
            return price;
        }

        //Phương thức tạo số random từ minvalue đến 100
        private int GenerateMinRandomNumber(int minValue)
        {
            // Khởi tạo một thực thể Random
            Random random = new Random();

            // Sinh số ngẫu nhiên từ minValue đến 100
            int randomNumber = random.Next(minValue, 101); // 101 để bao gồm cả 100

            return randomNumber;
        }
        //Phương thức tạo random driver có cùng kiểu
        private string GenerateMaxRandomDriver(string driverType)
        {
            // Khởi tạo một thực thể Random
            Random random = new Random();

            List<DriverAccount> drivers = new List<DriverAccount>();

            //Thêm các Driver có cùng kiểu truyền vào từ danh sách
            foreach (var driver in Drivers)
                if (driver.Type == driverType)
                    drivers.Add(driver);
            if (drivers.Count > 0)
            {
                // Sinh một số ngẫu nhiên để chọn một lái xe từ danh sách drivers
                int randomIndex = random.Next(0, drivers.Count);

                // Trả về lái xe được chọn ngẫu nhiên từ danh sách
                return drivers[randomIndex].Id;
            }
            return "";
        }

        //Truyền data của user vào
        private void FillDataTabUser()
        {
            txtFullName.Text = User.FullName.ToString();
            txtPhoneNumber.Text = User.PhoneNumber;
            txtUsername.Text = User.Username;
            //Chuyển trạng thái thành online
            User.Status = true;
            txtStatus.Text = User.Status == true ? "Online" : "Offline";
            txtAccountType.Text = User.Type;
        }

        private void FillDataTabManage()
        {
            dtgvBooking.Rows.Clear();//Xóa hết dữ liệu hiện trong bảng
            foreach (Booking book in Bookings)
            {
                if (book.User.Id == User.Id)
                {
                    dtgvBooking.Rows.Add(book.Id, book.Driver.Id, book.Driver.FullName.ToString(),
                        book.Driver.PhoneNumber, book.Distance, book.TotalPrice);
                }
            }
        }

        private void tabBooking_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Lấy chỉ mục của tab hiện tại
            int selectedIndex = tabBooking.SelectedIndex;

            // Kiểm tra xem tab nào đang được chọn và gọi phương thức tương ứng
            switch (selectedIndex)
            {
                case 0:
                    FillDataTabUser();
                    break;
                case 2:
                    FillDataTabManage();
                    break;

            }
        }
    }
}
