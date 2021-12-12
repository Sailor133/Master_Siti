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
<<<<<<< HEAD
<<<<<<< HEAD
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

     public partial class LoginForm : System.Windows.Forms.Form
    {
        private void exitButton_MouseEnter(object sender, EventArgs e)
        {
            exitButton.BackColor = Color.Red; // iskl // кнопка выхода
        }

        private void exitButton_MouseLeave(object sender, EventArgs e)
        {
            exitButton.BackColor = Color.FromArgb(255, 18, 25, 49); // кнопка заднего цвета 
        }


        private void LoginFild_Enter(object sender, EventArgs e)
        {
            if (LoginFild.Text == "Логин...") // логин форма
            {
                LoginFild.ForeColor = Color.Black;
                LoginFild.Text = "";
            }

        }

        private void LoginFild_Leave(object sender, EventArgs e)
        { 
            if (LoginFild.Text == "")           // серый цвет 
            {
                LoginFild.Text = "Логин...";
                LoginFild.ForeColor = Color.Gray;
            }
        }
    }
}
=======
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
        private void EnterButton_Click(object sender, EventArgs e)
        {
            String loginUser = LoginFild.Text;
            String passUser = PasswordFild.Text;

            DB db = new DB();
            DataTable tabel = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM users WHERE login = @uL and pass= @uP", db.getConnection());
            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = loginUser;
            command.Parameters.Add("@uP", MySqlDbType.VarChar).Value = passUser;
            adapter.SelectCommand = command;
            adapter.Fill(tabel);

            if (tabel.Rows.Count > 0)
            {
                this.Hide();
                MainForm mainForm = new MainForm();
                mainForm.Show();
            }

            else
                MessageBox.Show("Непрвильный логин или пароль");
        }
    }
}
>>>>>>> origin/Ilua
