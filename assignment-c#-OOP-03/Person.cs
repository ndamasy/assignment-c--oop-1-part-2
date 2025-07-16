using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace assignment_c__OOP_03
{
    internal class Person
    {
        public string Fname { get; set; }
        public string Lname { get; set; }
        public int age { get; set;  }

        public Person ( string _fname, string _lname, int _age)
        {
            Fname = _fname;
            Lname = _lname;
            age = _age;
        }


        public virtual string GetDetails()
        {
            
            return $"Name: {Fname} {Lname}\n Age: {age}";
        }

    }
}
