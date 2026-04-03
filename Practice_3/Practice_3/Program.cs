using System.Security.Cryptography.X509Certificates;

namespace Practice_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if (!Directory.Exists(@"..\..\..\MyDirInfo"))
            {
                Directory.CreateDirectory(@"..\..\..\MyDirInfo");
            }
           
            string info = "Vazha Tsamalashvili \n Proffesion is Student \n Contact: \n Levan Kbilashvili Highway N16\n 557-56-48-12 \n wamala731@gmail.com \n https://github.com/wamala731/1.1_VazhaTsamalashvili.git";
            File.WriteAllText(@"..\..\..\MyDirInfo\Vazha_Tsamalashvil_04.03.2026.txt", info);

        }
    }
}
