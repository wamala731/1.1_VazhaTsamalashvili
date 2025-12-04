namespace Practice2_DataTypes
{
    internal class Program
    {
        /// <summary>
        /// Score: 10/10
        /// Well done!
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.Write("Enter First Number: ");
            int userInput1 = int.Parse(Console.ReadLine());
            Console.Write("Enter Second Number: ");
            int userInput2 = int.Parse(Console.ReadLine());
            int result = userInput1 + userInput2;
            Console.WriteLine("Result: " + result);
        }
    }
}
