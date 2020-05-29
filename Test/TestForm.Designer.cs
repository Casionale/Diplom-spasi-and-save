namespace Diplom2.Test
{
    partial class TestForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TestForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.nbTest = new XanderUI.XUINavigationBar();
            this.pQuestion = new System.Windows.Forms.Panel();
            this.pTextQuestion = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.tbAnswerQuestion = new System.Windows.Forms.TextBox();
            this.pCheck = new System.Windows.Forms.Panel();
            this.cbQuestion2 = new XanderUI.XUICheckBox();
            this.cbQuestion1 = new XanderUI.XUICheckBox();
            this.cbQuestion3 = new XanderUI.XUICheckBox();
            this.cbQuestion4 = new XanderUI.XUICheckBox();
            this.pRadio = new System.Windows.Forms.Panel();
            this.rQestion1 = new XanderUI.XUIRadio();
            this.rQestion2 = new XanderUI.XUIRadio();
            this.rQestion3 = new XanderUI.XUIRadio();
            this.rQestion4 = new XanderUI.XUIRadio();
            this.rtbQuestion = new System.Windows.Forms.RichTextBox();
            this.lblTime = new System.Windows.Forms.Label();
            this.pbQuestion = new XanderUI.XUIFlatProgressBar();
            this.pResults = new System.Windows.Forms.Panel();
            this.xbtnReset = new XanderUI.XUIButton();
            this.dgvResults = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.lblResultsTitle = new System.Windows.Forms.Label();
            this.pQuestion.SuspendLayout();
            this.pTextQuestion.SuspendLayout();
            this.pCheck.SuspendLayout();
            this.pRadio.SuspendLayout();
            this.pResults.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResults)).BeginInit();
            this.SuspendLayout();
            // 
            // nbTest
            // 
            this.nbTest.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(119)))), ((int)(((byte)(215)))));
            this.nbTest.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.nbTest.ItemColor = System.Drawing.Color.White;
            this.nbTest.LeftCustomImage = null;
            this.nbTest.LeftCustomText = "Предыдущий вопрос";
            this.nbTest.LeftItem = XanderUI.XUINavigationBar.NavigationItem.CustomText;
            this.nbTest.Location = new System.Drawing.Point(0, 410);
            this.nbTest.Name = "nbTest";
            this.nbTest.NavBarStyle = XanderUI.XUINavigationBar.Style.Material;
            this.nbTest.RightCustomImage = null;
            this.nbTest.RightCustomText = "Следующий вопрос";
            this.nbTest.RightItem = XanderUI.XUINavigationBar.NavigationItem.CustomText;
            this.nbTest.Size = new System.Drawing.Size(800, 40);
            this.nbTest.TabIndex = 0;
            this.nbTest.Text = "Навигация";
            this.nbTest.Title = "Навигация";
            this.nbTest.TitleColor = System.Drawing.Color.White;
            // 
            // pQuestion
            // 
            this.pQuestion.Controls.Add(this.pTextQuestion);
            this.pQuestion.Controls.Add(this.pCheck);
            this.pQuestion.Controls.Add(this.pRadio);
            this.pQuestion.Controls.Add(this.rtbQuestion);
            this.pQuestion.Controls.Add(this.lblTime);
            this.pQuestion.Controls.Add(this.pbQuestion);
            this.pQuestion.Dock = System.Windows.Forms.DockStyle.Left;
            this.pQuestion.Location = new System.Drawing.Point(0, 0);
            this.pQuestion.Name = "pQuestion";
            this.pQuestion.Size = new System.Drawing.Size(219, 410);
            this.pQuestion.TabIndex = 1;
            // 
            // pTextQuestion
            // 
            this.pTextQuestion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pTextQuestion.Controls.Add(this.label2);
            this.pTextQuestion.Controls.Add(this.tbAnswerQuestion);
            this.pTextQuestion.Location = new System.Drawing.Point(242, 72);
            this.pTextQuestion.Name = "pTextQuestion";
            this.pTextQuestion.Size = new System.Drawing.Size(7, 146);
            this.pTextQuestion.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(10, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(217, 25);
            this.label2.TabIndex = 12;
            this.label2.Text = "Введите ответ на вопрос";
            // 
            // tbAnswerQuestion
            // 
            this.tbAnswerQuestion.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbAnswerQuestion.Location = new System.Drawing.Point(10, 60);
            this.tbAnswerQuestion.Name = "tbAnswerQuestion";
            this.tbAnswerQuestion.Size = new System.Drawing.Size(465, 29);
            this.tbAnswerQuestion.TabIndex = 11;
            // 
            // pCheck
            // 
            this.pCheck.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pCheck.Controls.Add(this.cbQuestion2);
            this.pCheck.Controls.Add(this.cbQuestion1);
            this.pCheck.Controls.Add(this.cbQuestion3);
            this.pCheck.Controls.Add(this.cbQuestion4);
            this.pCheck.Location = new System.Drawing.Point(242, 228);
            this.pCheck.Name = "pCheck";
            this.pCheck.Size = new System.Drawing.Size(7, 146);
            this.pCheck.TabIndex = 13;
            // 
            // cbQuestion2
            // 
            this.cbQuestion2.CheckboxCheckColor = System.Drawing.Color.White;
            this.cbQuestion2.CheckboxColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(119)))), ((int)(((byte)(215)))));
            this.cbQuestion2.CheckboxHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.cbQuestion2.CheckboxStyle = XanderUI.XUICheckBox.Style.Material;
            this.cbQuestion2.Checked = false;
            this.cbQuestion2.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbQuestion2.ForeColor = System.Drawing.Color.Black;
            this.cbQuestion2.Location = new System.Drawing.Point(10, 49);
            this.cbQuestion2.Name = "cbQuestion2";
            this.cbQuestion2.Size = new System.Drawing.Size(181, 20);
            this.cbQuestion2.TabIndex = 8;
            this.cbQuestion2.Text = "Выбор ответа 1";
            this.cbQuestion2.TickThickness = 2;
            // 
            // cbQuestion1
            // 
            this.cbQuestion1.CheckboxCheckColor = System.Drawing.Color.White;
            this.cbQuestion1.CheckboxColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(119)))), ((int)(((byte)(215)))));
            this.cbQuestion1.CheckboxHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.cbQuestion1.CheckboxStyle = XanderUI.XUICheckBox.Style.Material;
            this.cbQuestion1.Checked = false;
            this.cbQuestion1.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbQuestion1.ForeColor = System.Drawing.Color.Black;
            this.cbQuestion1.Location = new System.Drawing.Point(10, 12);
            this.cbQuestion1.Name = "cbQuestion1";
            this.cbQuestion1.Size = new System.Drawing.Size(181, 20);
            this.cbQuestion1.TabIndex = 7;
            this.cbQuestion1.Text = "Выбор ответа 1";
            this.cbQuestion1.TickThickness = 2;
            // 
            // cbQuestion3
            // 
            this.cbQuestion3.CheckboxCheckColor = System.Drawing.Color.White;
            this.cbQuestion3.CheckboxColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(119)))), ((int)(((byte)(215)))));
            this.cbQuestion3.CheckboxHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.cbQuestion3.CheckboxStyle = XanderUI.XUICheckBox.Style.Material;
            this.cbQuestion3.Checked = false;
            this.cbQuestion3.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbQuestion3.ForeColor = System.Drawing.Color.Black;
            this.cbQuestion3.Location = new System.Drawing.Point(10, 83);
            this.cbQuestion3.Name = "cbQuestion3";
            this.cbQuestion3.Size = new System.Drawing.Size(181, 20);
            this.cbQuestion3.TabIndex = 9;
            this.cbQuestion3.Text = "Выбор ответа 1";
            this.cbQuestion3.TickThickness = 2;
            // 
            // cbQuestion4
            // 
            this.cbQuestion4.CheckboxCheckColor = System.Drawing.Color.White;
            this.cbQuestion4.CheckboxColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(119)))), ((int)(((byte)(215)))));
            this.cbQuestion4.CheckboxHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.cbQuestion4.CheckboxStyle = XanderUI.XUICheckBox.Style.Material;
            this.cbQuestion4.Checked = false;
            this.cbQuestion4.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbQuestion4.ForeColor = System.Drawing.Color.Black;
            this.cbQuestion4.Location = new System.Drawing.Point(10, 115);
            this.cbQuestion4.Name = "cbQuestion4";
            this.cbQuestion4.Size = new System.Drawing.Size(181, 20);
            this.cbQuestion4.TabIndex = 10;
            this.cbQuestion4.Text = "Выбор ответа 1";
            this.cbQuestion4.TickThickness = 2;
            // 
            // pRadio
            // 
            this.pRadio.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pRadio.Controls.Add(this.rQestion1);
            this.pRadio.Controls.Add(this.rQestion2);
            this.pRadio.Controls.Add(this.rQestion3);
            this.pRadio.Controls.Add(this.rQestion4);
            this.pRadio.Location = new System.Drawing.Point(12, 228);
            this.pRadio.Name = "pRadio";
            this.pRadio.Size = new System.Drawing.Size(7, 146);
            this.pRadio.TabIndex = 12;
            // 
            // rQestion1
            // 
            this.rQestion1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.rQestion1.Checked = false;
            this.rQestion1.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rQestion1.ForeColor = System.Drawing.Color.Black;
            this.rQestion1.Location = new System.Drawing.Point(10, 16);
            this.rQestion1.Margin = new System.Windows.Forms.Padding(10);
            this.rQestion1.Name = "rQestion1";
            this.rQestion1.RadioColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(119)))), ((int)(((byte)(215)))));
            this.rQestion1.RadioHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.rQestion1.RadioStyle = XanderUI.XUIRadio.Style.Material;
            this.rQestion1.Size = new System.Drawing.Size(160, 18);
            this.rQestion1.TabIndex = 0;
            this.rQestion1.Text = "Выбор ответа 1";
            // 
            // rQestion2
            // 
            this.rQestion2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.rQestion2.Checked = false;
            this.rQestion2.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rQestion2.ForeColor = System.Drawing.Color.Black;
            this.rQestion2.Location = new System.Drawing.Point(10, 50);
            this.rQestion2.Margin = new System.Windows.Forms.Padding(10);
            this.rQestion2.Name = "rQestion2";
            this.rQestion2.RadioColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(119)))), ((int)(((byte)(215)))));
            this.rQestion2.RadioHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.rQestion2.RadioStyle = XanderUI.XUIRadio.Style.Material;
            this.rQestion2.Size = new System.Drawing.Size(160, 18);
            this.rQestion2.TabIndex = 1;
            this.rQestion2.Text = "Выбор ответа 1";
            // 
            // rQestion3
            // 
            this.rQestion3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.rQestion3.Checked = false;
            this.rQestion3.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rQestion3.ForeColor = System.Drawing.Color.Black;
            this.rQestion3.Location = new System.Drawing.Point(10, 84);
            this.rQestion3.Margin = new System.Windows.Forms.Padding(10);
            this.rQestion3.Name = "rQestion3";
            this.rQestion3.RadioColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(119)))), ((int)(((byte)(215)))));
            this.rQestion3.RadioHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.rQestion3.RadioStyle = XanderUI.XUIRadio.Style.Material;
            this.rQestion3.Size = new System.Drawing.Size(160, 18);
            this.rQestion3.TabIndex = 2;
            this.rQestion3.Text = "Выбор ответа 1";
            // 
            // rQestion4
            // 
            this.rQestion4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.rQestion4.Checked = false;
            this.rQestion4.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rQestion4.ForeColor = System.Drawing.Color.Black;
            this.rQestion4.Location = new System.Drawing.Point(10, 118);
            this.rQestion4.Margin = new System.Windows.Forms.Padding(10);
            this.rQestion4.Name = "rQestion4";
            this.rQestion4.RadioColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(119)))), ((int)(((byte)(215)))));
            this.rQestion4.RadioHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.rQestion4.RadioStyle = XanderUI.XUIRadio.Style.Material;
            this.rQestion4.Size = new System.Drawing.Size(160, 18);
            this.rQestion4.TabIndex = 3;
            this.rQestion4.Text = "Выбор ответа 1";
            // 
            // rtbQuestion
            // 
            this.rtbQuestion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbQuestion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbQuestion.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rtbQuestion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.rtbQuestion.Location = new System.Drawing.Point(10, 49);
            this.rtbQuestion.Margin = new System.Windows.Forms.Padding(20);
            this.rtbQuestion.Name = "rtbQuestion";
            this.rtbQuestion.ReadOnly = true;
            this.rtbQuestion.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rtbQuestion.Size = new System.Drawing.Size(197, 169);
            this.rtbQuestion.TabIndex = 6;
            this.rtbQuestion.Text = "ВОПРОС 1 ИЗ 1:\nКакой ушс случился с Микой?";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTime.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTime.Location = new System.Drawing.Point(0, 0);
            this.lblTime.Name = "lblTime";
            this.lblTime.Padding = new System.Windows.Forms.Padding(10);
            this.lblTime.Size = new System.Drawing.Size(290, 43);
            this.lblTime.TabIndex = 5;
            this.lblTime.Text = "Для этого вопроса осталось 00 сек.";
            // 
            // pbQuestion
            // 
            this.pbQuestion.BarStyle = XanderUI.XUIFlatProgressBar.Style.Material;
            this.pbQuestion.BorderColor = System.Drawing.Color.Black;
            this.pbQuestion.CompleteColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(119)))), ((int)(((byte)(215)))));
            this.pbQuestion.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pbQuestion.InocmpletedColor = System.Drawing.Color.White;
            this.pbQuestion.Location = new System.Drawing.Point(0, 390);
            this.pbQuestion.MaxValue = 100;
            this.pbQuestion.Name = "pbQuestion";
            this.pbQuestion.ShowBorder = true;
            this.pbQuestion.Size = new System.Drawing.Size(219, 20);
            this.pbQuestion.TabIndex = 4;
            this.pbQuestion.Text = "xuiFlatProgressBar1";
            this.pbQuestion.Value = 50;
            // 
            // pResults
            // 
            this.pResults.Controls.Add(this.xbtnReset);
            this.pResults.Controls.Add(this.dgvResults);
            this.pResults.Controls.Add(this.label1);
            this.pResults.Controls.Add(this.lblScore);
            this.pResults.Controls.Add(this.lblResultsTitle);
            this.pResults.Dock = System.Windows.Forms.DockStyle.Left;
            this.pResults.Location = new System.Drawing.Point(219, 0);
            this.pResults.Name = "pResults";
            this.pResults.Size = new System.Drawing.Size(578, 410);
            this.pResults.TabIndex = 2;
            // 
            // xbtnReset
            // 
            this.xbtnReset.BackgroundColor = System.Drawing.Color.White;
            this.xbtnReset.ButtonImage = ((System.Drawing.Image)(resources.GetObject("xbtnReset.ButtonImage")));
            this.xbtnReset.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.xbtnReset.ButtonText = "Запустить повторно";
            this.xbtnReset.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.xbtnReset.ClickTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.xbtnReset.CornerRadius = 5;
            this.xbtnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.xbtnReset.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.xbtnReset.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.xbtnReset.HoverTextColor = System.Drawing.Color.White;
            this.xbtnReset.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.xbtnReset.Location = new System.Drawing.Point(14, 132);
            this.xbtnReset.Name = "xbtnReset";
            this.xbtnReset.Size = new System.Drawing.Size(236, 28);
            this.xbtnReset.TabIndex = 4;
            this.xbtnReset.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(119)))), ((int)(((byte)(215)))));
            this.xbtnReset.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.xbtnReset.Click += new System.EventHandler(this.xbtnReset_Click);
            // 
            // dgvResults
            // 
            this.dgvResults.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvResults.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvResults.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResults.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column4,
            this.Column5,
            this.Column2,
            this.Column3});
            this.dgvResults.GridColor = System.Drawing.Color.Black;
            this.dgvResults.Location = new System.Drawing.Point(0, 167);
            this.dgvResults.Name = "dgvResults";
            this.dgvResults.RowHeadersVisible = false;
            this.dgvResults.Size = new System.Drawing.Size(578, 243);
            this.dgvResults.TabIndex = 3;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Номер вопроса";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Вопрос";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Ответ";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Баллов получено";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Баллов в вопросе";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(119)))), ((int)(((byte)(215)))));
            this.label1.Location = new System.Drawing.Point(191, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Посмотрите статистику ваших ответов";
            // 
            // lblScore
            // 
            this.lblScore.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblScore.AutoSize = true;
            this.lblScore.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblScore.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblScore.Location = new System.Drawing.Point(216, 74);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(152, 25);
            this.lblScore.TabIndex = 1;
            this.lblScore.Text = "10 баллов из 10";
            // 
            // lblResultsTitle
            // 
            this.lblResultsTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblResultsTitle.AutoSize = true;
            this.lblResultsTitle.Font = new System.Drawing.Font("Arial", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblResultsTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(119)))), ((int)(((byte)(215)))));
            this.lblResultsTitle.Location = new System.Drawing.Point(84, 18);
            this.lblResultsTitle.Name = "lblResultsTitle";
            this.lblResultsTitle.Size = new System.Drawing.Size(411, 44);
            this.lblResultsTitle.TabIndex = 0;
            this.lblResultsTitle.Text = "Лёгкий тест пройден!";
            // 
            // TestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pResults);
            this.Controls.Add(this.pQuestion);
            this.Controls.Add(this.nbTest);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TestForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TestForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TestForm_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.TestForm_FormClosed);
            this.Load += new System.EventHandler(this.TestForm_Load);
            this.Resize += new System.EventHandler(this.TestForm_Resize);
            this.pQuestion.ResumeLayout(false);
            this.pQuestion.PerformLayout();
            this.pTextQuestion.ResumeLayout(false);
            this.pTextQuestion.PerformLayout();
            this.pCheck.ResumeLayout(false);
            this.pRadio.ResumeLayout(false);
            this.pResults.ResumeLayout(false);
            this.pResults.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResults)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private XanderUI.XUINavigationBar nbTest;
        private System.Windows.Forms.Panel pQuestion;
        private XanderUI.XUIRadio rQestion1;
        private XanderUI.XUIRadio rQestion2;
        private XanderUI.XUIRadio rQestion4;
        private XanderUI.XUIRadio rQestion3;
        private System.Windows.Forms.RichTextBox rtbQuestion;
        private System.Windows.Forms.Label lblTime;
        private XanderUI.XUIFlatProgressBar pbQuestion;
        private XanderUI.XUICheckBox cbQuestion1;
        private XanderUI.XUICheckBox cbQuestion4;
        private XanderUI.XUICheckBox cbQuestion3;
        private XanderUI.XUICheckBox cbQuestion2;
        private System.Windows.Forms.TextBox tbAnswerQuestion;
        private System.Windows.Forms.Panel pCheck;
        private System.Windows.Forms.Panel pRadio;
        private System.Windows.Forms.Panel pTextQuestion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pResults;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label lblResultsTitle;
        private System.Windows.Forms.DataGridView dgvResults;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private XanderUI.XUIButton xbtnReset;
    }
}