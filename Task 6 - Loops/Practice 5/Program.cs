namespace Practice_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (j != i )
                    {
                        Console.Write("0 ");
                    }
                    else
                    {
                        Console.Write("1 ");
                    }

                }
                Console.WriteLine();
            }
        }
    }
}
