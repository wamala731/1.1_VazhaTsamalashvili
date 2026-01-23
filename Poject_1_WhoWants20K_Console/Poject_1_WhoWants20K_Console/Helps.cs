using System;
using System.Collections.Generic;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Poject_1_WhoWants20K_Console
{
    internal class Helps
    {
        private static Random random = new Random();
        public Dictionary<string, bool> remainingHelps = new Dictionary<string, bool>()
        {
            {"50/50", true },
            {"phone a friend", true},
            {"ask the audience", true }
       };

        public void returnRemainingHelps()
        {
            int number = 1;
            Console.WriteLine("Remaining helps: ");
            foreach (var help in remainingHelps)
            {
                Console.WriteLine($"{number}. {help.Key}");
                number++;

            }

        }
        public void useFiftyFiftyHelp(Question question)
        {
            byte removedAnswers = 0;
            int removingIndex = random.Next(question.answers.Count());
            while (removedAnswers < 2)
            {

                if (question.answers[removingIndex].isCorrect == false)
                {
                    question.answers.RemoveAt(removingIndex);
                    removedAnswers++;
                    
                }
                removingIndex = random.Next(question.answers.Count());

            }
            remainingHelps["50/50"] = false;
        }
        public void usePhoneAFriendHelp(Question question)
        {
            int correctAnswerIndex = -1;
            int wrongAnswerIndex = random.Next(4);
            for (int i = 0; i < question.answers.Count(); i++)
            {
                if (question.answers[i].isCorrect)
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
            for (int i = 0; i < question.answers.Count(); i++)
            {
                if (question.answers[i].isCorrect)
                {
                    correctAnswerIndex = i;
                }
            }

            int correctAnswerPercentage = random.Next(36, 46);
            int firstWrongAnswerPercentage = random.Next(30);
            int secondWrongAnswerPercentage = 30- firstWrongAnswerPercentage;
            int thirdWrongAnswerPercentage = 100 - (correctAnswerPercentage + firstWrongAnswerPercentage + secondWrongAnswerPercentage);

            for (int i = 0; i < question.answers.Count(); i++)
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
    }
}
