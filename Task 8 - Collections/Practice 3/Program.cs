using System;
using System.Security.Cryptography;

namespace Practice_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List <string> Dictionary = new List <string> () { "milk", "cheese", "tea", "apple" };
            string userInput;
            string exitMessage = "want to exit";
            bool alreadyInList = false;
            while (true)
            {
                alreadyInList = false;
                
                Console.WriteLine("================================================");
                foreach (string word in Dictionary)
                {
                    Console.WriteLine(word);
                }
                Console.WriteLine("================================================");
                
                Console.Write("Input word: ");
                userInput = Console.ReadLine().ToLower();
                
                if (userInput == exitMessage)
                {
                    break;
                }
                foreach (string word in Dictionary)
                {
                    if (userInput == word)
                    {
                        Console.WriteLine(userInput + " is already in list. \ntry again. ");
                        alreadyInList = true;
                        continue;
                    }
                }
                Console.WriteLine();
                if (!alreadyInList)
                {
                    Dictionary.Add(userInput);
                }

            }
        }
    }
}
