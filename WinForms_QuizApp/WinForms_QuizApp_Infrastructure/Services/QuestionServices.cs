using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;
using System.Xml.Serialization;
using WinForms_QuizApp_Application.Interfaces;
using WinForms_QuizApp_Domain.Entities;
using WinForms_QuizApp_Infrastructure.Data;

namespace WinForms_QuizApp_Infrastructure.Services
{
    public class QuestionServices : Services<Question>, IQuestionServices
    {
        List<Question> Questions = ApplicationStaticDataBase._questions ?? new List<Question>();
        XmlSerializer serializer = new XmlSerializer(typeof(List<Question>), new XmlRootAttribute("Questions"));
        public List<Question> GetAll()
        {
            return Questions;
        }
        public void ImportQuestions(string filePath)
        {
            using (StreamReader reader = new StreamReader(filePath))
            {
                var questions = (List<Question>)serializer.Deserialize(reader);

                foreach (Question question in questions)
                {
                    bool exists = false;
                    foreach (Question q in Questions)
                    {
                        if (q.Id == question.Id)
                        {
                            exists = true;
                            break;
                        }
                    }
                    if (!exists)
                    {
                        Questions.Add(question);
                    }
                }
            }

            
        }
        public void ExportQuestions(string filePath)
        {
            using (StreamWriter writer = new StreamWriter(filePath, false))
            {
                serializer.Serialize(writer, Questions);
            }
        }
    }
}
