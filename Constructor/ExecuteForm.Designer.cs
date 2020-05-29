namespace Diplom2.Constructor
{
    partial class ExecuteForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExecuteForm));
            this.pTop = new System.Windows.Forms.Panel();
            this.pWitchBrowser = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.xbtnExecute = new XanderUI.XUIButton();
            this.pTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // pTop
            // 
            this.pTop.Controls.Add(this.xbtnExecute);
            this.pTop.Controls.Add(this.label1);
            this.pTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pTop.Location = new System.Drawing.Point(0, 0);
            this.pTop.Name = "pTop";
            this.pTop.Size = new System.Drawing.Size(748, 50);
            this.pTop.TabIndex = 0;
            // 
            // pWitchBrowser
            // 
            this.pWitchBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pWitchBrowser.Location = new System.Drawing.Point(0, 50);
            this.pWitchBrowser.Name = "pWitchBrowser";
            this.pWitchBrowser.Size = new System.Drawing.Size(748, 301);
            this.pWitchBrowser.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(316, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Выполнить следующий запрос?";
            // 
            // xbtnExecute
            // 
            this.xbtnExecute.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.xbtnExecute.BackgroundColor = System.Drawing.Color.White;
            this.xbtnExecute.ButtonImage = ((System.Drawing.Image)(resources.GetObject("xbtnExecute.ButtonImage")));
            this.xbtnExecute.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.xbtnExecute.ButtonText = "Выполнить запрос";
            this.xbtnExecute.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.xbtnExecute.ClickTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.xbtnExecute.CornerRadius = 5;
            this.xbtnExecute.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.xbtnExecute.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.xbtnExecute.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.xbtnExecute.HoverTextColor = System.Drawing.Color.White;
            this.xbtnExecute.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.xbtnExecute.Location = new System.Drawing.Point(485, 11);
            this.xbtnExecute.Name = "xbtnExecute";
            this.xbtnExecute.Size = new System.Drawing.Size(236, 28);
            this.xbtnExecute.TabIndex = 5;
            this.xbtnExecute.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(119)))), ((int)(((byte)(215)))));
            this.xbtnExecute.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.xbtnExecute.Click += new System.EventHandler(this.xbtnExecute_Click);
            // 
            // ExecuteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 351);
            this.Controls.Add(this.pWitchBrowser);
            this.Controls.Add(this.pTop);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ExecuteForm";
            this.Text = "Выполнить";
            this.Load += new System.EventHandler(this.ExecuteForm_Load);
            this.pTop.ResumeLayout(false);
            this.pTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pTop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pWitchBrowser;
        private XanderUI.XUIButton xbtnExecute;
    }
}