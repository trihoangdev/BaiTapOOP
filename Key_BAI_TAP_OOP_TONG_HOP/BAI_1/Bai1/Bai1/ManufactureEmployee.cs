using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1
{
    internal class ManufactureEmployee : VincomEmployee
    {
        public float AllowanceCoefficient { get; set; }         //Hệ số phụ cấp
        public int NumOfDayOff { get; set; }                    //Số ngày nghỉ trong tháng

        public ManufactureEmployee(List<VingroupEmployee> employees, string fullName,
            DateTime birthDate, string address, bool gender, string phone, DateTime startDate,
            float coefficientSalary, int numOfDayOff)
            : base(employees, fullName, birthDate, address, gender,
                  phone, startDate, coefficientSalary)
        {
            ClassificMonth = GetClassificMonth(NumOfDayOff);
            Salary = CalculateSalary();
            AllowanceCoefficient = 0.1f;
            NumOfDayOff = numOfDayOff;
            AwardVincom = GetAwardVincom();
            AwardVingroup = GetAwardVingroup();
        }

        private string GetClassificMonth(int numOfDayOff)
        {
            if (numOfDayOff <= 1)
                return "A";
            else if (numOfDayOff <= 3)
                return "B";
            else if (numOfDayOff <= 5)
                return "C";
            else return "D";
        }
        public int CaculateManuEmpSalary() => (int)(CoefficientSalary * BaseSalary + (1 + AllowanceCoefficient));
        protected override int CalculateSalary()
        {
            var salaryBeforeConsider = CaculateManuEmpSalary(); //Lương trước khi xét xếp loại
            switch (ClassificMonth)
            {
                case "A":
                    return (int)(salaryBeforeConsider + SeniorityAllowance);
                case "B":
                    return (int)(salaryBeforeConsider * 0.75 + SeniorityAllowance);
                case "C":
                    return (int)(salaryBeforeConsider * 0.5 + SeniorityAllowance);
                case "D":
                    return (int)(salaryBeforeConsider * 0 + SeniorityAllowance);
            }
            return 0;
        }

        //Phương thức xét danh hiệu Vingroup
        protected override string GetAwardVingroup()
        {
            switch (AwardVincom)
            {
                case "Chiến sĩ thi đua":
                    return "năng lực tốt";
                case "Lao động tiên tiến":
                    return "có năng lực";
            }
            return "Không có danh hiệu";
        }

        //Phương thức xét danh hiệu Vincom
        protected override string GetAwardVincom()
        {
            switch (ClassificMonth)
            {
                case "A":
                    return "Chiến sĩ thi đua";
                case "B":
                    return "Lao động tiên tiến";
            }
            return "Không có danh hiệu";
        }
    }
}
