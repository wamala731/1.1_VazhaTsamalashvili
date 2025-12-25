namespace Practice_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numCount = 0;
            while (true)
            {
                Console.Write("Input number: ");
                if (int.TryParse(Console.ReadLine(), out int userInput))
                {
                    if (userInput != 0)
                    {
                        numCount++;
                    }
                    else
                    {
                        break;
                    }

                }
                else
                {
                    Console.WriteLine("You should enter numbers");
                }
            }
            Console.WriteLine("Count of entered numbers before zero: " + numCount);
                
        }
    }
}
