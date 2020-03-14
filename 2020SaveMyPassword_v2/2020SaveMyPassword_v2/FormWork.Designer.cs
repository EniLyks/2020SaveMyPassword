namespace _2020SaveMyPassword_v2
{
    partial class FormWork
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox_PA_FuncUser = new System.Windows.Forms.GroupBox();
            this.button_PA_ExitProfile = new System.Windows.Forms.Button();
            this.groupBox_PA_ChangePassword = new System.Windows.Forms.GroupBox();
            this.button_PA_ChangePassword = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_PA_OldPassword = new System.Windows.Forms.TextBox();
            this.textBox_PA_ReturnNewPassword = new System.Windows.Forms.TextBox();
            this.textBox_PA_NewPassword = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox_Administration = new System.Windows.Forms.GroupBox();
            this.groupBox_A_SelectedUser = new System.Windows.Forms.GroupBox();
            this.checkBox_A_PasswordLimit = new System.Windows.Forms.CheckBox();
            this.button_A_LockUser = new System.Windows.Forms.Button();
            this.groupBox_A_TempPassword = new System.Windows.Forms.GroupBox();
            this.button_A_ChangePassword = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_A_ReturnNewPassword = new System.Windows.Forms.TextBox();
            this.textBox_A_NewPassword = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.textBox_A_NameNewUser = new System.Windows.Forms.TextBox();
            this.button_A_NewUser = new System.Windows.Forms.Button();
            this.listBox_A_UsersList = new System.Windows.Forms.ListBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox_PA_FuncUser.SuspendLayout();
            this.groupBox_PA_ChangePassword.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox_Administration.SuspendLayout();
            this.groupBox_A_SelectedUser.SuspendLayout();
            this.groupBox_A_TempPassword.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(13, 13);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(621, 425);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox_PA_FuncUser);
            this.tabPage1.Controls.Add(this.groupBox_PA_ChangePassword);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(613, 396);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Личный кабинет";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox_PA_FuncUser
            // 
            this.groupBox_PA_FuncUser.Controls.Add(this.button_PA_ExitProfile);
            this.groupBox_PA_FuncUser.Location = new System.Drawing.Point(4, 120);
            this.groupBox_PA_FuncUser.Name = "groupBox_PA_FuncUser";
            this.groupBox_PA_FuncUser.Size = new System.Drawing.Size(603, 270);
            this.groupBox_PA_FuncUser.TabIndex = 6;
            this.groupBox_PA_FuncUser.TabStop = false;
            this.groupBox_PA_FuncUser.Text = "Функционал пользователя";
            // 
            // button_PA_ExitProfile
            // 
            this.button_PA_ExitProfile.Location = new System.Drawing.Point(76, 38);
            this.button_PA_ExitProfile.Name = "button_PA_ExitProfile";
            this.button_PA_ExitProfile.Size = new System.Drawing.Size(428, 195);
            this.button_PA_ExitProfile.TabIndex = 0;
            this.button_PA_ExitProfile.Text = "Выйти из профиля";
            this.button_PA_ExitProfile.UseVisualStyleBackColor = true;
            this.button_PA_ExitProfile.Click += new System.EventHandler(this.button_PA_ExitProfile_Click);
            // 
            // groupBox_PA_ChangePassword
            // 
            this.groupBox_PA_ChangePassword.Controls.Add(this.button_PA_ChangePassword);
            this.groupBox_PA_ChangePassword.Controls.Add(this.label3);
            this.groupBox_PA_ChangePassword.Controls.Add(this.label5);
            this.groupBox_PA_ChangePassword.Controls.Add(this.label4);
            this.groupBox_PA_ChangePassword.Controls.Add(this.textBox_PA_OldPassword);
            this.groupBox_PA_ChangePassword.Controls.Add(this.textBox_PA_ReturnNewPassword);
            this.groupBox_PA_ChangePassword.Controls.Add(this.textBox_PA_NewPassword);
            this.groupBox_PA_ChangePassword.Location = new System.Drawing.Point(6, 6);
            this.groupBox_PA_ChangePassword.Name = "groupBox_PA_ChangePassword";
            this.groupBox_PA_ChangePassword.Size = new System.Drawing.Size(601, 107);
            this.groupBox_PA_ChangePassword.TabIndex = 5;
            this.groupBox_PA_ChangePassword.TabStop = false;
            this.groupBox_PA_ChangePassword.Text = "Смена пароля";
            // 
            // button_PA_ChangePassword
            // 
            this.button_PA_ChangePassword.Location = new System.Drawing.Point(9, 68);
            this.button_PA_ChangePassword.Name = "button_PA_ChangePassword";
            this.button_PA_ChangePassword.Size = new System.Drawing.Size(586, 27);
            this.button_PA_ChangePassword.TabIndex = 4;
            this.button_PA_ChangePassword.Text = "Изменить";
            this.button_PA_ChangePassword.UseVisualStyleBackColor = true;
            this.button_PA_ChangePassword.Click += new System.EventHandler(this.button_PA_ChangePassword_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(456, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Повторить";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(55, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 17);
            this.label5.TabIndex = 2;
            this.label5.Text = "Старый пароль";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(245, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Новый пароль";
            // 
            // textBox_PA_OldPassword
            // 
            this.textBox_PA_OldPassword.Location = new System.Drawing.Point(9, 40);
            this.textBox_PA_OldPassword.Name = "textBox_PA_OldPassword";
            this.textBox_PA_OldPassword.PasswordChar = '*';
            this.textBox_PA_OldPassword.Size = new System.Drawing.Size(191, 22);
            this.textBox_PA_OldPassword.TabIndex = 0;
            // 
            // textBox_PA_ReturnNewPassword
            // 
            this.textBox_PA_ReturnNewPassword.Location = new System.Drawing.Point(404, 40);
            this.textBox_PA_ReturnNewPassword.Name = "textBox_PA_ReturnNewPassword";
            this.textBox_PA_ReturnNewPassword.PasswordChar = '*';
            this.textBox_PA_ReturnNewPassword.Size = new System.Drawing.Size(191, 22);
            this.textBox_PA_ReturnNewPassword.TabIndex = 1;
            this.textBox_PA_ReturnNewPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_PA_NewPassword_KeyPress);
            // 
            // textBox_PA_NewPassword
            // 
            this.textBox_PA_NewPassword.Location = new System.Drawing.Point(206, 40);
            this.textBox_PA_NewPassword.Name = "textBox_PA_NewPassword";
            this.textBox_PA_NewPassword.PasswordChar = '*';
            this.textBox_PA_NewPassword.Size = new System.Drawing.Size(191, 22);
            this.textBox_PA_NewPassword.TabIndex = 0;
            this.textBox_PA_NewPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_PA_NewPassword_KeyPress);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox_Administration);
            this.tabPage2.Controls.Add(this.listBox_A_UsersList);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(613, 396);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Администрирование";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox_Administration
            // 
            this.groupBox_Administration.Controls.Add(this.groupBox_A_SelectedUser);
            this.groupBox_Administration.Controls.Add(this.groupBox_A_TempPassword);
            this.groupBox_Administration.Controls.Add(this.groupBox5);
            this.groupBox_Administration.Location = new System.Drawing.Point(292, 7);
            this.groupBox_Administration.Name = "groupBox_Administration";
            this.groupBox_Administration.Size = new System.Drawing.Size(304, 297);
            this.groupBox_Administration.TabIndex = 5;
            this.groupBox_Administration.TabStop = false;
            this.groupBox_Administration.Text = "Администрирование пользователей";
            // 
            // groupBox_A_SelectedUser
            // 
            this.groupBox_A_SelectedUser.Controls.Add(this.checkBox_A_PasswordLimit);
            this.groupBox_A_SelectedUser.Controls.Add(this.button_A_LockUser);
            this.groupBox_A_SelectedUser.Location = new System.Drawing.Point(6, 93);
            this.groupBox_A_SelectedUser.Name = "groupBox_A_SelectedUser";
            this.groupBox_A_SelectedUser.Size = new System.Drawing.Size(289, 72);
            this.groupBox_A_SelectedUser.TabIndex = 7;
            this.groupBox_A_SelectedUser.TabStop = false;
            this.groupBox_A_SelectedUser.Text = "Выделенный пользователь";
            // 
            // checkBox_A_PasswordLimit
            // 
            this.checkBox_A_PasswordLimit.AutoSize = true;
            this.checkBox_A_PasswordLimit.Location = new System.Drawing.Point(7, 30);
            this.checkBox_A_PasswordLimit.Name = "checkBox_A_PasswordLimit";
            this.checkBox_A_PasswordLimit.Size = new System.Drawing.Size(118, 21);
            this.checkBox_A_PasswordLimit.TabIndex = 5;
            this.checkBox_A_PasswordLimit.Text = "Ограничение";
            this.checkBox_A_PasswordLimit.UseVisualStyleBackColor = true;
            this.checkBox_A_PasswordLimit.CheckedChanged += new System.EventHandler(this.checkBox_A_PasswordLimit_CheckedChanged);
            // 
            // button_A_LockUser
            // 
            this.button_A_LockUser.Location = new System.Drawing.Point(131, 24);
            this.button_A_LockUser.Name = "button_A_LockUser";
            this.button_A_LockUser.Size = new System.Drawing.Size(147, 31);
            this.button_A_LockUser.TabIndex = 4;
            this.button_A_LockUser.Text = "Заблокировать";
            this.button_A_LockUser.UseVisualStyleBackColor = true;
            this.button_A_LockUser.Click += new System.EventHandler(this.button_A_LockUser_Click);
            // 
            // groupBox_A_TempPassword
            // 
            this.groupBox_A_TempPassword.Controls.Add(this.button_A_ChangePassword);
            this.groupBox_A_TempPassword.Controls.Add(this.label2);
            this.groupBox_A_TempPassword.Controls.Add(this.label1);
            this.groupBox_A_TempPassword.Controls.Add(this.textBox_A_ReturnNewPassword);
            this.groupBox_A_TempPassword.Controls.Add(this.textBox_A_NewPassword);
            this.groupBox_A_TempPassword.Location = new System.Drawing.Point(6, 171);
            this.groupBox_A_TempPassword.Name = "groupBox_A_TempPassword";
            this.groupBox_A_TempPassword.Size = new System.Drawing.Size(289, 118);
            this.groupBox_A_TempPassword.TabIndex = 4;
            this.groupBox_A_TempPassword.TabStop = false;
            this.groupBox_A_TempPassword.Text = "Установка временного пароля";
            // 
            // button_A_ChangePassword
            // 
            this.button_A_ChangePassword.Location = new System.Drawing.Point(120, 85);
            this.button_A_ChangePassword.Name = "button_A_ChangePassword";
            this.button_A_ChangePassword.Size = new System.Drawing.Size(159, 27);
            this.button_A_ChangePassword.TabIndex = 4;
            this.button_A_ChangePassword.Text = "Изменить";
            this.button_A_ChangePassword.UseVisualStyleBackColor = true;
            this.button_A_ChangePassword.Click += new System.EventHandler(this.button_A_ChangePassword_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Повторить";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Новый пароль";
            // 
            // textBox_A_ReturnNewPassword
            // 
            this.textBox_A_ReturnNewPassword.Location = new System.Drawing.Point(121, 53);
            this.textBox_A_ReturnNewPassword.Name = "textBox_A_ReturnNewPassword";
            this.textBox_A_ReturnNewPassword.PasswordChar = '*';
            this.textBox_A_ReturnNewPassword.Size = new System.Drawing.Size(158, 22);
            this.textBox_A_ReturnNewPassword.TabIndex = 1;
            // 
            // textBox_A_NewPassword
            // 
            this.textBox_A_NewPassword.Location = new System.Drawing.Point(121, 25);
            this.textBox_A_NewPassword.Name = "textBox_A_NewPassword";
            this.textBox_A_NewPassword.PasswordChar = '*';
            this.textBox_A_NewPassword.Size = new System.Drawing.Size(158, 22);
            this.textBox_A_NewPassword.TabIndex = 0;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.textBox_A_NameNewUser);
            this.groupBox5.Controls.Add(this.button_A_NewUser);
            this.groupBox5.Location = new System.Drawing.Point(6, 21);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(289, 66);
            this.groupBox5.TabIndex = 6;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Добавление пользователя";
            // 
            // textBox_A_NameNewUser
            // 
            this.textBox_A_NameNewUser.Location = new System.Drawing.Point(7, 26);
            this.textBox_A_NameNewUser.Name = "textBox_A_NameNewUser";
            this.textBox_A_NameNewUser.Size = new System.Drawing.Size(183, 22);
            this.textBox_A_NameNewUser.TabIndex = 3;
            // 
            // button_A_NewUser
            // 
            this.button_A_NewUser.Location = new System.Drawing.Point(196, 21);
            this.button_A_NewUser.Name = "button_A_NewUser";
            this.button_A_NewUser.Size = new System.Drawing.Size(88, 32);
            this.button_A_NewUser.TabIndex = 2;
            this.button_A_NewUser.Text = "Добавить";
            this.button_A_NewUser.UseVisualStyleBackColor = true;
            this.button_A_NewUser.Click += new System.EventHandler(this.button_A_NewUser_Click);
            // 
            // listBox_A_UsersList
            // 
            this.listBox_A_UsersList.DisplayMember = "DisplayName";
            this.listBox_A_UsersList.FormattingEnabled = true;
            this.listBox_A_UsersList.ItemHeight = 16;
            this.listBox_A_UsersList.Location = new System.Drawing.Point(7, 7);
            this.listBox_A_UsersList.Name = "listBox_A_UsersList";
            this.listBox_A_UsersList.Size = new System.Drawing.Size(279, 372);
            this.listBox_A_UsersList.TabIndex = 0;
            this.listBox_A_UsersList.SelectedIndexChanged += new System.EventHandler(this.listBox_A_UsersList_SelectedIndexChanged);
            // 
            // FormWork
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 450);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FormWork";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormWork";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormWork_FormClosed);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox_PA_FuncUser.ResumeLayout(false);
            this.groupBox_PA_ChangePassword.ResumeLayout(false);
            this.groupBox_PA_ChangePassword.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.groupBox_Administration.ResumeLayout(false);
            this.groupBox_A_SelectedUser.ResumeLayout(false);
            this.groupBox_A_SelectedUser.PerformLayout();
            this.groupBox_A_TempPassword.ResumeLayout(false);
            this.groupBox_A_TempPassword.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox_Administration;
        private System.Windows.Forms.GroupBox groupBox_A_SelectedUser;
        private System.Windows.Forms.CheckBox checkBox_A_PasswordLimit;
        private System.Windows.Forms.Button button_A_LockUser;
        private System.Windows.Forms.GroupBox groupBox_A_TempPassword;
        private System.Windows.Forms.Button button_A_ChangePassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_A_ReturnNewPassword;
        private System.Windows.Forms.TextBox textBox_A_NewPassword;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox textBox_A_NameNewUser;
        private System.Windows.Forms.Button button_A_NewUser;
        private System.Windows.Forms.ListBox listBox_A_UsersList;
        private System.Windows.Forms.GroupBox groupBox_PA_ChangePassword;
        private System.Windows.Forms.Button button_PA_ChangePassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_PA_OldPassword;
        private System.Windows.Forms.TextBox textBox_PA_ReturnNewPassword;
        private System.Windows.Forms.TextBox textBox_PA_NewPassword;
        private System.Windows.Forms.GroupBox groupBox_PA_FuncUser;
        private System.Windows.Forms.Button button_PA_ExitProfile;
    }
}