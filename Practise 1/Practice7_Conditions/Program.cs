using System.ComponentModel.Design;

namespace Practice7_Conditions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if (int.TryParse(Console.ReadLine(), out int userinput) && userinput <= 12)
            {
                Console.Write("Month: ");
                switch (userinput)
                {
                    case 1:
                        Console.WriteLine("January");
                        break;
                    case 2:
                        Console.WriteLine("February");
                        break;
                    case 3:
                        Console.WriteLine("March");
                        break;
                    case 4:
                        Console.WriteLine("April");
                        break;
                    case 5:
                        Console.WriteLine("May");
                        break;
                    case 6:
                        Console.WriteLine("June");
                        break;
                    case 7:
                        Console.WriteLine("July");
                        break;
                    case 8:
                        Console.WriteLine("August");
                        break;
                    case 9:
                        Console.WriteLine("September");
                        break;
                    case 10:
                        Console.WriteLine("Octomber");
                        break;
                    case 11:
                        Console.WriteLine("November");
                        break;
                    case 12:
                        Console.WriteLine("December");
                        break;
                }

            }
            else if (userinput > 12)
            {
                Console.WriteLine("Month {" + userinput + "} doesn't exist");
            }
            else
            {
                Console.WriteLine("Input is not integer number.");
            }
        }
    }
}

