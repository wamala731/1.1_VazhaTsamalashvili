namespace Practice_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Task
Write a program that:
Accepts a list of numbers from the user line by line.
Prints the list sorted in descending order.
Prints the multiplication of the smallest and biggest number.
Acceptance Criteria
Declare a List<double> and allow user input.
If the user types exit, print the sorted list and finish the program. 

             */
            List <double> numbers = new List<double>();
            Console.WriteLine("Input numbers: ");
            while (true) {
                string usersInput = Console.ReadLine();
                if (usersInput == "exit")
                {
                    break;
                }
                if (double.TryParse(usersInput, out double num))
                {
                    numbers.Add(num);
                }
            }
            numbers.Sort();
            Console.Write("Sorted Numbers: ");
            for (int i = numbers.Count - 1; i >= 0; i--) {
                Console.Write(numbers[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Multiplication of the smallest and biggest numbers: " + (numbers.First() * numbers.Last()));
        }
    }
}
