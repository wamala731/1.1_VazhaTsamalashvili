using System.Transactions;

namespace Practice_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter first Number: ");
            int Num1;
            while(!int.TryParse(Console.ReadLine(), out  Num1))
            {
                Console.Write("Enter valid number: ");
            }
            Console.Write("Enter second Number: ");
            int Num2;
            while (!int.TryParse(Console.ReadLine(), out Num2))
            {
                Console.Write("Enter valid number: ");
            }
            if (Num1 <= Num2)
            {
                Console.WriteLine($"Numbers from {Num1} to {Num2}: ");
                for (int i = Num1; i <= Num2 ; i++)
                {
                    Console.Write($"{i}, ");
                }

            } else {
                Console.WriteLine("Range can not be calculated");
            }

        }
    }
}
