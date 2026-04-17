using System;
using System.Collections.Generic;
using System.Text;
using WhoWants20K_Domain.Entities;

namespace WhoWants20K_Application.IServices
{
    public interface IUserServices : IServices<User>
    {
        
        public void userAnsweredQuestion(User user, Question question, Answer answer, int Prize);
        public void userUsedHelp(User user, string helpType, int helpTime);
        
    }
}


