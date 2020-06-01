using System;

namespace Variaveis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public int GetValue()
        {
            //int n1 = int.MinValue;
            //int n2 = int.MinValue;
            int n1;
            int n2;

            n1 = GetNumber1();
            n2 = GetNumber2();

            return n1 + n2;
        }

        public int GetNumber1()
        {
            return 1;
        }

        public int GetNumber2()
        {
            return 2;
        }
    }
}
