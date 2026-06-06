using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using WinForms_QuizApp_Application.Interfaces;
using WinForms_QuizApp_Domain.Entities;
using WinForms_QuizApp_Infrastructure.Services;

namespace WinForms_QuizApp
{
    public partial class MainMenu : Form
    {
        public MainMenu(Player player)
        {
            StartPosition = FormStartPosition.CenterScreen;
            if (player.IsAdmin == true)
            {
                InitializeComponent();
                AdminMenuLabel.Visible = false;
                impExpPlayersLabel.Visible = false;
                impExpQuestionsLabel.Visible = false;
                ImportPlayersFiles.Visible = false;
                ExportPlayersFiles.Visible = false;
                ImportQuestionsFiles.Visible = false;
                ExportQuestionsFiles.Visible = false;
                GoBackButton.Visible = false;

            }
            else
            {
                InitializeComponent();
                AdminMenuLabel.Visible = false;
                impExpPlayersLabel.Visible = false;
                impExpQuestionsLabel.Visible = false;
                ImportPlayersFiles.Visible = false;
                ExportPlayersFiles.Visible = false;
                ImportQuestionsFiles.Visible = false;
                ExportQuestionsFiles.Visible = false;
                ShowAdminMenuButton.Visible = false;
            }
        }

        private void ImportQuestions_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "XML Files (*.xml)|*.xml|All Files (*.*)|*.*";
            ofd.Title = "Select Questions XML File";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string filePath = ofd.FileName;
                IQuestionServices questionServices = new QuestionServices();
                questionServices.ImportQuestions(filePath);
                MessageBox.Show("Questions imported successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                questionServices.ExportQuestions("..\\..\\..\\..\\WinForms_QuizApp_Infrastructure\\Data\\Questions.xml");
            }
        }

        private void ExportQuestionsFiles_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "XML Files (*.xml)|*.xml|All Files (*.*)|*.*";
            saveFileDialog.Title = "Export Questions to XML File";
            saveFileDialog.FileName = "ExportedQuestions.xml";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;
                IQuestionServices questionServices = new QuestionServices();
                questionServices.ExportQuestions(filePath);
                MessageBox.Show("Questions exported successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ImportPlayersFiles_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "XML Files (*.xml)|*.xml|All Files (*.*)|*.*";
            ofd.Title = "Select Players XML File";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string filePath = ofd.FileName;
                IPlayerServices playerServices = new PlayerServices();
                playerServices.ImportPlayersFromFile(filePath);
                MessageBox.Show("Players imported successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                playerServices.ExportPlayersToFile("..\\..\\..\\..\\WinForms_QuizApp_Infrastructure\\Data\\Players.xml");
            }
        }

        private void ExportPlayersFiles_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "XML Files (*.xml)|*.xml|All Files (*.*)|*.*";
            saveFileDialog.Title = "Export Players to XML File";
            saveFileDialog.FileName = "ExportedPlayers.xml";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;
                IPlayerServices playerServices = new PlayerServices();
                playerServices.ExportPlayersToFile(filePath);
                MessageBox.Show("Players exported successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ShowAdminMenuButton_Click(object sender, EventArgs e)
        {
            AdminMenuLabel.Visible = true;
            GoBackButton.Visible = true;
            impExpPlayersLabel.Visible = true;
            impExpQuestionsLabel.Visible = true;
            ImportPlayersFiles.Visible = true;
            ExportPlayersFiles.Visible = true;
            ImportQuestionsFiles.Visible = true;
            ExportQuestionsFiles.Visible = true;
            ShowAdminMenuButton.Visible = false;
            StartButton.Visible = false;
            
            LetsPlayLabel.Visible = false;
        }

        private void GoBackButton_Click(object sender, EventArgs e)
        {
            AdminMenuLabel.Visible = false;
            impExpPlayersLabel.Visible = false;
            impExpQuestionsLabel.Visible = false;
            ImportPlayersFiles.Visible = false;
            ExportPlayersFiles.Visible = false;
            ImportQuestionsFiles.Visible = false;
            ExportQuestionsFiles.Visible = false;
            ShowAdminMenuButton.Visible = true;
            StartButton.Visible = true;
            LetsPlayLabel.Visible = true;
            GoBackButton.Visible = false;
            
        }



        private void StartButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            GamePage gamePage = new GamePage();
            gamePage.Show();
        }

   
    }
}
