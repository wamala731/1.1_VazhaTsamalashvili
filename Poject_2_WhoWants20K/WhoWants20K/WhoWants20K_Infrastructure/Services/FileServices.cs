using System;
using System.Collections.Generic;
using System.Text;
using WhoWants20K_Application;
using System.IO;

namespace WhoWants20K_Infrastructure.Services
{
    internal class FileServices : IFileServices
    {
        
        public List<string> ReadFile(string filePath)
        {
            List<string> data = new List<string>();
            int i = 0;

            using (StreamReader sr = new StreamReader(filePath))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    data.Add(line);
                    i++;
                }
            }
            return data;
        }
        public void SaveToFile(string filePath, string data)
        {
            using (StreamWriter sw = new StreamWriter(filePath))
            {
                sw.Write(data);
            }
           
        }
        
    }
}
