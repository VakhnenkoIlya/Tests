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
    public class Serializer
    {
        public InteractiveTest Deserialize(string path)
        {
            string str = File.ReadAllText(path);
            var result = JsonSerializer.Deserialize<InteractiveTest>(str);
            return result;
        }

        public void Serialize(InteractiveTest Test, string path)
        {
            string str = JsonSerializer.Serialize<InteractiveTest>(Test);
            File.WriteAllText(path, str);
        }
    }
}
