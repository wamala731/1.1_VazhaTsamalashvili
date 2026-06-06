using System;
using System.Collections.Generic;
using System.Text;
using WinForms_QuizApp_Domain.Entities;

namespace WinForms_QuizApp_Application.Interfaces   
{
    public interface IQuestionServices : IService<Question>
    {
        public void ImportQuestions(string filePath);
        public void ExportQuestions(string filePath);
    }
}
