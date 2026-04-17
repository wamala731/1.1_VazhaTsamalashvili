using System;
using System.Collections.Generic;
using System.Text;

namespace WhoWants20K_Domain.Entities
{
    public class Question : BaseClass
    {
        public string Text { get; set; }
        public List<Answer> Answers { get; set; }

       
    }
}
