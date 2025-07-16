using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_c__OOP_03
{
    internal class Teacher:Person
    {
        public string Subject { get; set; }
        public Teacher(string _fname, string _lname, int _age, string _subject) : base(_fname, _lname, _age)
        {
            Subject = _subject;
        }
        public override string GetDetails()
        {
            return base.GetDetails() + $"\nSubject: {Subject}";
        }
    }
}
