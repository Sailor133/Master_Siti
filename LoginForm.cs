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
        private void exitButton_MouseEnter(object sender, EventArgs e)
        {
            exitButton.BackColor = Color.Red; // iskl
        }

        private void exitButton_MouseLeave(object sender, EventArgs e)
        {
            exitButton.BackColor = Color.FromArgb(255, 18, 25, 49);
        }


        private void LoginFild_Enter(object sender, EventArgs e)
        {
            if (LoginFild.Text == "Логин...")
            {
                LoginFild.ForeColor = Color.Black;
                LoginFild.Text = "";
            }

        }

        private void LoginFild_Leave(object sender, EventArgs e)
        {
            if (LoginFild.Text == "")
            {
                LoginFild.Text = "Логин...";
                LoginFild.ForeColor = Color.Gray;
            }

        }
    }
}
