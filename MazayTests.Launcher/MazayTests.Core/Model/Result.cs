using MazayTests.Core.Model;

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;


namespace MazayTests.Core
{
    [Serializable]
    public class Result
    {
        private TimeSpan _time;

        public Guid Guid { get; set; }
        public string TopicTest { get; set; }
        public TimeSpan Time { get => _time = StopTime.Subtract(StartTime); }
        public DateTime StartTime { get; set; }
        public DateTime StopTime { get; set; }
        public SerializableDictionary<Question, List <string>> UserAnswers { get; set; }
        public SerializableDictionary<Question, List<string>> UserRightAnswers { get; set; }
        public SerializableDictionary<Question, List<string>> UserWrongAnswers { get; set; }
        public double Percentage { get; set; }
        public Result()
        {

        }

        public void CheckAnswers()
        {
            
            foreach (var answer in UserAnswers)
            {
              
                if (new HashSet<string>(answer.Key.RightAnswers).SetEquals(answer.Value) == true)
                {
                    UserRightAnswers.Add(answer.Key, answer.Value);
                }
                else UserWrongAnswers.Add(answer.Key, answer.Value);
            }
            Percentage = Math.Round((double)UserRightAnswers.Count / UserAnswers.Count*100);
        }
    }
}
