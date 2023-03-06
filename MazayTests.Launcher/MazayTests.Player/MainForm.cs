using MazayTests.Core;
using MazayTests.Core.Model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;


namespace MazayTests.Player
{
    public partial class MainForm : Form
    {
        TestBuilder testBuilder = new();
        private TableLayoutPanel _answersPanel;
        private InteractiveTest _test;
        private List<string> answers;
        public Result _result1;
        int numberQuestion;
        string userResponses;
        string message;
        Question question;
        SerilizerResult serilizerResult;
        List<Question> randomQuestions;
        List<Question> restrictAmountQuestions;
        int h, m, s;

        public MainForm(InteractiveTest test)
        {
            InitializeComponent();
            _test = test;
            numberQuestion = 0;
            serilizerResult = new();
            _result1 = new();
            _result1.UserAnswers = new();
            _result1.UserRightAnswers = new();
            _result1.UserWrongAnswers = new();
            _result1.TopicTest = _test.Name;
            _result1.StartTime = DateTime.Now;
            answers = new();
            randomQuestions = GetRandomQuestion();
            restrictAmountQuestions = RestrictAmountQuestions(_test.StartProperties.QuestionCount);
            ShowQuestion(numberQuestion);
            NextButton(_test.StartProperties.withNextButton);
            BackButton(_test.StartProperties.withBackButton);
            _test.StartProperties.Timer = new TimeSpan(0, 0, 10);
            Time(_test.StartProperties.Timer);
        }

        private void ShowQuestion(int number)
        {
            if (_test.StartProperties.QuestionRandom == true)
                _test.Questions = randomQuestions;
            if (_test.StartProperties.QuestionCount > 0)
                _test.Questions = restrictAmountQuestions;
            MainTablePanel.Controls.Clear();
            question = _test.Questions[number];
            QuestionLabel.Text = question.Text;
            MainTablePanel.Controls.Add(QuestionLabel, 0, 0);
            ShowAnswers(question.Answers.Count, question);
            if (_result1.UserAnswers.ContainsKey(question) == true)
            {
                MainTablePanel.Enabled = false;
                QuestionLabel.Text += "\n Вы уже ответили на этот вопрос";
            }
            else MainTablePanel.Enabled = true;
        }

