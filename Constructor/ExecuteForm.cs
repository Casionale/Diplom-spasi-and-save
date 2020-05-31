using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Gecko;

namespace Diplom2.Constructor
{
    public partial class ExecuteForm : Form
    {
        GeckoWebBrowser gbQueryConstructor;
        string path;
        string query;
        MySQLWorker MySQL;
        public ExecuteForm(string path, MySQLWorker MySql, string query)
        {
            InitializeComponent();
            this.path = path;
            MySQL = MySql;
            this.query = query;
            gbQueryConstructor = new GeckoWebBrowser
            {
                Dock = DockStyle.Fill
            };
            pWitchBrowser.Controls.Add(gbQueryConstructor);
            gbQueryConstructor.Navigate(path);
        }

        private void ExecuteForm_Load(object sender, EventArgs e)
        {
        }

        private void xbtnExecute_Click(object sender, EventArgs e)
        {
            FormResultQuery f = new FormResultQuery(MySQL, query);
            f.Show();
        }
    }
}
