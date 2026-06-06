using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;
using WinForms_QuizApp_Application.Interfaces;
using WinForms_QuizApp_Domain.Entities;
using WinForms_QuizApp_Infrastructure.Data;

namespace WinForms_QuizApp_Infrastructure.Services
{
    public class PlayerServices : Services<Player>, IPlayerServices
    {
        
        
        List<Player> UserList = ApplicationStaticDataBase._players;


        public void ImportPlayersFromFile(string filePath)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<Player>), new XmlRootAttribute("Players"));
            using (StreamReader reader = new StreamReader(filePath))
            {
                var players = (List<Player>)serializer.Deserialize(reader);
               
                foreach (var player in players)
                {
                    bool exists = false;
                    foreach (Player p in UserList)
                    {
                        if (p.Id == player.Id)
                        {
                            exists = true;
                            break;
                        }
                    }
                    if (!exists)
                    {
                        UserList.Add(player);
                    }
                }
            }
            ApplicationStaticDataBase._players = UserList;
        }

        public void ExportPlayersToFile(string filePath)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<Player>), new XmlRootAttribute("Players"));
            using (StreamWriter writer = new StreamWriter(filePath, false)) 
            {
                serializer.Serialize(writer, UserList);
            }
        }
    }
}
