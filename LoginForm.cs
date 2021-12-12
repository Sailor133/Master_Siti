using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class LoginForm : System.Windows.Forms.Form
    {

        public LoginForm()
        {
            InitializeComponent();
            LoginFild.Text = "Логин...";
            LoginFild.ForeColor = Color.Gray;
            PasswordFild.ForeColor = Color.Gray;
            PasswordFild.Text = "Пароль...";
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}