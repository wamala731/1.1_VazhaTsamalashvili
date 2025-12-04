namespace Practice8_Conditions
{
    internal class Program
    {
        /// <summary>
        /// Score: 8/10
        /// Reason: It works but you have complexity in that code 
        /// check comments maybe you did not know default case in switch-case, use casting while try to output string value of enum, enum declaration warnings
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            // maybe directly output is better for you check this
            //bool wasValid = int.TryParse(Console.ReadLine(), out int userinput1);
            //Console.WriteLine("Color: "(rainbow)userinput1);

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

    // enum must be declared here and name must start with uppercase char
    enum MyEnum
    {

    }
}
// enums must be at the same level where are classes
public enum rainbow
{
    // when you start indexing from 1 
    // it defines next values by increment 1
    Red = 1,
    Orange = 2,
    Yellow = 3,
    Green = 4,
    Blue = 5,
    Indigo = 6,
    Violet = 7,
}
