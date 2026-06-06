using System;
using System.Collections.Generic;
using System.Text;
using WinForms_QuizApp_Domain.Entities;

namespace WinForms_QuizApp_Application.Interfaces
{
    public interface IPlayerServices : IService<Player>
    {
        public void ImportPlayersFromFile(string filePath);
        public void ExportPlayersToFile(string filePath);
    }
}
