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
            
            foreach (var help in remainingHelps)
            {
                int i = 0;
                
                Console.Write($"{i+1}) {help.Key} ");
                if(help.Value == false)
                {
                    Console.Write("(used)");
                }
                Console.WriteLine();    
                i++;
            }

        }
        public void useFiftyFiftyHelp(Question question)
        {
            byte removedAnswers = 0;
            int removingIndex = random.Next(question.Answers.Count());
            while (removedAnswers < 2)
            {

                if (question.Answers[removingIndex].IsCorrect == false)
                {
                    question.Answers.RemoveAt(removingIndex);
                    removedAnswers++;

                }
                removingIndex = random.Next(question.Answers.Count());

            }
            foreach (var answer in question.Answers)
            {
                Console.WriteLine($"{question.Answers.IndexOf(answer) + 1}. {answer.Text}");
            }

        }
        public void usePhoneAFriendHelp(Question question)
        {
            int correctAnswerIndex = -1;
            int wrongAnswerIndex = random.Next(4);
            for (int i = 0; i < question.Answers.Count(); i++)
            {
                if (question.Answers[i].IsCorrect)
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
                if (question.Answers[i].IsCorrect)
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
            if (remainingHelps["50/50"] == false && remainingHelps["phone a friend"] == false && remainingHelps["ask the audience"] == false)
            {
                Console.WriteLine("You have used all your helps.");
                return;
            }
            while (true)
            {
                
                Console.Write("Which help do you want to use?: ");

                if (!int.TryParse(Console.ReadLine(), out userChoice))
                {
                    Console.WriteLine("Invalid input. Please enter a number.");
                    continue;
                }

                if (userChoice < 1 || userChoice > 3)
                {
                    Console.WriteLine("Please enter a valid number (1-3).");
                    continue;
                }

                switch (userChoice)
                {
                    case 1:
                        if (remainingHelps.TryGetValue("50/50", out bool available) && available)
                        {
                            useFiftyFiftyHelp(question);
                            remainingHelps["50/50"] = false;
                            usedHelp = "50/50";
                            break; 
                        }
                        else
                        {
                            Console.WriteLine("You have already used this help.");
                            continue; 
                        }

                    case 2:
                        if (remainingHelps.TryGetValue("phone a friend", out bool available1) && available1)
                        {
                            usePhoneAFriendHelp(question);
                            remainingHelps["phone a friend"] = false;
                            usedHelp = "phone a friend";
                            break;
                        }
                        else
                        {
                            Console.WriteLine("You have already used this help.");
                            continue;
                        }

                    case 3:
                        if (remainingHelps.TryGetValue("ask the audience", out bool available2) && available2)
                        {
                            useAskTheAudienceHelp(question);
                            remainingHelps["ask the audience"] = false;
                            usedHelp = "ask the audience";
                            break;
                        }
                        else
                        {
                            Console.WriteLine("You have already used this help.");
                            continue;
                        }
                }

                
                break;
            }


        }
    }
}