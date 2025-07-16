using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_c__OOP_03
{
    internal class Admin:Person
    {
        public string Role { get; set; }
        public Admin(string _fname, string _lname, int _age, string _role) : base(_fname, _lname, _age)
        {
            Role = _role;
        }
        public override string GetDetails()
        {
            return base.GetDetails() + $"\nDepartment: {Role}";
        }
    }
}
