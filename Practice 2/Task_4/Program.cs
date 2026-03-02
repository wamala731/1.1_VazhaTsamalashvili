namespace Task_4
{
    /// <summary>
    /// Score: 25/60
    /// ყველას 3 ცდა არ აქვს, Random რიცხვს ყოველ მცდელობაზე თავიდან აგენერირებ. რიცხვი უნდა გენერირდეს ერთხელ, სირთულის არჩევის შემდეგ
    /// მოთხოვნა პრაქტიკულად დარღვეულია (random იცვლება, შანსები არასწორია) — ეს დავალება ფაქტობრივად უნდა ჩავთვალო შეუსრულებლად.
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to GuessRandom game!");
            Console.WriteLine("Choose Hardness.");
            Console.WriteLine("1. Easy");
            Console.WriteLine("2. Medium");
            Console.WriteLine("3. Hard");
            Console.WriteLine("Input choise: ");
            int hardness;
            while (!int.TryParse(Console.ReadLine(), out hardness) || hardness < 1 || hardness > 3)
            {
                Console.WriteLine("Invalid input. Please enter 1, 2, or 3 to choose hardness.");
            }
            Random random = new Random();
            int randomNumber = 0;
            int attempts = 0;
            int guesdNumber;
            while (true)
            {
                attempts++;
                if (hardness == 1)
                {
                    randomNumber = random.Next(1, 11);
                    Console.WriteLine("Enter number 1-10:");
                    while (!int.TryParse(Console.ReadLine(), out guesdNumber) || guesdNumber < 1 || guesdNumber > 10)
                    {
                        Console.WriteLine("Invalid input. Please enter a number between 1 and 10:");
                    }
                    if (attempts == 3)
                    {
                        Console.WriteLine($"You lost. The number was {randomNumber}");
                        return;
                    }
                    if (guesdNumber == randomNumber)
                    {
                        Console.WriteLine("You win!");
                        break;
                    }else if (randomNumber - guesdNumber > -3 && randomNumber - guesdNumber < 3)
                    {
                        Console.WriteLine("You are close! Try again: ");
                    }
                    else
                    {
                        Console.WriteLine("Try again.");
                    }

                }
                else if (hardness == 2)
                {
                    randomNumber = random.Next(-10, 11);
                    Console.WriteLine("Enter number -10 to 10:");
                    while (!int.TryParse(Console.ReadLine(), out guesdNumber) || guesdNumber < -10 || guesdNumber > 10)
                    {
                        Console.WriteLine("Invalid input. Please enter a number between -10 and 10:");
                    }
                    if (attempts == 3)
                    {
                        Console.WriteLine($"You lost. The number was {randomNumber}");
                        return;
                    }
                    if (guesdNumber == randomNumber)
                    {
                        Console.WriteLine("You win!");
                        break;
                    }else if (randomNumber - guesdNumber > -3 && randomNumber - guesdNumber < 3)
                    {
                        Console.WriteLine("You are close! Try again: ");
                    }
                    else
                    {
                        Console.WriteLine("Try again.");
                    }
                }
                else if (hardness == 3)
                {
                    randomNumber = random.Next(-20, 21);
                    Console.WriteLine("Enter number -20 to 20:");
                    while (!int.TryParse(Console.ReadLine(), out guesdNumber) || guesdNumber < -20 || guesdNumber > 20)
                    {
                        Console.WriteLine("Invalid input. Please enter a number between -20 and 20:");
                    }
                    if (attempts == 3)
                    {
                        Console.WriteLine($"You lost. The number was {randomNumber}");
                        return;
                    }
                    if (guesdNumber == randomNumber)
                    {
                        Console.WriteLine("You win!");
                        break;
                    }else if (randomNumber - guesdNumber > -3 && randomNumber - guesdNumber < 3)
                    {
                        Console.WriteLine("You are close! Try again: ");
                    }
                    else
                    {
                        Console.WriteLine("Try again.");
                    }
                }
               
            }
        }
    }
}