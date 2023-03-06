using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MazayTests.Core.Model
{
    [Serializable]
    public class Question
    {
        public Guid GuidQuestion { get; set; }
        public string Text { get; set; }
        public List<Answer> Answers { get; set; }
        public List<string> AnswerImages { get; set; }
        public List<string> AnswerSounds { get; set; }
        public List<string> RightAnswers { get; set; }
    }
}
