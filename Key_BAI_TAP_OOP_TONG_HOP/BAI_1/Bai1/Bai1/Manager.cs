using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1
{
    internal class Manager : VincomEmployee
    {
        public string Position { get; set; }            //Chức vụ   
        public float PositionCoefficient { get; set; }  //Hệ số chức vụ
        public Manager(List<VingroupEmployee> employees, string fullName,
            DateTime birthDate, string address, bool gender, string phone,
            DateTime startDate, float coefficientSalary,
            string position, float positionCoefficient)
            : base(employees, fullName, birthDate, address,
                  gender, phone, startDate, coefficientSalary)
        {
            ClassificMonth = "A";
            Position = position;
            PositionCoefficient = positionCoefficient;
            AwardVincom = GetAwardVincom();
            AwardVingroup = GetAwardVingroup();
            Salary = CalculateSalary();
        }

        //Phương thức tính lương của cán bộ quản lý
        public int CalculatePositionSalary() => (int)(PositionCoefficient * 2_000_000);
        public int CalculateManagerSalary() => (int)(CoefficientSalary * BaseSalary + CalculatePositionSalary());
        protected override int CalculateSalary() => (int)(CalculateManagerSalary() + SeniorityAllowance);

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
