namespace Practice_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int hours;
            int minutes;
            int seconds;
            int userChoice;
            Console.Write("Input hours: ");
            while (!int.TryParse(Console.ReadLine(), out hours))
            {
                Console.Write("Invalid input. Try agian: ");
            }
            Console.Write("Input minutes: ");
            while (!int.TryParse(Console.ReadLine(), out minutes))
            {
                Console.Write("Invalid input. Try agian: ");
            }
            Console.Write("Input seconds: ");
            while (!int.TryParse(Console.ReadLine(), out seconds))
            {
                Console.Write("Invalid input. Try agian: ");
            }
            Clock clock1 = new Clock(hours, minutes, seconds, out string errorMessage);
            if (errorMessage != "")
            {
                Console.WriteLine(errorMessage);
            }
            else
            {
                Console.WriteLine("==============================");
                Console.WriteLine("1. Get hours.");
                Console.WriteLine("2. Get minutes. ");
                Console.WriteLine("3. Get seconds. ");
                Console.WriteLine("4. Set time. ");
                Console.WriteLine("5. Show time. ");
                Console.WriteLine("6. Tick down. ");
                Console.WriteLine("7. Add hours. ");
                Console.WriteLine("8. Exit. ");
                Console.WriteLine("==============================");
                while (true)
                {
                    Console.Write("Input your choice: ");
                    while (!int.TryParse(Console.ReadLine(), out userChoice) || userChoice < 1 || userChoice > 8)
                    {
                        Console.Write("Invalid input. Try agian: ");
                    }
                    if (userChoice == 1)
                    {
                        Console.WriteLine("Hours = " + clock1.getHours());
                    }
                    else if (userChoice == 2)
                    {
                        Console.WriteLine("Minutes = " + clock1.getMinutes());
                    }
                    else if (userChoice == 3)
                    {
                        Console.WriteLine("Seconds = " + clock1.getSeconds());

                    }
                    else if (userChoice == 4)
                    {
                        Console.Write("Input hours: ");
                        while (!int.TryParse(Console.ReadLine(), out hours) || hours < 1 || hours > 59) 
                        {
                            Console.Write("Invalid input. Try agian: ");
                        }
                        Console.Write("Input minutes: ");
                        while (!int.TryParse(Console.ReadLine(), out minutes) || minutes < 1 || minutes > 59)
                        {
                            Console.Write("Invalid input. Try agian: ");
                        }
                        Console.Write("Input seconds: ");
                        while (!int.TryParse(Console.ReadLine(), out seconds) || seconds < 1 || seconds >59)
                        {
                            Console.Write("Invalid input. Try agian: ");
                        }
                        clock1.setTime(new DateTime(hours, minutes, seconds));
                    }
                    else if (userChoice == 5)
                    {
                        Console.Write("Time: ");
                        clock1.showTime();
                    }
                    else if (userChoice == 6)
                    {
                        clock1.tickDown();
                        Console.WriteLine("Ticked down by one second.");
                    }
                    else if (userChoice == 7)
                    {
                        Console.WriteLine("Input hours to add: ");
                        while (!int.TryParse(Console.ReadLine(), out hours))
                        {
                            Console.Write("Invalid input. Try agian: ");
                        }
                        clock1.addHours(hours);
                        Console.WriteLine("Added " + hours + " hours.");
                    }
                    else if (userChoice == 8)
                    {
                        break;
                    }
                }
            }
        }
    }
}