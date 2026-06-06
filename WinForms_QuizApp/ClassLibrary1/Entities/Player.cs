using System;
using System.Collections.Generic;
using System.Text;

namespace WinForms_QuizApp_Domain.Entities
{
    public class Player : BaseClass
    {
        public string Username { get; set; }
        public string FirstName { get; set; } 
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public bool IsAdmin { get; set; } = false;
        public int prize { get; set; } = 0;
        public bool IsWinner { get; set; } = false;
        public Player() { }

        public Player(int id,string username, string firstName, string lastName, string email, string password)
        {
            Id = id;
            Username = username;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Password = password;
        }
    }
}
