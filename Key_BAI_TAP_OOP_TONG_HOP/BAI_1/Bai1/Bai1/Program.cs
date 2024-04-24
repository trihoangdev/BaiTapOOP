using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Bai1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<VingroupEmployee> employees = new List<VingroupEmployee>();
            bool option = true;
            int choice;
            CreateFakeData(employees);
            while (option)
            {
                Console.Clear();
                Console.WriteLine("==============================================MENU==============================================");
                Console.WriteLine("0. Thoát chương trình");
                Console.WriteLine("1. Thêm mới nhân viên Vincom");
                Console.WriteLine("2. Thêm mới nhân viên Vinreal");
                Console.WriteLine("3. Đếm tổng số nhân viên của công ty con");
                Console.WriteLine("4. Cho biết tổng công ty VINGROUP có bao nhiêu nhân viên có “năng lực tốt”.");
                Console.WriteLine("5. Xuất thông tin các  nhân viên chưa được xét thi đua ở cty VINREAL.");
                Console.WriteLine("6. Xuất thông tin các nhân viên lao động tiên tiến của cty VINCOM.");
                Console.WriteLine("7. Cho biết trong tổng công ty có bao nhiêu nhân viên có “năng lực”.");
                Console.WriteLine("8. Xuất danh sách bảng lương của các nhân viên VINCOM");
                Console.WriteLine("9. Xuất danh sách các nhân viên của công ty VINCOM có hệ số lương là 3.99");
                Console.WriteLine("10. Xuất danh sách các nhân viên có lương cao nhất trong VINCOM");
                Console.WriteLine("11. Đếm số nhân viên có phụ cấp thâm niên ở VINCOM");
                Console.WriteLine("12. Xuất thông tin các nhân viên là chiến sĩ thi đua của tổng công ty VINGROUP");
                Console.WriteLine("13. Xuất thông tin các nhân viên có thâm niên từ 10  năm trở lên ở VINCOM");
                Console.WriteLine("14. Xuất danh sách các nhân viên không đạt chỉ tiêu của nhân viên VINREAL");
                Console.WriteLine("==============================================================================================");
                Console.Write("Nhập lựa chọn: ");
                try
                {
                    choice = int.Parse(Console.ReadLine());
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                    Console.WriteLine("Thoát chương trình do nhập sai cú pháp!");
                    choice = 0;
                }
                switch (choice)
                {
                    case 0:
                        Console.WriteLine("Thoát chương trình");
                        option = false;
                        break;
                    case 1:
                        //Thêm mới nhân viên Vincom
                        int choice2;
                        Console.WriteLine("0. Thoát");
                        Console.WriteLine("1. Thêm mới nhân viên sản xuất Vincom");
                        Console.WriteLine("2. Thêm mới nhân viên kinh doanh Vincom");
                        Console.WriteLine("3. Thêm mới cán bộ điều hành Vincom");
                        Console.Write("Nhập lựa chọn: ");
                        try
                        {
                            choice2 = int.Parse(Console.ReadLine());
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine("Thoát chương trình do nhập sai cú pháp!");
                            choice2 = 0;
                        }
                        switch (choice2)
                        {
                            case 0:
                                Console.WriteLine("Thoát chương trình");
                                break;
                            case 1:
                                //Thêm mới nhân viên sản xuất Vincom
                                ManufactureEmployee manuEmp = AddNewManufactEmp(employees);
                                if (manuEmp != null)
                                {
                                    employees.Add(manuEmp);
                                    Console.WriteLine("Thêm mới nhân viên sản xuất Vincom thành công!");
                                }
                                else Console.WriteLine("Thêm mới nhân viên sản xuất Vincom thất bại!");
                                break;
                            case 2:
                                //Thêm mới nhân viên kinh doanh Vincom
                                BussinessEmployee bussEmp = AddNewBussinessEmp(employees);
                                if (bussEmp != null)
                                {
                                    employees.Add(bussEmp);
                                    Console.WriteLine("Thêm mới nhân viên kinh doanh Vincom thành công!");
                                }
                                else Console.WriteLine("Thêm mới nhân viên kinh doanh Vincom thất bại!");
                                break;
                            case 3:
                                //Thêm mới cán bộ điều hành Vincom
                                Manager manager = AddNewManager(employees);
                                if (manager != null)
                                {
                                    employees.Add(manager);
                                    Console.WriteLine("Thêm mới cán bộ điều hành Vincom thành công!");
                                }
                                else Console.WriteLine("Thêm mới cán bộ điều hành Vincom thất bại!");
                                break;
                        }
                        break;
                    case 2:
                        //Thêm mới nhân viên Vinreal
                        VinrealEmployee vinrealEmp = AddNewVinrealEmp(employees);
                        if (vinrealEmp != null)
                        {
                            employees.Add(vinrealEmp);
                            Console.WriteLine("Thêm mới nhân viên Vinreal thành công!");
                        }
                        else Console.WriteLine("Thêm mới nhân viên Vinreal thất bại!");
                        break;
                    case 3:
                        //Đếm tổng số nhân viên của công ty con
                        Console.WriteLine("Số nhân viên công ty Vincom: " + CountMemberOfVincom(employees));
                        Console.WriteLine("Số nhân viên công ty Vinreal: " + CountMemberOfVinreal(employees));
                        break;
                    case 4:
                        // Cho biết tổng công ty VINGROUP có bao nhiêu nhân viên có “năng lực tốt”
                        Console.WriteLine($"Tổng công ty VINGROUP có {CountGoodEmployee(employees)} nhân viên có “năng lực tốt”");
                        break;
                    case 5:
                        //Xuất thông tin các nhân viên chưa được xét thi đua ở cty VINREAL.
                        Console.WriteLine("=== Các nhân viên chưa được xét thi đua ở VINREAL <===");
                        for (int i = 0; i < employees.Count; i++)
                            if (employees[i] is VinrealEmployee)
                            {
                                VinrealEmployee empCast = (VinrealEmployee)employees[i];//Ép kiểu
                                if (empCast.AwardVinreal == "Không có danh hiệu")
                                    ShowEmpInfo(employees[i]);
                            }
                        break;
                    case 6:
                        //Xuất thông tin các nhân viên lao động tiên tiến của cty VINCOM.
                        Console.WriteLine("=== Các nhân viên lao động tiên tiến của cty VINCOM <===");
                        for (int i = 0; i < employees.Count; i++)
                            if (employees[i] is VincomEmployee)
                            {
                                VincomEmployee empCast = (VincomEmployee)employees[i];//Ép kiểu
                                if (empCast.AwardVincom == "Lao động tiên tiến")
                                    ShowEmpInfo(employees[i]);
                            }
                        break;
                    case 7:
                        //Cho biết trong tổng công ty có bao nhiêu nhân viên có “năng lực”.
                        Console.WriteLine($"Tổng công ty VINGROUP có {CountNormalEmployee(employees)} nhân viên có “năng lực”");

                        break;
                    case 8:
                        //Xuất danh sách bảng lương của các nhân viên VINCOM
                        ShowVincomSalary(employees);
                        break;
                    case 9:
                        //Xuất danh sách các nhân viên của công ty VINCOM có hệ số lương là 3.99
                        foreach (var emp in employees)
                            if (emp is VincomEmployee)
                            {
                                var empCast = (VincomEmployee)emp;
                                if (empCast.CoefficientSalary == 3.99f)
                                    ShowEmpInfo_1(empCast);
                            }
                        break;
                    case 10:
                        // Xuất danh sách các nhân viên có lương cao nhất trong VINCOM
                        FilterImp filter = new FilterImp();
                        List<VincomEmployee> vincomEmployees = new List<VincomEmployee>();
                        foreach (var emp in employees)
                            if (emp is VincomEmployee)
                            {
                                var empCast = (VincomEmployee)emp;
                                vincomEmployees.Add(empCast);
                            }
                        filter.SortVincomBySalaryDESC(vincomEmployees);
                        foreach (var emp in vincomEmployees)
                        {
                            ShowEmpInfo(emp);
                            Console.WriteLine("===================");
                        }
                        break;
                    case 11:
                        //Đếm số nhân viên có phụ cấp thâm niên ở VINCOM
                        var count = 0;
                        foreach (var emp in employees)
                            if (emp is VincomEmployee && emp.SeniorityAllowance > 0)
                                count++;
                        Console.WriteLine($"Có {count} nhân viên có phụ cấp thâm niên ở VINCOM");
                        break;
                    case 12:
                        //Xuất thông tin các nhân viên là chiến sĩ thi đua của tổng công ty VINGROUP
                        foreach (var emp in employees)
                            if (emp.AwardVingroup == "năng lực tốt")
                                ShowEmpInfo(emp);
                        break;
                    case 13:
                        //Xuất thông tin các nhân viên có thâm niên từ 10  năm trở lên ở VINCOM
                        foreach (var emp in employees)
                            if (emp is VincomEmployee)
                            {
                                var empCast = (VincomEmployee)emp;
                                if (CountYearAtVin(empCast.StartDate) > 10)
                                    ShowEmpInfo_1(empCast);
                            }

                        break;
                    case 14:
                        // Xuất danh sách các nhân viên không đạt chỉ tiêu của nhân viên VINREAL
                        Console.WriteLine("Các nhân viên không đạt chỉ tiêu của nhân viên VINREAL");
                        foreach (var emp in employees)
                            if (emp is VinrealEmployee)
                            {
                                var empCast = (VinrealEmployee)emp;
                                if (empCast.AwardVinreal == "Không đạt chỉ tiêu")
                                    ShowEmpInfo(emp);
                            }
                        break;
                    default:
                        Console.WriteLine("Vui lòng chọn các chức năng trong [0-14]");
                        break;

                }
                Console.ReadKey();
            }
        }

        private static void CreateFakeData(List<VingroupEmployee> employees)
        {
            //Tạo Data fake nhân viên sản xuất
            employees.Add(new ManufactureEmployee(employees, "Hoàng Minh Trí", DateTime.ParseExact("06/01/2003", "dd/MM/yyyy", null), "Trần Phú, VT", true, "0792352701", DateTime.ParseExact("06/01/2024", "dd/MM/yyyy", null), 3.99f, 10));
            employees.Add(new ManufactureEmployee(employees, "Vũ Lê Thanh", DateTime.ParseExact("12/01/1998", "dd/MM/yyyy", null), "Lê Hồng Phong, VT", false, "0955236201", DateTime.ParseExact("30/03/2022", "dd/MM/yyyy", null), 3f, 5));
            employees.Add(new ManufactureEmployee(employees, "Hoàng Bảo Vi", DateTime.ParseExact("22/10/1977", "dd/MM/yyyy", null), "Nguyễn Văn Trỗi, VT", false, "0792350201", DateTime.ParseExact("06/05/2024", "dd/MM/yyyy", null), 4.2f, 7));
            employees.Add(new ManufactureEmployee(employees, "Nguyễn Hồng Đào", DateTime.ParseExact("30/05/1999", "dd/MM/yyyy", null), "Nguyễn Tri Phương, VT", false, "0788352701", DateTime.ParseExact("06/03/2015", "dd/MM/yyyy", null), 6.2f, 4));
            employees.Add(new ManufactureEmployee(employees, "Đào Thị Hồng Nhung", DateTime.ParseExact("12/12/2000", "dd/MM/yyyy", null), "Lê Lợi, VT", false, "0792352331", DateTime.ParseExact("08/05/2016", "dd/MM/yyyy", null), 2.12f, 6));
            employees.Add(new ManufactureEmployee(employees, "Nguyễn Thiện Chí", DateTime.ParseExact("01/08/2004", "dd/MM/yyyy", null), "Lê Lợi, VT", true, "0792352991", DateTime.ParseExact("12/02/2019", "dd/MM/yyyy", null), 1.02f, 0));
            employees.Add(new ManufactureEmployee(employees, "Hứa Kim Tuyền", DateTime.ParseExact("03/08/1978", "dd/MM/yyyy", null), "Trần Phú, VT", false, "0792352766", DateTime.ParseExact("24/01/2012", "dd/MM/yyyy", null), 6.25f, 9));
            employees.Add(new ManufactureEmployee(employees, "Thân Văn Triệu", DateTime.ParseExact("06/06/1988", "dd/MM/yyyy", null), "Lê Hồng Phong, VT", true, "0792345701", DateTime.ParseExact("08/01/2014", "dd/MM/yyyy", null), 2.05f, 4));
            employees.Add(new ManufactureEmployee(employees, "Nguyễn Anh Vũ", DateTime.ParseExact("30/04/2001", "dd/MM/yyyy", null), "30/4, VT", true, "0792352702", DateTime.ParseExact("16/07/2018", "dd/MM/yyyy", null), 3.25f, 7));

            //Tạo Data fake nhân viên kinh doanh
            employees.Add(new BussinessEmployee(employees, "Hoàng Minh Trí", DateTime.ParseExact("13/05/1999", "dd/MM/yyyy", null), "Quận 3, HCM", true, "0556821478", DateTime.ParseExact("06/05/2015", "dd/MM/yyyy", null), 3.2f, 20000000, 19800000));
            employees.Add(new BussinessEmployee(employees, "Vũ Minh Trí", DateTime.ParseExact("20/05/1998", "dd/MM/yyyy", null), "Quận 3, HCM", true, "0556821668", DateTime.ParseExact("06/05/2020", "dd/MM/yyyy", null), 3.5f, 30000000, 49800000));
            employees.Add(new BussinessEmployee(employees, "Hoàng Cẩm Ly", DateTime.ParseExact("04/05/2000", "dd/MM/yyyy", null), "Quận 3, HCM", true, "0556827478", DateTime.ParseExact("06/05/2012", "dd/MM/yyyy", null), 3.99f, 26000000, 69800000));
            employees.Add(new BussinessEmployee(employees, "Lê Văn Quân", DateTime.ParseExact("13/06/2005", "dd/MM/yyyy", null), "Quận 3, HCM", true, "0556821038", DateTime.ParseExact("06/05/2018", "dd/MM/yyyy", null), 4f, 12000000, 19800000));
            employees.Add(new BussinessEmployee(employees, "Phạm Thị Trang", DateTime.ParseExact("13/07/1985", "dd/MM/yyyy", null), "Quận 3, HCM", true, "0522821478", DateTime.ParseExact("06/05/2019", "dd/MM/yyyy", null), 4.2f, 36000000, 20800000));
            employees.Add(new BussinessEmployee(employees, "Phạm Đoan Trang", DateTime.ParseExact("07/05/1963", "dd/MM/yyyy", null), "Quận 3, HCM", true, "0565821478", DateTime.ParseExact("06/05/2010", "dd/MM/yyyy", null), 6.2f, 30000000, 19800000));
            employees.Add(new BussinessEmployee(employees, "Phạm Thế Nguyễn", DateTime.ParseExact("02/05/1975", "dd/MM/yyyy", null), "Quận 3, HCM", true, "0577821478", DateTime.ParseExact("06/05/2005", "dd/MM/yyyy", null), 6.3f, 24000000, 66800000));
            employees.Add(new BussinessEmployee(employees, "Chu Thế Vỹ", DateTime.ParseExact("13/01/1969", "dd/MM/yyyy", null), "Quận 3, HCM", true, "0556821628", DateTime.ParseExact("06/05/2006", "dd/MM/yyyy", null), 3.1f, 30000000, 29800000));
            employees.Add(new BussinessEmployee(employees, "Nguyễn Thế Trường", DateTime.ParseExact("13/08/1973", "dd/MM/yyyy", null), "Quận 3, HCM", true, "0595821478", DateTime.ParseExact("06/05/2012", "dd/MM/yyyy", null), 2.8f, 30000000, 48800000));
            employees.Add(new BussinessEmployee(employees, "Hoàng Văn An", DateTime.ParseExact("07/05/1983", "dd/MM/yyyy", null), "Quận 3, HCM", true, "0556821658", DateTime.ParseExact("06/05/2018", "dd/MM/yyyy", null), 2.9f, 30000000, 29800000));
            employees.Add(new BussinessEmployee(employees, "Hoàng Trọng Nhân", DateTime.ParseExact("05/05/1988", "dd/MM/yyyy", null), "Quận 3, HCM", true, "0558821478", DateTime.ParseExact("06/05/2017", "dd/MM/yyyy", null), 3f, 15700000, 25800000));
        
        }

        //Phương thức tính thâm niên
        private static int CountYearAtVin(DateTime startDate)
        {
            var yearNow = DateTime.Now.Year;
            var yearStart = startDate.Year;
            return yearNow - yearStart;
        }

        //Xuất danh sách bảng lương của các nhân viên VINCOM
        private static void ShowVincomSalary(List<VingroupEmployee> employees)
        {
            var titleId = "Mã NV";
            var titleName = "Họ tên";
            var titleSalary = "Lương";
            Console.WriteLine($"{titleId,-15}{titleName,-40}{titleSalary,-10}");
            for (int i = 0; i < employees.Count; i++)
                if (employees[i] is VincomEmployee)
                {
                    var empCast = (VincomEmployee)employees[i];
                    Console.WriteLine($"{empCast.Id,-15}{empCast.FullName.ToString(),-40}{ConvertMoneyToVND(empCast.Salary),-10}");
                }
        }
        private static string ConvertMoneyToVND(int amount)
        {
            // Sử dụng phương thức ToString() với định dạng "#,##0" để chuyển đổi số thành chuỗi tiền tệ
            return amount.ToString("#,##0") + " VNĐ";
        }

        //Phương thức đếm nhân viên có năng lực tại Vingroup
        private static object CountNormalEmployee(List<VingroupEmployee> employees)
        {
            int count = 0;
            foreach (VingroupEmployee employee in employees)
                if (employee.AwardVingroup == "có năng lực")
                    count++;
            return count;
        }

        //Phương thức hiển thị thông tin nhân viên
        private static void ShowEmpInfo(VingroupEmployee vingroupEmployee)
        {
            vingroupEmployee.ShowEmpInfo_3();
            Console.WriteLine("===============================");
        }
        //Phương thức hiển thị thông tin nhân viên
        private static void ShowEmpInfo_1(VingroupEmployee vingroupEmployee)
        {
            vingroupEmployee.ShowEmpInfo_1();
            Console.WriteLine("===============================");
        }

        //Phương thức đếm nhân viên có năng lực tốt tại Vingroup
        private static int CountGoodEmployee(List<VingroupEmployee> employees)
        {
            int count = 0;
            foreach (VingroupEmployee employee in employees)
                if (employee.AwardVingroup == "năng lực tốt")
                    count++;
            return count;
        }

        //Phương thức đếm số nhân viên công ty Vinreal
        private static int CountMemberOfVinreal(List<VingroupEmployee> employees)
        {
            int count = 0;
            for (int i = 0; i < employees.Count; i++)
            {
                if (employees[i] is VinrealEmployee) count++;
            }
            return count;
        }

        //Phương thức đếm số nhân viên công ty Vincom
        private static int CountMemberOfVincom(List<VingroupEmployee> employees)
        {
            int count = 0;
            for (int i = 0; i < employees.Count; i++)
            {
                if (employees[i] is VincomEmployee) count++;
            }
            return count;
        }

        //Phương thức tạo mới nhân viên Vinreal
        private static VinrealEmployee AddNewVinrealEmp(List<VingroupEmployee> emps)
        {
            EmployeeImp empCheck = new EmployeeImp();
            Console.Write("Họ và tên: ");
            var name = Console.ReadLine();
            Console.Write("Ngày sinh (dd/MM/yyyy): ");
            var birthDate = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);
            if (!empCheck.IsOldEnough(birthDate))
            {
                Console.WriteLine("Chưa đủ 18 tuổi, không thể làm việc tại đây!");
                return null;
            }
            Console.Write("Địa chỉ: ");
            var address = Console.ReadLine();
            Console.Write("Giới tính (1-Nam, 2-Nữ): ");
            var genderInt = int.Parse(Console.ReadLine());
            bool gender;
            if (genderInt == 1)
                gender = true;
            else
                gender = false;
            Console.Write("Số điện thoại: ");
            var phone = Console.ReadLine();
            Console.Write("Ngày bắt đầu vào làm (dd/MM/yyyy): ");
            var startDate = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);
            Console.Write("Thu nhập hằng tháng: ");
            var totalIncomeInMonth = int.Parse(Console.ReadLine());
            return new VinrealEmployee(emps, name, birthDate, address, gender,
                phone, startDate, totalIncomeInMonth);
        }

        //Phương thức tạo mới cán bộ điều hành
        private static Manager AddNewManager(List<VingroupEmployee> emps)
        {
            EmployeeImp empCheck = new EmployeeImp();
            Console.Write("Họ và tên: ");
            var name = Console.ReadLine();
            Console.Write("Ngày sinh (dd/MM/yyyy): ");
            var birthDate = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);
            if (!empCheck.IsOldEnough(birthDate))
            {
                Console.WriteLine("Chưa đủ 18 tuổi, không thể làm việc tại đây!");
                return null;
            }
            Console.Write("Địa chỉ: ");
            var address = Console.ReadLine();
            Console.Write("Giới tính (1-Nam, 2-Nữ): ");
            var genderInt = int.Parse(Console.ReadLine());
            bool gender;
            if (genderInt == 1)
                gender = true;
            else
                gender = false;
            Console.Write("Số điện thoại: ");
            var phone = Console.ReadLine();
            Console.Write("Ngày bắt đầu vào làm (dd/MM/yyyy): ");
            var startDate = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);
            Console.Write("Hệ số lương: ");
            var coefficientSalary = float.Parse(Console.ReadLine());
            Console.Write("Chức vụ: ");
            var position = Console.ReadLine();
            Console.Write("Hệ số chức vụ: ");
            var positionCoefficient = float.Parse(Console.ReadLine());
            return new Manager(emps, name, birthDate, address, gender,
                phone, startDate, coefficientSalary, position, positionCoefficient);
        }

        //Phương thức tạo mới nhân viên sản xuất tại Vincom
        private static BussinessEmployee AddNewBussinessEmp(List<VingroupEmployee> emps)
        {
            EmployeeImp empCheck = new EmployeeImp();
            Console.Write("Họ và tên: ");
            var name = Console.ReadLine();
            Console.Write("Ngày sinh (dd/MM/yyyy): ");
            var birthDate = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);
            if (!empCheck.IsOldEnough(birthDate))
            {
                Console.WriteLine("Chưa đủ 18 tuổi, không thể làm việc tại đây!");
                return null;
            }
            Console.Write("Địa chỉ: ");
            var address = Console.ReadLine();
            Console.Write("Giới tính (1-Nam, 2-Nữ): ");
            var genderInt = int.Parse(Console.ReadLine());
            bool gender;
            if (genderInt == 1)
                gender = true;
            else
                gender = false;
            Console.Write("Số điện thoại: ");
            var phone = Console.ReadLine();
            Console.Write("Ngày bắt đầu vào làm (dd/MM/yyyy): ");
            var startDate = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);
            Console.Write("Hệ số lương: ");
            var coefficientSalary = float.Parse(Console.ReadLine());
            Console.Write("Doanh số bán hàng tối thiểu: ");
            var minSale = int.Parse(Console.ReadLine());
            Console.Write("Doanh số bán hàng theo tháng: ");
            var saleMonth = int.Parse(Console.ReadLine());
            return new BussinessEmployee(emps, name, birthDate, address, gender,
                phone, startDate, coefficientSalary, minSale, saleMonth);
        }

        //Phương thức tạo mới nhân viên kinh doanh tại Vincom
        private static ManufactureEmployee AddNewManufactEmp(List<VingroupEmployee> emps)
        {
            EmployeeImp empCheck = new EmployeeImp();
            Console.Write("Họ và tên: ");
            var name = Console.ReadLine();
            Console.Write("Ngày sinh (dd/MM/yyyy): ");
            var birthDate = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);
            if (!empCheck.IsOldEnough(birthDate))
            {
                Console.WriteLine("Chưa đủ 18 tuổi, không thể làm việc tại đây!");
                return null;
            }
            Console.Write("Địa chỉ: ");
            var address = Console.ReadLine();
            Console.Write("Giới tính (1-Nam, 2-Nữ): ");
            var genderInt = int.Parse(Console.ReadLine());
            bool gender;
            if (genderInt == 1)
                gender = true;
            else
                gender = false;
            Console.Write("Số điện thoại: ");
            var phone = Console.ReadLine();
            Console.Write("Ngày bắt đầu vào làm (dd/MM/yyyy): ");
            var startDate = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);
            Console.Write("Hệ số lương: ");
            var coefficientSalary = float.Parse(Console.ReadLine());
            Console.Write("Số ngày nghỉ trong tháng: ");
            var numOfDayOff = int.Parse(Console.ReadLine());
            return new ManufactureEmployee(emps, name, birthDate, address, gender, phone,
                startDate, coefficientSalary, numOfDayOff);
        }


    }
}
