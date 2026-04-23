using System;
using System.Collections.Generic;
using System.Text;
using WhoWants20K_Application.IServices;
using WhoWants20K_Domain.Entities;


namespace WhoWants20K_Infrastructure.Services
{
     public class QuestionServices : Services<Question>, IQuestionServices
    {
        public Question create(int id, string text, List<Answer> answers)
        {
            Question question = new Question
            {
                Id = id,
                Text = text,
                Answers = answers
            };
            return question;
        }
        public void printQuestion(Question question)
        {
            Console.WriteLine(question.Text);
            for (int i = 0; i < question.Answers.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {question.Answers[i].Text}");
            }
        }

        public bool answerQuestion(Question question, int userInput)
        {
            if(question.Answers[userInput - 1].IsCorrect)
            {
                return true;
            }
            else
            {
                
                return false;
            }
        }
    }
}
