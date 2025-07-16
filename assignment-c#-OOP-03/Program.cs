using System;
using System.Reflection;

namespace assignment_c__OOP_03
{
    internal class Program
    {


        public static void PrintPersonDetails(Person person)
        {
           if(person is not null)
            {
                person.GetDetails();
            }
        }
        static void Main(string[] args)
        {
          Person person01 = new Person("John", "Doe", 30 );
            Person person02 = new Student("Jane", "Smith", 20, "Level 1");
            Person person03 = new Teacher("Alice", "Johnson", 40, "Mathematics");
            Person person04 =new Admin ("Bob", "Brown", 35, "Administration");
            person02.GetDetails();

            Console.WriteLine(person01.GetDetails());
            Console.WriteLine(person02.GetDetails());
            Console.WriteLine(person03.GetDetails());
            Console.WriteLine(person04.GetDetails());




        }
    }
}
