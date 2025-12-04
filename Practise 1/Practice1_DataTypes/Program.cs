namespace Practice1_DataTypes
{
    internal class Program
    {
        /// <summary>
        /// Score: 10/10*
        /// GREAT WORK
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.Write("Enter first number: ");
            double user_Input1 = double.Parse(Console.ReadLine());
            Console.Write("Enter second number: ");
            double user_Input2 = double.Parse(Console.ReadLine());
            double result = user_Input1 + user_Input2;
            Console.WriteLine("Result: " + result);
            bool resultIsNumEven = (int)result % 2 == 0 ? true : false;
            Console.WriteLine("Number is even: " + resultIsNumEven);

        }
    }
}
