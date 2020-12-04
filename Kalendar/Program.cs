using System;
using System.Collections.Generic;
using System.Linq;

namespace Kalendar
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Month ");
            //int month = int.Parse(Console.ReadLine());
            //Console.WriteLine("Year ");
            //int year = int.Parse(Console.ReadLine());
            int m = 1;
            int y = 2020;
            var month = new DateTime(y, m, 1);
            List<int> result = new List<int> { };

            var padLeftDays = (int)month.DayOfWeek;
            var currentDay = month;
            if (m != 1)
            {
                var prevMonth = new DateTime(2020, m - 1, 1);
                int countPrevMonth = DateTime.DaysInMonth(y, m - 1);
                var prevDay = prevMonth.AddDays(countPrevMonth - padLeftDays);

                var countMonth = DateTime.DaysInMonth(y, m);
                var newMonth = new DateTime(y, m, countMonth);
                var padRaightDays = 6 - (int)newMonth.DayOfWeek;
                var iterations = DateTime.DaysInMonth(month.Year, month.Month) + padLeftDays + padRaightDays;
                for (int j = 0; j < iterations; j++)
                {
                    if (j < padLeftDays)
                    {
                        result.Add(prevDay.Day);
                        prevDay = prevDay.AddDays(1);
                    }
                    else
                    {
                        result.Add(currentDay.Day);
                        currentDay = currentDay.AddDays(1);
                    }
                }
            }
            else
            {
                var prevMonth = new DateTime(y-1, 12, 1);
                int countPrevMonth = DateTime.DaysInMonth(y-1, 12);
                var prevDay = prevMonth.AddDays(countPrevMonth - padLeftDays);

                var countMonth = DateTime.DaysInMonth(y, m);
                var newMonth = new DateTime(y, m, countMonth);
                var padRaightDays = 6 - (int)newMonth.DayOfWeek;
                var iterations = DateTime.DaysInMonth(month.Year, month.Month) + padLeftDays + padRaightDays;
                for (int j = 0; j < iterations; j++)
                {
                    if (j < padLeftDays)
                    {
                        result.Add(prevDay.Day);
                        prevDay = prevDay.AddDays(1);
                    }
                    else
                    {
                        result.Add(currentDay.Day);
                        currentDay = currentDay.AddDays(1);
                    }
                }
            }
            
            foreach (var x in result)
            {
                Console.WriteLine(x);
            }

            Console.Write("\nDone!\nPress and key to exit...");
            Console.ReadKey();

        }
    }
}
