using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_c__oop02
{
    internal class Employees
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }
        public Gender Gender { get; set; }
        public DateOnly Hiringdate { get; set; }
        public string SecurityLevel { get; set; }
        public string Role { get; set; }



        public Employees(int _Id, string _Name, double _Salary, Gender _Gender, DateTime _Hiringdate, string _SecurityLevel , Role _role)
        {
            Id = _Id;
            Name = _Name;
            Salary = _Salary;
          Gender  = _Gender;
            Hiringdate = DateOnly.FromDateTime(_Hiringdate);
            SecurityLevel = _SecurityLevel;
            Role = _role.ToString();


        }
        public string GetFormattedSalary()
        {
            return String.Format("{0:C}", Salary); 
        }

        override public string ToString()
        {
            return $"Id: {Id}\n Name: {Name}\n Salary: {Salary}\n  Gender:{Gender}\n  Hiringdate:{Hiringdate}\n  Security:{SecurityLevel}\n Role{Role} ";
        }



       }    

}
