using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1
{
    public class VinrealEmployee : VingroupEmployee
    {
        public int TotalIncomeInMonth { get; set; }     //Thu nhập hằng tháng
        public string AwardVinreal { get; set; }        //Danh hiệu Vinreal

        //Phương thức khởi tạo
        public VinrealEmployee(List<VingroupEmployee> employees,
            string fullName, DateTime birthDate, string address,
            bool gender, string phone, DateTime startDate,
            int totalIncomeInMonth) :
            base(employees, fullName, birthDate, address,
            gender, phone, startDate)
        {
            TotalIncomeInMonth = totalIncomeInMonth;
            Salary = CalculateSalary();
            AwardVinreal = GetAwardVinreal();
            AwardVingroup = GetAwardVingroup();
        }
        //Phương thức xét danh hiệu Vingroup
        private string GetAwardVingroup()
        {
            switch (AwardVinreal)
            {
                case "Chiến sĩ thi đua":
                    return "năng lực tốt";
                case "Lao động tiên tiến":
                    return "có năng lực";
            }
            return "Không có danh hiệu";
        }

        //Phương thức xét danh hiệu Vinreal
        private string GetAwardVinreal()
        {
            if (Salary > 20_000_000)
                return "Chiến sĩ thi đua";
            else if (Salary > 10_000_000)
                return "Lao động tiên tiến";
            return "Không đat chỉ tiêu";
        }

       //Phương thức tính lương của nhân viên
        public int CalculateSalary() => (int)(TotalIncomeInMonth * 0.2);

    }
}
