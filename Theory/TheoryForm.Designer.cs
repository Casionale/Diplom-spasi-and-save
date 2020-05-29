namespace Diplom2.Theory
{
    partial class TheoryForm
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
            this.wcTheory = new Awesomium.Windows.Forms.WebControl(this.components);
            this.tvTheory = new System.Windows.Forms.TreeView();
            this.SuspendLayout();
            // 
            // wcTheory
            // 
            this.wcTheory.BackColor = System.Drawing.Color.White;
            this.wcTheory.Dock = System.Windows.Forms.DockStyle.Right;
            this.wcTheory.Location = new System.Drawing.Point(196, 0);
            this.wcTheory.Size = new System.Drawing.Size(604, 450);
            this.wcTheory.TabIndex = 0;
            // 
            // tvTheory
            // 
            this.tvTheory.BackColor = System.Drawing.Color.White;
            this.tvTheory.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tvTheory.Dock = System.Windows.Forms.DockStyle.Left;
            this.tvTheory.Location = new System.Drawing.Point(0, 0);
            this.tvTheory.Name = "tvTheory";
            this.tvTheory.Size = new System.Drawing.Size(190, 450);
            this.tvTheory.TabIndex = 1;
            this.tvTheory.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.tvTheory_NodeMouseDoubleClick);
            // 
            // TheoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tvTheory);
            this.Controls.Add(this.wcTheory);
            this.Name = "TheoryForm";
            this.Text = "Справочник MySQL";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TheoryForm_FormClosing);
            this.Load += new System.EventHandler(this.TheoryForm_Load);
            this.Resize += new System.EventHandler(this.TheoryForm_Resize);
            this.ResumeLayout(false);

        }

        #endregion

        private Awesomium.Windows.Forms.WebControl wcTheory;
        private System.Windows.Forms.TreeView tvTheory;
    }
}