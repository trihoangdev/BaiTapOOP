using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1
{
    internal class EmployeeImp : IEmployee
    {
        //Phương thức kiểm tra nhân viên đủ tuổi làm chưa
        public bool IsOldEnough(DateTime birthDate)
        {
            var birthDateThisYear = birthDate.AddYears(18);
            var now = DateTime.Now;
            return now >= birthDateThisYear;
        }

    }
}
