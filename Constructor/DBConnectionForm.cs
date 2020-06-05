using Awesomium.Core.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diplom2.Constructor
{
    public partial class DBConnectionForm : Form
    {
        public DBConnectionForm()
        {
            InitializeComponent();
        }

        private void btnConnection_Click(object sender, EventArgs e)
        {
            if (tbLoginWitchBD.Text != "" && cbNames.SelectedItem.ToString() != "" && tbServerNameWitchDB.Text != "")
            {
                Information.DBName = cbNames.SelectedItem.ToString();
                Information.LoginDB = tbLoginWitchBD.Text;
                Information.PasswordDB = tbPasswordWitchDB.Text;
                Information.Server = tbServerNameWitchDB.Text;
                Close();
            }
        }

        private void tbServerNameWitchDB_TextChanged(object sender, EventArgs e)
        {
            try
            {
                MySQLWorker worker = new MySQLWorker(tbLoginWitchBD.Text, tbPasswordWitchDB.Text,
                    "", tbServerNameWitchDB.Text);
                worker.Connection();
                var dbs = worker.Execute("SHOW DATABASES");
                cbNames.Items.Clear();
                while (dbs.Read())
                {
                    string row = "";
                    for (int i = 0; i < dbs.FieldCount; i++)
                        row += dbs.GetValue(i).ToString();
                    cbNames.Items.Add(row);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
