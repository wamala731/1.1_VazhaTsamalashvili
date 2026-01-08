namespace Practice_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
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
