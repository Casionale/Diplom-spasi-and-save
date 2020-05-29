using System;
using System.IO;
using System.Text.Json;
using System.Windows.Forms;

namespace Diplom2.Service
{
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Settings.countQuestions = Convert.ToInt32(tbMaxQuestions.Text);
            Settings.pathContent = tbPathContent.Text;
            Settings.checkQuestion = Convert.ToInt32(tbTimeCheck.Text);
            Settings.radioQuestion = Convert.ToInt32(tbTimeRadio.Text);
            Settings.textQuestion = Convert.ToInt32(tbTimeText.Text);
            Settings.ShowAnswers = cbShowAnswer.Checked;
            Settings.ShowMenuStrip = cbShowMenu.Checked;
            SaveSettings();
        }

        private static void SaveSettings()
        {
            SettingsData data = Settings.getSettings();
            string json = JsonSerializer.Serialize(data,
                new JsonSerializerOptions
                {
                    WriteIndented = true,
                    IgnoreNullValues = false
                });
            StreamWriter sr = new StreamWriter(File.Create(@"Titles\system\settings.json"));
            sr.Write(json);
            sr.Close();
        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {
            //LoadSettings();
            tbMaxQuestions.Text = Settings.countQuestions.ToString();
            tbPathContent.Text = Settings.pathContent.ToString();
            tbTimeCheck.Text = Settings.checkQuestion.ToString();
            tbTimeRadio.Text = Settings.radioQuestion.ToString();
            tbTimeText.Text = Settings.textQuestion.ToString();
            cbShowAnswer.Checked = Settings.ShowAnswers;
            cbShowMenu.Checked = Settings.ShowMenuStrip;
        }

        public static void LoadSettings()
        {
            StreamReader sr = new StreamReader(File.Open(@"Titles\system\settings.json", FileMode.Open));
            string json = sr.ReadToEnd();
            sr.Close();
            SettingsData data = JsonSerializer.Deserialize<SettingsData>(json);
            Settings.setSettings(data);
        }
    }
}
