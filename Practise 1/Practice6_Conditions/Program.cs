namespace Practice6_Conditions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input number: ");
            if (int.TryParse(Console.ReadLine(), out int userInput))
            {
                if (userInput % 10 == 0)
                {
                    Console.WriteLine("Number is divisible by 5 and 10");
                }
                else if (userInput % 5 == 0)
                {
                    Console.WriteLine("Number id divisible by 5 only");
                }
                else
                {
                    Console.WriteLine("Number is not divisible by 5 or 10");
                }
            }else {
                Console.WriteLine("Number is not integer. ");
            }
        }
    }
}
