using System.Reflection.Metadata.Ecma335;

namespace Practice_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> userData = new Dictionary<string, string>() {
                {"giorgi", "grg123" },
                { "davit", "qwe890" },
                { "davit0", "zxc000" },
                { "malvina", "paskey1" }
            };
            Console.Write("Input username: ");
            string userName = Console.ReadLine();
            Console.Write("Input Password: ");
            string password = Console.ReadLine();
            if (userData.ContainsKey(userName))
            {
                if (userData[userName] == password) {
                    Console.WriteLine("Hello: " + userName);
                }
                else
                {
                    Console.WriteLine("Password is incorrect. ");
                }
            }
            else
            {
                Console.WriteLine("User with this name could not be found. ");
            }
        }
    }
}
