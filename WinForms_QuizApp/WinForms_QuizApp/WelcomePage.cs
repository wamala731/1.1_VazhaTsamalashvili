using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WinForms_QuizApp_Application.Interfaces;
using WinForms_QuizApp_Infrastructure.Services;

namespace WinForms_QuizApp
{
    public partial class WelcomePage : Form
    {
        public WelcomePage()
        {
            StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RegistrationPage registrationPage = new RegistrationPage();
            this.Hide();
            registrationPage.Show();

        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void goToLogInPageButton_Click(object sender, EventArgs e)
        {
            LogInPage logInPage = new LogInPage();
            this.Hide();
            logInPage.Show();
        }

        private void letsStartButton_Click(object sender, EventArgs e)
        {
            IPlayerServices playerServices = new PlayerServices();
            playerServices.ImportPlayersFromFile("..\\..\\..\\..\\WinForms_QuizApp_Infrastructure\\data\\Players.xml");
            IQuestionServices questionServices = new QuestionServices();
            questionServices.ImportQuestions("..\\..\\..\\..\\WinForms_QuizApp_Infrastructure\\data\\Questions.xml");
            goToLogInPageButton.Visible = true;
            goToRegistrationPageButton.Visible = true;
            closeButton.Visible = true;
            letsStartButton.Visible = false;
        }
    }
}
