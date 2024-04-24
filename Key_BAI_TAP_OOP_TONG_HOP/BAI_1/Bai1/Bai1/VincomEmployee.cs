using System;
using System.Collections.Generic;

namespace Bai1
{
    public abstract class VincomEmployee : VingroupEmployee
    {
        public float CoefficientSalary { get; set; }        //Hệ số lương
        public int BaseSalary { get; set; }                //Lương cơ bản
        public string ClassificMonth { get; set; }          //Xếp loại hằng tháng
        public string AwardVincom { get; set; }             //Danh hiệu Vincom
        public VincomEmployee(
            List<VingroupEmployee> employees, string fullName, DateTime birthDate,
            string address, bool gender, string phone, DateTime startDate,
            float coefficientSalary)
            : base(employees, fullName, birthDate, address, gender, phone, startDate)
        {
            BaseSalary = 1_400_000;
            CoefficientSalary = coefficientSalary;
        }
        //Phương thức xét danh hiệu Vingroup
        protected abstract string GetAwardVingroup();

        //Phương thức xét danh hiệu Vincom
        protected abstract string GetAwardVincom();

        protected abstract int CalculateSalary();
    }
}
