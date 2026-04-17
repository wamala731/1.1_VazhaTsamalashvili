using System;
using System.Collections.Generic;
using System.Text;
using WhoWants20K_Domain.Entities;

namespace WhoWants20K_Application.IServices
{
    public interface IGameServices
    {
        public void StartGame(User user);
       
    }
}
