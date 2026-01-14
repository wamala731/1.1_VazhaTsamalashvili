namespace Practice_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Triangle usersTriangle = new Triangle();
            double sideA, sideB, sideC;
            Console.Write("Input Side A: ");
            while (true)
            {
                if (!double.TryParse(Console.ReadLine(), out sideA ) && sideA > 0)
                {
                    Console.WriteLine("Incorrect format. Try Again: ");
                    continue;
                }
                usersTriangle.FirstSide = sideA;
                break;
            }
            Console.Write("Input Side B: ");
            while (true)
            {
                if (!double.TryParse(Console.ReadLine(), out sideB) && sideB > 0)
                {
                    Console.WriteLine("Incorrect format. Try Again: ");
                    continue;
                }
                usersTriangle.SecondSide = sideB;
                break;
            }
            Console.Write("Input Side C: ");    
            while (true)
            {
                if (!double.TryParse(Console.ReadLine(), out sideC) && sideC > 0)
                {
                    Console.WriteLine("Incorrect format. Try Again: ");
                    continue;
                }
                usersTriangle.ThirdSide = sideC;
                break;
            }
            Console.WriteLine($"Perimeter: {usersTriangle.perimeter}");
            Console.WriteLine($"Isosceles: {usersTriangle.IsIsosceles}");


        }
    }
}