        private void ShowAnswers(int answCount, Question que)
        {
            _answersPanel = new TableLayoutPanel();
            _answersPanel.Update();

            var colWidth = 100F / answCount;
            _answersPanel.ColumnCount = answCount;
            if (answCount > 4)
            {
                _answersPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50));
                _answersPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50));
                _answersPanel.ColumnCount = (int)Math.Ceiling((double)answCount / 2);
            }
            _answersPanel.Dock = DockStyle.Fill;
            _answersPanel.RowCount = 1;
            _answersPanel.Padding = new Padding(50, 50, 50, 50);
            int columnBuffer = 0;
            for (int i = 0; i < que.Answers.Count; i++)
            {
                if (i < _answersPanel.ColumnCount)
                {
                    _answersPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, colWidth));
                    _answersPanel.Controls.Add(AddButton($"{que.Answers[i].Text}"));
                }
                else
                {
                    if (answCount == 5 && i == 4)
                    {
                        _answersPanel.Controls.Add(AddButton($"{que.Answers[i].Text}"), columnBuffer + 1, 1);
                        columnBuffer++;
                    }
                    else
                    {
                        _answersPanel.Controls.Add(AddButton($"{que.Answers[i].Text}"), columnBuffer, 1);
                        columnBuffer++;
                    }
                }
            }
            MainTablePanel.Controls.Add(_answersPanel, 0, 1);
        }

        private CheckBox AddButton(string text)
        {
            var button = new CheckBox()
            {
                Appearance = Appearance.Button,
                Text = text,
                TextAlign = System.Drawing.ContentAlignment.MiddleCenter,
                Dock = DockStyle.Fill,
                AutoSize = false
            };
            button.CheckedChanged += checkBox_CheckedChanged;
            return button;
        }
        private void checkBox_CheckedChanged(object sender, EventArgs e)
        {

            if (_test.StartProperties.withNextButton == false)
            {
                List<string> questionAnswered = new List<string>();
                userResponses = ((CheckBox)sender).Text;
                questionAnswered.Add(userResponses);
                _result1.UserAnswers.Add(question, questionAnswered);
                GetNextQuestion();
            }
            else
            {
                if (((CheckBox)sender).Checked == true)
                {
                    userResponses = ((CheckBox)sender).Text;
                    answers.Add(userResponses);
                }
                else answers.Remove(((CheckBox)sender).Text);
            }
        }


        private void NextButton(bool isReg)
        {
            if (isReg)
            {
                var nextButton = new Button()
                {
                    Text = "ДАЛЕЕ",
                    Width = 150,
                    Height = 80,
                    Anchor = AnchorStyles.Bottom | AnchorStyles.Right,
                    Location = new Point(this.Width - 180, this.Height - 120),
                };
                nextButton.Click += NextButton_Click;
                Controls.Add(nextButton);
                nextButton.BringToFront();
            }
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            if (answers.Count > 0)
            {
                List<string> vs = new();
                foreach (string answ in answers)
                {
                    vs.Add(answ);
                }
                _result1.UserAnswers.Add(question, vs);
                answers.Clear();

            }
            if (numberQuestion == _test.Questions.Count - 1)
            {
                if (_result1.UserAnswers.Count == _test.Questions.Count)
                {
                    FinishTest();
                }
                else
                {
                    numberQuestion = 0;
                    ShowQuestion(numberQuestion);
                }
            }
            else
            {
                GetNextQuestion();
            }
        }

        private void GetNextQuestion()
        {
            if (_result1.UserAnswers.Count == _test.Questions.Count)
            {
                FinishTest();
            }
            else
            {
                numberQuestion += 1;
                ShowQuestion(numberQuestion);
            }
        }
        private void FinishTest()
        {
            _result1.CheckAnswers();
            _result1.StopTime = DateTime.Now;
            DialogResult result = MessageBox.Show("Вы ответили на все вопросы, просмотреть результат?", "Сообщение",
                      MessageBoxButtons.YesNo,
                      MessageBoxIcon.Information,
                      MessageBoxDefaultButton.Button1,
                      MessageBoxOptions.DefaultDesktopOnly);
            if (result == DialogResult.Yes)
            {
                message = $"Вы прошли тестирование по теме {_result1.TopicTest}.\n" +
                    $"Время начала проведения теста {_result1.StartTime}.\n" +
                    $"Прохождение теста составило {_result1.Time.ToString().Substring(0, _result1.Time.ToString().LastIndexOf('.'))}.\n" +
                    $"Правильных ответов {_result1.Percentage} %";
                foreach (var response in _result1.UserRightAnswers)
                {
                    message += $"\n вопрос {response.Key.Text} ответ пользователя {response.Value[0]}";
                }
                message += $"\n Неправильные ответы:";
                foreach (var response in _result1.UserWrongAnswers)
                {
                    message += $"\n вопрос {response.Key.Text} ответ пользователя {response.Value[0]}";
                }
                MessageBox.Show(message);
            }
            serilizerResult.SaveResult(_result1);
            Close();
        }

        private void BackButton(bool IsReg)
        {
            if (IsReg)
            {
                var backButton = new Button()
                {
                    Text = "НАЗАД",
                    Width = 150,
                    Height = 80,
                    Anchor = AnchorStyles.Bottom | AnchorStyles.Right,
                    Location = new Point(this.Width - 340, this.Height - 120),
                };
                backButton.Click += BackButton_Click;
                Controls.Add(backButton);
                backButton.BringToFront();
            }
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            answers.Clear();
            if (numberQuestion == 0)
            {
                numberQuestion = _test.Questions.Count - 1;
            }
            else
            {
                numberQuestion--;
            }
            ShowQuestion(numberQuestion);
        }
        private void Time(TimeSpan time)
        {
            if (time.Hours > 0 || time.Minutes > 0 || time.Seconds > 0)
            {
                panel1.BringToFront();
                timer1.Enabled = true;
                 h = time.Hours;
                 m = time.Minutes;
                 s = time.Seconds;
                timer1.Start();
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            s = s - 1; 
            if (s == -1) 
            {
                m = m - 1;
                s = 59;
            }
            if (m == -1) 
            {
                h = h - 1;
                m = 59;
            }

            if (h == 0 && m == 0 && s == 0) 
            {
                timer1.Stop();
                MessageBox.Show("Время вышло!");
                if(_result1.UserAnswers.Count < _test.Questions.Count)
                {
                    answers.Clear();
                    answers.Add("нет ответа");
                    for (int i = _result1.UserAnswers.Count; i < _test.Questions.Count; i++)
                    {    
                        _result1.UserAnswers.Add(_test.Questions[i], answers); 
                    }
                }
                FinishTest();
            }
            label1.Text = Convert.ToString(h); 
            label3.Text = Convert.ToString(m);
            label5.Text = Convert.ToString(s);
        }
        private List<Question> GetRandomQuestion()
        {
            Random rnd = new();

            List<Question> newListQue = _test.Questions.OrderBy(x => rnd.Next()).ToList();
            return newListQue;
        }
        private List<Question> RestrictAmountQuestions(int count)
        {
            List<Question> newListQue = GetRandomQuestion().Take(count).ToList();
            return newListQue;
        }
    }
}
