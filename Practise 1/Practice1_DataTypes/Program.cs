namespace Practice1_DataTypes
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
            bool resultIsNumEven = (int)result % 2 == 0 ? true : false;
            Console.WriteLine("Number is even: " + resultIsNumEven);
           
            

        }
    }
}
