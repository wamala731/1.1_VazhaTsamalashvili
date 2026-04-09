using System;
using System.Collections.Generic;
using System.Text;
using WhoWants20K_Domain.Entities;
using WhoWants20K_Infrastructure.Services;

namespace WhoWants20K_Infrastructure.AppData
{
    public class ApplicationStaticDataBase
    {
        List<Question> ApplicationData { get; set; } 

        public void GetData(string filePath)
        {
            string[] data = new FileServices().ReadFile(filePath);
            List<Question> questionList = new List<Question>();
            //1|What is the capital city of France?|Berlin;Madrid;Paris*;Rome
            foreach (string question in data)
            {
                string[] strParts = question.Split('|');

                int id = int.Parse(strParts[0]);
                string questionText = strParts[1];
                string[] answers = strParts[2].Split(';');
                List<Answer> answerList = new List<Answer>();
                foreach (string answer in answers)
                {
                    if (!answer.Contains('*'))
                    {
                        string answerText = answer;
                        bool isCorrect = false;
                        answerList.Add(new Answer(answerText, isCorrect));
                    }
                    else
                    {
                        string answerText = answer.Replace("*", "");
                        bool isCorrect = true;
                        answerList.Add(new Answer(answerText, isCorrect));
                    }
                    Question q = new Question(id, questionText, answerList);

                    questionList.Add(q);
                }
                ApplicationData = questionList;
            }
        }
    }
}