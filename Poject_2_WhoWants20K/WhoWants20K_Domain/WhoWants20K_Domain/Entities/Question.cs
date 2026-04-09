using System;
using System.Collections.Generic;
using System.Text;

namespace WhoWants20K_Domain.Entities
{
    public class Question : BaseClass
    {
        public string Text { get; set; }
        public List<Answer> Answer { get; set; }

        public Question(int id, string Text, List<Answer> Answer) 
        { 
            this.Id = id;
            this.Text = Text;
            this.Answer = new List<Answer>();
        }
    }
}
