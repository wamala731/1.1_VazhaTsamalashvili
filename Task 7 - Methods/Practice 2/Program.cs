using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace Practice_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input a password: ");
            string usersPassword = Console.ReadLine();
            bool isValid = IsPasswordValid(usersPassword, out string error);
            if (isValid)
            {
                Console.WriteLine("Password is valid: True");
            }
            else {
                Console.WriteLine(error);
            }
        }
        
        public static bool IsPasswordValid(string password, out string errorMessage)
        {
            errorMessage = "";
            const byte minLengthOfPassword = 8;
            const byte minNumOfDigits = 2;
            bool isLengthValid = true;
            bool onlyDigitsAndLetters = true;
            if (password.Length < minLengthOfPassword)
            {
                isLengthValid = false; 
            }
            int digitsInPassword = 0;
            for (int i = 0; i < password.Length; i++) {
                if (password[i] > 47 && password[i] < 58)
                {
                    digitsInPassword++;
                }
 
                if ((password[i]<48 || password[i] > 57) && (password[i] < 65 || password[i] > 90) && (password[i] < 97 || password[i] > 122))
                {
                    onlyDigitsAndLetters = false;
                }
            }
            if (!isLengthValid)
            {
                errorMessage += "A password must have at least 8 digits \n";
            }
            else if (!onlyDigitsAndLetters)
            {
                errorMessage += "A password must consist of only letters and digits \n";
            }
            else if (digitsInPassword < minNumOfDigits) {
                errorMessage += "A password must consist of at least 2 digits";
            } else
            {
                return true;
            }
            return false;

        }
    }
}
