using MazayTests.Core;
using MazayTests.Core.Model;
using System;
using System.Collections.Generic;
using System.IO;

namespace MazayTests.Manager
{
    public class FSRepository : IFSRepository
    {

        public void CreateCollection(string collectionName)
        {
            Directory.CreateDirectory(collectionName);
        }

        public void DeleteColection(string currentCollection)
        {
            Directory.Delete(currentCollection, true);
        }

        public bool DeleteTest(string collection, string testName)
        {
            if (string.IsNullOrWhiteSpace(collection))
            {
                throw new ArgumentException($"\"{nameof(collection)}\" не может быть пустым или содержать только пробел.", nameof(collection));
            }

            if (string.IsNullOrWhiteSpace(testName))
            {
                throw new ArgumentException($"\"{nameof(testName)}\" не может быть пустым или содержать только пробел.", nameof(testName));
            }

            if (File.Exists(collection + "\\" + testName + ".json"))
            {
                File.Delete(collection + "\\" + testName + ".json");
                return true;
            }
            else
                return false;
        }

        public string[] GetCollections()
        {
            return Directory.GetDirectories("Tests");
        }

        public string GetFullNameCollection(string nameCollection)
        {
            return "Tests" + "\\" + nameCollection;
        }

        public string GetNameCollection(string currentCollection)
        {
            return currentCollection.Substring(currentCollection.IndexOf('\\') + 1);
        }

        public IEnumerable<InteractiveTest> GetTests(string currentCollection)
        {
            Serializer serializer = new();
            string[] pathToTest = Directory.GetFiles(currentCollection, "*.json");
            foreach (string path in pathToTest)
            {
                yield return (serializer.Deserialize(path));
            }
        }

        public void MoveTest(string oldColection, string curentCollection, string currentTest) 
        {
            File.Move(oldColection + "\\" + currentTest + ".json", curentCollection + "\\" + currentTest + ".json");
        }
    }
}
