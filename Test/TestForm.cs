using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.Json;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Diplom2.Service;

namespace Diplom2.Test
{
    public partial class TestForm : Form
    {
        public string Title { get; set; }
        public string pathToQuestions { get; set; }
        private List<Question> _questions = new List<Question>();
        private List<List<int>> _timesQuestion = new List<List<int>>();
        private List<List<string>> answers;
        private int _question = 0;
        private int maxQuestions;
        Thread t;
        public TestForm()
        {
            InitializeComponent();
            Title = "Лёгкий тест";
        }

        public TestForm(string title, string path)
        {
            InitializeComponent();
            Title = title;
            pathToQuestions = path;
        }
        public TestForm(string title, string path, bool closing)
        {
            InitializeComponent();
            Title = title;
            pathToQuestions = path;
            if (closing)
            {
                ClosingChoose();
            }
        }

        async private void ClosingChoose() 
        {
            await Task.Run(()=> {
                Thread.Sleep(10);
                Invoke(new Action(() =>
                {
                    Program.chooseForm.Visible = false;
                }));
            });
        }

        private void TestForm_Load(object sender, EventArgs e)
        {
            //LoadingQuestions();
            Program.testForm = this;
            Text = Title;
            
            pRadio.Width = Width;
            rQestion1.Width = Width;
            rQestion2.Width = Width;
            rQestion3.Width = Width;
            rQestion4.Width = Width;
            pCheck.Width = Width;
            cbQuestion1.Width = Width;
            cbQuestion2.Width = Width;
            cbQuestion3.Width = Width;
            cbQuestion4.Width = Width;
            pTextQuestion.Width = Width;
            tbAnswerQuestion.Width = Width - 50;
            nbTest.LeftItemClick += NbTest_LeftItemClick;
            nbTest.RightItemClick += NbTest_RightItemClick;
            pCheck.Visible = false;
            pCheck.Location = pRadio.Location;
            pRadio.Visible = false;
            pTextQuestion.Visible = false;
            pTextQuestion.Location = pRadio.Location;
            LoadingQuestions();
            
            pQuestion.Width = Width;
            pResults.Width = 0;

            HelloTestForm f = new HelloTestForm(Text, maxQuestions);
            f.ShowDialog();
            t = new Thread(tick);
            LoadQuestion();
        }

        private void NbTest_RightItemClick(object sender, EventArgs e)
        {
            NextQuestion();
        }

        private void NbTest_LeftItemClick(object sender, EventArgs e)
        {
            PreviousQuestion();
        }

        private void LoadingQuestions()
        {
            StreamReader sr = new StreamReader(File.OpenRead(pathToQuestions));
            _questions.Clear();
            _questions = JsonSerializer.Deserialize<List<Question>>(sr.ReadToEnd());
            sr.Close();
            maxQuestions = _questions.Count;
            List<int> randomBuf = new List<int>();
            List<Question> buf = new List<Question>();
            Random ran = new Random();
            while(buf.Count < Settings.countQuestions)
            {
                int index = ran.Next(0, _questions.Count);
                if (!randomBuf.Contains(index))
                {
                    buf.Add(_questions[index]);
                    randomBuf.Add(index);
                }
                else
                {
                    continue;
                }
                
            }
            _questions = buf;

            answers = new List<List<string>>();
            foreach (Question q in _questions)
            {
                if (q.Type == "text")
                    _timesQuestion.Add(new List<int>() { 0, Settings.textQuestion });
                if (q.Type == "radio")
                    _timesQuestion.Add(new List<int>() { 0, Settings.radioQuestion });
                if (q.Type == "check")
                    _timesQuestion.Add(new List<int>() { 0, Settings.checkQuestion });
                answers.Add(new List<string>(4));
            }
        }

