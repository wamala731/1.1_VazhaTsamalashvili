using System.ComponentModel.Design;

namespace Practice_4
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
            string errorMessage;
            bool signInComplete;
            bool signUpComplete;
            string userName;
            string password;
            byte usersChoise;
            while (true)
            {
                Console.WriteLine("===================");
                Console.WriteLine("1. Sign in");
                Console.WriteLine("2. Sign up");
                Console.WriteLine("3. Exit");
                Console.WriteLine("===================");
                Console.Write("Select option: ");
                usersChoise = byte.Parse(Console.ReadLine());
                Console.WriteLine();

                if (usersChoise == 1)
                {
                    Console.Write("Input username: ");
                    userName = Console.ReadLine();
                    Console.Write("Input password: ");
                    password = Console.ReadLine();
                    Console.WriteLine();
                    signInComplete = signInMethod(userName, password, userData, out errorMessage);
                    if (signInComplete)
                    {
                        Console.WriteLine("Hello: " + userName);
                        break;
                    }
                    else
                    {
                        Console.WriteLine(errorMessage);
                        Console.WriteLine();
                    }
                }
                else if (usersChoise == 2)
                {
                    Console.Write("Input username: ");
                    userName = Console.ReadLine();
                    Console.Write("Input password: ");
                    password = Console.ReadLine();
                    Console.WriteLine();
                    signUpComplete = signUpMethod(userName, password, userData, out errorMessage);
                    if (signUpComplete)
                    {
                        Console.WriteLine("Success.");
                        break;
                    }
                    else
                    {
                        Console.WriteLine(errorMessage);
                        Console.WriteLine();
                    }
                }
                else if (usersChoise == 3)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Choose one of the following.");
                }
            }

        }
        static public bool signInMethod(string userName, string password, Dictionary<string,string> userData, out string errorMessage)
        {
            errorMessage = "";
            if (userData.ContainsKey(userName))
            {
                if (userData[userName] == password)
                {
                    return true;
                }
                else
                {
                    errorMessage += "Password is incorrect. ";
                }
            }
            else
            {
               errorMessage += "User with this name could not be found. ";
                return false;
            }
            return false;
            
        }
        static public bool signUpMethod(string userName, string password, Dictionary<string, string> userData, out string errorMessage)
        {
            errorMessage = "";
            if (userName == null) {
                errorMessage += "Username is required.";
                return false;
            }
            if (userData.ContainsKey(userName))
            {
                errorMessage += "Username is already taken. ";
                return false;
            }
            if ( password.Length < 6)
            {
                errorMessage += "Password's minimum length should be 6 characters.";
                return false;
            }
            userData.Add(userName, password);
            
            return true;

        }
    }
}
