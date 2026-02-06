namespace Task_1
{
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
            while (true)
            {
                Console.Write("Here is the list of animals: ");
                foreach (string animal in animals)
                {
                    Console.Write(animal + " ");
                }
                Console.WriteLine();
                Console.WriteLine("Type in (exit) if you want to stop removing enimals.");
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