using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1
{
    internal interface IFilter
    {
        void SortVingroupBySalaryDESC(List<VingroupEmployee> employees);
        void SortVincomBySalaryDESC(List<VincomEmployee> employees);
    }
}
