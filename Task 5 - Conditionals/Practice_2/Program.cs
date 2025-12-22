using System.Collections.Specialized;
using System.Reflection.Metadata.Ecma335;

namespace Practice_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("======= Menu =======");
            Console.WriteLine("1. The current month");
            Console.WriteLine("2. The current day of week");
            Console.WriteLine("3. The current year");
            Console.WriteLine("0. Exit");
            Console.WriteLine("===================");
            Console.WriteLine("Select Menu number:");
            DateTime dateNow = DateTime.Now;
            while (true)
            {
                Console.Write("Enter your choise: ");
                if (int.TryParse(Console.ReadLine(), out int UserChoise))
                {
                    if (UserChoise == 0)
                    {
                        return;
                    }
                    else if (UserChoise == 1)
                    {
                        Console.WriteLine(dateNow);
                        Console.WriteLine("Current month: " + dateNow.Month);
                    }
                    else if (UserChoise == 2)
                    {
                        Console.WriteLine(dateNow);
                        Console.WriteLine("Current day of week: " + dateNow.DayOfWeek);
                    }
                    else if (UserChoise == 3)
                    {
                        Console.WriteLine(dateNow);
                        Console.WriteLine("Current year: " + dateNow.Year);
                    }

                    else if (UserChoise > 3)
                    {
                        Console.WriteLine("You must choose one of the following numbers: ");
                    }
                }


            }
        }
    }
}