        private void NextQuestion()
        {
            if (_question < _questions.Count - 1)
            {
                SaveProgressInQuestion();
                _question++;
                LoadQuestion();
                if (_question == _questions.Count - 1)
                    nbTest.RightCustomText = "Завершить тест";

            }
            else
            {
                pQuestion.Width = 0;
                pResults.Width = Width;
                SaveProgressInQuestion();
                CheckingResultTesting();
            }
        }

        private void PreviousQuestion()
        {
            if (_question > 0)
            {
                SaveProgressInQuestion();
                _question--;
                LoadQuestion();
                nbTest.RightCustomText = "Следующий вопрос";
            }
        }

        private void SaveProgressInQuestion() 
        {
            if (_questions[_question].Type == "text")
                answers[_question].Add(tbAnswerQuestion.Text);
            if (_questions[_question].Type == "radio")
            {
                answers[_question].Add(rQestion1.Checked.ToString());
                answers[_question].Add(rQestion2.Checked.ToString());
                answers[_question].Add(rQestion3.Checked.ToString());
                answers[_question].Add(rQestion4.Checked.ToString());
            }
            if (_questions[_question].Type == "check")
            {
                answers[_question].Add(cbQuestion1.Checked.ToString());
                answers[_question].Add(cbQuestion2.Checked.ToString());
                answers[_question].Add(cbQuestion3.Checked.ToString());
                answers[_question].Add(cbQuestion4.Checked.ToString());
            }
        }

        private void LoadProgressInQuestion() 
        {
            if (answers[_question].Count > 0)
            {
                if (_questions[_question].Type == "text")
                    tbAnswerQuestion.Text = answers[_question][0];
                if (_questions[_question].Type == "radio")
                {
                    rQestion1.Checked = Convert.ToBoolean(answers[_question][0]);
                    rQestion2.Checked = Convert.ToBoolean(answers[_question][1]);
                    rQestion3.Checked = Convert.ToBoolean(answers[_question][2]);
                    rQestion4.Checked = Convert.ToBoolean(answers[_question][3]);
                }
                if (_questions[_question].Type == "check")
                {
                    cbQuestion1.Checked = Convert.ToBoolean(answers[_question][0]);
                    cbQuestion2.Checked = Convert.ToBoolean(answers[_question][1]);
                    cbQuestion3.Checked = Convert.ToBoolean(answers[_question][2]);
                    cbQuestion4.Checked = Convert.ToBoolean(answers[_question][3]);
                }
            }
        }

        private void LoadQuestion()
        {
            Question currentQuestion = _questions[_question];
            rtbQuestion.Text = string.Format("ВОПРОС {0} ИЗ {1}\n{2}",
                _question + 1, _questions.Count, currentQuestion.Text);
            pCheck.Visible = false;
            pTextQuestion.Visible = false;
            pRadio.Visible = false;
            if (currentQuestion.Type == "text")
            {
                tbAnswerQuestion.Text = "";
                pTextQuestion.Visible = true;
            }
            if (currentQuestion.Type == "radio")
            {
                rQestion1.Text = currentQuestion.Query[0][0];
                rQestion1.Checked = false;
                rQestion2.Text = currentQuestion.Query[1][0];
                rQestion2.Checked = false;
                rQestion3.Text = currentQuestion.Query[2][0];
                rQestion3.Checked = false;
                rQestion4.Text = currentQuestion.Query[3][0];
                rQestion4.Checked = false;
                pRadio.Visible = true;
            }
            if (currentQuestion.Type == "check")
            {
                cbQuestion1.Text = currentQuestion.Query[0][0];
                cbQuestion1.Checked = false;
                cbQuestion2.Text = currentQuestion.Query[1][0];
                cbQuestion2.Checked = false;
                cbQuestion3.Text = currentQuestion.Query[2][0];
                cbQuestion3.Checked = false;
                cbQuestion4.Text = currentQuestion.Query[3][0];
                cbQuestion4.Checked = false;
                pCheck.Visible = true;
            }
            lblTime.Text = string.Format("Для этого вопроса осталось {0} сек.",
                (_timesQuestion[_question][1] - _timesQuestion[_question][0]).ToString());
            pbQuestion.MaxValue = _timesQuestion[_question][1];
            pbQuestion.Value = _timesQuestion[_question][0];
            LoadProgressInQuestion();
            if (!t.IsAlive)
                t.Start();
        }

