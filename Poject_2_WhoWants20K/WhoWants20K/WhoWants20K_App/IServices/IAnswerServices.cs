using WhoWants20K_Domain.Entities;

namespace WhoWants20K_Application.IServices
{
    public interface IAnswerServices : IServices<Answer>
    {
        public bool checkAnswer(Answer answer);
      
    }
}
