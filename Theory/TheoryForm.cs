using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diplom2.Theory
{
    public partial class TheoryForm : Form
    {
        List<string> filesInRoot = new List<string>();

        public TheoryForm()
        {
            InitializeComponent();
            resizeElements();
        }

        private void TheoryForm_Load(object sender, EventArgs e)
        {
            Program.theoryForm = this;
            string curDir = Directory.GetCurrentDirectory();
            wcTheory.Source = new Uri(String.Format(@"file:\{0}\Titles\html\Базовый курс\Основная информация\1.html", curDir));
            string path = string.Format(@"{0}\Titles\html\Базовый курс", curDir);
            FilesSearch(new DirectoryInfo(path));

        }

        void FilesSearch(DirectoryInfo root)
        {
            FileInfo[] files = null;
            DirectoryInfo[] subDirs = null;
            if (root.Name != "images")
            {
                try
                {
                    files = root.GetFiles("*.*");
                }
                catch (UnauthorizedAccessException e)
                { }

                catch (System.IO.DirectoryNotFoundException e)
                { }

                if (files != null)
                {
                    tvTheory.Nodes.Add(root.FullName, root.Name);
                    foreach (System.IO.FileInfo fi in files)
                    {
                        filesInRoot.Add(fi.FullName);
                        tvTheory.Nodes[tvTheory.Nodes.Count - 1].Nodes.Add(fi.FullName, fi.Name.Replace(".html", ""));
                    }
                    subDirs = root.GetDirectories();

                    foreach (System.IO.DirectoryInfo dirInfo in subDirs)
                    {
                        FilesSearch(dirInfo);
                    }
                }
            }
        }

        private void tvTheory_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            wcTheory.Source = new Uri(String.Format(@"file:\{0}", e.Node.Name));
            for (int i = 0; i < tvTheory.Nodes.Count; i++)
            {
                tvTheory.Nodes[i].BackColor = Color.Empty;
            }
            e.Node.BackColor = Color.LightGreen;
        }

        private void resizeElements()
        {
            tvTheory.Width = 300;
            wcTheory.Width = Width - 317;
        }

        private void TheoryForm_Resize(object sender, EventArgs e)
        {
            resizeElements();
        }

        private void TheoryForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Program.chooseForm.Visible = true;
            Program.theoryForm = null;
        }
    }
}
