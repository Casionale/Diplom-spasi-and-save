using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diplom2.Test
{
    public partial class HelloTestForm : Form
    {
        public HelloTestForm(string title, int maxQuestions)
        {
            Program.chooseForm.Visible = false;
            InitializeComponent();
            Text = title;
            label4.Text = title;
            string ending = "";
            if (((maxQuestions % 100) > 10) && ((maxQuestions % 100) < 20))
                ending = "записей";
            else if (maxQuestions % 10 == 1)
                ending = "запись";
            else if((maxQuestions % 10 == 2) || (maxQuestions % 10 == 3) || (maxQuestions % 10 == 4))
                ending = "записи";
            label3.Text = string.Format("В пуле вопросов {0} {1} из которых будут отобраны 10",maxQuestions, ending);
        }

        private void HelloTestForm_Load(object sender, EventArgs e)
        {
            cbShowAnswers.Checked = Settings.ShowAnswers;
        }

        private void xbtnGo_Click(object sender, EventArgs e)
        {
            Settings.ShowAnswers = cbShowAnswers.Checked;
            Close();
        }
    }
}
