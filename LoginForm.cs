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
    private void PasswordFild_Enter(object sender, EventArgs e)
    {
        if (PasswordFild.Text == "Пароль...")
        {
            PasswordFild.Text = "";
            PasswordFild.ForeColor = Color.Black;
        }

    }
    private void PasswordFild_Leave(object sender, EventArgs e)
    {
        if (PasswordFild.Text == "")
        {
            PasswordFild.Text = "Пароль...";
            PasswordFild.ForeColor = Color.Gray;
        }

    }
    Point lastPoint;
    private void label1_MouseMove(object sender, MouseEventArgs e)
    {
        if (e.Button == MouseButtons.Left)
        {
            this.Left += e.X - lastPoint.X;
            this.Top += e.Y - lastPoint.Y;
        }

        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }
    }
}
