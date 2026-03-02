namespace Task_5
{
    /// <summary>
    /// Score: 10/10
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            
            List<string> sia = new List<string> {"abc", "d", "efghi", "j", "klmnop", "qr", "st", "uv", "wxyz"};
            string Name = sia[7].Substring(1, 1).ToUpper() + sia[0].Substring(0,1) + sia[8].Substring(3, 1) + sia[2].Substring(3,1) + sia[0].Substring(0,1);          
            string SurName = sia[6].Substring(1,1).ToUpper() + sia[6].Substring(0,1) + sia[0].Substring(0,1) + sia[4].Substring(2,1) + sia[0].Substring(0, 1) + sia[4].Substring(1,1) 
                + sia[0].Substring(0, 1) + sia[6].Substring(0,1) + sia[2].Substring(3,1) + sia[7].Substring(1,1) + sia[2].Substring(4,1) + sia[4].Substring(1,1) + sia[2].Substring(4, 1);
            Console.WriteLine(Name.Substring(Name.Count() - 2, 2) + SurName.Substring(0,3));

            string a, b, c;
            a = "abfjb";
            Console.Write("Input something: ");
            b = Console.ReadLine();
            Console.Write("Input something: ");
            c = Console.ReadLine();

            sia.Add(a);
            sia.Add(b);
            sia.Add(c);
            foreach (var item in sia)
            {
                Console.WriteLine(item);
            }
        }
    }
}
