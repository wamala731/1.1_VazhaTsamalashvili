namespace Practice_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input sentence: ");
            string usersString = Console.ReadLine();
            int numOfVowels = 0;
            foreach(char letter in usersString)
            {
                if (isVowel(letter))
                {
                    numOfVowels++;
                }
            }
            Console.WriteLine("Number of vowels: " + numOfVowels);
        }
   public static bool isVowel(char letter)
        {
            if (letter == 'a' || letter == 'e' || letter == 'i' || letter == 'o' || letter == 'u' || letter == 'A' || letter == 'E' || letter == 'I' || letter == 'O' || letter == 'U') { 
                return true;            
            }
            return false;
        }
    }
}