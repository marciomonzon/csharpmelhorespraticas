using System;

namespace MuitasClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    // não é bom que uma classe tenha muitas dependencias
    // de classes
    public class MainClass
    {
        public void Start()
        {
            Class1 c1 = new Class1();
            Class2 c2 = new Class2();
            Class3 c3 = new Class3();
        }

        public void Stop()
        {

        }
    }

    public class Class1
    {

    }

    public class Class2
    {

    }

    public class Class3
    {

    }
}
