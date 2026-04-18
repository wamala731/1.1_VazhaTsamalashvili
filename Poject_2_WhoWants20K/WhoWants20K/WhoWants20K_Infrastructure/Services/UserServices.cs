using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;
using WhoWants20K_Application.IServices;
using WhoWants20K_Domain.Entities;

namespace WhoWants20K_Infrastructure.Services
{
    public class UserServices : Services<User>, IUserServices
    {
        public User create()
        {
            Console.Write("What do you want to enter name or nickname?: ");

            while (true)
            {
                string input = Console.ReadLine().ToLower();
                if (input == "name")
                {
                    Console.Write("Enter your name: ");
                    string name = Console.ReadLine();
                    return new User { Name = name, Balance = 0, AnsweredQuestions = new List<Question>(), ChoosenAnswers = new List<Answer>(), usedHelps = new string[10, 2] };
                }
                else if (input == "nickname")
                {
                    Console.Write("Enter your nickname: ");
                    string nickname = Console.ReadLine();
                    return new User { NickName = nickname, Balance = 0, AnsweredQuestions = new List<Question>(), ChoosenAnswers = new List<Answer>(), usedHelps = new string[10, 2] };
                }
                else
                {
                    Console.Write("Invalid input. Please enter 'name' or 'nickname': ");
                }
            }
        }
        public void userStoppedGame(User user)
        {
            Console.WriteLine($"Congratulations! You won {user.Balance} lari!");
        }
        public void userAnsweredQuestion(User user, Question question, Answer answer, int Prize)
        {
            user.AnsweredQuestions.Add(question);
            user.ChoosenAnswers.Add(answer);
            user.Balance = Prize;
        }
        public void userAnsweredWrongAnswer(User user, Question question, Answer answer)
        {
            user.AnsweredQuestions.Add(question);
            user.ChoosenAnswers.Add(answer);
            user.Balance = 0;
        }
        public void userUsedHelp(User user, string helpType, int helpTime)
        {
            user.usedHelps[helpTime, 0] = helpType;
        }

    }
}
