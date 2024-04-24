using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1
{
    internal class FilterImp : IFilter
    {
        //Phương thức sắp xếp nhân viênVingroup theo thứ tự giảm dần lương 
        public void SortVingroupBySalaryDESC(List<VingroupEmployee> employees)
        {
            for(int i = 0; i < employees.Count-1; i++)
            {
                for(int j = i+1; j < employees.Count; j++)
                {
                    if (employees[i].Salary < employees[j].Salary)
                    {
                        var emp = employees[i];
                        employees[i] = employees[j];
                        employees[j] = emp;
                    }    
                }
            }
        }
        
        //Phương thức sắp xếp nhân viên Vincom theo thứ tự giảm dần lương 
        public void SortVincomBySalaryDESC(List<VincomEmployee> employees)
        {
            for(int i = 0; i < employees.Count-1; i++)
            {
                for(int j = i+1; j < employees.Count; j++)
                {
                    if (employees[i].Salary < employees[j].Salary)
                    {
                        var emp = employees[i];
                        employees[i] = employees[j];
                        employees[j] = emp;
                    }    
                }
            }
        }

    }
}
