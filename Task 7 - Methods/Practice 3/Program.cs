using System.Globalization;

namespace Practice_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("What do you want to multiply? 1)int or 2)double: ");
            byte usersTypeChoise;
            while (!byte.TryParse(Console.ReadLine(), out usersTypeChoise) && (usersTypeChoise == 1 || usersTypeChoise == 2) )
            {
                Console.Write("Choose one of them: ");
            }
            Console.Write("How many numbers to multiply? (2 or 3)");
            byte usersCountChoise;
            while (!byte.TryParse(Console.ReadLine(), out  usersCountChoise) && (usersCountChoise == 3 || usersCountChoise == 2))
            {
                Console.Write("Choose one of them: ");
            }
            int x, y, z;
            double x1, y1, z1;
            if (usersTypeChoise == 1)
            {
                if (usersCountChoise == 2)
                {
                    Console.Write("Enter numbers: ");
                    while (!int.TryParse(Console.ReadLine(), out x))
                    {
                        Console.WriteLine("Enter real number: ");
                    }
                    while (!int.TryParse(Console.ReadLine(), out y))
                    {
                        Console.WriteLine("Enter real number: ");
                    }
                    Console.Write("Result: ");
                    Console.WriteLine(Multiply(x, y));

                }
                else
                {
                    Console.Write("Enter numbers: ");
                    while (!int.TryParse(Console.ReadLine(), out x))
                    {
                        Console.WriteLine("Enter real number: ");
                    }
                    while (!int.TryParse(Console.ReadLine(), out y))
                    {
                        Console.WriteLine("Enter real number: ");
                    }
                    while (!int.TryParse(Console.ReadLine(), out z))
                    {
                        Console.WriteLine("Enter real number: ");
                    }
                    Console.Write("Result: ");
                    Console.WriteLine(Multiply(x, y, z));
                }


            }
            else if (usersTypeChoise == 2)
            {
                if (usersCountChoise == 2)
                {
                    Console.Write("Enter numbers: ");
                    while (!double.TryParse(Console.ReadLine(), out x1))
                    {
                        Console.WriteLine("Enter real number: ");
                    }
                    while (!double.TryParse(Console.ReadLine(), out y1))
                    {
                        Console.WriteLine("Enter real number: ");
                    }
                    Console.Write("Result: ");
                    Console.WriteLine(Multiply(x1, y1));

                }
                else
                {
                    Console.Write("Enter numbers: ");
                    while (!double.TryParse(Console.ReadLine(), out x1))
                    {
                        Console.WriteLine("Enter real number: ");
                    }
                    while (!double.TryParse(Console.ReadLine(), out y1))
                    {
                        Console.WriteLine("Enter real number: ");
                    }
                    while (!double.TryParse(Console.ReadLine(), out z1))
                    {
                        Console.WriteLine("Enter real number: ");
                    }
                    Console.Write("Result: ");
                    Console.WriteLine(Multiply(x1,y1,z1));
                }

            }
            }


        public static int Multiply(int x, int y)
        {
            return x * y;
        }
        public static int Multiply(int x, int y, int z)
        {
            return x * y * z;
        }

        public static double Multiply(double x, double y)
        {
            return x * y;
        }
        public static double Multiply(double x, double y, double z)
        {
            return x * y * z;
        }
    }
}
