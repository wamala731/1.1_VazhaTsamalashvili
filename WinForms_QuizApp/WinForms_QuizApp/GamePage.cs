using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Drawing;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Windows.Forms;
using WinForms_QuizApp_Application.Interfaces;
using WinForms_QuizApp_Domain.Entities;
using WinForms_QuizApp_Infrastructure.Data;
using WinForms_QuizApp_Infrastructure.Services;

namespace WinForms_QuizApp
{
    public partial class GamePage : Form
    {
        private Random rand = new Random();
        public IHelpServices _helpService;
        public IQuestionServices _questionService;
        public IPlayerServices _playerService;
        public List<int> usedQuestions = new List<int>();
        private int _currentQuestionIndex = 0;
        private int AnsweredQuestionsAmount = 0;
        public GamePage()
        {
            StartPosition = FormStartPosition.CenterScreen;
            _helpService = new HelpService();
            _playerService = new PlayerServices();
            _questionService = new QuestionServices();
            InitializeComponent();
            LoadQuestion();
        }
        public void LoadQuestion()
        {
            if (AnsweredQuestionsAmount > 4)
            {
                CashOutButton.Visible = true;
            }
            if (AnsweredQuestionsAmount == 10)
            {
                MessageBox.Show("Congratulations! You have won the game! \n Now you have 20000 laris on your Balance!");
                foreach (Player player in ApplicationStaticDataBase._players)
                {
                    if (player.Id == ApplicationStaticDataBase.currentPlayerId)
                    {
                        player.prize = Convert.ToInt32(ApplicationStaticDataBase.rewards[AnsweredQuestionsAmount - 1]);
                        player.IsWinner = true;
                    }
                    _playerService.ExportPlayersToFile("..\\..\\..\\..\\WinForms_QuizApp_Infrastructure\\data\\Players.xml");
                }
                this.Close();

            }
            Question currentQuestion = null;
            bool isUsed = true;
            List<Question> allQuestions = _questionService.GetAll();
            while (isUsed)
            {
                currentQuestion = allQuestions[rand.Next(0, allQuestions.Count)];

                isUsed = usedQuestions.Contains(currentQuestion.Id);
            }

            QuestionTextLabel.Text = currentQuestion.QuestionText;
            answerButton1.Text = currentQuestion.AnswersTexts[0];
            answerButton2.Text = currentQuestion.AnswersTexts[1];
            answerButton3.Text = currentQuestion.AnswersTexts[2];
            answerButton4.Text = currentQuestion.AnswersTexts[3];
            _currentQuestionIndex = ApplicationStaticDataBase._questions.IndexOf(currentQuestion);
            
            
            


            usedQuestions.Add(currentQuestion.Id);
        }
        public void CorrectAnswer()
        {
            showBalanceLabel.Text = $"Balance: {ApplicationStaticDataBase.rewards[AnsweredQuestionsAmount]}";
            AnsweredQuestionsAmount++;
            MessageBox.Show(ApplicationStaticDataBase.correctAnswerMessages[rand.Next(0, ApplicationStaticDataBase.correctAnswerMessages.Count)]);
            LoadQuestion();
        }
        public void WrongAnswer()
        {
            MessageBox.Show(ApplicationStaticDataBase.wrongAnswerMessages[rand.Next(0, ApplicationStaticDataBase.wrongAnswerMessages.Count)]);
            foreach (Player player in ApplicationStaticDataBase._players)
            {
                if (player.Id == ApplicationStaticDataBase.currentPlayerId)
                {
                    player.prize = 0;
                    player.IsWinner = false;
                }
                _playerService.ExportPlayersToFile("..\\..\\..\\..\\WinForms_QuizApp_Infrastructure\\data\\Players.xml");
            }
            this.Close();
        }
        private void answerButton1_Click(object sender, EventArgs e)
        {
            if (ApplicationStaticDataBase._questions[_currentQuestionIndex].CorrectAnswerIndex == 0)
            {
                CorrectAnswer();
            }
            else
            {
                WrongAnswer();
            }
        }
        private void answerButton2_Click(object sender, EventArgs e)
        {
            if (ApplicationStaticDataBase._questions[_currentQuestionIndex].CorrectAnswerIndex == 1)
            { 
                CorrectAnswer();
            }
            else
            {
                WrongAnswer();
            }
        }
        private void answerButton3_Click(object sender, EventArgs e)
        {
            if (ApplicationStaticDataBase._questions[_currentQuestionIndex].CorrectAnswerIndex == 2)
            {
                CorrectAnswer();
            }
            else
            {
                WrongAnswer();
            }
        }
        private void answerButton4_Click(object sender, EventArgs e)
        {
            if (ApplicationStaticDataBase._questions[_currentQuestionIndex].CorrectAnswerIndex == 3)
            {
                CorrectAnswer();
            }
            else
            {
                WrongAnswer();
            }
        }

        private void CashOutButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Congratulations! You have cashed out with {ApplicationStaticDataBase.rewards[AnsweredQuestionsAmount - 1]} laris!");
            foreach (Player player in ApplicationStaticDataBase._players)
            {
                if (player.Id == ApplicationStaticDataBase.currentPlayerId)
                {
                    player.prize = Convert.ToInt32(ApplicationStaticDataBase.rewards[AnsweredQuestionsAmount - 1]);
                    player.IsWinner = true;
                }
                _playerService.ExportPlayersToFile("..\\..\\..\\..\\WinForms_QuizApp_Infrastructure\\data\\Players.xml");
            }
            this.Close();

        }
    }
}