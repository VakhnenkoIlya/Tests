using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MazayTests.Core.Model
{
    public class LaunchProperties
    {
        public TimeSpan Timer { get; set; }
        public bool withNextButton { get; set; }
        public bool withBackButton { get; set; }
        public int QuestionCount { get; set; }
        public bool QuestionRandom { get; set; }
        public bool AnswerRandom { get; set; }
        public List<Question> SelectedQuestions { get; set; }

        private CustomMode _customMode;
    }
}
