
namespace MazayTests.Manager
{
    partial class CreatorTestForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.questionTextBox = new System.Windows.Forms.RichTextBox();
            this.rightAnswerTextBox = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.answerTextBox = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.addQuestion = new System.Windows.Forms.Button();
            this.saveTest = new System.Windows.Forms.Button();
            this.addRightAnswer = new System.Windows.Forms.Button();
            this.addAnswer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // questionTextBox
            // 
            this.questionTextBox.Location = new System.Drawing.Point(12, 113);
            this.questionTextBox.Name = "questionTextBox";
            this.questionTextBox.Size = new System.Drawing.Size(776, 58);
            this.questionTextBox.TabIndex = 1;
            this.questionTextBox.Text = "";
            // 
            // rightAnswerTextBox
            // 
            this.rightAnswerTextBox.Location = new System.Drawing.Point(12, 192);
            this.rightAnswerTextBox.Name = "rightAnswerTextBox";
            this.rightAnswerTextBox.Size = new System.Drawing.Size(776, 58);
            this.rightAnswerTextBox.TabIndex = 2;
            this.rightAnswerTextBox.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Введите текст вопроса";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(194, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Введите текст правильного ответа";
            // 
            // answerTextBox
            // 
            this.answerTextBox.Location = new System.Drawing.Point(12, 287);
            this.answerTextBox.Name = "answerTextBox";
            this.answerTextBox.Size = new System.Drawing.Size(776, 59);
            this.answerTextBox.TabIndex = 5;
            this.answerTextBox.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 269);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Введите текст ответа";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 413);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 25);
            this.button1.TabIndex = 7;
            this.button1.Text = "Добавить рисунки";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(140, 413);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(119, 25);
            this.button2.TabIndex = 8;
            this.button2.Text = "Добавить звуки";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // addQuestion
            // 
            this.addQuestion.Location = new System.Drawing.Point(544, 413);
            this.addQuestion.Name = "addQuestion";
            this.addQuestion.Size = new System.Drawing.Size(119, 25);
            this.addQuestion.TabIndex = 11;
            this.addQuestion.Text = "Добавить вопрос";
            this.addQuestion.UseVisualStyleBackColor = true;
            this.addQuestion.Click += new System.EventHandler(this.AddQuestion_Click);
            // 
            // saveTest
            // 
            this.saveTest.Location = new System.Drawing.Point(669, 413);
            this.saveTest.Name = "saveTest";
            this.saveTest.Size = new System.Drawing.Size(119, 25);
            this.saveTest.TabIndex = 12;
            this.saveTest.Text = "Сохранить тест";
            this.saveTest.UseVisualStyleBackColor = true;
            this.saveTest.Click += new System.EventHandler(this.SaveTest_Click);
            // 
            // addRightAnswer
            // 
            this.addRightAnswer.Location = new System.Drawing.Point(669, 256);
            this.addRightAnswer.Name = "addRightAnswer";
            this.addRightAnswer.Size = new System.Drawing.Size(119, 25);
            this.addRightAnswer.TabIndex = 13;
            this.addRightAnswer.Text = "Добавить ответ";
            this.addRightAnswer.UseVisualStyleBackColor = true;
            this.addRightAnswer.Click += new System.EventHandler(this.AddRightAnswer_Click);
            // 
            // addAnswer
            // 
            this.addAnswer.Location = new System.Drawing.Point(669, 352);
            this.addAnswer.Name = "addAnswer";
            this.addAnswer.Size = new System.Drawing.Size(119, 25);
            this.addAnswer.TabIndex = 14;
            this.addAnswer.Text = "Добавить ответ";
            this.addAnswer.UseVisualStyleBackColor = true;
            this.addAnswer.Click += new System.EventHandler(this.AddAnswer_Click);
            // 
            // CreatorTestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.addAnswer);
            this.Controls.Add(this.addRightAnswer);
            this.Controls.Add(this.saveTest);
            this.Controls.Add(this.addQuestion);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.answerTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rightAnswerTextBox);
            this.Controls.Add(this.questionTextBox);
            this.Name = "CreatorTestForm";
            this.Text = "CreatorTestForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CreatorTestForm_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox questionTextBox;
        private System.Windows.Forms.RichTextBox rightAnswerTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox answerTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button addQuestion;
        private System.Windows.Forms.Button saveTest;
        private System.Windows.Forms.Button addRightAnswer;
        private System.Windows.Forms.Button addAnswer;
    }
}