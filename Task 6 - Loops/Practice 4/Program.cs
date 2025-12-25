namespace Practice_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (j != 5 - (i+1))
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