        private void tick()
        {
            bool isWorking = true;
            while (isWorking)
            {
                Thread.Sleep(1000);
                try
                {
                    Invoke(new Action(() =>
                    {
                        if (_timesQuestion[_question][0] < _timesQuestion[_question][1])
                            _timesQuestion[_question][0]++;
                        else
                        {
                            if (pbQuestion.Width != 0)
                                NbTest_RightItemClick(null, null);
                        }
                        lblTime.Text = string.Format("Для этого вопроса осталось {0} сек.",
                            (_timesQuestion[_question][1] - _timesQuestion[_question][0]).ToString());
                        if (pbQuestion.Value < pbQuestion.MaxValue)
                            pbQuestion.Value++;
                    }));
                }
                catch
                {
                    isWorking = false;
                }
            }
        }

        private void TestForm_Resize(object sender, EventArgs e)
        {
            if (pQuestion.Width != 0)
                pQuestion.Width = Width;
            if (pResults.Width != 0)
                pResults.Width = Width;
        }

        private void CheckingResultTesting() 
        {
            int maxScore = 0;
            int score = 0;
            for (int i = 0; i < _questions.Count; i++)
            {
                int scoreInQuestion = 0;
                int scoreInQuestionReceived = 0;
                string answer = "";
                if (_questions[i].Type == "text")
                {
                    if (_questions[i].Query[0][0].ToUpper() == answers[i][0].ToUpper())
                    {
                        scoreInQuestionReceived++;
                        score++;
                    }
                    maxScore++;
                    dgvResults.Rows.Add(i+1, _questions[i].Text, _questions[i].Query[0][0].ToUpper(),
                                        scoreInQuestionReceived, 1);
                }
                if (_questions[i].Type == "radio" || _questions[i].Type == "check")
                {
                    
                    for (int j = 0; j < _questions[i].Query.Count; j++)
                    {
                        if (_questions[i].Query[j][1] == "t" && answers[i][j] == "True")
                        {
                            scoreInQuestionReceived++;
                            score++;
                        }
                        if (_questions[i].Query[j][1] == "t")
                        {
                            scoreInQuestion++;
                            maxScore++;
                            answer += "\n " + (Settings.ShowAnswers ? _questions[i].Query[j][0] : "Скрыто");
                        }
                    }
                    dgvResults.Rows.Add(i + 1, _questions[i].Text, answer,
                                        scoreInQuestionReceived, scoreInQuestion);
                }
            }
            double precent = score > 0 ? 100 / (maxScore / (double) score) : 0;
            string ending = "";
            if (((score % 100) > 10) && ((score % 100) < 20))
                ending = "баллов";
            else if (score % 10 == 1)
                ending = "балл";
            else if ((score % 10 == 2) || (score % 10 == 3) || (score % 10 == 4))
                ending = "балла";
            lblScore.Text = string.Format("{0} {3} из {1} / {2}%", score, maxScore, precent.ToString("#.##"), ending);
            lblResultsTitle.Text = string.Format("{0} пройден", Title);
            lblScore.Left = this.Width / 2 - lblScore.Width / 2;
            lblResultsTitle.Left = this.Width / 2 - lblResultsTitle.Width / 2;
            label1.Left = this.Width / 2 - label1.Width / 2;
        }

        private void TestForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Program.chooseForm.Visible = true;
            Program.testForm = null;
        }

        private void xbtnReset_Click(object sender, EventArgs e)
        {
            TestForm t = new TestForm(Title, pathToQuestions, true);
            t.Show();
            Close();
        }

        private void TestForm_FormClosed(object sender, FormClosedEventArgs e)
        {
        }
    }
}
