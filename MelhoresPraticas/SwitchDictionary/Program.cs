using System;
using System.Collections.Generic;

namespace SwitchDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int day = 0;

            // muito grande
            switch (day)
            {
                case 1:
                    Console.WriteLine("Segunda");
                    break;
                case 2:
                    Console.WriteLine("Terça");
                    break;
                case 3:
                    Console.WriteLine("Quarta");
                    break;
                case 4:
                    Console.WriteLine("Quinta");
                    break;
                case 5:
                    Console.WriteLine("Sexta");
                    break;
                case 6:
                    Console.WriteLine("Sabado");
                    break;
                case 7:
                    Console.WriteLine("Domingo");
                    break;
            }

            // fica mais enxuto
            Dictionary<int, string> datTimeMap = new Dictionary<int, string>();
            datTimeMap.Add(1, "Segunda"); // key, value
            datTimeMap.Add(2, "Terça");
            datTimeMap.Add(3, "Quarta");

            if (datTimeMap.ContainsKey(1))
            {
                Console.WriteLine(datTimeMap[1]);
                Console.ReadKey();
            }


            // exemplo com delegate
            Dictionary<int, Action> datTimeMap2 = new Dictionary<int, Action>();
            datTimeMap2.Add(1, delegate () { Console.WriteLine("Segunda-feira"); Console.ReadKey(); }); // key, value

            if (datTimeMap.ContainsKey(1))
            {
                datTimeMap2[1]();
            }
        }
    }
}
