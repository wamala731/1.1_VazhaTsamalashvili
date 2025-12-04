namespace Practice5_DataTypes
{
    internal class Program
    {
        /// <summary>
        /// Score: 10/10
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.Write("Enter double number: ");
            double user_Input1 = double.Parse(Console.ReadLine());
            int result = (int)user_Input1;
            Console.WriteLine("Result: " + result);
        }
    }
}
