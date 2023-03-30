using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using Taxi.Classes;

namespace Taxi.Forms
{
    public partial class SignInForm : ClassLibTaxi.FormParent
    {
        public static bool IsDriver = false;
        public static string ConnectionAdress = ConnectionString.strconn;

        public SignInForm()
        {
            InitializeComponent();
        }

        private void AnotherLogIN(object sender, MouseEventArgs e)
        {
            LAnotherLogin.ForeColor = SystemColors.HotTrack;
        }

        private void AnotherLogIOUT(object sender, EventArgs e)
        {
            LAnotherLogin.ForeColor = SystemColors.WindowFrame;
        }

        private void NonRegisteredIN(object sender, MouseEventArgs e)
        {
            LNonRegistered.ForeColor = SystemColors.HotTrack;
        }

        private void NonRegisteredOUT(object sender, EventArgs e)
        {
            LNonRegistered.ForeColor = SystemColors.WindowFrame;
        }

        private void LoginForm(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }

        private void ExitProgram(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        public static string GetHash(string password)
        { // шифрование
            using (var hash = SHA256.Create())
            {
                return string.Concat(hash.ComputeHash(Encoding.UTF8.
                GetBytes(password)).
                Select(x => x.ToString("X2")));
            }
        }

        private void LoginOrganization(object sender, EventArgs e)
        {
            if (!IsDriver)
            {
                LAnotherLogin.Text = "Войти как клиент?";
                IsDriver = true;
                LIncorrectLogin.Visible = false;
            }
            else
            {
                LAnotherLogin.Text = "Войти как водитель?";
                IsDriver = false;
                LIncorrectLogin.Visible = false;
            }
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            if (TBLogin.Text == "" || TBPassword.Text == "")
            {
                LIncorrectLogin.Text = "Заполните все поля";
                LIncorrectLogin.Visible = true;
            }
            else
            {
                if (!IsDriver)
                {

                    using (SqlConnection connection = new SqlConnection(ConnectionAdress))
                    {
                        connection.Open();

                        // посыпаем солью
                        string Salt1 = "6r-2"; string Salt2 = "&0sw";
                        string SaltPassword = Salt1 + TBPassword.Text + Salt2;
                        string Password = GetHash(SaltPassword);

                        string SQL = "SELECT * FROM Taxi.Users WHERE Login ='" +
                        TBLogin.Text + "' AND Password = '" + Password + "'";

                        SqlCommand command = new SqlCommand(SQL, connection);
                        SqlDataReader sqlReader = command.ExecuteReader();

                        if (sqlReader.HasRows == true)
                        {
                            ClientForm.IsDriver = false;
                            ClientForm.UserLogin = TBLogin.Text;
                            this.Hide();
                            ClientForm userForm = new ClientForm();
                            userForm.Show();
                        }
                        else
                        {
                            LIncorrectLogin.Text = "Неверный логин или пароль";
                            LIncorrectLogin.Visible = true;
                        }

                    }
                }
                else
                {
                    using (SqlConnection connection = new SqlConnection(ConnectionAdress))
                    {
                        connection.Open();

                        // посыпаем солью
                        string Salt1 = "6r-2"; string Salt2 = "&0sw";
                        string SaltPassword = Salt1 + TBPassword.Text + Salt2;
                        string Password = GetHash(SaltPassword);

                        string SQL = "SELECT * FROM Taxi.Drivers WHERE Login ='" +
                        TBLogin.Text + "' AND Password = '" + Password + "'";

                        SqlCommand command = new SqlCommand(SQL, connection);
                        SqlDataReader sqlReader = command.ExecuteReader();

                        if (sqlReader.HasRows == true)
                        {
                            ClientForm.IsDriver = true;
                            ClientForm.UserLogin = TBLogin.Text;
                            this.Hide();
                            ClientForm clientForm = new ClientForm();
                            clientForm.Show();
                        }
                        else
                        {
                            LIncorrectLogin.Text = "Неверный логин или пароль";
                            LIncorrectLogin.Visible = true;
                        }

                    }
                }
            }

        }

    }
}
