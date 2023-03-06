using System;

namespace MazayTests.Core.Model
{
    [Serializable]
    public class Answer
    {
        public string Text { get; set; }
        public bool DefaultImage { get; set; }
        public bool DefaultSound { get; set; }
    }
}
