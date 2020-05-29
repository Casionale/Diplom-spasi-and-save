using Awesomium.Core;
using Diplom2.Test;
using Diplom2.Theory;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Diplom2.Constructor;
using Diplom2.Service;

namespace Diplom2.Choose
{
    public partial class ChooseForm : Form
    {
        bool isWorking = true;
        Thread t;
        public ChooseForm()
        {
            InitializeComponent();
            SettingsForm.LoadSettings();
            if (Settings.ShowMenuStrip)
                msMain.Visible = true;
            else
                msMain.Visible = false;
            Program.chooseForm = this;
            wcChoose.WebSession = WebCore.CreateWebSession("c:\\temp", WebPreferences.Default);
            t = new Thread(dCookie);
            HelpButtonClicked += ChooseForm_HelpButtonClicked;
            KeyPreview = true;
            tsmiMenu.Click += TsmiMenu_Click;
            msMain.VisibleChanged += MsMain_VisibleChanged;
        }

        private void MsMain_VisibleChanged(object sender, EventArgs e)
        {
            if (msMain.Visible)
                Height += msMain.Height;
            else
                Height -= msMain.Height;
        }

        private void ChooseForm_HelpButtonClicked(object sender, CancelEventArgs e)
        {
            msMain.Visible = true;
        }

        private void TsmiMenu_Click(object sender, EventArgs e)
        {
            msMain.Visible = true;
        }

        private void ChooseForm_Load(object sender, EventArgs e)
        {
            wcChoose.DocumentReady += WcChoose_DocumentReady;
            string curDir = Directory.GetCurrentDirectory();
            wcChoose.Source = new Uri(String.Format(@"file:\{0}\Titles\system\ChooseForm.html", curDir));
        }

        private void WcChoose_DocumentReady(object sender, Awesomium.Core.DocumentReadyEventArgs e)
        {

        }

        private void dCookie()
        {
            try
            {
                while (isWorking)
                {
                    Thread.Sleep(500);
                    Invoke(new Action(() =>
                    {
                        try
                        {
                            string cookie = wcChoose.Source.AbsoluteUri.Substring(
                                wcChoose.Source.AbsoluteUri.IndexOf("?q=" +
                                ""));
                            if (cookie != "")
                            {
                                string curDir = Directory.GetCurrentDirectory();
                                if (cookie == "?q=1")
                                {
                                    TheoryForm f = new TheoryForm();
                                    f.Show();
                                    Visible = false;
                                }
                                if (cookie == "?q=2")
                                {
                                    string path = String.Format(@"{0}\Tests\Лёгкий тест.json", curDir);
                                    TestForm f = new TestForm("Лёгкий тест", path);
                                    f.Show();
                                    Visible = false;
                                }
                                if (cookie == "?q=3")
                                {
                                    string path = String.Format(@"{0}\Tests\Сложный тест.json", curDir);
                                    TestForm f = new TestForm("Сложный тест", path);
                                    f.Show();
                                    Visible = false;
                                }
                                if (cookie == "?q=4")
                                {
                                    string path = String.Format(@"{0}\Tests\Технический тест.json", curDir);
                                    TestForm f = new TestForm("Технический тест", path);
                                    f.Show();
                                    Visible = false;
                                }
                                if (cookie == "?q=5")
                                {
                                    FormDiagram f = new FormDiagram();
                                    f.Show();
                                    Visible = false;
                                }
                                isWorking = false;
                            }
                        }
                        catch { }
                    }));
                }
            }
            catch
            {}

        }

        private void ChooseForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            isWorking = false;
        }

        private void ChooseForm_VisibleChanged(object sender, EventArgs e)
        {
            if (Visible)
            {
                string curDir = Directory.GetCurrentDirectory();
                wcChoose.Source = new Uri(String.Format(@"file:\{0}\Titles\system\ChooseForm.html", curDir));
                if (!t.IsAlive)
                {
                    t = new Thread(dCookie);
                    t.Start();
                }
                isWorking = true;
            }
            else
            {
                isWorking = false;
            }
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void настройкиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SettingsForm f = new SettingsForm();
            f.ShowDialog();
        }

        private void показатьМенюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            msMain.Visible = true;
        }

        private void скрытьМенюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            msMain.Visible = false;
        }

        private void ChooseForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.M && e.Alt && e.Shift)
            {
                msMain.Visible = true;
            }
            if (e.KeyCode == Keys.M && e.Alt)
            {
                msMain.Visible = false;
            }
            if (e.KeyCode == Keys.X && e.Alt && e.Shift)
            {
                Application.Exit();
            }
            if (e.KeyCode == Keys.S && e.Alt && e.Shift)
            {
                настройкиToolStripMenuItem_Click(null, null);
            }
        }

        private void Awesomium_Windows_Forms_WebControl_KeyDown(object sender, KeyEventArgs e)
        {
            ChooseForm_KeyDown(sender, e);
        }

        private void показатьМенюToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            msMain.Visible = true;
        }
    }
}