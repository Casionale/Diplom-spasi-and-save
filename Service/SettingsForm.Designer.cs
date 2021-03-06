﻿namespace Diplom2.Service
{
    partial class SettingsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
            this.tbMaxQuestions = new System.Windows.Forms.TextBox();
            this.lblScore = new System.Windows.Forms.Label();
            this.cbShowAnswer = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbTimeText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbTimeCheck = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbTimeRadio = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbPathContent = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDialog = new System.Windows.Forms.Button();
            this.cbShowMenu = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tbDefaultDBUser = new System.Windows.Forms.TextBox();
            this.tbDefaultDBPassword = new System.Windows.Forms.TextBox();
            this.tbDefaultDBServer = new System.Windows.Forms.TextBox();
            this.tbDefaultDBName = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbMaxQuestions
            // 
            this.tbMaxQuestions.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbMaxQuestions.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(119)))), ((int)(((byte)(215)))));
            this.tbMaxQuestions.Location = new System.Drawing.Point(302, 34);
            this.tbMaxQuestions.Name = "tbMaxQuestions";
            this.tbMaxQuestions.Size = new System.Drawing.Size(204, 29);
            this.tbMaxQuestions.TabIndex = 1;
            this.tbMaxQuestions.Text = "10";
            // 
            // lblScore
            // 
            this.lblScore.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblScore.AutoSize = true;
            this.lblScore.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblScore.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblScore.Location = new System.Drawing.Point(12, 34);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(284, 25);
            this.lblScore.TabIndex = 2;
            this.lblScore.Text = "Количество вопросов в тестах";
            // 
            // cbShowAnswer
            // 
            this.cbShowAnswer.AutoSize = true;
            this.cbShowAnswer.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbShowAnswer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.cbShowAnswer.Location = new System.Drawing.Point(538, 35);
            this.cbShowAnswer.Name = "cbShowAnswer";
            this.cbShowAnswer.Size = new System.Drawing.Size(220, 29);
            this.cbShowAnswer.TabIndex = 4;
            this.cbShowAnswer.Text = "Показ ответов в тестах";
            this.cbShowAnswer.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(19, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(265, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Время на вопросы с вводом";
            // 
            // tbTimeText
            // 
            this.tbTimeText.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbTimeText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(119)))), ((int)(((byte)(215)))));
            this.tbTimeText.Location = new System.Drawing.Point(24, 56);
            this.tbTimeText.Name = "tbTimeText";
            this.tbTimeText.Size = new System.Drawing.Size(260, 29);
            this.tbTimeText.TabIndex = 5;
            this.tbTimeText.Text = "90";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(19, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(428, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "Время на вопросы с множественным выбором";
            // 
            // tbTimeCheck
            // 
            this.tbTimeCheck.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbTimeCheck.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(119)))), ((int)(((byte)(215)))));
            this.tbTimeCheck.Location = new System.Drawing.Point(24, 198);
            this.tbTimeCheck.Name = "tbTimeCheck";
            this.tbTimeCheck.Size = new System.Drawing.Size(260, 29);
            this.tbTimeCheck.TabIndex = 7;
            this.tbTimeCheck.Text = "60";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(19, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(414, 25);
            this.label3.TabIndex = 10;
            this.label3.Text = "Время на вопросы с единственным выбором";
            // 
            // tbTimeRadio
            // 
            this.tbTimeRadio.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbTimeRadio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(119)))), ((int)(((byte)(215)))));
            this.tbTimeRadio.Location = new System.Drawing.Point(24, 126);
            this.tbTimeRadio.Name = "tbTimeRadio";
            this.tbTimeRadio.Size = new System.Drawing.Size(260, 29);
            this.tbTimeRadio.TabIndex = 9;
            this.tbTimeRadio.Text = "45";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tbTimeText);
            this.groupBox1.Controls.Add(this.tbTimeRadio);
            this.groupBox1.Controls.Add(this.tbTimeCheck);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(119)))), ((int)(((byte)(215)))));
            this.groupBox1.Location = new System.Drawing.Point(12, 79);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(494, 237);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Время тестирования";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(12, 330);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(239, 25);
            this.label4.TabIndex = 13;
            this.label4.Text = "Путь к папке доп контента";
            // 
            // tbPathContent
            // 
            this.tbPathContent.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbPathContent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(119)))), ((int)(((byte)(215)))));
            this.tbPathContent.Location = new System.Drawing.Point(269, 332);
            this.tbPathContent.Name = "tbPathContent";
            this.tbPathContent.Size = new System.Drawing.Size(456, 22);
            this.tbPathContent.TabIndex = 12;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.White;
            this.btnSave.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(119)))), ((int)(((byte)(215)))));
            this.btnSave.Location = new System.Drawing.Point(17, 409);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(157, 32);
            this.btnSave.TabIndex = 14;
            this.btnSave.Text = "Сохранить изменения";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDialog
            // 
            this.btnDialog.BackColor = System.Drawing.Color.White;
            this.btnDialog.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDialog.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(119)))), ((int)(((byte)(215)))));
            this.btnDialog.Location = new System.Drawing.Point(725, 332);
            this.btnDialog.Name = "btnDialog";
            this.btnDialog.Size = new System.Drawing.Size(23, 23);
            this.btnDialog.TabIndex = 15;
            this.btnDialog.UseVisualStyleBackColor = false;
            // 
            // cbShowMenu
            // 
            this.cbShowMenu.AutoSize = true;
            this.cbShowMenu.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbShowMenu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.cbShowMenu.Location = new System.Drawing.Point(538, 70);
            this.cbShowMenu.Name = "cbShowMenu";
            this.cbShowMenu.Size = new System.Drawing.Size(224, 27);
            this.cbShowMenu.TabIndex = 16;
            this.cbShowMenu.Text = "Показ меню главного окна";
            this.cbShowMenu.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbDefaultDBName);
            this.groupBox2.Controls.Add(this.tbDefaultDBServer);
            this.groupBox2.Controls.Add(this.tbDefaultDBPassword);
            this.groupBox2.Controls.Add(this.tbDefaultDBUser);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(119)))), ((int)(((byte)(215)))));
            this.groupBox2.Location = new System.Drawing.Point(538, 107);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(224, 209);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Стандартная БД";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(6, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "User";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label6.Location = new System.Drawing.Point(6, 70);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 16);
            this.label6.TabIndex = 8;
            this.label6.Text = "Password";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label7.Location = new System.Drawing.Point(6, 162);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 16);
            this.label7.TabIndex = 10;
            this.label7.Text = "DB Name";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label8.Location = new System.Drawing.Point(6, 120);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 16);
            this.label8.TabIndex = 9;
            this.label8.Text = "Server";
            // 
            // tbDefaultDBUser
            // 
            this.tbDefaultDBUser.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbDefaultDBUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(119)))), ((int)(((byte)(215)))));
            this.tbDefaultDBUser.Location = new System.Drawing.Point(9, 45);
            this.tbDefaultDBUser.Name = "tbDefaultDBUser";
            this.tbDefaultDBUser.Size = new System.Drawing.Size(209, 22);
            this.tbDefaultDBUser.TabIndex = 11;
            this.tbDefaultDBUser.Text = "root";
            // 
            // tbDefaultDBPassword
            // 
            this.tbDefaultDBPassword.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbDefaultDBPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(119)))), ((int)(((byte)(215)))));
            this.tbDefaultDBPassword.Location = new System.Drawing.Point(8, 93);
            this.tbDefaultDBPassword.Name = "tbDefaultDBPassword";
            this.tbDefaultDBPassword.Size = new System.Drawing.Size(209, 22);
            this.tbDefaultDBPassword.TabIndex = 12;
            // 
            // tbDefaultDBServer
            // 
            this.tbDefaultDBServer.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbDefaultDBServer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(119)))), ((int)(((byte)(215)))));
            this.tbDefaultDBServer.Location = new System.Drawing.Point(8, 139);
            this.tbDefaultDBServer.Name = "tbDefaultDBServer";
            this.tbDefaultDBServer.Size = new System.Drawing.Size(209, 22);
            this.tbDefaultDBServer.TabIndex = 13;
            // 
            // tbDefaultDBName
            // 
            this.tbDefaultDBName.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbDefaultDBName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(119)))), ((int)(((byte)(215)))));
            this.tbDefaultDBName.Location = new System.Drawing.Point(6, 181);
            this.tbDefaultDBName.Name = "tbDefaultDBName";
            this.tbDefaultDBName.Size = new System.Drawing.Size(209, 22);
            this.tbDefaultDBName.TabIndex = 14;
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(770, 453);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.cbShowMenu);
            this.Controls.Add(this.btnDialog);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbPathContent);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cbShowAnswer);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.tbMaxQuestions);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SettingsForm";
            this.Text = "Настройки приложения";
            this.Load += new System.EventHandler(this.SettingsForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbMaxQuestions;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.CheckBox cbShowAnswer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbTimeText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbTimeCheck;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbTimeRadio;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbPathContent;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDialog;
        private System.Windows.Forms.CheckBox cbShowMenu;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbDefaultDBName;
        private System.Windows.Forms.TextBox tbDefaultDBServer;
        private System.Windows.Forms.TextBox tbDefaultDBPassword;
        private System.Windows.Forms.TextBox tbDefaultDBUser;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
    }
}