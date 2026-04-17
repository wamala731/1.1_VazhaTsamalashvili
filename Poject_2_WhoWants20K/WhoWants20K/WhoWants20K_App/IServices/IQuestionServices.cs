using WhoWants20K_Domain.Entities;

namespace WhoWants20K_Application.IServices
{
    public interface IQuestionServices : IServices<Question>
    {
        public void printQuestion(Question question);
        public bool answerQuestion(Question question, int userInput);
    }
}
