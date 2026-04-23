using System;
using System.Collections.Generic;
using System.Text;
using WhoWants20K_Application.IServices;
using WhoWants20K_Domain.Entities;

namespace WhoWants20K_Infrastructure.Services
{
    public class AnswerServices : Services<Answer>, IAnswerServices
    {
        public Answer create(int id, string text, bool isCorrect)
        {
            Answer answer = new Answer
            {
                Id = id,
                Text = text,
                IsCorrect = isCorrect
            };
            return answer;
        }
        public bool checkAnswer(Answer answer)
        {
            return answer.IsCorrect;
        }
       
        
    }
}
