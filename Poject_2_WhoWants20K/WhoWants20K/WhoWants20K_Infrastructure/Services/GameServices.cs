using System;
using System.Collections.Generic;
using System.Text;
using WhoWants20K_Application.IServices;
using WhoWants20K_Domain.Entities;
using WhoWants20K_Infrastructure.AppData;

namespace WhoWants20K_Infrastructure.Services
{
    public class GameServices : IGameServices
    {
        public List<string> rewards = new List<string>
         {
            "50 lari",
            "100 lari",
            "250 lari",
            "500 lari",
            "1000 lari",
            "2500 lari",
            "5000 lari",
            "10000 lari",
            "15000 lari",
            "20000 lari"
        };
        public void StartGame(User user)
        {
            Random rnd = new Random();
            QuestionServices questionService = new QuestionServices();
            AnswerServices answerService = new AnswerServices();
            UserServices userService = new UserServices();
            FeedbackServices feedbackService = new FeedbackServices();
            ApplicationStaticDataBase dataBase = new ApplicationStaticDataBase();
            HelpServices helpService = new HelpServices();
            List<Question> questions = dataBase.GetData("../../../../WhoWants20K_Data/QuestionsAndAnswers.txt");
            feedbackService.printIntrodactionMessage();
            for (int i = 0; i < 10; i++)
            {
                int current = rnd.Next(questions.Count);
                feedbackService.printQuestionIntroMessage(i);
                questionService.printQuestion(questions[current]);
                string userInputStr = Console.ReadLine();
                int userAnswer;
                int userInputAfterHelp = 0;
                if (userInputStr.ToLower() == "help")
                {
                    helpService.returnRemainingHelps();
                    helpService.useHelp(questions[current], out string usedHelp);
                    userService.userUsedHelp(user, usedHelp, i);
                    while (int.TryParse(Console.ReadLine(), out userAnswer) == false || userAnswer < 1 || userAnswer > 4)
                    {
                        Console.Write("Please enter a valid answer (1-4): ");
                      
                    }
                }
                if ((int.TryParse(userInputStr, out userAnswer) && userAnswer >= 1 && userAnswer <= 4) || (userAnswer != 0))
                     
                    if (questionService.answerQuestion(questions[current], userAnswer) == true)
                    {
                        userService.userAnsweredQuestion(user, questions[current], questions[current].Answers[userAnswer - 1], int.Parse(rewards[i].Split(' ')[0]));
                        feedbackService.printCorrectAnswerMessage(i);
                        questions.RemoveAt(current);
                        if (i == 9)
                        {
                            feedbackService.printCongratulationsMessage();
                        }

                    }
                    else
                    {
                        userService.userAnsweredQuestion(user, questions[current], questions[current].Answers[userAnswer - 1], 0);
                        feedbackService.printGameOverMessage();
                        break;
                    }
                {

                }
            }
        }
    }
}
