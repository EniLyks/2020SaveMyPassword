using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2020SaveMyPassword_v2
{
    public partial class Form_PasswordFromDb : Form
    {
        public string Password { get; set; } = "123";

        public Form_PasswordFromDb()
        {
            InitializeComponent();
        }

        private void button_Ok_Click(object sender, EventArgs e)
        {
            if (textBox_Password.Text == Password)
                DialogResult = DialogResult.OK;
            else
                DialogResult = DialogResult.No;

        }
    }
}
