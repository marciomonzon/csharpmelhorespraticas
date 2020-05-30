using System;

namespace Override
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    public class Person
    {
        public string FirstName { get; private set; }
        public string LastName { get; private set; }

        public Person(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public virtual string GetFullName()
        {
            return string.Format("{0} {1}", FirstName, LastName);
        }
    }

    public class Employee : Person
    {
        public string Role { get; private set; }

        public Employee(string firstName, string lastName, string role) : base(firstName, lastName)
        {
            Role = role;
        }

        public override string GetFullName()
        {
            return base.GetFullName();
            // posso fazer outras coisas a mais
        }
    }
}
