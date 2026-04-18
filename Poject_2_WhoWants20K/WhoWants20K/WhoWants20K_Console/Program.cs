using System.Text;
using WhoWants20K_Application.IServices;
using WhoWants20K_Domain.Entities;
using WhoWants20K_Infrastructure.AppData;
using WhoWants20K_Infrastructure.Services;

namespace WhoWants20K_Console
{
    internal class Program
    {
        
        
        static void Main(string[] args)
        {

            GameHistoryDataBase gameHistoryDataBase = new GameHistoryDataBase();
            FeedbackServices feedbackService = new FeedbackServices();
            GameServices gameService = new GameServices();
            UserServices userService = new UserServices();
            feedbackService.printIntrodactionMessage();
            User user = userService.create();
            gameService.StartGame(user);
            gameHistoryDataBase.SaveGameHistory(user);


        }
    }
}
