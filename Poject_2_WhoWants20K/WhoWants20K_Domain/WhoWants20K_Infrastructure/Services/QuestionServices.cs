using System;
using System.Collections.Generic;
using System.Text;
using WhoWants20K_Application.IServices;
using WhoWants20K_Domain.Entities;


namespace WhoWants20K_Infrastructure.Services
{
    internal class QuestionServices : Services<Question>, IQuestionServices
    {
        public void printQuestion(Question question)
        {
            Console.WriteLine(question.Text);
        }

        public void printQuestion()
        {
            throw new NotImplementedException();
        }
    }
}
