namespace Practice_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter lengt of array: ");
            int lengthOfArray;
            while (!int.TryParse(Console.ReadLine(), out lengthOfArray))
            {
                Console.WriteLine("Incorrect format");
                Console.Write("Enter lengt of array: ");
            }
            byte[] usersArray = new byte[lengthOfArray];
            byte max = 0;
            for (int i = 0; i < lengthOfArray; i++)
            {

                while (true)
                {
                    Console.Write($"input number {i + 1}: ");
                    if (byte.TryParse(Console.ReadLine(), out byte usersNum))
                    {

                        usersArray[i] = usersNum;
                        if (usersNum > max)
                        {
                            max = usersNum;
                        }
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Number is not byte. Try again");

                    }
                }
            }
            Console.Write("Array: ");
            foreach (byte usersBytes in usersArray)
            {
                Console.Write(usersBytes + " ");
            }
            Console.WriteLine();
            Console.WriteLine("The biggest in Array: " + max);
        }
    }
}
