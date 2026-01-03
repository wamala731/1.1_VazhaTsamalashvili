using System.ComponentModel.Design;

namespace Practice_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input your name: ");
            string usersName = Console.ReadLine();
            Console.Write("input your weight in kilograms: ");
            double usersWeigth;
            while (!double.TryParse(Console.ReadLine(), out usersWeigth)) 
            {
                Console.Write("Wrong input try again: ");
            }
            Console.Write("input yout height in meters: ");
            double usersHeight;
            while (!double.TryParse(Console.ReadLine(), out usersHeight))
            {
                Console.Write("Wrong input try again: ");
            }
            double usersBMI = BMICalculator(usersWeigth, usersHeight);
            string usersBMICategorie = BMICategorie(usersBMI);

            Console.WriteLine($"{usersName}, your BMI is: {(int)usersBMI}  \n BMI categorie: {usersBMICategorie}");

        }
        static public double BMICalculator(double weight, double height)
        {
            return weight / Math.Pow(height,2);
        }
        static public string BMICategorie(double BMI)
        {
            if (BMI < 18.5)
            {
                return "Underweight";
            }
            else if (BMI < 24.9)
            {
                return "Normal weight";
            }
            else if (BMI < 29.9)
            {
                return "Overweight";
            }
            else 
            {
                return "Obesity";
            }
        
        }
    }
}
