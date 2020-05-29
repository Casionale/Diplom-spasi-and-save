namespace Diplom2.Constructor
{
    partial class DBConnectionForm
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
            this.tbLoginWitchBD = new System.Windows.Forms.TextBox();
            this.tbPasswordWitchDB = new System.Windows.Forms.TextBox();
            this.tbNameDB = new System.Windows.Forms.TextBox();
            this.tbServerNameWitchDB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Пароль = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnConnection = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbLoginWitchBD
            // 
            this.tbLoginWitchBD.Location = new System.Drawing.Point(242, 48);
            this.tbLoginWitchBD.Name = "tbLoginWitchBD";
            this.tbLoginWitchBD.Size = new System.Drawing.Size(213, 20);
            this.tbLoginWitchBD.TabIndex = 0;
            this.tbLoginWitchBD.Text = "root";
            // 
            // tbPasswordWitchDB
            // 
            this.tbPasswordWitchDB.Location = new System.Drawing.Point(242, 75);
            this.tbPasswordWitchDB.Name = "tbPasswordWitchDB";
            this.tbPasswordWitchDB.Size = new System.Drawing.Size(213, 20);
            this.tbPasswordWitchDB.TabIndex = 1;
            // 
            // tbNameDB
            // 
            this.tbNameDB.Location = new System.Drawing.Point(242, 102);
            this.tbNameDB.Name = "tbNameDB";
            this.tbNameDB.Size = new System.Drawing.Size(213, 20);
            this.tbNameDB.TabIndex = 2;
            this.tbNameDB.Text = "заполнити .-.";
            // 
            // tbServerNameWitchDB
            // 
            this.tbServerNameWitchDB.Location = new System.Drawing.Point(242, 129);
            this.tbServerNameWitchDB.Name = "tbServerNameWitchDB";
            this.tbServerNameWitchDB.Size = new System.Drawing.Size(213, 20);
            this.tbServerNameWitchDB.TabIndex = 3;
            this.tbServerNameWitchDB.Text = "localhost";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Имя пользователя";
            // 
            // Пароль
            // 
            this.Пароль.AutoSize = true;
            this.Пароль.Location = new System.Drawing.Point(75, 78);
            this.Пароль.Name = "Пароль";
            this.Пароль.Size = new System.Drawing.Size(45, 13);
            this.Пароль.TabIndex = 5;
            this.Пароль.Text = "Пароль";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(75, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Имя БД (Потом будет выбор)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(75, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Сервер";
            // 
            // btnConnection
            // 
            this.btnConnection.Location = new System.Drawing.Point(166, 171);
            this.btnConnection.Name = "btnConnection";
            this.btnConnection.Size = new System.Drawing.Size(215, 23);
            this.btnConnection.TabIndex = 8;
            this.btnConnection.Text = "Попробовать присоединится";
            this.btnConnection.UseVisualStyleBackColor = true;
            this.btnConnection.Click += new System.EventHandler(this.btnConnection_Click);
            // 
            // DBConnectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 217);
            this.Controls.Add(this.btnConnection);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Пароль);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbServerNameWitchDB);
            this.Controls.Add(this.tbNameDB);
            this.Controls.Add(this.tbPasswordWitchDB);
            this.Controls.Add(this.tbLoginWitchBD);
            this.Name = "DBConnectionForm";
            this.Text = "DBConnectionForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbLoginWitchBD;
        private System.Windows.Forms.TextBox tbPasswordWitchDB;
        private System.Windows.Forms.TextBox tbNameDB;
        private System.Windows.Forms.TextBox tbServerNameWitchDB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Пароль;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnConnection;
    }
}