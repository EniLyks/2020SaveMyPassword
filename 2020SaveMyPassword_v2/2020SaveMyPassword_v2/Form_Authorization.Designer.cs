namespace _2020SaveMyPassword_v2
{
    partial class Form_Authorization
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox_AuthorizationName = new System.Windows.Forms.TextBox();
            this.textBox_AuthorizationPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button_Entry = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox_AuthorizationName
            // 
            this.textBox_AuthorizationName.Location = new System.Drawing.Point(37, 40);
            this.textBox_AuthorizationName.Name = "textBox_AuthorizationName";
            this.textBox_AuthorizationName.Size = new System.Drawing.Size(254, 22);
            this.textBox_AuthorizationName.TabIndex = 0;
            // 
            // textBox_AuthorizationPassword
            // 
            this.textBox_AuthorizationPassword.Location = new System.Drawing.Point(37, 85);
            this.textBox_AuthorizationPassword.Name = "textBox_AuthorizationPassword";
            this.textBox_AuthorizationPassword.PasswordChar = '*';
            this.textBox_AuthorizationPassword.Size = new System.Drawing.Size(254, 22);
            this.textBox_AuthorizationPassword.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(136, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Логин";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(132, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Пароль";
            // 
            // button_Entry
            // 
            this.button_Entry.Location = new System.Drawing.Point(37, 129);
            this.button_Entry.Name = "button_Entry";
            this.button_Entry.Size = new System.Drawing.Size(254, 29);
            this.button_Entry.TabIndex = 3;
            this.button_Entry.Text = "Войти";
            this.button_Entry.UseVisualStyleBackColor = true;
            this.button_Entry.Click += new System.EventHandler(this.button_Entry_Click);
            // 
            // Form_Authorization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 180);
            this.Controls.Add(this.button_Entry);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_AuthorizationPassword);
            this.Controls.Add(this.textBox_AuthorizationName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_Authorization";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Авторизация";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_AuthorizationName;
        private System.Windows.Forms.TextBox textBox_AuthorizationPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_Entry;
    }
}

