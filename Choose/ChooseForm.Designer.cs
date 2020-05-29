namespace Diplom2.Choose
{
    partial class ChooseForm
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
            this.components = new System.ComponentModel.Container();
            Awesomium.Core.WebPreferences webPreferences1 = new Awesomium.Core.WebPreferences(true);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChooseForm));
            this.wcChoose = new Awesomium.Windows.Forms.WebControl(this.components);
            this.wspChoose = new Awesomium.Windows.Forms.WebSessionProvider(this.components);
            this.msMain = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.настройкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.показатьМенюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.скрытьМенюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.webControlContextMenu1 = new Awesomium.Windows.Forms.WebControlContextMenu(this.components);
            this.tsmiMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.cmShoose = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.показатьМенюToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.msMain.SuspendLayout();
            this.webControlContextMenu1.SuspendLayout();
            this.cmShoose.SuspendLayout();
            this.SuspendLayout();
            // 
            // wcChoose
            // 
            this.wcChoose.ContextMenuStrip = this.cmShoose;
            this.wcChoose.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wcChoose.Location = new System.Drawing.Point(0, 24);
            this.wcChoose.Size = new System.Drawing.Size(800, 408);
            this.wcChoose.Source = new System.Uri("about:blank", System.UriKind.Absolute);
            this.wcChoose.TabIndex = 0;
            this.wcChoose.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Awesomium_Windows_Forms_WebControl_KeyDown);
            // 
            // wspChoose
            // 
            webPreferences1.CanScriptsAccessClipboard = true;
            webPreferences1.Databases = true;
            webPreferences1.EnableGPUAcceleration = true;
            webPreferences1.FileAccessFromFileURL = true;
            webPreferences1.JavascriptViewChangeSource = false;
            webPreferences1.JavascriptViewEvents = false;
            webPreferences1.JavascriptViewExecute = false;
            webPreferences1.MaxHttpCacheStorage = 1000;
            webPreferences1.SmoothScrolling = true;
            webPreferences1.UniversalAccessFromFileURL = true;
            webPreferences1.WebGL = true;
            this.wspChoose.Preferences = webPreferences1;
            // 
            // msMain
            // 
            this.msMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem});
            this.msMain.Location = new System.Drawing.Point(0, 0);
            this.msMain.Name = "msMain";
            this.msMain.Size = new System.Drawing.Size(800, 24);
            this.msMain.TabIndex = 1;
            this.msMain.Text = "msMain";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.настройкиToolStripMenuItem,
            this.показатьМенюToolStripMenuItem,
            this.скрытьМенюToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // настройкиToolStripMenuItem
            // 
            this.настройкиToolStripMenuItem.Name = "настройкиToolStripMenuItem";
            this.настройкиToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.настройкиToolStripMenuItem.Size = new System.Drawing.Size(236, 22);
            this.настройкиToolStripMenuItem.Text = "Настройки";
            this.настройкиToolStripMenuItem.Click += new System.EventHandler(this.настройкиToolStripMenuItem_Click);
            // 
            // показатьМенюToolStripMenuItem
            // 
            this.показатьМенюToolStripMenuItem.Name = "показатьМенюToolStripMenuItem";
            this.показатьМенюToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.M)));
            this.показатьМенюToolStripMenuItem.Size = new System.Drawing.Size(236, 22);
            this.показатьМенюToolStripMenuItem.Text = "Показать меню";
            this.показатьМенюToolStripMenuItem.Click += new System.EventHandler(this.показатьМенюToolStripMenuItem_Click);
            // 
            // скрытьМенюToolStripMenuItem
            // 
            this.скрытьМенюToolStripMenuItem.Name = "скрытьМенюToolStripMenuItem";
            this.скрытьМенюToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.M)));
            this.скрытьМенюToolStripMenuItem.Size = new System.Drawing.Size(236, 22);
            this.скрытьМенюToolStripMenuItem.Text = "Скрыть меню";
            this.скрытьМенюToolStripMenuItem.Click += new System.EventHandler(this.скрытьМенюToolStripMenuItem_Click);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.X)));
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(236, 22);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // webControlContextMenu1
            // 
            this.webControlContextMenu1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiMenu});
            this.webControlContextMenu1.Name = "webControlContextMenu1";
            this.webControlContextMenu1.Size = new System.Drawing.Size(203, 148);
            this.webControlContextMenu1.View = null;
            // 
            // tsmiMenu
            // 
            this.tsmiMenu.Name = "tsmiMenu";
            this.tsmiMenu.Size = new System.Drawing.Size(202, 22);
            this.tsmiMenu.Text = "Открыть меню";
            // 
            // cmShoose
            // 
            this.cmShoose.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.показатьМенюToolStripMenuItem1});
            this.cmShoose.Name = "cmShoose";
            this.cmShoose.Size = new System.Drawing.Size(160, 26);
            // 
            // показатьМенюToolStripMenuItem1
            // 
            this.показатьМенюToolStripMenuItem1.Name = "показатьМенюToolStripMenuItem1";
            this.показатьМенюToolStripMenuItem1.Size = new System.Drawing.Size(159, 22);
            this.показатьМенюToolStripMenuItem1.Text = "Показать меню";
            this.показатьМенюToolStripMenuItem1.Click += new System.EventHandler(this.показатьМенюToolStripMenuItem1_Click);
            // 
            // ChooseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(800, 432);
            this.ContextMenuStrip = this.cmShoose;
            this.Controls.Add(this.wcChoose);
            this.Controls.Add(this.msMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MainMenuStrip = this.msMain;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ChooseForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Изучаем синтаксис MySQL";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ChooseForm_FormClosing);
            this.Load += new System.EventHandler(this.ChooseForm_Load);
            this.VisibleChanged += new System.EventHandler(this.ChooseForm_VisibleChanged);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ChooseForm_KeyDown);
            this.msMain.ResumeLayout(false);
            this.msMain.PerformLayout();
            this.webControlContextMenu1.ResumeLayout(false);
            this.cmShoose.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Awesomium.Windows.Forms.WebControl wcChoose;
        private Awesomium.Windows.Forms.WebSessionProvider wspChoose;
        private System.Windows.Forms.MenuStrip msMain;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem настройкиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem показатьМенюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem скрытьМенюToolStripMenuItem;
        private Awesomium.Windows.Forms.WebControlContextMenu webControlContextMenu1;
        private System.Windows.Forms.ToolStripMenuItem tsmiMenu;
        private System.Windows.Forms.ContextMenuStrip cmShoose;
        private System.Windows.Forms.ToolStripMenuItem показатьМенюToolStripMenuItem1;
    }
}