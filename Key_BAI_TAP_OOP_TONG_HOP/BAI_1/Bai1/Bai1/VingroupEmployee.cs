using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Bai1
{
    public class VingroupEmployee
    {
        private static int IdInt = 0;                       //Mã NV tự động tăng
        public string Id { get; set; }                      //Mã NV, có dạng VG****
        public FullName FullName { get; set; }              //Họ và tên
        public DateTime BirthDate { get; set; }             //Ngày sinh
        public string Address { get; set; }                 //Địa chỉ
        public bool Gender { get; set; }                    //Giới tính: 1-Nam, 2-Nữ
        public string PhoneNumber { get; set; }             //SĐT
        public DateTime StartDate { get; set; }             //Ngày bắt đầu vào làm - Chỉ nhận từ 18 tuổi
        public DateTime StartDateEmployee { get; set; }     //Ngày bắt đầu nhận làm chính thức
        public string Email { get; set; }                   //Email
        public int SeniorityAllowance { get; set; }         //Phụ cấp thâm niên
        public string AwardVingroup { get; set; }           //Danh hiệu Vingroup
        public int Salary { get; set; }                     //Lương thực lãnh


        //Phương thức khởi tạo
        public VingroupEmployee()
        {
            Id = $"VG";
            switch (IdInt.ToString().Length)
            {
                case 1:
                    Id += "000";
                    break;
                case 2:
                    Id += "00";
                    break;
                case 3:
                    Id += "0";
                    break;
            }
            Id += IdInt++;
        }

        public VingroupEmployee(List<VingroupEmployee> employees, string fullName, DateTime birthDate, string address,
            bool gender, string phone, DateTime startDate) : this()
        {
            FullName = new FullName(fullName);
            BirthDate = birthDate;
            Address = address;
            Gender = gender;
            PhoneNumber = phone;
            StartDate = startDate;
            StartDateEmployee = calculateStartDateEmp(startDate);
            Email = getEmail(employees, FullName, birthDate);
            SeniorityAllowance = calculateSeniorityAllowance(StartDateEmployee);
        }

        //Phương thức tạo Email của nhân viên
        private string getEmail(List<VingroupEmployee> employees, FullName fullName, DateTime birthDate)
        {
            //Hoang Minh Tri
            var emailStr = "";
            string nameRemoveAccents = RemoveAccents(fullName.ToString());
            var names = nameRemoveAccents.Split(' ');//Tách tên thành mảng các chữ
            emailStr += names[names.Length - 1];
            emailStr += names[0][0];
            for (int i = 1; i < names.Length - 1; i++)
            {
                emailStr += names[i][0];
            }

            //Kiểm tra tên đã tồn tại hay chưa, nếu đã tồn tại thì thêm ngày sinh vào
            if (isFullNameExist(fullName.ToString(), employees))
            {
                var dayBirthDate = birthDate.ToString("dd");
                emailStr += dayBirthDate;
            }

            return emailStr + "@vingroup.com";
        }

        //Phương thức kiểm tra tên đã tồn tại chưa
        private bool isFullNameExist(string name, List<VingroupEmployee> employees)
        {
            for (int i = 0; i < employees.Count; i++)
            {
                if (employees[i].FullName.ToString().Equals(name))
                    return true;
            }
            return false;
        }

        //Phương thức loại bỏ dấu của từ
        static string RemoveAccents(string input)
        {
            //Chuyển chữ hoa thành thường
            input = input.ToLower();

            // Sử dụng Regular Expression để loại bỏ dấu từ các từ có dấu
            string pattern = "[áàảãạăắằẳẵặâấầẩẫậéèẻẽẹêếềểễệíìỉĩịóòỏõọôốồổỗộơớờởỡợúùủũụưứừửữựýỳỷỹỵđ]";
            string result = Regex.Replace(input, pattern, m =>
            {
                switch (m.Value)
                {
                    case "á": return "a";
                    case "à": return "a";
                    case "ả": return "a";
                    case "ã": return "a";
                    case "ạ": return "a";
                    case "ă": return "a";
                    case "ắ": return "a";
                    case "ằ": return "a";
                    case "ẳ": return "a";
                    case "ẵ": return "a";
                    case "ặ": return "a";
                    case "â": return "a";
                    case "ấ": return "a";
                    case "ầ": return "a";
                    case "ẩ": return "a";
                    case "ẫ": return "a";
                    case "ậ": return "a";
                    case "é": return "e";
                    case "è": return "e";
                    case "ẻ": return "e";
                    case "ẽ": return "e";
                    case "ẹ": return "e";
                    case "ê": return "e";
                    case "ế": return "e";
                    case "ề": return "e";
                    case "ể": return "e";
                    case "ễ": return "e";
                    case "ệ": return "e";
                    case "í": return "i";
                    case "ì": return "i";
                    case "ỉ": return "i";
                    case "ĩ": return "i";
                    case "ị": return "i";
                    case "ó": return "o";
                    case "ò": return "o";
                    case "ỏ": return "o";
                    case "õ": return "o";
                    case "ọ": return "o";
                    case "ô": return "o";
                    case "ố": return "o";
                    case "ồ": return "o";
                    case "ổ": return "o";
                    case "ỗ": return "o";
                    case "ộ": return "o";
                    case "ơ": return "o";
                    case "ớ": return "o";
                    case "ờ": return "o";
                    case "ở": return "o";
                    case "ỡ": return "o";
                    case "ợ": return "o";
                    case "ú": return "u";
                    case "ù": return "u";
                    case "ủ": return "u";
                    case "ũ": return "u";
                    case "ụ": return "u";
                    case "ư": return "u";
                    case "ứ": return "u";
                    case "ừ": return "u";
                    case "ử": return "u";
                    case "ữ": return "u";
                    case "ự": return "u";
                    case "ý": return "y";
                    case "ỳ": return "y";
                    case "ỷ": return "y";
                    case "ỹ": return "y";
                    case "ỵ": return "y";
                    case "đ": return "d";
                    default: return "";
                }
            });

            // Nếu từ đã loại bỏ dấu vẫn giống từ ban đầu, tức là không có dấu, 
            // thì trả về từ ban đầu
            if (result == input)
            {
                return result;
            }

            return result;
        }

        //Phương thức tính lương thâm niên
        private int calculateSeniorityAllowance(DateTime dateStart)
        {
            var dateNow = DateTime.Now;            //Năm hiện tại
            var seniorityMonth = (dateNow.Year - dateStart.Year) * 12 + dateNow.Month - dateStart.Month; //Số tháng thâm niên
            var seniorityYear = seniorityMonth / 12;
            if (seniorityYear <= 3) return 1_000_000;
            else if (seniorityYear <= 6) return 2_000_000;
            else if (seniorityYear <= 10) return 4_000_000;
            else
            {
                var bonus = 5_000_000;
                for (int i = 0; i < seniorityYear - 11; i++)
                {
                    bonus += 500_000;
                }
                return bonus;
            }
        }

        //Phương thức tính ngày bắt đầu làm việc kể từ ngày thử việc
        private DateTime calculateStartDateEmp(DateTime startDate) => startDate.AddMonths(3);

        //Phương thức chuyển đổi định dạng tiền
         string ConvertMoneyToVND(int amount)
        {
            // Sử dụng phương thức ToString() với định dạng "#,##0" để chuyển đổi số thành chuỗi tiền tệ
            return amount.ToString("#,##0") + " VNĐ";
        }


        //Phương thức xuất thông tin nhân viên gồm: mã số, họ tên, địa chỉ, số điện thoại, email
        public void ShowEmpInfo_1()
        {
            Console.WriteLine($"Mã NV: {Id}");
            Console.WriteLine($"Họ và tên: {FullName}");
            Console.WriteLine($"Địa chỉ: {Address}");
            Console.WriteLine($"SĐT: {PhoneNumber}");
            Console.WriteLine($"Email: {Email}");
        }

        //Phương thức xuất thông tin nhân viên gồm: mã số, họ tên, ngày sinh, địa chỉ, số điện thoại, email, thời gian vào làm 
        public void ShowEmpInfo_2()
        {
            Console.WriteLine($"Mã NV: {Id}");
            Console.WriteLine($"Họ và tên: {FullName}");
            Console.WriteLine($"Ngày sinh: {BirthDate.ToString("dd-MM-yyyy")}");
            Console.WriteLine($"Địa chỉ: {Address}");
            Console.WriteLine($"SĐT: {PhoneNumber}");
            Console.WriteLine($"Email: {Email}");
            Console.WriteLine($"Thời gian vào làm: {StartDate.ToString("dd-MM-yyyy")}");
        }

        //Phương thức xuất thông tin nhân viên gồm: tất cả thông tin kể cả thâm niên và phụ cấp thâm niên
        public void ShowEmpInfo_3()
        {
            Console.WriteLine($"Mã NV: {Id}");
            Console.WriteLine($"Họ và tên: {FullName}");
            Console.WriteLine($"Ngày sinh: {BirthDate.ToString("dd-MM-yyyy")}");
            Console.WriteLine($"Địa chỉ: {Address}");
            Console.WriteLine($"SĐT: {PhoneNumber}");
            Console.WriteLine($"Email: {Email}");
            Console.WriteLine($"Thời gian vào làm: {StartDate.ToString("dd-MM-yyyy")}");
            Console.WriteLine($"Thời gian vào làm nhân viên chính thức: {StartDateEmployee.ToString("dd-MM-yyyy")}");
            Console.WriteLine($"Phụ cấp thâm niên: {ConvertMoneyToVND(SeniorityAllowance)}");
            Console.WriteLine($"Lương: {ConvertMoneyToVND(Salary)}");
            Console.WriteLine($"Danh hiệu Vingroup: {AwardVingroup}");
        }


       
    }
}
