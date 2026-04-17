using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Text;
using WhoWants20K_Application.IServices;
using WhoWants20K_Domain.Entities;

namespace WhoWants20K_Infrastructure.Services
{
    internal class HelpServices : IHelpServices
    {
        Random rnd = new Random();
        private static Random random = new Random();
        public Dictionary<string, bool> remainingHelps = new Dictionary<string, bool>()
        {
            {"50/50", true },
            {"phone a friend", true},
            {"ask the audience", true }
       };

        public void returnRemainingHelps()
        {

            Console.WriteLine("Remaining helps: ");
            int i = 0;
            foreach (var help in remainingHelps)
            {
                if (help.Value)
                {
                    Console.WriteLine($"{i + 1}. {help.Key}");
                    i++;
                }
            }

        }
        public Question useFiftyFiftyHelp(Question question)
        {
            byte removedAnswers = 0;
            int removingIndex = random.Next(question.Answers.Count());
            while (removedAnswers < 2)
            {

                if (question.Answers[removingIndex].isCorrect == false)
                {
                    question.Answers.RemoveAt(removingIndex);
                    removedAnswers++;

                }
                removingIndex = random.Next(question.Answers.Count());

            }
            return question;
            
        }
        public void usePhoneAFriendHelp(Question question)
        {
            int correctAnswerIndex = -1;
            int wrongAnswerIndex = random.Next(4);
            for (int i = 0; i < question.Answers.Count(); i++)
            {
                if (question.Answers[i].isCorrect)
                {
                    correctAnswerIndex = i;

                }
            }
            if (correctAnswerIndex == wrongAnswerIndex)
            {
                while (correctAnswerIndex == wrongAnswerIndex)
                {
                    wrongAnswerIndex = random.Next(4);
                }
            }
            List<string> friendSuggestions = new List<string>()
            {
                $"I think the answer is {correctAnswerIndex+1} or {wrongAnswerIndex+1}. ",
                $"I'm pretty sure it's {wrongAnswerIndex + 1} or {correctAnswerIndex + 1}. ",
                $"I have no idea, but maybe it's {wrongAnswerIndex + 1} or it can be {correctAnswerIndex + 1}. ",
                $"Maybe i am wrong, but i think correct answer is {correctAnswerIndex + 1} or {wrongAnswerIndex +1}",
                $"Definitely it's {correctAnswerIndex + 1}!, but just in case, it can be {wrongAnswerIndex + 1}."
            };
            Console.WriteLine(friendSuggestions[random.Next(friendSuggestions.Count)]);
        }
        public void useAskTheAudienceHelp(Question question)
        {
            int correctAnswerIndex = -1;
            for (int i = 0; i < question.Answers.Count(); i++)
            {
                if (question.Answers[i].isCorrect)
                {
                    correctAnswerIndex = i;
                }
            }

            int correctAnswerPercentage = random.Next(36, 46);
            int firstWrongAnswerPercentage = random.Next(30);
            int secondWrongAnswerPercentage = 30 - firstWrongAnswerPercentage;
            int thirdWrongAnswerPercentage = 100 - (correctAnswerPercentage + firstWrongAnswerPercentage + secondWrongAnswerPercentage);

            for (int i = 0; i < question.Answers.Count(); i++)
            {
                if (i == correctAnswerIndex)
                {
                    Console.WriteLine($"Answer {i + 1}: {correctAnswerPercentage}%");
                }
                else
                {
                    if (firstWrongAnswerPercentage != -1)
                    {
                        Console.WriteLine($"Answer {i + 1}: {firstWrongAnswerPercentage}%");
                        firstWrongAnswerPercentage = -1;
                    }
                    else if (secondWrongAnswerPercentage != -1)
                    {
                        Console.WriteLine($"Answer {i + 1}: {secondWrongAnswerPercentage}%");
                        secondWrongAnswerPercentage = -1;
                    }
                    else
                    {
                        Console.WriteLine($"Answer {i + 1}: {thirdWrongAnswerPercentage}%");
                    }
                }
            }
        }
        public void useHelp(Question question, out string usedHelp)
        {
            int userChoice;
            usedHelp = "";
            while (true) 
            {
                Console.Write("Which help do you want to use?: ");
                if (int.TryParse(Console.ReadLine(), out  userChoice))
                {
                    if (userChoice >= 1 && userChoice <= 3)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Please enter a valid number corresponding to the help you want to use.");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a number.");
                }
            }
            
            switch (userChoice)
            {
                case 1:
                    if (remainingHelps["50/50"])
                    {
                        Question f = useFiftyFiftyHelp(question);
                        foreach (var answer in f.Answers)
                        {
                            Console.WriteLine($"{f.Answers.IndexOf(answer) + 1}. {answer.Text}");
                        }
                       remainingHelps.Remove("50/50");
                        usedHelp = "50/50";
                    }
                    else
                    {
                        Console.WriteLine("You have already used this help.");
                    }
                    break;
                case 2:
                    if (remainingHelps["phone a friend"])
                    {
                        usePhoneAFriendHelp(question);
                        remainingHelps.Remove("phone a friend");
                        usedHelp = "phone a friend";
                    }
                    else
                    {
                        Console.WriteLine("You have already used this help.");
                    }
                    break;
                case 3:
                    if (remainingHelps["ask the audience"])
                    {
                        useAskTheAudienceHelp(question);
                        remainingHelps.Remove("ask the audience");
                        usedHelp = "ask the audience";
                    }
                    else
                    {
                        Console.WriteLine("You have already used this help.");
                    }
                    break;
                default:
                    Console.WriteLine("Invalid help type.");
                        
                    break;
            }
        }
    }
}