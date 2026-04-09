using System;
using System.Collections.Generic;
using System.Text;

namespace WhoWants20K_Application
{
    public interface IFileServices
    {
        public string[] ReadFile(string filePath);
        public void SaveToFile(string filePath, string Content);
    }
}
