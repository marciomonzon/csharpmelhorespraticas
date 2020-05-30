using System;

namespace EnumNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var weekDay = GetWeekDay(WeekDay.Thursday);
            Console.WriteLine(weekDay);
            Console.ReadLine();
        }

        public static int GetWeekDay(WeekDay day)
        {
            int weekDay = (int)day;
            return weekDay;
        }
    }

    public enum WeekDay
    {
        Monday = 1,
        Tuesday = 2,
        Wednesday = 3,
        Thursday = 4,
        Friday = 5,
        Saturday = 6,
        Sunday = 7
    }
}
