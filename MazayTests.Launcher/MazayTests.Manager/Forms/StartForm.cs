using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using MazayTests.Core;

namespace MazayTests.Manager
{
    public partial class StartForm : Form
    {
        string pathTest;
        IFSRepository filerepo = new FSRepository();
        public StartForm()
        {
            InitializeComponent();
           
        }
        
        private void Start_Click(object sender, EventArgs e)
        {
            if (!Directory.Exists("Tests"))
            {
                Directory.CreateDirectory("Tests");
                CreateCollection();
            }
            else
            {
                CreateCollection();
            }
            //Hide();
        }
        //public void ShowCreatorTest()
        //{
        //    DialogNameForm dialogName = new();
        //    Label label1 = new();
        //    label1.Text = "Введите название теста";
        //    label1.AutoSize = true;
        //    label1.Location = new System.Drawing.Point(250, 100);
        //    label1.Anchor = System.Windows.Forms.AnchorStyles.None;
        //    label1.Font = new System.Drawing.Font("Comfortaa Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
        //    label1.ForeColor = System.Drawing.SystemColors.AppWorkspace;
        //    dialogName.Controls.Add(label1);
        //    dialogName.ShowDialog();
        //    if (!File.Exists($"{pathTest}\\{dialogName.newName}.json") && dialogName.newName != string.Empty)
        //    {
        //        new CreatorTestForm(dialogName.newName, $"{pathTest}\\{dialogName.newName}.json").Show();
               
        //    }
        //    else MessageBox.Show("Тест не будет создан! \n Возможные причины\n" +
        //        "-Нажата кнопкка отмены\n" +
        //        "-Не введен текст\n" +
        //        "-Тест с таким именем уже существует");

        //}

        private void CreateCollection()
        {
            DialogNameForm dialogName = new();
            Label label1 = new();
            label1.Location = new System.Drawing.Point(30, 100);
            label1.Text = "Введите название колекции в которой будут хранится тесты";
            label1.AutoSize = true;
            label1.Anchor =  System.Windows.Forms.AnchorStyles.None;
            label1.Font = new System.Drawing.Font("Comfortaa Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label1.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            dialogName.Controls.Add(label1);
            dialogName.ShowDialog();
            string path = $"Tests\\{dialogName.newName}";
            if (!Directory.Exists($"{path}"))
            {
                pathTest = Directory.CreateDirectory($"{path}").FullName;
                // ShowCreatorTest();
                MessageBox.Show("Коллекция созданна, наполните ее тестами");
                Hide();
                new ManagerTestsForm(filerepo).Show();
            }
            else
            {
                MessageBox.Show("Коллекция не будет создана! \n Возможные причины\n" +
                "-Нажата кнопкка отмены\n" +
                "-Не введен текст\n" +
                "-Коллекция с таким именем уже существует"); 
            }
        }
        private void StartForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
