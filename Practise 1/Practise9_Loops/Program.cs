using System.ComponentModel;

namespace Practise9_Loops
{
    internal class Program
    {
        /// <summary>
        /// Score: 15/20
        /// Reasons: It works it is fine but history does not work
        /// here are some issues about optimisation and code contains complex logics and solutions for goal
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            bool work = true;
            while (work)
            {
                Console.Write("Enter Number X: ");

                // Logic solution here: if first number is valid then try to get second value
                // if it is not correct then break loop 


                // check region for solutions
                #region Solution to get values

                // Way N1
                string userInputstr = Console.ReadLine();
                if (!int.TryParse(userInputstr, out int X1)) // if value is not valid for that you have to use !True = False(not true)
                {
                    Console.WriteLine("Inaccessible operation: " + userInputstr + "is not a number");
                    break;
                }
                

                Console.Write("Enter Number Y: ");
                string userInputstr2 = Console.ReadLine();
                if (!int.TryParse(userInputstr2, out int Y1)) // same logic here
                {
                    Console.WriteLine("Inaccessible operation: " + userInputstr2 + " is not a number");
                    break;
                }

                // Way N2

                string userInputstr1 = Console.ReadLine();
                if (int.TryParse(userInputstr1, out int X2))
                {
                    Console.Write("Enter Number Y: ");
                    string userInputstr3 = Console.ReadLine();
                    if (!int.TryParse(userInputstr3, out int Y2))
                    {
                        // Menu for operations
                    }
                    else
                    {

                        Console.WriteLine("Inaccessible operation: " + userInputstr3 + " is not a number");
                        break;
                    }
                }
                else
                {
                    Console.WriteLine("Inaccessible operation: " + userInputstr1 + "is not a number");
                    break;
                }

                // there are different ways for solution but you have to choose optimal for that
                #endregion

                string userInput1 = Console.ReadLine();
                if (int.TryParse(userInput1, out int X))
                {
                    // what if not? you have to write code here not out of if-else
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
                    // what if not? you have to write code here not out of if-else
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
                        // აქ Option კი მაქვს უკვე მარა if გარეთ არ მიჩანს და როგორ გავაკეთო ისე რო public გახდეს?
                        // გარეთ აღწერე ინიციალიზაციის გარეშე ან ველიუ მიანიჭე 0 მას შემდეგ რაც გამოთვლი scope-შიც გექნება და გარეთაც გაგყვება ცვლადი
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
                    // declare string type history variable out of the scope
                    // and modify or save history here historyVariable += what is written in Console.WriteLine();
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