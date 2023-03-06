using MazayTests.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MazayTests.Manager
{
    public interface IFSRepository
    {
        string[] GetCollections();
        IEnumerable <InteractiveTest> GetTests(string currentCollection);
        string GetNameCollection(string currentCollection);
        void DeleteColection( string currentCollection);
        bool DeleteTest(string collection, string currentTest);
        void CreateCollection(string path);
        void MoveTest(string oldColection, string curentCollection, string currentTest);
        string GetFullNameCollection(string nameCollection);
    }
}
