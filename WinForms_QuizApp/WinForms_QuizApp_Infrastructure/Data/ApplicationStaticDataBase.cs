using System;
using System.Collections.Generic;
using System.Text;
using WinForms_QuizApp_Domain.Entities;

namespace WinForms_QuizApp_Infrastructure.Data
{
    public static class ApplicationStaticDataBase
    {
        public static List<Question> _questions = new List<Question>() 
        {
            new(20,"What is the capital of France?", ["Paris", "London", "Berlin", "Madrid"], 0),
            new(21,"What is the largest planet in our solar system?", ["Earth", "Mars", "Jupiter", "Saturn"], 2),
            new(22,"What is the chemical symbol for water?", ["H2O", "CO2", "O2", "NaCl"], 0),
            new(23,"Who is the author of the Harry Potter series?", ["J.K. Rowling", "Stephen King", "George R.R. Martin", "Agatha Christie"], 0),
        };
        public static List<Player> _players = new List<Player>()
        {
            new (1,"john_doe42","John", "Doe", "john.doe@example.com", "john123"),
            new (2,"jane_smith41", "Jane", "Smith", "jane.smith@example.com", "jane123"),
            new (3,"alice_johnson35", "Alice", "Johnson", "alice.johnson@example.com", "alice123")
        };
        public static int currentPlayerId = 0;

        public static List<string> correctAnswerMessages = new List<string>
        {
            "Good job!",
            "Great work!",
            "Well done!",
            "Nice answer!",
            "Excellent!",
            "That's correct!",
            "Keep it up!",
            "You're doing great!",
            "Fantastic!",
            "Awesome work!",
            "Let's move on to the next question.",
            "Ready for the next question?",
            "Let's continue!",
            "On to the next one!",
            "Keep the momentum going!",
            "Great progress, next question!",
            "Let's see the next challenge.",
            "You're doing well, let's continue.",
            "Next question coming up!",
            "Let's keep going!"
        };
        public static List<string> wrongAnswerMessages = new List<string>
        {
            "Wrong answer! Game over.",
            "Incorrect! The game has ended.",
            "That's not correct. Game over.",
            "Oops, wrong answer. Better luck next time!",
            "Unfortunately, that's incorrect. Game over.",
            "Nice try, but that's the wrong answer. Game over.",
            "The answer is incorrect. Your run ends here.",
            "Game over! That wasn't the right answer.",
            "Incorrect answer. Thanks for playing!",
            "You missed this one. Game over.",
            "That's not the answer we were looking for. Game over.",
            "Wrong answer! Your streak has ended.",
            "Close, but not correct. Game over.",
            "The game ends with that answer.",
            "Incorrect. Better luck in the next game!"
        };
        public static List<string> rewards = new List<string>
        {
            "100",
            "200",
            "300",
            "500",
            "1000",
            "2000",
            "5000",
            "10000",
            "15000",
            "20000"
        };
    }
}
