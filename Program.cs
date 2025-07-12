using System.Net.Http.Headers;

namespace assignment_c__oop_12
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region write a C# program to display the details of all the persons in the array.
            //Person[] people = new Person[3];
            //people[0] = new Person("mazen", 30);
            //people[1] = new Person("omar", 27);
            //people[2] = new Person("ahmed", 33);
            //foreach (var person in people)
            //{
            //    Console.WriteLine($"Name: {person.Name}, Age: {person.Age}");
            //}
            #endregion

            #region Write a C# program that takes two points as input from the user and calculates the distance between them
            //Point distance = new Point();
            //double result = 0;
            //Console.WriteLine("Enter the coordinates of the first point (x1 y1):");
            //string[] firstPointInput = Console.ReadLine().Split(' ');
            //int x1 = int.Parse(firstPointInput[0]);
            //int y1 = int.Parse(firstPointInput[1]);
            //Console.WriteLine("Enter the coordinates of the second point (x2 y2):");
            //string[] secondPointInput = Console.ReadLine().Split(' ');
            //int x2 = int.Parse(secondPointInput[0]);
            //int y2 = int.Parse(secondPointInput[1]);
            //result = x1+ y1+ x2+ y2;

            //Console.WriteLine($"The distance between the points ({x1}, {y1}) and ({x2}, {y2}) is: {result}");

            #endregion

            #region Write a C# program that takes details of 3 persons as input from the user and displays the name and age of the oldest person.
            //Person[] people = new Person[3];
            //people[0] = new Person("mazen", 30);
            //people[1] = new Person("omar", 27);
            //people[2] = new Person("ahmed", 33);
            //Person oldest = people[0];

            //for (int i = 1; i < people.Length; i++)
            //{
            //    if (people[i].Age > oldest.Age)
            //    {
            //        oldest = people[i];
            //    }
            //}

            //Console.WriteLine($"The oldest person is {oldest.Name}, Age: {oldest.Age}");

            #endregion

            #region Create Variable from Enum to Add and Remove Permission from variable
            user user1 = new user();
            user1.Id = 1;
            user1.UserPermissions = (permissions)4;
            user1.UserPermissions = (permissions)10;
            user1.UserPermissions = user1.UserPermissions ^ permissions.Read;
            user1.UserPermissions = user1.UserPermissions ^= permissions.Read;

            Console.WriteLine(user1.UserPermissions);
            #endregion
        }
    }
}
