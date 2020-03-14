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
    public partial class FormWork : Form
    {
        List<User> Users { get; set; }
        User CurrentUser { get; set; }
        public FormWork(List<User> users, User currentUser)
        {
            InitializeComponent();

            Users = users;

            // Устанавливаем ссылку текущего пользователя на список со всеми пользователями
            foreach(User user in users)
                if (user == currentUser)
                    CurrentUser = user;

            if (currentUser.Name != "Admin")
            {
                tabPage2.Parent = null;

                if (currentUser.TempPassword)
                {
                    groupBox_PA_FuncUser.Visible = false;
                    if(currentUser.PasswordLimit)
                        MessageBox.Show("Поставлены ограничения на пароль!\nДо смены пароля функционал не доступен!");
                    else
                        MessageBox.Show("У вас установлен временный пароль!\nДо смены пароля функционал не доступен!");
                }
            }
            else
                listBox_A_UsersList.DataSource = Users;
        }

        private void FormWork_FormClosed(object sender, FormClosedEventArgs e)
        {
            string db = string.Empty;

            if (CurrentUser.Name != "Admin")
                foreach (User user in Users)
                {
                    if (user.Name != "Admin")
                        db += "\n" + user.Name + " " + user.Password + " " + user.PasswordLimit + " " + user.Lock + " " + user.TempPassword;
                    else
                        db += user.Name + " " + user.Password + " " + "False" + " " + "False" + " " + "False";
                }
            else
                foreach (User user in listBox_A_UsersList.Items)
                {
                    if (user.Name != "Admin")
                        db += "\n" + user.Name + " " + user.Password + " " + user.PasswordLimit + " " + user.Lock + " " + user.TempPassword;
                    else
                        db += user.Name + " " + user.Password + " " + "False" + " " + "False" + " " + "False";
                }

            File.WriteAllBytes(Environment.CurrentDirectory + "\\db.txt", RC4.R4EncoderText(Form_Authorization.Key, Encoding.Unicode.GetBytes(db)));

            if (DialogResult != DialogResult.Retry)
                DialogResult = DialogResult.OK;
        }

        

        //########### КОД ЛИЧНОГО КАБИНЕТА ###########

        private void button_PA_ExitProfile_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Retry;
        }

        private void button_PA_ChangePassword_Click(object sender, EventArgs e)
        {
            if (textBox_PA_OldPassword.Text == CurrentUser.Password)
                if (textBox_PA_NewPassword.Text == textBox_PA_ReturnNewPassword.Text)
                {
                    CurrentUser.Password = textBox_PA_NewPassword.Text;
                    CurrentUser.TempPassword = false;
                    MessageBox.Show("Новый пароль установлен!");
                }
                else
                    MessageBox.Show("Новые пароли не совпадают!");
            else
                MessageBox.Show("Не верно введён старый пароль!");

            textBox_PA_OldPassword.Text = string.Empty;
            textBox_PA_NewPassword.Text = string.Empty;
            textBox_PA_ReturnNewPassword.Text = string.Empty;

            groupBox_PA_FuncUser.Visible = true;

        }

        private void textBox_PA_NewPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (CurrentUser.PasswordLimit)
                if (!((e.KeyChar >= 48 && e.KeyChar <= 57) || (e.KeyChar >= 65 && e.KeyChar <= 90)
                    || (e.KeyChar >= 97 && e.KeyChar <= 122) || (e.KeyChar >= 'А' && e.KeyChar <= 'я') || e.KeyChar == 8))
                {
                    e.Handled = true;
                }
        }

        //########### КОД ПАНЕЛИ АДМИНИСТРАТОРА ###########

        private void button_A_ChangePassword_Click(object sender, EventArgs e)
        {
            if (textBox_A_NewPassword.Text != textBox_A_ReturnNewPassword.Text)
            {
                MessageBox.Show("Новые пароли не совпадают!");
            }
            else
            {
                User user = (User)listBox_A_UsersList.SelectedItem;
                foreach (User u in listBox_A_UsersList.Items)
                {
                    if (u.Name == user.Name)
                    {
                        u.Password = textBox_A_NewPassword.Text;
                        u.TempPassword = true;
                        break;
                    }
                }

                MessageBox.Show("Пароль успешно изменён!");
            }

            textBox_A_NewPassword.Text = "";
            textBox_A_ReturnNewPassword.Text = "";
        }

        private void listBox_A_UsersList_SelectedIndexChanged(object sender, EventArgs e)
        {
            User user = (User)listBox_A_UsersList.SelectedItem;

            if(user.Name == "Admin")
            {
                groupBox_A_SelectedUser.Enabled = false;
                groupBox_A_TempPassword.Enabled = false;
            }
            else
            {
                groupBox_A_SelectedUser.Enabled = true;
                groupBox_A_TempPassword.Enabled = true;
            }

            if (user.PasswordLimit)
                checkBox_A_PasswordLimit.Checked = true;
            else
                checkBox_A_PasswordLimit.Checked = false;

            if (user.Lock)
                button_A_LockUser.Text = "Разблокировать";
            else
                button_A_LockUser.Text = "Заблокировать";

        }

        private void button_A_NewUser_Click(object sender, EventArgs e)
        {
            if(textBox_A_NameNewUser.Text == string.Empty)
            {
                MessageBox.Show("Логин не может быть пустым!");
                return;
            }

            User newUser = new User(textBox_A_NameNewUser.Text, string.Empty, false, false, true);

            int index = listBox_A_UsersList.SelectedIndex;
            List<User> users = new List<User>();

            foreach (User u in listBox_A_UsersList.Items)
            {
                if (u.Name == newUser.Name)
                {
                    MessageBox.Show("Пользователь с таким именем уже существует!");
                    listBox_A_UsersList.SelectedIndex = index;
                }
                users.Add(u);
            }
            users.Add(newUser);
            listBox_A_UsersList.DataSource = users;
            listBox_A_UsersList.SelectedIndex = listBox_A_UsersList.Items.Count - 1;
            textBox_A_NameNewUser.Text = "";
        }

        private void button_A_LockUser_Click(object sender, EventArgs e)
        {
            User user = (User)listBox_A_UsersList.SelectedItem;
            List<User> users = new List<User>();
            int currentIndex = 0;
            int needIndex = 0;

            foreach (User u in listBox_A_UsersList.Items)
            {
                if (u.Name == user.Name)
                {
                    if (u.Lock == true)
                    {
                        u.Lock = false;
                        button_A_LockUser.Text = "Заблокировать";
                    }
                    else
                    {
                        u.Lock = true;
                        button_A_LockUser.Text = "Разблокировать";
                    }
                    needIndex = currentIndex;
                }
                users.Add(u);
                currentIndex++;
            }

            listBox_A_UsersList.DataSource = users;
            listBox_A_UsersList.SelectedIndex = needIndex;
        }

        private void checkBox_A_PasswordLimit_CheckedChanged(object sender, EventArgs e)
        {
            User user = (User)listBox_A_UsersList.SelectedItem;

            foreach (User u in listBox_A_UsersList.Items)
            {
                if (u.Name == user.Name)
                {


                    if (checkBox_A_PasswordLimit.Checked == true)
                    {
                        u.PasswordLimit = true;
                        u.TempPassword = true;
                    }
                    else
                    {
                        u.PasswordLimit = false;
                        u.TempPassword = false;
                    }
                    return;
                }
            }
        }
    }
}
