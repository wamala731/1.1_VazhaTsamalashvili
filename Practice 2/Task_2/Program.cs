namespace Task_2
{
    /// <summary>
    /// Score: 10/10
    /// string[,]-ის ნაცვლად უფრო სწორი იქნება Dictionary<string,string> ან List<(country, capital)> სასურველია მაგრამ კარგია 
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            string[,] countries = { {"USA", "Washington D.C." }, { "Canada", "Ottawa" }, { "Georgia", "Tbilisi" }, { "France", "Paris" }, { "Germany", "Berlin" } };
            for(int i = 0; i < countries.GetLength(0); i++)
            {
                Console.WriteLine($"{i+1}. {countries[i,0]}");
            }
            Console.WriteLine("Select a country to get a capital (1-5):");
            int selection;
            while (true) // same 
            {
                Console.Write("");
                if (int.TryParse(Console.ReadLine(), out selection) && selection >= 1 && selection <= countries.GetLength(0))
                {
                    Console.WriteLine(countries[selection - 1, 1]);
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid input.");
                }
            }
        }
    }
}
