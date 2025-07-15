using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_c__oop02
{
    internal class Emp
    {
        public DateTime HiringDate { get; set; }
        public Emp(DateTime hiringDate)
        {
            HiringDate = hiringDate;
        }

        override public string ToString()
        {
            return $"Hiring Date: {HiringDate.ToShortDateString()}";
        }
    }

   
}
