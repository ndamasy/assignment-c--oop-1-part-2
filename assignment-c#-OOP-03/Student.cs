using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_c__OOP_03
{
    internal class Student:Person
    {
        public string GradeLevel { get; set; }

        public Student (string _fname , string _lname ,int _age,  string _gradeLevel) :base(_fname , _lname , _age)
        {

            GradeLevel = _gradeLevel;
        }
        public override string GetDetails()
        {
            return base.GetDetails() + $"\nGrade Level: {GradeLevel}";
        }

    }
}
