using System.IO;
using System.Xml.Serialization;

namespace MazayTests.Core
{
    public class SerilizerResult
    {
        XmlSerializer xmlSerializer = new(typeof(Result));
        public void SaveResult(Result result)
        {
            XmlSerializer xmlSerializer = new(typeof(Result));
            using (FileStream fs = new($"Results\\{result.TopicTest}.xml", FileMode.OpenOrCreate))
            {
                xmlSerializer.Serialize(fs, result);
            }
        }
        public Result OpenResult(string name)
        {
            using (FileStream fs = new FileStream(name, FileMode.OpenOrCreate))
            {
                Result result = new();
                return result = xmlSerializer.Deserialize(fs) as Result;
            }
        }
    }
}
