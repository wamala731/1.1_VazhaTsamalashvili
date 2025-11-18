namespace Practice2_DataTypes
{
    internal class Program
    {
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
