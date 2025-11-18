namespace Practice5_DataTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter double number: ");
            double user_Input1 = double.Parse(Console.ReadLine());
            int result = (int)user_Input1;
            Console.WriteLine("Result: " + result);
        }
    }
}
