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
            if (tbLoginWitchBD.Text != "" && tbNameDB.Text != "" && tbServerNameWitchDB.Text != "")
            {
                Information.DBName = tbNameDB.Text;
                Information.LoginDB = tbLoginWitchBD.Text;
                Information.PasswordDB = tbPasswordWitchDB.Text;
                Information.Server = tbServerNameWitchDB.Text;
                Close();
            }
        }
    }
}
