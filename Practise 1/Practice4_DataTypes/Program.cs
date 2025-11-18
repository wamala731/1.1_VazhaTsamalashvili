namespace Practice4_DataTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter first number: ");
            double user_Input1 = double.Parse(Console.ReadLine());
            Console.Write("Enter second number: ");
            double user_Input2 = double.Parse(Console.ReadLine());
            bool areNumbersEqual = user_Input1 == user_Input2 ? true : false;
            Console.WriteLine("Numbers are equal: " + areNumbersEqual);
        }
    }
}
