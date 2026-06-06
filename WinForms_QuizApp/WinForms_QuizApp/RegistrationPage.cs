using Microsoft.VisualBasic.ApplicationServices;
using WinForms_QuizApp_Application.Interfaces;
using WinForms_QuizApp_Domain.Entities;
using WinForms_QuizApp_Infrastructure.Data;
using WinForms_QuizApp_Infrastructure.Services;
namespace WinForms_QuizApp
{
    public partial class RegistrationPage : Form
    {
        public RegistrationPage()
        {
            StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(usernameTextBox.Text) || string.IsNullOrEmpty(firstNameTextBox.Text) || string.IsNullOrEmpty(surnameTextBox.Text) || string.IsNullOrEmpty(emailTextBox.Text) || string.IsNullOrEmpty(passwordTextBox.Text))
            {
                MessageBox.Show("Please fill in all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (passwordTextBox.Text.Length < 6)
            {
                MessageBox.Show("Password must be at least 6 characters long.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            IPlayerServices playerServices = new PlayerServices();
            //public Player(int id,string username, string firstName, string lastName, string email, string password)
            Player user = new Player(ApplicationStaticDataBase._players.Count + 2, usernameTextBox.Text, firstNameTextBox.Text, surnameTextBox.Text, emailTextBox.Text, passwordTextBox.Text);
            ApplicationStaticDataBase._players.Add(user);
            MessageBox.Show("Registration successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ApplicationStaticDataBase.currentPlayerId = user.Id;
            MainMenu mainMenu = new MainMenu(user);
            mainMenu.Show();
            this.Close();
        }

        private void goBackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            WelcomePage welcomePage = new WelcomePage();
            welcomePage.Show();
        }
    }
}
