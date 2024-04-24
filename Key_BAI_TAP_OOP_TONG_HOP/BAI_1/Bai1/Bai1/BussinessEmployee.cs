using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1
{
    internal class BussinessEmployee : VincomEmployee
    {
        public int MinSale { get; set; }        //Doanh số bán hàng tối thiểu
        public int SalesMonth { get; set; }     //Doanh số bán hàng theo tháng
        public int Commision { get; set; }      //Hoa hồng: 15% của doanh thu vượt mức doanh thu tối thiểu

        //Các phương thức khởi tạo
        public BussinessEmployee(List<VingroupEmployee> employees, string fullName,
            DateTime birthDate, string address, bool gender, string phone,
            DateTime startDate, float coefficientSalary, int minSale, int saleMonth) : 
            base(employees, fullName, birthDate, address, 
                gender, phone, startDate, coefficientSalary)
        {
            ClassificMonth = GetClassificMonth(minSale, saleMonth);
            Salary = CalculateSalary();
            MinSale = minSale;
            SalesMonth = saleMonth;
            Commision = CalculateCommision();
            AwardVincom = GetAwardVincom();
            AwardVingroup = GetAwardVingroup();
        }

        //Phương thức xét loại
        private string GetClassificMonth(int minSale, int saleMonth)
        {
            if (saleMonth > 2 * minSale )
                return "A";
            else if (saleMonth >= minSale)
                return "B";
            else if (saleMonth > 0.5 * minSale)
                return "C";
            else
                return "D";
        }

        //Phương thức tính hoa hồng
        public int CalculateCommision()
        {
            if (SalesMonth > MinSale)
            {
                var overMin = SalesMonth - MinSale;
                return (int)(overMin * 0.15f);
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

        public int CaculateBussiEmpSalary() => (int)(CoefficientSalary * BaseSalary + Commision);
        protected override int CalculateSalary()
        {
            var salaryBeforeConsider = CaculateBussiEmpSalary(); //Lương trước khi xét xếp loại
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

    }
}
