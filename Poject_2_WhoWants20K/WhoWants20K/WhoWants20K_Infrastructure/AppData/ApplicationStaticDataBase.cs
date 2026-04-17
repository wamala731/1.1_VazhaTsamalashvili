using System;
using System.Collections.Generic;
using System.Text;
using WhoWants20K_Domain.Entities;
using WhoWants20K_Infrastructure.Services;

namespace WhoWants20K_Infrastructure.AppData
{
    public class ApplicationStaticDataBase
    {
        public List<Question> GetData(string filePath)
        {
            List<string> data = new FileServices().ReadFile(filePath);
            List<Question> questionList = new List<Question>();
            foreach (string question in data)
            {
                string[] strParts = question.Split('|');

                int questionId = int.Parse(strParts[0]);
                string questionText = strParts[1];
                string[] answers = strParts[2].Split(';');
                List<Answer> answerList = new List<Answer>();
                Question q = new Question();
                int answerId = 0;
                foreach (string answer in answers)
                {
                    if (!answer.Contains('*'))
                    {
                        string answerText = answer;
                        bool isCorrect = false;
                        answerList.Add(new AnswerServices().create(answerId, answerText, isCorrect));
                    }
                    else
                    {
                        string answerText = answer.Replace("*", "");
                        bool isCorrect = true;
                        answerList.Add(new AnswerServices().create(answerId,answerText, isCorrect));
                    }
                    q = new QuestionServices().create(questionId, questionText, answerList);

                    
                }
                questionList.Add(q);
            }
            return questionList;
        }
    }
}