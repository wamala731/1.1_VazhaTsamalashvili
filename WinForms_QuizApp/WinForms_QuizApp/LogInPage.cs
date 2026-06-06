using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WinForms_QuizApp_Domain.Entities;
using WinForms_QuizApp_Infrastructure.Data;

namespace WinForms_QuizApp
{
    public partial class LogInPage : Form
    {
        public LogInPage()
        {
            StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
        }

        private void goBackButton_Click(object sender, EventArgs e)
        {
            WelcomePage welcomePage = new WelcomePage();
            welcomePage.Show();
            this.Close();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LogInButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(usernameTextBox.Text) || string.IsNullOrEmpty(passwordTextBox.Text))
            {
                MessageBox.Show("Please fill in all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            bool userFound = false;
            foreach (Player player in ApplicationStaticDataBase._players)
            {
                if (player.Username == usernameTextBox.Text && player.Password == passwordTextBox.Text)
                {
                    userFound = true;
                    MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ApplicationStaticDataBase.currentPlayerId = player.Id;
                    MainMenu mainMenu = new MainMenu(player);
                    mainMenu.Show();
                    this.Close();
                    return;
                }
            }
            if (!userFound)
            {
                MessageBox.Show("Invalid username or password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

     
    }
}
