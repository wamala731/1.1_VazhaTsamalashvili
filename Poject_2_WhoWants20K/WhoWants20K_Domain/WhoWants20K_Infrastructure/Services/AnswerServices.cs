using System;
using System.Collections.Generic;
using System.Text;
using WhoWants20K_Application.IServices;
using WhoWants20K_Domain.Entities;

namespace WhoWants20K_Infrastructure.Services
{
    internal class AnswerServices : Services<Answer>, IAnswerServices
    {
        
        public bool isAnswerCorrect()
        {
            throw new NotImplementedException();
        }
    }
}
