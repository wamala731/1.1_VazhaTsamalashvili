namespace Practice3_DataTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter first number: ");
            double user_Input1 = double.Parse(Console.ReadLine());
            Console.Write("Enter second number: ");
            double user_Input2 = double.Parse(Console.ReadLine());
            double result = user_Input1 + user_Input2;
            Console.WriteLine("Result: " + result);
            bool isNumGreaterThan10 = result > 10 ? true : false;
            Console.WriteLine("Result is greater than 10: " + isNumGreaterThan10);
        }
    }
}
