namespace Practice4_DataTypes
{
    internal class Program
    {
        /// <summary>
        /// Score: 10/10
        /// Warning: need some optimisation for check values are equal or not
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.Write("Enter first number: ");
            double user_Input1 = double.Parse(Console.ReadLine());
            Console.Write("Enter second number: ");
            double user_Input2 = double.Parse(Console.ReadLine());
            // bool areNumbersEqual = user_Input1 == user_Input2;
            bool areNumbersEqual = user_Input1 == user_Input2 ? true : false;
            Console.WriteLine("Numbers are equal: " + areNumbersEqual);
        }
    }
}
