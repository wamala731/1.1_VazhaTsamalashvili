using System;
using System.Collections.Generic;
using System.Text;

namespace WhoWants20K_Domain.Entities
{
    public class Answer : BaseClass
    {
        public string Text { get; set; }
        public bool IsCorrect { get; set; }
       
    }
}
