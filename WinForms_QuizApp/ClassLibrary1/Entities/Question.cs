using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using System.Xml.Serialization;

namespace WinForms_QuizApp_Domain.Entities
{
    public class Question : BaseClass
    {
        public string QuestionText { get; set; }
        [XmlArray("AnswersTexts")]
        [XmlArrayItem("Answer")]
        public List<string>   AnswersTexts { get; set; }
        public int CorrectAnswerIndex { get; set; }

        public Question() { }
        public Question(int id, string questionText, List<string> answersTexts, int correctAnswerIndex)
        {
            Id = id;
            QuestionText = questionText;
            AnswersTexts = answersTexts;
            CorrectAnswerIndex = correctAnswerIndex;
        }

    }
}
