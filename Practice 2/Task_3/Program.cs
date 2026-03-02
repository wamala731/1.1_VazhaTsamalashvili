namespace Task_3
{
    /// <summary>
    /// Score: 10/10
    /// რაები აკეთე if-else-ში არ ვიცი მაგრამ დააკვირდი
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            string word = string.Empty;
            List<string> words = new List<string>();
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    word += (char)random.Next('a', 'z' + 1);
                }
                words.Add(word);
                word = string.Empty;
            }
            for (int i = 0; i < words.Count; i++)
            {
                Console.WriteLine(words[i]);
            }
            Console.WriteLine();
            Console.Write("Input your word: ");
            string usersWord = Console.ReadLine();
            for (int i = 0; i < words.Count; i++)
            {
                if ((i + 1) % 2 == 0) // a? just if i % 2 == 0 (კენტი რიგითი ნომერია)... else (ლუწი რიგითია)...
                {
                    string currentWord = usersWord + words[i];
                    words[i] = currentWord;
                }
                else
                {
                    string currentWord = words[i] + usersWord;
                    words[i] = currentWord;
                }
            }
            foreach (var item in words)
            {
                Console.WriteLine();
                Console.WriteLine(item);
            }
        }
    }
}
