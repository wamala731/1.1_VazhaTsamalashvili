namespace Practice_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            List<DateTime> Dates = new List<DateTime>() {
                new DateTime(2009, 01, 04),
                new DateTime(2016, 11, 10),
                new DateTime(2010, 12, 09),
                new DateTime(1984, 05, 04)
            };

            while (true)
            {
            Console.WriteLine();
            Console.Write("Input date (year, month, day): ");
            if (!DateTime.TryParse(Console.ReadLine(), out DateTime usersDate))
            {
                Console.WriteLine("Invalid date format. try again.");
                continue;
            }
            string usersChoise;
            bool dateExists = false;
            for (int i = 0; i < Dates.Count; i++)
            {
                if (usersDate == Dates[i])
                {
                    dateExists = true;
                    Console.WriteLine();
                    Console.Write("Do you want to modify it? (yes) or (no): ");
                    usersChoise = Console.ReadLine();
                    if (usersChoise == "yes")
                    {
                            DateTime newDate;
                            ;
                            while (true)
                            {
                                Console.Write("Input new date: ");
                                if (!DateTime.TryParse(Console.ReadLine(), out newDate))
                                {
                                    Console.WriteLine("Invalid date format. try again: ");
                                    continue;
                                }else
                                {
                                    break;
                                }
                            }
                            
                    Dates[i] = newDate;
                    }else if (usersChoise == "no")
                    {
                        break;

                        }
                    }
            }
            if (!dateExists)
            {
                Console.WriteLine();
                Console.WriteLine("Such date could not be found. ");
            }
        }
        }
    }
}
