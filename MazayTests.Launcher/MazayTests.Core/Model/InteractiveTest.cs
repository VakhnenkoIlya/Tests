using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MazayTests.Core.Model
{
    public class InteractiveTest
    {
        //public Guid
        public string Name { get; set; }
        public List<Question> Questions { get; set; }
        public LaunchProperties StartProperties { get; set; }
        public List<string> Sounds { get; set; }
        public List <string> Images { get; set; }
    }
}
