using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diplom2
{
    public partial class FormResultQuery : Form
    {
        private MySQLWorker _mySQL;
        private string _mySQLCommand;

        public FormResultQuery(MySQLWorker mySQL, string mySQLCommand)
        {
            InitializeComponent();
            MySQL = mySQL;
            MySQLCommand = mySQLCommand;
            dgvConstructor.RowsAdded += DgvConstructor_RowsAdded;
            dgvConstructor.Resize += DgvConstructor_Resize;
            dgvConstructor.ColumnHeadersHeightSizeModeChanged += DgvConstructor_ColumnHeadersHeightSizeModeChanged;
        }

        private void DgvConstructor_ColumnHeadersHeightSizeModeChanged(object sender, DataGridViewAutoSizeModeEventArgs e)
        {
            ResizeDGV();
        }

        private void DgvConstructor_Resize(object sender, EventArgs e)
        {
            ResizeDGV();
        }

        public MySQLWorker MySQL { get => _mySQL; set => _mySQL = value; }
        public string MySQLCommand { get => _mySQLCommand; set => _mySQLCommand = value; }

        private void FormResultQuery_Load(object sender, EventArgs e)
        {
            dgvConstructor.DataSource = MySQL.GetResultCommand(MySQLCommand);
            if (dgvConstructor.Rows.Count == 0)
                MessageBox.Show("Запрос не вернул значений. Запрос выполнен.");
            Close();
        }

        private void DgvConstructor_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            ResizeDGV();
        }

        private void ResizeDGV()
        {
            dgvConstructor.Height = dgvConstructor.Rows.GetRowsHeight(DataGridViewElementStates.Visible) +
                                   dgvConstructor.ColumnHeadersHeight;
            dgvConstructor.Width = dgvConstructor.Columns.GetColumnsWidth(DataGridViewElementStates.Visible) +
                +dgvConstructor.RowHeadersWidth;
            Height = dgvConstructor.Height;
            Width = dgvConstructor.Width;
        }

    }
}
