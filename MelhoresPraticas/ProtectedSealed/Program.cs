using System;

namespace ProtectedSealed
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        class Person
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
        }

        sealed class Employee : Person
        {
            //protected string EmployeeCode { get; set; }

            private string EmployeeCode { get; set; }
        }

        // não é possível herdar classe sealed
        //class Accountant : Employee
        //{

        //}
    }
}
