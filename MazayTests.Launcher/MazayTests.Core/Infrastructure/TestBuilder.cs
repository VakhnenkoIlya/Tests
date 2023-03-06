using MazayTests.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MazayTests.Core
{
    public class TestBuilder
    {
        private Serializer _serializer;

        public TestBuilder()
        {
            _serializer = new Serializer();
        }

        public void SaveTest(InteractiveTest test, string path)
        {
            _serializer.Serialize(test, path);
        }

        public InteractiveTest OpenTest (string path)
        {
           return  _serializer.Deserialize(path);
        }
    }
}
