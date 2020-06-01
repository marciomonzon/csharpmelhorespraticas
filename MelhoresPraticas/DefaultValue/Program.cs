using System;

namespace DefaultValue
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        // pode ser qualquer valor default
        public static void ProcessRule(int value2)
        {
            int value1 = int.MinValue;

            if (value2 > 5)
            {
                value1 = 6;
            }
            Console.WriteLine(value1);
        }
    }
}
