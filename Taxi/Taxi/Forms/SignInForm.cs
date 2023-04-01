/*
 * CLASS: Base class for implementing authorization functionality (SignInForm)
 * WHO CREATED: shonkhorovkirill2005@gmail.com (Shonkhorov Kirill)
 * DATE: -
*/
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using Conferention.Classes;

namespace Conferention.Forms
{
    public partial class SignInForm : ClassLibConferention.FormParent
    {
        public static bool IsParticipant = true;
        public static bool IsJury = true;
        public static bool IsModerator = true;
        public static bool IsOrganizer = true;

        public static string ConnectionAdress = ConnectionString.strconn;

        public SignInForm()
        {
            InitializeComponent();
        }
        private void ExitProgram(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
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
        private void LoginOrganization(object sender, EventArgs e)
        {
            if (IsParticipant)
            {
                IsParticipant = false;
                IsJury = true;
                IsModerator = false;
                IsOrganizer = false;

                LAnotherLogin.Text = "Войти как жюри?";

                LIncorrectLogin.Visible = false;
            }
            else if (IsJury)
            {
                IsParticipant = false;
                IsJury = false;
                IsModerator = true;
                IsOrganizer = false;

                LAnotherLogin.Text = "Войти как модератор?";

                LIncorrectLogin.Visible = false;
            }
            else if (IsModerator)
            {
                IsParticipant = false;
                IsJury = false;
                IsModerator = false;
                IsOrganizer = true;

                LAnotherLogin.Text = "Войти как организатор?";

                LIncorrectLogin.Visible = false;
            }
            else if (IsOrganizer)
            {
                IsParticipant = true;
                IsJury = false;
                IsModerator = false;
                IsOrganizer = false;

                LAnotherLogin.Text = "Войти как участник?";

                LIncorrectLogin.Visible = false;
            }
        }
        private void BtnLogin_Click(object sender, EventArgs e)
        {
            if (IsParticipant)
            {
                LoginParticipant();
            }
            else if (IsJury)
            {
                LoginJury();
            }
            else if (IsModerator)
            {
                LoginModerator();
            }
            else if (IsOrganizer)
            {
                LoginOrganizer();
            }
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
        private string SaltPassword()
        {
            string Salt1 = "6r-2"; string Salt2 = "&0sw";
            string SaltPassword = Salt1 + TBPassword.Text + Salt2;
            string Password = GetHash(SaltPassword);
            return Password;
        }

        
        private bool FieldsIsEmpty()
        {
            if (TBLogin.Text == "" || TBPassword.Text == "")
            {
                LIncorrectLogin.Text = "Заполните все поля!";
                LIncorrectLogin.Visible = true;
                return false;
            }
            else
            {
                LIncorrectLogin.Text = "";
                LIncorrectLogin.Visible = false;
                return true;
            }
        }

        private void TryToConnect(string SQL)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionAdress))
            {
                connection.Open();

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

        private void LoginParticipant()
        {
            if (FieldsIsEmpty())
            {
                string Password = SaltPassword();
                string SQL = "SELECT * FROM conferention.[Участники] " +
                    "WHERE [Почта] ='" + TBLogin.Text + "' AND [Пароль] = '" + Password + "'";

                TryToConnect(SQL);
            }
        }
        private void LoginJury()
        {
            FieldsIsEmpty();
        }
        private void LoginModerator()
        {
            FieldsIsEmpty();
        }
        private void LoginOrganizer()
        {
            FieldsIsEmpty();
        }
    }
}




















/*if (TBLogin.Text == "" || TBPassword.Text == "")
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
            }*/