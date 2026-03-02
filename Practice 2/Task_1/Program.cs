namespace Task_1
{
    /// <summary>
    /// Score: 8/10 
    /// ნაწილობრივ შესრულებულია ინდექსით წაშლა აკლია, ასევე while ციკლი შეიძლება გაუმჯობესდეს, რომ არ იკითხოს ზედმეტად და არ იწეროს ზედმეტად კონსოლში.
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {

            List<string> animals = new List<string>();
            string input;
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Input any animal: ");
                input = Console.ReadLine();
                animals.Add(input);
            }
            while (true) // while (animals.Count > 0) will be better or while input != "exit"
            {
                Console.Write("Here is the list of animals: ");
                foreach (string animal in animals)
                {
                    Console.Write(animal + " ");
                }
                Console.WriteLine();
                Console.WriteLine("Type in (exit) if you want to stop removing enimals."); // while input != "exit" will be better
                Console.WriteLine("Which animal do you want to remove? ");

                string toRemove = Console.ReadLine();
                if (toRemove.ToLower() == "exit")
                {
                    break;
                }
                while (true)
                {
                    if (animals.Contains(toRemove))
                    {
                        Console.WriteLine($"{toRemove} has been removed.");
                        animals.Remove(toRemove);
                        break;
                    }
                    else
                    {
                        Console.WriteLine($"{toRemove} not found in the list.");
                        Console.WriteLine("Try again.");
                        break;
                    }
                }
            }
        }
    }
}