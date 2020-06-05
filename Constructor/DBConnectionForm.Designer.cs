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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DBConnectionForm));
            this.tbLoginWitchBD = new System.Windows.Forms.TextBox();
            this.tbPasswordWitchDB = new System.Windows.Forms.TextBox();
            this.tbServerNameWitchDB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Пароль = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnConnection = new System.Windows.Forms.Button();
            this.cbNames = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbLoginWitchBD
            // 
            this.tbLoginWitchBD.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbLoginWitchBD.Location = new System.Drawing.Point(196, 25);
            this.tbLoginWitchBD.Name = "tbLoginWitchBD";
            this.tbLoginWitchBD.Size = new System.Drawing.Size(305, 29);
            this.tbLoginWitchBD.TabIndex = 0;
            this.tbLoginWitchBD.Text = "root";
            // 
            // tbPasswordWitchDB
            // 
            this.tbPasswordWitchDB.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbPasswordWitchDB.Location = new System.Drawing.Point(196, 57);
            this.tbPasswordWitchDB.Name = "tbPasswordWitchDB";
            this.tbPasswordWitchDB.Size = new System.Drawing.Size(305, 29);
            this.tbPasswordWitchDB.TabIndex = 1;
            // 
            // tbServerNameWitchDB
            // 
            this.tbServerNameWitchDB.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbServerNameWitchDB.Location = new System.Drawing.Point(196, 89);
            this.tbServerNameWitchDB.Name = "tbServerNameWitchDB";
            this.tbServerNameWitchDB.Size = new System.Drawing.Size(305, 29);
            this.tbServerNameWitchDB.TabIndex = 3;
            this.tbServerNameWitchDB.Text = "localhost";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(20, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 22);
            this.label1.TabIndex = 4;
            this.label1.Text = "Имя пользователя";
            // 
            // Пароль
            // 
            this.Пароль.AutoSize = true;
            this.Пароль.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Пароль.Location = new System.Drawing.Point(20, 60);
            this.Пароль.Name = "Пароль";
            this.Пароль.Size = new System.Drawing.Size(76, 22);
            this.Пароль.TabIndex = 5;
            this.Пароль.Text = "Пароль";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(21, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 22);
            this.label3.TabIndex = 6;
            this.label3.Text = "Имя БД";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(20, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 22);
            this.label4.TabIndex = 7;
            this.label4.Text = "Сервер";
            // 
            // btnConnection
            // 
            this.btnConnection.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnConnection.Location = new System.Drawing.Point(123, 171);
            this.btnConnection.Name = "btnConnection";
            this.btnConnection.Size = new System.Drawing.Size(275, 34);
            this.btnConnection.TabIndex = 8;
            this.btnConnection.Text = "Попробовать присоединится";
            this.btnConnection.UseVisualStyleBackColor = true;
            this.btnConnection.Click += new System.EventHandler(this.btnConnection_Click);
            // 
            // cbNames
            // 
            this.cbNames.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbNames.FormattingEnabled = true;
            this.cbNames.Location = new System.Drawing.Point(281, 121);
            this.cbNames.Name = "cbNames";
            this.cbNames.Size = new System.Drawing.Size(220, 32);
            this.cbNames.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(196, 121);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(79, 34);
            this.button1.TabIndex = 10;
            this.button1.Text = "БД";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.tbServerNameWitchDB_TextChanged);
            // 
            // DBConnectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 217);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cbNames);
            this.Controls.Add(this.btnConnection);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Пароль);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbServerNameWitchDB);
            this.Controls.Add(this.tbPasswordWitchDB);
            this.Controls.Add(this.tbLoginWitchBD);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DBConnectionForm";
            this.Text = "Подключение";
            this.Load += new System.EventHandler(this.tbServerNameWitchDB_TextChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbLoginWitchBD;
        private System.Windows.Forms.TextBox tbPasswordWitchDB;
        private System.Windows.Forms.TextBox tbServerNameWitchDB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Пароль;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnConnection;
        private System.Windows.Forms.ComboBox cbNames;
        private System.Windows.Forms.Button button1;
    }
}