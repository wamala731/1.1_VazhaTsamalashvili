using System.ComponentModel;

namespace Practise9_Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {

            bool work = true;
            while (work)
            {
                Console.Write("Enter Number X: ");
                string userInput1 = Console.ReadLine();
                if (int.TryParse(userInput1, out int X))
                {
                }
                else
                {
                    Console.WriteLine("Inaccessible operation: " + userInput1 + "is not a number");
                    break;
                }
                Console.Write("Enter Number Y: ");
                string userInput2 = Console.ReadLine();
                if (int.TryParse(userInput2, out int Y))
                {
                }
                else
                {
                    Console.WriteLine("Inaccessible operation: " + userInput2 + " is not a number");
                    break;
                }
                int userOption;
                while (true)
                {
                    Console.WriteLine("Choose an option from the following list:");
                    Console.WriteLine("1 - Add");
                    Console.WriteLine("2 - Subtract");
                    Console.WriteLine("3 - Multiply");
                    Console.WriteLine("4 - Divide");
                    if (int.TryParse(Console.ReadLine(), out int Option) && (Option > 0 && Option < 5))
                    {
                        Console.WriteLine("Option: " + Option);
                        //აქ Option კი მაქვს უკვე მარა if გარეთ არ მიჩანს და როგორ გავაკეთო ისე რო public გახდეს?
                        userOption = Option;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Option: " + Option + " Does not exist");
                    }

                }
                Console.Write("Result: ");
                switch (userOption)
                {
                    case (int)MathematicalOperations.Add:
                        Console.WriteLine(X + " + " + Y + " = " + (Y + X));
                        break;
                    case (int)MathematicalOperations.Subtract:
                        Console.WriteLine(X + " - " + Y + " = " + (X - Y));
                        break;
                    case (int)MathematicalOperations.Multiply:
                        Console.WriteLine(X + " * " + Y + " = " + (Y * X));
                        break;
                    case (int)MathematicalOperations.Divide:
                        if (Y != 0)
                        {
                            Console.WriteLine(X + " / " + Y + " = " + (X / Y));
                            break;
                        }
                        else 
                        {
                            Console.WriteLine("Inaccessible operation: You cannot divide by zero.");
                            break;
                        }
                        
                }
                Console.WriteLine("Continue (y/n): ");
                while (true)
                {
                    string ContinueOrNot = Console.ReadLine();
                    if (ContinueOrNot == "y")
                    {
                        break;
                    }
                    else if (ContinueOrNot == "n")
                    {
                        work = false;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Choose y (Yes) or n (Not)");
                    }
                }

            }
        }
    }
}


public enum MathematicalOperations
{
    Add = 1,
    Subtract = 2,
    Multiply = 3,
    Divide = 4,

} 