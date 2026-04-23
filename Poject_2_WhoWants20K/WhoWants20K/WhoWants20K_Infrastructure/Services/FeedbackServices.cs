using System;
using System.Collections.Generic;
using System.Text;
using WhoWants20K_Application.IServices;

namespace WhoWants20K_Infrastructure.Services
{
    public class FeedbackServices : IFeedbackServices
    {
        public List<string> rewards = new List<string>
         {
            "50 ₾",
            "100 ₾",
            "250 ₾",
            "500 ₾",
            "1,000 ₾",
            "2,500 ₾",
            "5,000 ₾",
            "10,000 ₾",
            "15,000 ₾",
            "20,000 ₾"
        };
        Random rnd = new Random();
        public void printGameOverMessage()
        {
            List<string> gameOverMessages = new List<string>{
    "Wrong answer. Game over.",
    "That's incorrect. You've lost the game.",
    "Nope. Game over.",
    "Incorrect answer. Better luck next time.",
    "That's not right. Your run ends here.",
    "Wrong choice. Game over.",
    "You answered incorrectly. Game over.",
    "That's incorrect. The game is over.",
    "Oops, wrong answer. You lose.",
    "Not correct. Game over."
};
            Console.WriteLine(gameOverMessages[rnd.Next(gameOverMessages.Count)]);
        }
        public void printCongratulationsMessage()
        {
            List<string> congratulationsMessages = new List<string>
{
    "Congratulations! You won 20000!",
    "Well done! You got it right and won 20000!",
    "Correct! You beat the game and won 20000!",
    "Excellent! Victory is yours — 20000 is yours!",
    "That's right! You win 20000!",
    "Perfect answer! You completed the quiz and won 20000!",
    "Brilliant! You nailed it and earned 20000!",
    "You're a winner! 20000 is yours!",
    "Victory! You conquered the quiz and won 20000!",
    "Flawless! You made no mistakes and won 20000!",
    "Champion! You completed the challenge and earned 20000!",
    "Legendary! You got every answer right and won 20000!",
    "Impressive! You beat the game and took 20000!",
    "Nice! You crushed it and won 20000!",
    "You're on fire! 20000 won!",
    "That was smooth. You win 20000!",
    "You smashed that quiz and earned 20000!",
    "Quiz master! You just won 20000!",
    "You did it! 20000 is yours!",
    "Outstanding performance! You won 20000!"
};
            Console.WriteLine(congratulationsMessages[rnd.Next(congratulationsMessages.Count)]);
        }
        public void printIntrodactionMessage()
        {
            Console.WriteLine("=============================================================");
            Console.WriteLine();
            Console.WriteLine("                  Welcome to WHO WANTS 20K:                 ");
            Console.WriteLine();
            Console.WriteLine("=============================================================");
            Console.WriteLine();
            Console.WriteLine("You will have to answer 10 questions if you want to get 20 k.");
            for (int i = 0; i < rewards.Count; i++)
            {
                Console.WriteLine($"Question {i + 1}: {rewards[i]}");
            }
            Console.WriteLine("You can stop playing at any moment. ");
            Console.WriteLine();
            Console.WriteLine("============================================================");
            Console.WriteLine();
            Console.WriteLine("There are 3 different helps you can use during game.");
            Console.WriteLine("1. 50/50 - removes two wrong answers.");
            Console.WriteLine("2. Phone a Friend - you can ask your friend for help.");
            Console.WriteLine("3. Ask the Audience - audience will vote for the answer they think is correct.");
            Console.WriteLine("You can use theese helps by typing in (Help)");
            Console.WriteLine();
            Console.WriteLine("============================================================");
            Console.WriteLine();
            Console.WriteLine("Let's start!");
        }
        public void printQuestionIntroMessage(int currentQuestionIndex)
        {
            List<string> questionIntroMessages = new List<string>
{
    $"Question {currentQuestionIndex + 1} coming up!",
    $"Here is Question {currentQuestionIndex + 1}!",
    $"Get ready for Question {currentQuestionIndex + 1}!",
    $"Next up: Question {currentQuestionIndex + 1}!",
    $"This is Question {currentQuestionIndex + 1}!",
    $"Brace yourself for Question {currentQuestionIndex + 1}!",
    $"Let's go! Question {currentQuestionIndex + 1}!",
    $"Time for Question {currentQuestionIndex + 1}!",
    $"Up next is Question {currentQuestionIndex + 1}!",
    $"Pay attention! Question {currentQuestionIndex + 1}!"
};
            Console.WriteLine(questionIntroMessages[rnd.Next(questionIntroMessages.Count)]);
        }
        public void printCorrectAnswerMessage(int currentQuestionIndex)
        {
            List<string> correctAnswerMessages = new List<string>
{
    $"Correct! You've won {rewards[currentQuestionIndex]}!",
    $"Nice! That's right! You're at {rewards[currentQuestionIndex]}!",
    $"Good job! Keep going! Current prize: {rewards[currentQuestionIndex]}!",
    $"Well done! You've reached {rewards[currentQuestionIndex]}!",
    $"That's correct! {rewards[currentQuestionIndex]} in the bank!",
    $"You're doing great! {rewards[currentQuestionIndex]} so far!",
    $"Right answer! You've got {rewards[currentQuestionIndex]}!",
    $"Keep it up! Current winnings: {rewards[currentQuestionIndex]}!",
    $"Great work! You're now at {rewards[currentQuestionIndex]}!",
    $"Exactly right! {rewards[currentQuestionIndex]} is yours!",
    $"You're on track! {rewards[currentQuestionIndex]} so far!",
    $"Solid answer! You've earned {rewards[currentQuestionIndex]}!",
    $"That's it! {rewards[currentQuestionIndex]} in your pocket!",
    $"Correct, next question! You're at {rewards[currentQuestionIndex]}!",
    $"Good one! {rewards[currentQuestionIndex]} won so far!"
};
            Console.WriteLine(correctAnswerMessages[rnd.Next(correctAnswerMessages.Count)]);
        }

    }
}

