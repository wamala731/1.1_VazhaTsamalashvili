using System;
using System.Collections.Generic;
using System.Text;

namespace WhoWants20K_Application.IServices
{
    public interface IFeedbackServices
    {
        public void printGameOverMessage();
        public void printCongratulationsMessage();
        public void printIntrodactionMessage();

        public void printCorrectAnswerMessage(int currentQuestionIndex);
        public void printQuestionIntroMessage(int currentQuestionIndex);
    }
}
