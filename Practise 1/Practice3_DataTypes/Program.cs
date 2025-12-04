namespace Practice3_DataTypes
{
    internal class Program
    {
        /// <summary>
        /// Score: 8/10
        /// Reason: no correct operation occured, no optimal solution for check result
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.Write("Enter first number: ");
            double user_Input1 = double.Parse(Console.ReadLine());
            Console.Write("Enter second number: ");
            double user_Input2 = double.Parse(Console.ReadLine());
            // Operation must be multiplication
            double result = user_Input1 + user_Input2;
            Console.WriteLine("Result: " + result);
            // isNumGreaterThan10 = result > 10; is enough
            bool isNumGreaterThan10 = result > 10 ? true : false;
            Console.WriteLine("Result is greater than 10: " + isNumGreaterThan10);
        }
    }
}
