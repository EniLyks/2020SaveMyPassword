using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2020SaveMyPassword_v2
{
    public partial class Form_Authorization : Form
    {
        public const string Key = "123";
        int attempt = 3;

        public Form_Authorization()
        {
            InitializeComponent();
            List<User> users = new List<User>();
            
            if (!File.Exists(Environment.CurrentDirectory + "\\db.txt"))
                // ИмяПользователя Пароль ОграничениеНаПароль Блокировка ВременныйПароль
                File.WriteAllBytes(Environment.CurrentDirectory + "\\db.txt", RC4.R4EncoderText(Key, Encoding.Unicode.GetBytes("Admin admin False False False")));

            while (true)
            {
                if (new Form_PasswordFromDb().ShowDialog() == DialogResult.OK)
                {
                    break;
                }
                else
                {
                    MessageBox.Show("Ошибка доступа! Не верен пароль от БД!");
                }
            }

        }

        List<User> GetUsers()
        {
            List<User> users = new List<User>();
            foreach (string str in  RC4.R4DecoderText(Key, File.ReadAllBytes(Environment.CurrentDirectory + "\\db.txt")).Split('\n'))
            {
                string[] strSplit = str.Split(' ');
                bool passwordLimit = false;
                bool lockUser = false;
                bool tempPassword = false;

                if (strSplit[2] != "False")
                    passwordLimit = true;

                if (strSplit[3] != "False")
                    lockUser = true;

                if (strSplit[4] != "False")
                    tempPassword = true;

                users.Add(new User(strSplit[0], strSplit[1], passwordLimit, lockUser, tempPassword));
            }
            return users;
        }

        private void button_Entry_Click(object sender, EventArgs e)
        {
            bool entry = false;

            string Name = textBox_AuthorizationName.Text;
            string Password = textBox_AuthorizationPassword.Text;

            textBox_AuthorizationName.Text = string.Empty;
            textBox_AuthorizationPassword.Text = string.Empty;

            User currentUser = null;
            List<User> users = GetUsers();

            for (int i = 0; i < users.Count; i++)
            {
                if (users[i].Name == Name)
                    if (users[i].Password == Password)
                    {
                        currentUser = users[i];
                        entry = true;
                        break;
                    }
            }

            if (!entry)
            {
                attempt--;
                if (attempt > 0)
                    MessageBox.Show("Не верен логин или пароль!\nОсталось попыток: " + attempt);
                else
                {
                    MessageBox.Show("Не верен логин или пароль!\nУ вас исчерпаны попытки входа! Завершение программы.");
                    Application.Exit();
                }
                return;
            }

            attempt = 3;

            if (currentUser.Lock)
            {
                MessageBox.Show("Пользователь заблокирован! Обратитесь к администратору!");
                return;
            }

            this.Hide();

            DialogResult resultWork = new FormWork(users, currentUser).ShowDialog();

            if (resultWork == DialogResult.Retry)
                this.Show();
            else if (resultWork == DialogResult.OK)
                this.Close();


        }
    }
}
