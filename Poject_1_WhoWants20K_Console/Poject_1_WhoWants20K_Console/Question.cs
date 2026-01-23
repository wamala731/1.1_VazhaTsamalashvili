using System;
using System.Collections.Generic;
using System.Text;

namespace Poject_1_WhoWants20K_Console
{
    internal class Question
    {

        public string question { get; set; }
        public List<(string Text, bool isCorrect)> answers { get; set; }
        public Question() { }
        public Question(string Question, List<(string, bool)> Answers)
        {
            question = Question;
            answers = Answers;
        }

        public void DisplayQuestion()
        {
            Console.WriteLine(question);
            for (int i = 0; i < answers.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {answers[i].Text}");
            }

        }


        public bool checkAnswer(int userAnswer, out string errorMessage)
        {
            errorMessage = string.Empty;
            if(userAnswer < 1 || userAnswer > answers.Count)
            {
                errorMessage = "Invalid answer number. Please choose a valid option.";
                return false;
            }
            return answers[userAnswer - 1].isCorrect;   

        }
    }
}
