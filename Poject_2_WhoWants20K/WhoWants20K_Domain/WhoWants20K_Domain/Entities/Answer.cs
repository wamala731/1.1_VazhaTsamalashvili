using System;
using System.Collections.Generic;
using System.Text;

namespace WhoWants20K_Domain.Entities
{
    public class Answer : BaseClass
    {
        public string text { get; set; }
        public bool isCorrect { get; set; }
        
        public Answer(string text, bool isCorrect)
        {
            this.text = text;
            this.isCorrect = isCorrect;
        }
    }
}
