namespace Practice_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input string: ");
            string usersWord = Console.ReadLine();
            Console.WriteLine("Number of words in the string: " + CountWords(usersWord));
        }
        public static int CountWords(string word)
        {
            int numberOfWords = 1;
            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] == ' ')
                {
                    numberOfWords++;
                }
            }
            return numberOfWords;
        }
    }

}



