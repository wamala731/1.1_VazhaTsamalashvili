namespace Practice_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input folowing parameters:");
            Console.Write("Input side a: ");
            double sideA = double.Parse(Console.ReadLine());
            Console.Write("Input side B: ");
            double sideB = double.Parse(Console.ReadLine());
            Console.Write("Input angle between them: ");
            double angle = double.Parse(Console.ReadLine());
            double areaOfUsersTriangle = CalculateTriangleArea(sideA, sideB, angle, out string errorMessage);
            if (areaOfUsersTriangle < 1) { 
                Console.WriteLine(errorMessage);
            }
            else
            {
                Console.WriteLine("Result: " + areaOfUsersTriangle);
            }
            //Console.WriteLine($"Your triangles area: " + CalculateTriangleArea(sideA, sideB, angle, out string errorMessage));
            

        }
   
    public static double CalculateTriangleArea(double sideA, double sideB, double angle, out string errorMessage) {
            errorMessage = "";
            if (sideA < 1)
            {
                errorMessage += "Side A must be greater than 1 \n";
            }
            else if (sideB < 1)
            {
                errorMessage += "Side B must be greater than 1 \n";
            }
            else if (angle < 1 && angle > 179)
            {
                errorMessage += "Angle value must be in range of 1 and 179 \n";
            }
            else
            {
                return 0.5 * sideA * sideB * Math.Sin(angle);
            }
            return 0;

        }
    }
}
