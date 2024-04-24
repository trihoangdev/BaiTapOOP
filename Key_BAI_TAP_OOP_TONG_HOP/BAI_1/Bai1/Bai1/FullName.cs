using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1
{
    //Lớp mô tả thông tin họ và tên
    public class FullName
    {

        public string FirstName { get; set; }   //Tên
        public string MidName { get; set; }     //Đệm
        public string LastName { get; set; }    //Họ
        public FullName(string fullName)
        {
            var data = fullName.Split(' ');
            LastName = data[0];
            FirstName = data[data.Length - 1];
            var mid = "";
            for (int i = 1; i < data.Length - 1; i++)
            {
                mid += data[i] + ' ';
            }
            MidName = mid.Trim();
        }

        public override string ToString() => LastName + " " + MidName + " " + FirstName;
    }
}
