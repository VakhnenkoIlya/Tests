using MazayTests.Core;
using MazayTests.Core.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MazayTests.Manager
{
    public partial class CreatorTestForm : Form
    {
        TestGenerator generator = new();
        List<string> rightAnswers;
        List<Answer> answers;
        List<Question> questions;
        readonly string newName;
        readonly string pathToTest;

        public CreatorTestForm(string name, string path)
        {
            InitializeComponent();
            rightAnswers = new List<string>();
            answers = new List<Answer>();
            questions = new List<Question>();
            newName = name;
            pathToTest = path;
        }

        public CreatorTestForm(string name, string path, List<Question> _questions)
        {
            InitializeComponent();
            rightAnswers = new List<string>();
            answers = new List<Answer>();
            questions = _questions;
            newName = name;
            pathToTest = path;
        }

        private void CreatorTestForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Hide();
        }

        private void AddRightAnswer_Click(object sender, EventArgs e)
        {
            rightAnswers.Add(rightAnswerTextBox.Text);
            rightAnswerTextBox.Clear();
        }

        private void AddAnswer_Click(object sender, EventArgs e)
        {
            Answer answer = new();
            answer.Text = answerTextBox.Text;
            answers.Add(answer);
            answerTextBox.Clear();
        }

        private void AddQuestion_Click(object sender, EventArgs e)
        {
            questions.Add(generator.GetQuestion(questionTextBox.Text, rightAnswers, answers));
            new CreatorTestForm(newName, pathToTest, questions).Show();
            Hide();
        }

        private void SaveTest_Click(object sender, EventArgs e)
        {
            var test = new TestGenerator().GetTest(newName, questions);
            new TestBuilder().SaveTest(test, pathToTest);
            Hide();
        }
    }
}
