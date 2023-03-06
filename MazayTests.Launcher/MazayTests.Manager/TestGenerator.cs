using MazayTests.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.Json;

namespace MazayTests.Manager
{
    class TestGenerator
    {
        public InteractiveTest GetTest(string name, List <Question> questions)
        {
            InteractiveTest Test = new()
            {
                Name = name
            };
            Test.Questions = questions;
            Test.Images = null;
            Test.Sounds = null;
            Test.StartProperties = new()
            {
                Timer = new(),
                withBackButton = false,
                withNextButton = false,
                QuestionCount = 0,
                AnswerRandom = true,
                QuestionRandom = true
            };
            return Test;
        }

        public Question GetQuestion( string text, List<string> rightAnswers, List<Answer> answer)
        {
            Question q = new();
            q.GuidQuestion = Guid.NewGuid(); 
            q.Text = text;
            q.RightAnswers = rightAnswers;
            q.Answers = answer;
            return q;
        }
    }
}
