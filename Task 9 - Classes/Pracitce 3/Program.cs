namespace Pracitce_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Car> cars = new List<Car>()
            {
                new Car { modelNumber = 56013, brand = "Audi", year = 2019, price = 22000m },
                new Car { modelNumber = 56099, brand = "Ford", year = 2021, price = 27000m },

            };
            int modelNumber;
            string brand;
            int year;
            decimal price;
            byte option;
            while (true)
            {

                Console.WriteLine("======================");
                Console.WriteLine("1. Check all cars");
                Console.WriteLine("2. Add car");
                Console.WriteLine("3. Exit");
                Console.WriteLine("======================");
                Console.Write("Select option: ");

                while (!byte.TryParse(Console.ReadLine(), out option) || option < 1 || option > 3)
                {
                    Console.Write("Invalid input. Please select a valid option (1-3): ");
                }
                if (option == 1)
                {
                    Console.WriteLine("-----------------------------------------------------");
                    Console.WriteLine("|  Number of model  |  Brand  |  Year  |   Price   | ");
                    Console.WriteLine("-----------------------------------------------------");
                    foreach (var car in cars)
                    {
                        Console.WriteLine($"|       {car.modelNumber}       |  {car.brand}   |  {car.year}  |   {car.price}   | ");
                    }
                    Console.WriteLine("-----------------------------------------------------");
                }
                else if (option == 2)
                {
                    Console.Write("Input model number: ");
                    while (!int.TryParse(Console.ReadLine(), out modelNumber))
                    {
                        Console.Write("Invalid input. Please input a valid model number: ");
                    }
                    Console.Write("Input brand: ");
                    brand = Console.ReadLine();
                    Console.Write("Input year: ");
                    while (!int.TryParse(Console.ReadLine(), out year))
                    {
                        Console.Write("Invalid input. Please input a valid year: ");
                    }
                    Console.Write("Input price: ");
                    while (!decimal.TryParse(Console.ReadLine(), out price))
                    {
                        Console.Write("Invalid input. Please input a valid price: ");
                    }
                    cars.Add(new Car { modelNumber = modelNumber, brand = brand, year = year, price = price });
                    Console.WriteLine("Car added successfully!");
                }
                else
                {
                    break;
                }
            }



        }
    }
}
