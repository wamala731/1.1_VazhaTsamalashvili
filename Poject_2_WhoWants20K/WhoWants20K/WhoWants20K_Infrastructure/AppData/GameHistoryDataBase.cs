using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using WhoWants20K_Domain.Entities;
using WhoWants20K_Infrastructure.Services;

namespace WhoWants20K_Infrastructure.AppData
{
    public class GameHistoryDataBase
    {
         List<string> rewards = new List<string>
         {
            "50 lari",
            "100 lari",
            "250 lari",
            "500 lari",
            "1,000 lari",
            "2,500 lari",
            "5,000 lari",
            "10,000 lari",
            "15,000 lari",
            "20,000 lari"
        };
        public void SaveGameHistory(User user)
        {
            string fileName = $"{DateTime.Now:ddMMyyyy}_GameHistory.txt";
   
            StringBuilder filePath = new StringBuilder();
            filePath.Append(@"../../../../WhoWants20K_Data/");
            filePath.Append(fileName);
            using(StreamWriter writer = new StreamWriter(filePath.ToString(), true))
            {
                writer.WriteLine("--------------------------------------------------");
                writer.WriteLine(user.CreatedAt.ToString("dd/MM/yyyy HH:mm:ss") + " - Start Game: - Player: " + (user.Name ?? user.NickName) );
                for (int i = 0; i < user.AnsweredQuestions.Count; i++) {
                    writer.WriteLine($"Question {i + 1}: {user.AnsweredQuestions[i].Text}");
                    writer.WriteLine($"Chosen Answer: {user.ChoosenAnswers[i].Text} " + user.ChoosenAnswers[i].isCorrect);
                    if(user.usedHelps[i, 0] != null)
                    {
                        writer.WriteLine($"Used Help: {user.usedHelps[i, 0]}");
                    }
                    if (user.ChoosenAnswers[i].isCorrect)
                    {
                        writer.WriteLine($"Balance: {rewards[i]}");
                    }
                    else
                    {
                        writer.WriteLine("Game Over! Balance: 0");
                        writer.WriteLine("End of Game: " + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"));
                        writer.WriteLine("--------------------------------------------------");
                        break;
                    }
                }

            }
        }
    }
}
