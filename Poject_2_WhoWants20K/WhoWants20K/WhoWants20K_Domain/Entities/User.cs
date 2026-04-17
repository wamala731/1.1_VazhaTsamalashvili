using System;
using System.Collections.Generic;
using System.Text;

namespace WhoWants20K_Domain.Entities
{
    public class User : BaseClass
    {
        public string Name { get; set; } = string.Empty;
        public string NickName { get; set; } =  string.Empty;
        public int Balance { get; set; }
        public List<Question> AnsweredQuestions { get; set; }
        public List<Answer> ChoosenAnswers { get; set; }
        public string[,] usedHelps { get; set; } 
    }
}
