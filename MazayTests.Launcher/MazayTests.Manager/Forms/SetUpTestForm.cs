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
    public partial class SetUpTestForm : Form
    {
        IFSRepository filerepo = new FSRepository();
        //InteractiveTest test
        public SetUpTestForm()
        {
            InitializeComponent();
        }

        private void SetUpTestForm_Load(object sender, EventArgs e)
        {

        }
        private void SetUpTestForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            new ManagerTestsForm(filerepo).Show();
            Hide();
        }
    }
}
