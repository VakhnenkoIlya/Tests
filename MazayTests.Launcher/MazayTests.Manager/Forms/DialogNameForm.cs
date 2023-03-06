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
    public partial class DialogNameForm : Form
    {
        public string newName;
        
        public DialogNameForm()
        {
            InitializeComponent();
            newName = GetName();

        }
        private void Save_Click(object sender, EventArgs e)
        {
            GetName();
           // textBox1.Clear();
            Close();
        }
        public string GetName()
        {
            return newName = textBox1.Text;
        }
        public void GetLabel(string str)
        {
            Label label = new();
            label.AutoSize = true;
            label.Anchor = System.Windows.Forms.AnchorStyles.None;
            label.Font = new System.Drawing.Font("Comfortaa Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            label.Text = str;
            if (str == "Введите название колекции в которой будут хранится тесты")
            label.Location = new System.Drawing.Point(30, 100);
            else
                label.Location = new System.Drawing.Point(250, 100);

            Controls.Add(label);
        }
    }
}
