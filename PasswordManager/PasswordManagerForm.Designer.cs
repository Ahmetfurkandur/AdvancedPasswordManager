
namespace PasswordManager
{
    partial class PasswordManagerForm
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
            this.dgwPasswords = new System.Windows.Forms.DataGridView();
            this.btnDeletePassword = new System.Windows.Forms.Button();
            this.btnCreatePassword = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.tbxAddPassword = new System.Windows.Forms.TextBox();
            this.tbxAddUsername = new System.Windows.Forms.TextBox();
            this.tbxAddPlatform = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblAddPlatform = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.tbxUpdatePassword = new System.Windows.Forms.TextBox();
            this.tbxUpdateUsername = new System.Windows.Forms.TextBox();
            this.tbxUpdatePlatform = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbxSearchByName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgwPasswords)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgwPasswords
            // 
            this.dgwPasswords.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwPasswords.Location = new System.Drawing.Point(12, 41);
            this.dgwPasswords.Name = "dgwPasswords";
            this.dgwPasswords.Size = new System.Drawing.Size(620, 370);
            this.dgwPasswords.TabIndex = 0;
            this.dgwPasswords.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwPasswords_CellClick);
            // 
            // btnDeletePassword
            // 
            this.btnDeletePassword.Location = new System.Drawing.Point(12, 12);
            this.btnDeletePassword.Name = "btnDeletePassword";
            this.btnDeletePassword.Size = new System.Drawing.Size(75, 23);
            this.btnDeletePassword.TabIndex = 1;
            this.btnDeletePassword.Text = "Şifreyi Sil";
            this.btnDeletePassword.UseVisualStyleBackColor = true;
            this.btnDeletePassword.Click += new System.EventHandler(this.btnDeletePassword_Click);
            // 
            // btnCreatePassword
            // 
            this.btnCreatePassword.Location = new System.Drawing.Point(104, 12);
            this.btnCreatePassword.Name = "btnCreatePassword";
            this.btnCreatePassword.Size = new System.Drawing.Size(75, 23);
            this.btnCreatePassword.TabIndex = 2;
            this.btnCreatePassword.Text = "Şifre Üret";
            this.btnCreatePassword.UseVisualStyleBackColor = true;
            this.btnCreatePassword.Click += new System.EventHandler(this.btnCreatePassword_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(821, 12);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Çıkış Yap";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.tbxAddPassword);
            this.groupBox1.Controls.Add(this.tbxAddUsername);
            this.groupBox1.Controls.Add(this.tbxAddPlatform);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lblAddPlatform);
            this.groupBox1.Location = new System.Drawing.Point(638, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(258, 176);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Şifre Ekle";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(97, 137);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Ekle";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // tbxAddPassword
            // 
            this.tbxAddPassword.Location = new System.Drawing.Point(137, 105);
            this.tbxAddPassword.Name = "tbxAddPassword";
            this.tbxAddPassword.Size = new System.Drawing.Size(100, 20);
            this.tbxAddPassword.TabIndex = 5;
            // 
            // tbxAddUsername
            // 
            this.tbxAddUsername.Location = new System.Drawing.Point(137, 67);
            this.tbxAddUsername.Name = "tbxAddUsername";
            this.tbxAddUsername.Size = new System.Drawing.Size(100, 20);
            this.tbxAddUsername.TabIndex = 4;
            // 
            // tbxAddPlatform
            // 
            this.tbxAddPlatform.Location = new System.Drawing.Point(137, 36);
            this.tbxAddPlatform.Name = "tbxAddPlatform";
            this.tbxAddPlatform.Size = new System.Drawing.Size(100, 20);
            this.tbxAddPlatform.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Şifre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Kullanıcı Adı";
            // 
            // lblAddPlatform
            // 
            this.lblAddPlatform.AutoSize = true;
            this.lblAddPlatform.Location = new System.Drawing.Point(40, 43);
            this.lblAddPlatform.Name = "lblAddPlatform";
            this.lblAddPlatform.Size = new System.Drawing.Size(45, 13);
            this.lblAddPlatform.TabIndex = 0;
            this.lblAddPlatform.Text = "Platform";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(277, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Platform Adına Göre Ara";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnUpdate);
            this.groupBox2.Controls.Add(this.tbxUpdatePassword);
            this.groupBox2.Controls.Add(this.tbxUpdateUsername);
            this.groupBox2.Controls.Add(this.tbxUpdatePlatform);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(639, 224);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(257, 187);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Şifreyi Güncelle";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(87, 132);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 13;
            this.btnUpdate.Text = "Güncelle";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // tbxUpdatePassword
            // 
            this.tbxUpdatePassword.Location = new System.Drawing.Point(127, 100);
            this.tbxUpdatePassword.Name = "tbxUpdatePassword";
            this.tbxUpdatePassword.Size = new System.Drawing.Size(100, 20);
            this.tbxUpdatePassword.TabIndex = 12;
            // 
            // tbxUpdateUsername
            // 
            this.tbxUpdateUsername.Location = new System.Drawing.Point(127, 62);
            this.tbxUpdateUsername.Name = "tbxUpdateUsername";
            this.tbxUpdateUsername.Size = new System.Drawing.Size(100, 20);
            this.tbxUpdateUsername.TabIndex = 11;
            // 
            // tbxUpdatePlatform
            // 
            this.tbxUpdatePlatform.Location = new System.Drawing.Point(127, 31);
            this.tbxUpdatePlatform.Name = "tbxUpdatePlatform";
            this.tbxUpdatePlatform.Size = new System.Drawing.Size(100, 20);
            this.tbxUpdatePlatform.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Şifre";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Kullanıcı Adı";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 38);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Platform";
            // 
            // tbxSearchByName
            // 
            this.tbxSearchByName.Location = new System.Drawing.Point(403, 13);
            this.tbxSearchByName.Name = "tbxSearchByName";
            this.tbxSearchByName.Size = new System.Drawing.Size(154, 20);
            this.tbxSearchByName.TabIndex = 7;
            this.tbxSearchByName.TextChanged += new System.EventHandler(this.tbxSearchByName_TextChanged);
            // 
            // PasswordManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(902, 419);
            this.Controls.Add(this.tbxSearchByName);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCreatePassword);
            this.Controls.Add(this.btnDeletePassword);
            this.Controls.Add(this.dgwPasswords);
            this.Name = "PasswordManagerForm";
            this.Text = "PasswordManager";
            this.Load += new System.EventHandler(this.PasswordManagerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwPasswords)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwPasswords;
        private System.Windows.Forms.Button btnDeletePassword;
        private System.Windows.Forms.Button btnCreatePassword;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbxAddPassword;
        private System.Windows.Forms.TextBox tbxAddUsername;
        private System.Windows.Forms.TextBox tbxAddPlatform;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblAddPlatform;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox tbxUpdatePassword;
        private System.Windows.Forms.TextBox tbxUpdateUsername;
        private System.Windows.Forms.TextBox tbxUpdatePlatform;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbxSearchByName;
    }
}