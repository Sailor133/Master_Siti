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