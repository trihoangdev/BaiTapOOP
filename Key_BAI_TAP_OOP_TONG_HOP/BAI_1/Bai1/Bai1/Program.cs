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
                                ShowEmpInfo(empCast);
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
                            if(emp is VincomEmployee)
                            {
                                var empCast = (VincomEmployee)emp;
                                if (CountYearAtVin(empCast.StartDate) > 10)
                                    ShowEmpInfo(empCast);
                            }    
                           
                        break;
                    case 14:
                        // Xuất danh sách các nhân viên không đạt chỉ tiêu của nhân viên VINREAL
                        Console.WriteLine("Các nhân viên không đạt chỉ tiêu của nhân viên VINREAL");
                        foreach (var emp in employees)
                            if(emp is VinrealEmployee)
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
