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

namespace ExampleSQLApp
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Проверка");
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            String loginUser = inputLogin.Text;
            String passUser = inputPass.Text;

            User user = new User();

            bool authorized = user.Authorize(loginUser, passUser);

            if (authorized)
            {
                this.Hide();
                AdminPanel ap = new AdminPanel();
                ap.Show();

            } 
            else
                MessageBox.Show("Авторизация не совершена!");

        }
    }
}
