namespace Practice8_Conditions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if (int.TryParse(Console.ReadLine(), out int userinput))
            {
                Console.Write("Color: ");
                switch (userinput)
                {
                    case (int)rainbow.Red:
                        Console.WriteLine("Red");
                        break;
                    case (int)rainbow.Orange:
                        Console.WriteLine("Orange");
                        break;
                    case (int)rainbow.Yellow:
                        Console.WriteLine("Yellow");
                        break;
                    case (int)rainbow.Green:
                        Console.WriteLine("Green");
                        break;
                    case (int)rainbow.Blue:
                        Console.WriteLine("Blue");
                        break;
                    case (int)rainbow.Indigo:
                        Console.WriteLine("indigo");
                        break;
                    case (int)rainbow.Violet:
                        Console.WriteLine("Violet");
                        break;
                    
                }

            }
            else if (userinput > 7)
            {
                Console.WriteLine("Color: White" );
            }
            else
            {
                Console.WriteLine("Input is not integer number.");
            }
        }
    }
}
public enum rainbow
{
    Red = 1,
    Orange = 2,
    Yellow = 3,
    Green = 4,
    Blue = 5,
    Indigo = 6,
    Violet = 7,
}
