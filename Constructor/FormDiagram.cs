using Diplom2.Constructor;
using Gecko;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diplom2
{
    public partial class FormDiagram : Form
    {
        List<TableInDiagram> tablesInForm = new List<TableInDiagram>();
        private bool _mouseDown = false;
        private TableInDiagram selectTable;
        public MySQLWorker MySQL;
        public SelectQuery mainSelectQuery;
        public InsertQuery mainInsertQuery;
        public UpdateQuery mainUpdateQuery;
        public DeleteQuery mainDeleteQuery;
        private bool isMin;
        private bool isMax;
        private bool isOpenConstructior = false;
        private bool isOpenSelectInConstructor = false;
        private bool isOpenInsertInConstructor = false;
        private bool isOpenUpdateInConstructor = false;
        private bool isOpenDeleteInConstructor = false;
        private bool isShift = false;
        private int _clicableField;
        GeckoWebBrowser gbQueryConstructor;

        public FormDiagram()
        {
            Xpcom.Initialize("Firefox");
            InitializeComponent();
            gbQueryConstructor = new GeckoWebBrowser { Dock = DockStyle.Right, 
                Location = rtbQueryConstructor.Location,
                Width = rtbQueryConstructor.Width};
            pConstructor.Controls.Add(gbQueryConstructor);
            rtbQueryConstructor.Visible = false;
        }

        private void FormDiagram_Load(object sender, EventArgs e)
        {
            Program.formDiagram = this;
            Information.FormDiagram = this;
            Information.DiagramStatus = sLabel;
            vsbDiagram.Minimum = 0;
            vsbDiagram.Maximum = 1000;
            ResizeElements();
            pSelect.Visible = false;
        }

        private void ResizeElements()
        {
            if (!isOpenConstructior)
            {
                pbDiagram.Height = this.Height - menuStrip1.Height - ss.Height - 40;
                vsbDiagram.Height = pbDiagram.Height;
                pConstructor.Visible = false;
            }
            else
            {
                pbDiagram.Height = this.Height - menuStrip1.Height - ss.Height - 240;
                vsbDiagram.Height = pbDiagram.Height;
                pConstructor.Visible = true;
            }
            try
            {
                gbQueryConstructor.Width = pConstructor.Width * 1 / 3;
            }
            catch { }
            pSelect.Width = pConstructor.Width * 2 / 3;
            pInsert.Width = pConstructor.Width * 2 / 3;
            pUpdate.Width = pConstructor.Width * 2 / 3;
            pDelete.Width = pConstructor.Width * 2 / 3;

            dgvConditions.Width = tcSelect.Width;
            dgvAlias.Width = tcSelect.Width / 2;
            dgvJoin.Width = tcSelect.Width / 2;
            vsbDiagram.Height = pbDiagram.Height;

            dgvInsertFields.Width = pInsert.Width / 2;
            rtbInsertSelectQuery.Width = pInsert.Width / 2;

            dgvUpdateFields.Width = pUpdate.Width * 2 / 3;
            pUpdateSettings.Width = pUpdate.Width * 1 / 3;

            dgvDeleteFields.Width = pDelete.Width * 2 / 3;

            if (isOpenSelectInConstructor)
                ClosePanels(Constructors.Select);
            else if (isOpenInsertInConstructor)
                    ClosePanels(Constructors.Insert);
            else if (isOpenUpdateInConstructor)
                    ClosePanels(Constructors.Update);
            else if (isOpenDeleteInConstructor)
                ClosePanels(Constructors.Delete);
            else ClosePanels(Constructors.None);


        }

        private void ClosePanels(Constructors type)
        {
            switch (type)
            {
                case Constructors.Select:
                    pSelect.Visible = true;
                    pInsert.Visible = false;
                    pUpdate.Visible = false;
                    pDelete.Visible = false;
                    pInsert.Height = 0;
                    pUpdate.Height = 0;
                    pDelete.Height = 0;
                    break;
                case Constructors.Insert:
                    pSelect.Visible = false;
                    pInsert.Visible = true;
                    pUpdate.Visible = false;
                    pDelete.Visible = false;
                    pSelect.Height = 0;
                    pUpdate.Height = 0;
                    pDelete.Height = 0;
                    break;
                case Constructors.Update:
                    pSelect.Visible = false;
                    pInsert.Visible = false;
                    pUpdate.Visible = true;
                    pDelete.Visible = false;
                    pSelect.Height = 0;
                    pInsert.Height = 0;
                    pDelete.Height = 0;
                    break;
                case Constructors.Delete:
                    pSelect.Visible = false;
                    pInsert.Visible = false;
                    pUpdate.Visible = false;
                    pDelete.Visible = true;
                    pSelect.Height = 0;
                    pInsert.Height = 0;
                    pUpdate.Height = 0;
                    break;
                case Constructors.None:
                    pSelect.Visible = false;
                    pInsert.Visible = false;
                    pUpdate.Visible = false;
                    pDelete.Visible = false;
                    break;
            }
        }

        private void pbDiagram_Paint(object sender, PaintEventArgs e)
        {
            RelationshipsDrawer.e = e;
            if (tablesInForm.Count != 0)
            {
                e.Graphics.Clear(Color.White);
                for (int i = 0; i < tablesInForm.Count; i++)
                {
                    tablesInForm[i].DrawingTable(e);
                    if (tablesInForm[i].startPoint.Y == 0 || tablesInForm[i].startPoint.Y < 5)
                    {
                        isMax = true;
                        isMin = false;
                        tablesInForm[i].startPoint.Y = 5;
                    }
                    if (tablesInForm[i].endPoint.Y == vsbDiagram.Maximum || tablesInForm[i].endPoint.Y > vsbDiagram.Maximum - 5)
                    {
                        isMin = true;
                        isMax = false;
                        tablesInForm[i].startPoint.Y = vsbDiagram.Maximum - (tablesInForm[i].endPoint.Y - tablesInForm[i].startPoint.Y) - 5;
                    }

                }
                RelationshipsDrawer.DrawingRelationships();
            }
        }

        private void pbDiagram_MouseMove(object sender, MouseEventArgs e)
        {
            if (_mouseDown)
            {
                selectTable.startPoint = e.Location;
                pbDiagram.Invalidate();
            }
        }

        private void pbDiagram_MouseUp(object sender, MouseEventArgs e)
        {
            _mouseDown = false;
            if (selectTable != null)
            {
                int max = 0;
                foreach (TableInDiagram t in tablesInForm)
                {
                    if (t.endPoint.Y > max)
                        max = t.endPoint.Y;
                }
            }
            selectTable = null;
            pbDiagram.Invalidate();
        }

        private void pbDiagram_MouseDown(object sender, MouseEventArgs e)
        {
            foreach (TableInDiagram t in tablesInForm)
            {
                if (Rectangle.Intersect(new Rectangle(e.X, e.Y, 0, 0), t.rect) != Rectangle.Empty)
                {
                    _mouseDown = true;
                    selectTable = t;
                }
            }
        }

        private void стандартToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Information.IsUseStandartDataBase = true;
            Thread t = new Thread(downloadFromDB);
            t.Start();
        }

        private void свояToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Information.IsUseStandartDataBase = false;
            DBConnectionForm f = new DBConnectionForm();
            f.ShowDialog();
            Thread t = new Thread(downloadFromDB);
            t.Start();
        }

        private void downloadFromDB()
        {
            if (Information.IsUseStandartDataBase)
                DownloadFromDbData(new MySQLWorker());
            else
                DownloadFromDbData(new MySQLWorker(Information.LoginDB, Information.PasswordDB,
                    Information.DBName, Information.Server));
        }

        private void DownloadFromDbData(MySQLWorker MySQL)
        {
            this.MySQL = MySQL;
            tablesInForm.Clear();
            RelationshipsDrawer.relationships.Clear();
            MySQL.Connection();
            List<string> tableNames = MySQL.GetTableNames();
            int startPointMod = 0;
            List<NamesAndCoordinates> names = null; 
            if (File.Exists("Constructor/" + MySQL.Db + ".json"))
            {
                StreamReader sr = new StreamReader(File.OpenRead("Constructor/" + MySQL.Db + ".json"));
                string json = sr.ReadToEnd();
                sr.Close();
                names = JsonSerializer.Deserialize<List<NamesAndCoordinates>>(json);
            }
            foreach (string table in tableNames)
            {
                List<Field> fields = MySQL.GetFieldsInTable(table);
                Point startPoint = GetStartPoint(startPointMod, names, table);
                TableInDiagram tID = new TableInDiagram(startPoint, table, fields, new List<string>());
                tablesInForm.Add(tID);
                startPointMod++;
                this.Invoke(new Action(() =>
                {
                    sLabel.Text = "Обработка таблицы " + table + " " + startPointMod + " из " + tableNames.Count + 1;
                }));
            }
            RelationshipsDrawer.tables = tablesInForm;
            RelationshipsDrawer.relationships = MySQL.GetRelationships(tableNames);
            pbDiagram.Invalidate();
            this.Invoke(new Action(() =>
            {
                vsbDiagram.Value = 0;
                sLabel.Text = "Загрузка из БД завершена успешно";
            }));
        }

        private static Point GetStartPoint(int startPointMod, List<NamesAndCoordinates> names, string name)
        {
            if (names == null)
                return new Point(50 + (50 * startPointMod), 10);
            else
            {
                foreach (NamesAndCoordinates n in names)
                {
                    if (name == n.Name)
                    {
                        return n.Coordinate;
                    }
                }
                return new Point(50 + (50 * startPointMod), 10);
            }
        }

        private void FormDiagram_Resize(object sender, EventArgs e)
        {
            ResizeElements();
        }

        private void vsbDiagram_Scroll(object sender, ScrollEventArgs e)
        {
            if (e.NewValue < e.OldValue) //Тянуть вверх, идёт вниз
            {
                if (!isMin)
                {
                    if (vsbDiagram.Value != 0)
                    {
                        for (int i = 0; i < tablesInForm.Count; i++)
                        {
                            if (tablesInForm[i].startPoint.Y - 1 > vsbDiagram.Minimum)
                                tablesInForm[i].startPoint.Y -= (e.NewValue - e.OldValue);
                            if (tablesInForm[i].startPoint.Y < 0)
                                tablesInForm[i].startPoint.Y = 5;
                        }
                    }
                }
                else
                {
                    vsbDiagram.Value = e.OldValue;
                }
                isMax = false;
            }
            else//Тянуть внизЮ идёт вверх
            {
                if (!isMax)
                {
                    if (vsbDiagram.Value != vsbDiagram.Maximum)
                    {
                        for (int i = 0; i < tablesInForm.Count; i++)
                        {
                            if (tablesInForm[i].endPoint.Y + 1 <= vsbDiagram.Maximum)
                                tablesInForm[i].startPoint.Y += (e.OldValue - e.NewValue);
                            if (tablesInForm[i].endPoint.Y > vsbDiagram.Maximum)
                                tablesInForm[i].startPoint.Y = vsbDiagram.Maximum - tablesInForm[i].Height;
                        }
                    }
                }
                else
                {
                    vsbDiagram.Value = e.OldValue;
                }
                isMin = false;
            }
            pbDiagram.Invalidate();
        }

        private void открытьКонструкторToolStripMenuItem_Click(object sender, EventArgs e)
        {
            isOpenConstructior = true;
            ResizeElements();
            sLabel.Text = "Конструктор открыт успешно";
        }

        private void закрытьКонструкторToolStripMenuItem_Click(object sender, EventArgs e)
        {
            isOpenConstructior = false;
            ResizeElements();

            sLabel.Text = "Конструктор закрыт успешно";
        }

        private void pbDiagram_MouseClick(object sender, MouseEventArgs e)
        {
            if (isShift && isOpenConstructior)
            {
                TableInDiagram clickedTable = null;
                string clickedField = null;
                foreach (TableInDiagram t in tablesInForm)
                {
                    if (Rectangle.Intersect(new Rectangle(e.X, e.Y, 0, 0), t.rect) != Rectangle.Empty)
                    {
                        clickedTable = t;
                        if (clickedTable != null)
                        {
                            for (int i = 0; i < clickedTable.Fields.Count; i++)
                            {
                                Rectangle bufRect = new Rectangle(clickedTable.Fields[i].Marker,
                                                        new Size(clickedTable.Width, clickedTable.Height));
                                if (Rectangle.Intersect(new Rectangle(e.X, e.Y, 0, 0), bufRect) != Rectangle.Empty)
                                {
                                    _clicableField = i;
                                    clickedField = clickedTable.Fields[i].name;
                                    Field f = clickedTable.Fields[i]; // цвет выделения!
                                    f.Brush = Brushes.Green;
                                    clickedTable.Fields[i] = f;
                                    break;
                                }
                            }
                        }
                        break;
                    }
                }
                if (clickedTable != null)
                {
                    //rtbQueryConstructor.Text = "Клик на поле `" + clickedTable.nameTable + "`.`" + clickedField + "`";
                    //Добавить в список полей
                    if (isOpenSelectInConstructor)
                    {
                        AddInSelect(clickedTable, clickedField);
                    }
                    if (isOpenInsertInConstructor)
                    {
                        AddInInsert(clickedTable, clickedField);
                    }
                    if (isOpenUpdateInConstructor)
                    {
                        AddInUpdate(clickedTable, clickedField);
                    }
                    if (isOpenDeleteInConstructor)
                    {
                        AddInDelete(clickedTable, clickedField);
                    }
                }
            }
        }

        private void AddInInsert(TableInDiagram clickedTable, string clickedField)
        {
            if (mainInsertQuery.Table == null)
                mainInsertQuery.Table = clickedTable;
            if (mainInsertQuery.Table == clickedTable)
            {
                if (clickedField != "" && clickedField != null)
                    if (!FindDublicate(dgvInsertFields, "`" + clickedTable.NameTable + "`.`" + clickedField + "`", 0))
                        dgvInsertFields.Rows.Add("`" + clickedTable.NameTable + "`.`" + clickedField + "`", "");
            }
            else
            {
                MessageBox.Show("Запрос INSERT может работать только с одной таблицей!", "Ошибка генерации запроса INSERT",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void AddInUpdate(TableInDiagram clickedTable, string clickedField)
        {
            if (mainUpdateQuery.Table == null)
                mainUpdateQuery.Table = clickedTable;
            if (mainUpdateQuery.Table == clickedTable)
            {
                if (!FindDublicate(dgvUpdateFields, clickedField, 0))
                    dgvUpdateFields.Rows.Add("`" + clickedTable.NameTable + "`.`" + clickedField + "`", "", "",
                        new DataGridViewComboBoxCell().DisplayMember = "NONE");
            }
            else
            {
                MessageBox.Show("Запрос INSERT может работать только с одной таблицей!", "Ошибка генерации запроса INSERT",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void AddInSelect(TableInDiagram clickedTable, string clickedField)
        {
            if (!FindDublicate(dgvAlias, clickedTable.NameTable, 0))  // если это поле не выбиралось
            {
                int relCount = mainSelectQuery.useRelationships.Count;
                Relationship r = FindRelationshipField(clickedTable.NameTable);// поиск таблицы если можно связать
                if (relCount == 0)//Если связей нет
                {
                    //Если такой таблицы не было добавлено, то добавить
                    if (!mainSelectQuery.tableNames.Contains(clickedTable.NameTable))
                        mainSelectQuery.tableNames.Add(clickedTable.NameTable);
                    //Если такого поля не было выбрано ранее, то выбрать
                    if (clickedField != null && clickedField != "" &&
                                !FindDublicate(dgvAlias, "`" + clickedTable.NameTable + "`.`" + clickedField + "`", 0))
                    {
                        dgvAlias.Rows.Add("`" + clickedTable.NameTable + "`.`" + clickedField + "`", "");
                        mainSelectQuery.selectExpressions.Add("`" + clickedTable.NameTable + "`.`" + clickedField + "`");
                    }
                    if (r.columnName != null)
                    {
                        dgvJoin.Rows.Add(r.referencedTableName, r.referencedColumnName, r.tableName, r.columnName,
                                    new DataGridViewComboBoxCell().ValueMember = "JOIN");
                        mainSelectQuery.useRelationships.Add(r);
                    }
                }
                else //Если связи уже есть
                {
                    if (r.tableName == mainSelectQuery.useRelationships[relCount - 1].tableName ||
                         r.referencedTableName == mainSelectQuery.useRelationships[relCount - 1].tableName)
                    {
                        if (!mainSelectQuery.useRelationships.Contains(r))
                        {
                            if (clickedField != "" || clickedField != null)
                            {
                                dgvAlias.Rows.Add("`" + clickedTable.NameTable + "`.`" + clickedField + "`", "");
                                mainSelectQuery.selectExpressions.Add("`" + clickedTable.NameTable + "`.`" + clickedField + "`");
                            }
                            dgvJoin.Rows.Add(r.referencedTableName, r.referencedColumnName, r.tableName, r.columnName,
                                new DataGridViewComboBoxCell().ValueMember = "JOIN");
                            mainSelectQuery.useRelationships.Add(r);
                        }
                        else
                        {
                            if (clickedField != "" || clickedField != null)
                            {
                                dgvAlias.Rows.Add("`" + clickedTable.NameTable + "`.`" + clickedField + "`", "");
                                mainSelectQuery.selectExpressions.Add("`" + clickedTable.NameTable + "`.`" + clickedField + "`");
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Для использования оператора JOIN необходимо связывать таблицы последовательно!");
                        Field f = clickedTable.Fields[_clicableField]; // цвет выделения!
                        f.Brush = Brushes.Black;
                        clickedTable.Fields[_clicableField] = f; 
                    }
                }
            }
        }

        private void AddInDelete(TableInDiagram clickedTable, string clickedField) 
        {
            if (clickedField != null & clickedField != "")
            {
                if (!mainDeleteQuery.TableNames.Contains(clickedTable.NameTable))
                    mainDeleteQuery.TableNames.Add(clickedTable.NameTable);
                if (!FindDublicate(dgvDeleteFields, clickedField, 0))
                {
                    dgvDeleteFields.Rows.Add("`"+clickedTable.NameTable+"`.`"+clickedField+"`", "",
                        false);
                }
            }
        }

        private Relationship FindRelationshipField(string table1)
        {
            Relationship fRelationship = new Relationship();
            foreach (Relationship r in RelationshipsDrawer.relationships)
            {
                if (r.tableName == table1 && mainSelectQuery.tableNames.Contains(r.referencedTableName))
                    fRelationship = r;
                if (mainSelectQuery.tableNames.Contains(r.tableName) && r.referencedTableName == table1)
                    fRelationship = r;
            }
            return fRelationship;
        }

        private bool FindDublicate(DataGridView dgv, string s, int col)
        {
            bool isDublocate = false;
            for (int i = 0; i < dgv.Rows.Count; i++)
            {
                if ((string)dgv.Rows[i].Cells[col].Value == s)
                    isDublocate = true;
            }
            return isDublocate;
        }

        private void FormDiagram_KeyDown(object sender, KeyEventArgs e)
        {
            isShift = true;
        }

        private void FormDiagram_KeyUp(object sender, KeyEventArgs e)
        {
            isShift = false;
        }

        private void btnResetQuery_Click(object sender, EventArgs e)
        {
            foreach (TableInDiagram t in tablesInForm)
            {
                for (int i = 0; i < t.Fields.Count; i++)
                {
                    Field f = t.Fields[i];
                    f.Brush = Brushes.Black;
                    t.Fields[i] = f;
                }
            }
            mainSelectQuery = new SelectQuery();
            mainInsertQuery = new InsertQuery();
            mainUpdateQuery = new UpdateQuery();
            mainDeleteQuery = new DeleteQuery();
            rtbQueryConstructor.Text = "";
            dgvAlias.Rows.Clear();
            dgvJoin.Rows.Clear();
            pbDiagram.Invalidate();
            dgvInsertFields.Rows.Clear();
            rtbInsertSelectQuery.Text = "Введи SELECT запрос для команды INSERT";
            dgvUpdateFields.Rows.Clear();
            dgvDeleteFields.Rows.Clear();
            rtbDeleteWhere.Text = "";
            tbDeleteLimit.Text = "";
            cbDeleteLow.Checked = false;
            cbDeleteQuick.Checked = false;

        }

        private void sELECTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenConstructor(Constructors.Select);
        }

        private void iNSERTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenConstructor(Constructors.Insert);
        }

        private void uPDATEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenConstructor(Constructors.Update);
        }

        private void dELETEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenConstructor(Constructors.Delete);
        }

        private void OpenSelectConstructor()
        {
            if (!isOpenConstructior)
            {
                isOpenConstructior = true;
                mainSelectQuery = new SelectQuery();
            }
            isOpenSelectInConstructor = true;
            mainSelectQuery = new SelectQuery();
            ResizeElements();
        }

        private void OpenInsertConstructor()
        {
            if (!isOpenConstructior)
            {
                isOpenConstructior = true;
                mainInsertQuery = new InsertQuery();
            }
            isOpenInsertInConstructor = true;
            mainInsertQuery = new InsertQuery();
            ResizeElements();
        }

        private void OpenUpdateConstructor()
        {
            if (!isOpenConstructior)
            {
                isOpenConstructior = true;
                mainUpdateQuery = new UpdateQuery();
            }
            isOpenUpdateInConstructor = true;
            mainUpdateQuery = new UpdateQuery();
            ResizeElements();
        }

        private void OpenDeleteConstructor()
        {
            if (!isOpenConstructior)
            {
                isOpenConstructior = true;
                mainDeleteQuery = new DeleteQuery();
            }
            isOpenDeleteInConstructor = true;
            mainDeleteQuery = new DeleteQuery();
            ResizeElements();
        }

        private enum Constructors
        {
            Select,
            Insert,
            Update,
            Delete,
            None
        }

        private void OpenConstructor(Constructors type)
        {
            ResetConstructors();
            switch (type)
            {
                case Constructors.Select:
                    OpenSelectConstructor();
                    break;
                case Constructors.Insert:
                    OpenInsertConstructor();
                    break;
                case Constructors.Update:
                    OpenUpdateConstructor();
                    break;
                case Constructors.Delete:
                    OpenDeleteConstructor();
                    break;
                case Constructors.None:
                    ResetConstructors();
                    break;

            }
        }

        private void ResetConstructors()
        {
            isOpenSelectInConstructor = false;
            isOpenInsertInConstructor = false;
            isOpenUpdateInConstructor = false;
            isOpenDeleteInConstructor = false;
            ResetSelectConstructor();
            ResetInsertConstructor();
            ResetDeleteConstructor();
            UnSelectTables();
        }

        private void ResetSelectConstructor()
        {
            dgvAlias.Rows.Clear();
            dgvJoin.Rows.Clear();
            dgvConditions.Rows.Clear();
            tbLimit.Text = "";
            cbUsingDistinct.Checked = false;
            mainSelectQuery = new SelectQuery();
        }

        private void ResetInsertConstructor()
        {
            rtbInsertSelectQuery.Text = "Введи SELECT запрос для команды INSERT";
            dgvInsertFields.Rows.Clear();
            mainInsertQuery = new InsertQuery();
        }

        private void ResetDeleteConstructor()
        {
            dgvDeleteFields.Rows.Clear();
            cbDeleteLow.Checked = false;
            cbDeleteQuick.Checked = false;
            tbDeleteLimit.Text = "";
            rtbDeleteWhere.Text = "";
        }

        private void UnSelectTables()
        {
            foreach (TableInDiagram t in tablesInForm)
            {
                for (int i = 0; i < t.Fields.Count; i++)
                {
                    Field f = t.Fields[i];
                    f.Brush = Brushes.Black;
                    t.Fields[i] = f;
                }
            }
        }

        private void pSelect_VisibleChanged(object sender, EventArgs e)
        {
            // Очистить все поля
        }


        private void SelectGenerate()
        {
            if (mainSelectQuery.selectExpressions.Count > 0)
            {
                mainSelectQuery.generateConditions(dgvConditions);
                mainSelectQuery.useTypesRelationships.Clear();
                mainSelectQuery.alias.Clear();
                for (int i = 0; i < dgvAlias.Rows.Count - 1; i++)
                {
                    mainSelectQuery.alias.Add(dgvAlias.Rows[i].Cells[1].Value.ToString());
                }
                for (int i = 0; i < dgvJoin.Rows.Count - 1; i++)
                {
                    mainSelectQuery.useTypesRelationships.Add(((DataGridViewComboBoxCell)dgvJoin.Rows[i].Cells[4]).Value.ToString());
                }
                mainSelectQuery.generatedLimitAndDistinct(tbLimit.Text, cbUsingDistinct.Checked);
                string generatedQuery = mainSelectQuery.generateQuery();
                gbQueryConstructor.Navigate(loadHTML(generatedQuery));
                ExecuteForm f = new ExecuteForm(loadHTML(generatedQuery), MySQL, generatedQuery);
                f.ShowDialog();
            }
        }

        private void DeleteGenerate()
        {
            mainDeleteQuery.Limit = tbDeleteLimit.Text;
            mainDeleteQuery.LowPriotity = cbDeleteLow.Checked;
            mainDeleteQuery.Quick = cbDeleteQuick.Checked;
            mainDeleteQuery.Where = rtbDeleteWhere.Text;
            string orderBy = "";
            foreach (DataGridViewRow r in dgvDeleteFields.Rows)
            {
                if (r.Cells[0].Value != null)
                {
                    if (((DataGridViewCheckBoxCell)r.Cells[2]).Value.ToString() == true.ToString())
                    {
                        orderBy += orderBy != "" ? "," + r.Cells[0].Value.ToString() : r.Cells[0].Value.ToString();
                    }
                }
            }
            mainDeleteQuery.OrderBy = orderBy;
            string generatedQuery = mainDeleteQuery.GenerateDeleteQuery();
            ExecuteForm f = new ExecuteForm(loadHTML(generatedQuery), MySQL, generatedQuery);
            f.ShowDialog();
        }

        private void tcSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (tcSelect.SelectedTab.Text)
            {
                case ("Условия"):

                    break;
            }
        }

        private void dgvAlias_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            dgvConditions.Rows.Add(dgvAlias.Rows[e.RowIndex].Cells[0].Value, "", new DataGridViewComboBoxCell().ValueMember = "NONE"
                , new DataGridViewComboBoxCell().ValueMember = "NONE", "",
                new DataGridViewCheckBoxCell().Value = false);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            mainSelectQuery.generateConditions(dgvConditions);
        }

        private void InsertGenerate()
        {
            try
            {
                mainInsertQuery.Expression.Clear();
                foreach (DataGridViewRow dgvr in dgvInsertFields.Rows)
                {
                    if (dgvr.Cells[0].Value != null && dgvr.Cells[1].Value != null)
                    {
                        mainInsertQuery.Expression.Add(new List<string>(){dgvr.Cells[0].Value.ToString(),
                                                                dgvr.Cells[1].Value.ToString()});
                    }
                }
                string generatedQuery = mainInsertQuery.CreateInsertQuery();
                gbQueryConstructor.Navigate(loadHTML(generatedQuery));
                ExecuteForm f = new ExecuteForm(loadHTML(generatedQuery), MySQL, generatedQuery);
                f.ShowDialog();
            }
            catch
            { }
        }

        private void UpdateGenerate()
        {
            mainUpdateQuery.Ignore = cbIgnoreUpdate.Checked;
            mainUpdateQuery.Low = cbLowPriorityUpdate.Checked;
            mainUpdateQuery.Limit = tbLimit.Text;
            mainUpdateQuery.Where = tbWhereUpdate.Text;
            try
            {
                mainUpdateQuery.Expression.Clear();
                foreach (DataGridViewRow dgvr in dgvUpdateFields.Rows)
                {
                    if (dgvr.Cells[0].Value != null && dgvr.Cells[2].Value != null)
                        mainUpdateQuery.Expression.Add(new List<string>(){dgvr.Cells[0].Value.ToString(), dgvr.Cells[1].Value.ToString(),
                                                dgvr.Cells[2].Value.ToString(), dgvr.Cells[3].Value.ToString()});
                }
                string generatedQuery = mainUpdateQuery.CreateUpdateQuery();
                gbQueryConstructor.Navigate(loadHTML(generatedQuery));
                ExecuteForm f = new ExecuteForm(loadHTML(generatedQuery), MySQL, generatedQuery);
                f.ShowDialog();
            }
            catch { }
        }

        private void FormDiagram_FormClosing(object sender, FormClosingEventArgs e)
        {
            Program.chooseForm.Visible = true;
            Program.formDiagram = null;
            if (tablesInForm.Count != 0)
            {
                List<NamesAndCoordinates> names = new List<NamesAndCoordinates>();
                foreach (TableInDiagram t in tablesInForm)
                {
                    names.Add(new NamesAndCoordinates
                    {
                        Name = t.NameTable,
                        Coordinate = t.startPoint
                    });
                }
                string json = JsonSerializer.Serialize(names);
                StreamWriter sr = new StreamWriter(File.Create("Constructor/" + MySQL.Db+".json"));
                sr.Write(json);
                sr.Close();
            }
        }

        public string loadHTML(string sql)
        {
            string site = string.Format("<!DOCTYPE html> <head> <meta charset='UTF-8'> <script src='rainbow-custom.min.js'></script> <link href='obsidian.css' rel='stylesheet'> <title>Document</title> </head> <body> <pre><code data-language='sql'>{0}</code></pre> </body> </html>", sql);
            StreamWriter sw = new StreamWriter(File.Create(Directory.GetCurrentDirectory() + @"\Titles\js\TEMPSQL.html"));
            sw.Write(site);
            sw.Close();
            return Directory.GetCurrentDirectory() + @"\Titles\js\TEMPSQL.html";
        }

        private void dgvDeleteFields_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 1)
                rtbDeleteWhere.Text += (rtbDeleteWhere.Text != "" ? "\n AND \n" : "") +
                    dgvDeleteFields.Rows[e.RowIndex].Cells[0].Value.ToString() + " " +
                    dgvDeleteFields.Rows[e.RowIndex].Cells[1].Value.ToString();
        }

        private void btnGen_Click(object sender, EventArgs e)
        {
            if (isOpenSelectInConstructor)
                SelectGenerate();
            if (isOpenInsertInConstructor)
                InsertGenerate();
            if (isOpenUpdateInConstructor)
                UpdateGenerate();
            if (isOpenDeleteInConstructor)
                DeleteGenerate();
        }
        private void OpenContext(Point point)
        {
            
        }
        private void CloseContext(Point point)
        {
            
        }
    }

    public class NamesAndCoordinates 
    {
        public string Name { get; set; }
        public Point Coordinate { get; set; }
    }
}

