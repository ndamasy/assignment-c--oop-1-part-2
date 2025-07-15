namespace assignment_c__oop02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region employees class implementation
            //Employees employee01 = new Employees(1, "John Doe", 50000, Gender.Male, new DateTime(2025, 3, 7), "high");
            //Console.WriteLine(employee01.ToString());
            #endregion

            #region Develop a Class to represent the Hiring Date Data

            //Emp emp01 = new Emp(new DateTime(2025, 10, 7));
            //Console.WriteLine(emp01.ToString());
            #endregion

            #region restrict the Gender field to be only M or F [Male or Female]

            //Employees employee01 = new Employees(1, "John Doe", 50000, Gender.Male, new DateTime(2025, 3, 7), "high");
            //Console.WriteLine(employee01.ToString());
            #endregion

            #region security privileges to the employee (guest, Developer, secretary and DBA) in a form of Enum
            //Employees employee01 = new Employees(1, "John Doe", 50000, Gender.Male, new DateTime(2025, 3, 7), "high" ,Role.Developer);
            //Console.WriteLine(employee01.ToString());

            #endregion


            #region  display employee salary in a currency format
            //Employees emp1 = new Employees(1, "John Doe", 50000, Gender.Male, new DateTime(2025, 3, 7), "High" , Role.Developer);

            //Console.WriteLine("Salary: " + emp1.GetFormattedSalary());

            #endregion

            #region Create an array of Employees
            //Employees[] EmpArr = new Employees[3];
            //EmpArr[0] = new Employees(1, "Ahmed Saleh", 15000, Gender.Male, new DateTime(2023, 1, 10), "High", Role.DBA);
            //EmpArr[1] = new Employees(1, "Ahmed hussein", 15000, Gender.Male, new DateTime(2023, 1, 10), "low", Role.Guest);
            //EmpArr[2] = new Employees(1, "Ahmed ebrahim", 15000, Gender.Male, new DateTime(2023, 1, 10), "High", Role.Secretary);
            //for(int i = 0; i < EmpArr.Length; i++)
            //{
            //    Console.WriteLine(EmpArr[i].ToString());
            //    Console.WriteLine("Formatted Salary: " + EmpArr[i].GetFormattedSalary());
               
            //}
            #endregion

        }
    }
}
