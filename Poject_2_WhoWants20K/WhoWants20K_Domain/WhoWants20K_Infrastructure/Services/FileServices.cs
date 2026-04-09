using System;
using System.Collections.Generic;
using System.Text;
using WhoWants20K_Application;

namespace WhoWants20K_Infrastructure.Services
{
    internal class FileServices : IFileServices
    {
        
        public string[] ReadFile(string filePath)
        {
            string[] data = null;
            int i = 0;
            using (StreamReader sr = new StreamReader(filePath))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    data[i] += line;
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
