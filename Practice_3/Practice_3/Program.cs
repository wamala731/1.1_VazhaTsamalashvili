using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Practice_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input your name: ");
            string name = Console.ReadLine()!;
            Console.WriteLine("Input your Surname: ");
            string lastName = Console.ReadLine()!;
            Console.WriteLine("Input your profession: ");
            string profession = Console.ReadLine()!;
            Console.WriteLine("Input your address: ");
            string address = Console.ReadLine()!;
            Console.WriteLine("Input your phone: ");
            string phoneNumber = Console.ReadLine()!;
            Console.WriteLine("Input your mail: ");
            string email = Console.ReadLine()!;
            Console.WriteLine("Input your github url: ");
            string githubUrl = Console.ReadLine()!;
            
            if (!Directory.Exists(@"..\..\..\MyDirInfo"))
            {
                Directory.CreateDirectory(@"..\..\..\MyDirInfo");
            }

            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"My name is {name} {lastName}");
            sb.AppendLine($"Profession:  {profession}");
            sb.AppendLine("Contact information:");
            sb.AppendLine($"\tAddress: {address}");
            sb.AppendLine($"\tPhone number: {phoneNumber}");
            sb.AppendLine($"\tMail: {email}");
            sb.AppendLine($"\tGitHub: {githubUrl}");

            string fileName = $@"{name}_{lastName}_{DateTime.Today:dd.MM.yy}.txt";
            string filePath = Path.Combine(@"..\..\..\MyDirInfo", fileName);
            File.WriteAllLines(filePath, sb.ToString().Split(Environment.NewLine));
        }
    }
}
