namespace Practice_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter first Number:");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("Enter second Number: ");
            int num2 = int.Parse(Console.ReadLine());
            Console.Write("Enter third Number: ");
            int num3 = int.Parse(Console.ReadLine());
            bool isNegative = false;
            if (num1 < 0)
            {
                isNegative = true;
            }
            else if (num2 < 0)
            {
                isNegative = true;
            }
            else if (num3 < 0)
            {
                isNegative = true;
            }
            int max = num1;
            if (max < num2)
            {
                max = num2;
            }
            else if (max < num3)
            {
                max = num3;
            }

            Console.WriteLine("The greatest number: " + max);
            if (isNegative) {
                Console.WriteLine("Negative number contained");
            }
        }
    }
}
