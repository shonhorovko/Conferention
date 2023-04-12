/*
 * CLASS: Base class for implementing authorization functionality (SignInForm)
 * WHO CREATED: shonkhorovkirill2005@gmail.com (Shonkhorov Kirill)
 * DATE: 08.04.23
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
        //+++User's roles
        public static bool IsParticipant = true;
        public static bool IsJury = false;
        public static bool IsModerator = false;
        public static bool IsOrganizer = false;
        //---

        //+++Connection String
        public static string ConnectionAdress = ConnectionString.strconn;
        //---

        //+++Main Constructor
        public SignInForm()
        {
            InitializeComponent();
        }
        //---

        //+++Exit Program Event
        private void ExitProgram(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        //---

        //+++Animatoin for TextButtons
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
        //---

        //+++Show LoginForm
        private void LoginForm(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }
        //---
        //+++Show ClientForm
        private void ClientFormLoad()
        {
            ClientForm.UserEmail = TBLogin.Text;
            this.Hide();
            ClientForm userForm = new ClientForm();
            userForm.Show();
        }
        //---

        //+++Role Selector
        private void LoginAnotherUser(object sender, EventArgs e)
        {
            if (IsParticipant)
            {
                IsParticipant = false;
                IsJury = true;
                IsModerator = false;
                IsOrganizer = false;

                LAnotherLogin.Text = "Войти как модератор?";

                LIncorrectLogin.Text = "";
                LIncorrectLogin.Visible = false;
                return;
            }
            else if (IsJury)
            {
                IsParticipant = false;
                IsJury = false;
                IsModerator = true;
                IsOrganizer = false;

                LAnotherLogin.Text = "Войти как организатор?";

                LIncorrectLogin.Text = "";
                LIncorrectLogin.Visible = false;
                return;

            }
            else if (IsModerator)
            {
                IsParticipant = false;
                IsJury = false;
                IsModerator = false;
                IsOrganizer = true;

                LAnotherLogin.Text = "Войти как участник?";

                LIncorrectLogin.Text = "";
                LIncorrectLogin.Visible = false;
                return;

            }
            else if (IsOrganizer)
            {
                IsParticipant = true;
                IsJury = false;
                IsModerator = false;
                IsOrganizer = false;

                LAnotherLogin.Text = "Войти как жюри?";

                LIncorrectLogin.Text = "";
                LIncorrectLogin.Visible = false;
                return;
            }
        }
        //---

        //+++Authorize Button
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
        //---

        //+++Password Hash Function
        public static string GetHash(string password)
        {
            using (var hash = SHA256.Create())
            {
                return string.Concat(hash.ComputeHash(Encoding.UTF8.
                GetBytes(password)).
                Select(x => x.ToString("X2")));
            }
        }
        //---

        //+++Salting password function
        private string SaltPassword()
        {
            string Salt1 = "6r-2"; string Salt2 = "&0sw";
            string SaltPassword = Salt1 + TBPassword.Text + Salt2;
            string Password = GetHash(SaltPassword);
            return Password;
        }
        //---

        //+++Check fields
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
        //---

        //+++Main Connection Func.
        private bool TryToConnect(string SQL)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionAdress))
            {
                try
                {
                    connection.Open();

                    SqlCommand command = new SqlCommand(SQL, connection);
                    SqlDataReader sqlReader = command.ExecuteReader();

                    if (sqlReader.HasRows == true)
                    {
                        return true;
                    }
                    else
                    {
                        LIncorrectLogin.Text = "Неверный логин или пароль";
                        LIncorrectLogin.Visible = true;

                        return false;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + "\nСервер выдал непредвиденную ошибку. Обратитесь к своему системному администратору для устранения неполадок.");
                    return false;
                }
            }
        }
        //---

        //+++Login Types
        private void LoginParticipant()
        {
            if (FieldsIsEmpty())
            {
                string Password = TBPassword.Text;//Password();
                string SQL = "SELECT * FROM conferention.[Участники] " +
                    "WHERE [Почта] ='" + TBLogin.Text + "' AND [пароль] = '" + Password + "'";

                if (TryToConnect(SQL))
                {
                    ClientForm.IsParticipant = true;
                    ClientFormLoad();
                }
            }
        }
        private void LoginJury()
        {
            if (FieldsIsEmpty())
            {
                string Password = TBPassword.Text;//Password();
                string SQL = "SELECT * FROM conferention.[Жюри] " +
                    "WHERE [Почта] ='" + TBLogin.Text + "' AND [пароль] = '" + Password + "'";

                if (TryToConnect(SQL))
                {
                    ClientForm.IsJury = true;
                    ClientFormLoad();
                }
            }
        }
        private void LoginModerator()
        {
            if (FieldsIsEmpty())
            {
                string Password = TBPassword.Text;//Password();
                string SQL = "SELECT * FROM conferention.[Модераторы] " +
                    "WHERE [Почта] ='" + TBLogin.Text + "' AND [пароль] = '" + Password + "'";

                if (TryToConnect(SQL))
                {
                    ClientForm.IsModerator = true;
                    ClientFormLoad();
                }
            }
        }
        private void LoginOrganizer()
        {
            if (FieldsIsEmpty())
            {
                string Password = TBPassword.Text;//Password();
                string SQL = "SELECT * FROM conferention.[Организаторы] " +
                    "WHERE [Почта] ='" + TBLogin.Text + "' AND [пароль] = '" + Password + "'";

                if (TryToConnect(SQL))
                {
                    ClientForm.IsOrganizer = true;
                    ClientFormLoad();
                }
            }
        }
        //---
    }
}