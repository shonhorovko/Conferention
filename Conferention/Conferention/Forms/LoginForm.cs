/*
 * CLASS: Base class for implementing registration functionality (LoginForm)
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
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Conferention.Classes;

namespace Conferention.Forms
{
    public partial class LoginForm : ClassLibConferention.FormParent
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
        public LoginForm()
        {
            InitializeComponent();
        }
        //---

        //+++Animatoin for TextButtons
        private void DoLogIN(object sender, MouseEventArgs e)
        {
            LHaveAccount.ForeColor = SystemColors.HotTrack;
        }
        private void DoLogOUT(object sender, EventArgs e)
        {
            LHaveAccount.ForeColor = SystemColors.WindowFrame;
        }
        private void CommunityLogIN(object sender, MouseEventArgs e)
        {
            L_AnotherLogin.ForeColor = SystemColors.HotTrack;
        }
        private void CommunityLogOUT(object sender, EventArgs e)
        {
            L_AnotherLogin.ForeColor = SystemColors.WindowFrame;
        }
        //---

        //+++Show SignInForm
        private void SignInForm(object sender, EventArgs e)
        {
            this.Hide();
            SignInForm SignInForm = new SignInForm();
            SignInForm.Show();
        }
        //---

        //+++Exit Program Event
        private void ExitProgram(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
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

        //+++Role Selector
        private void LoginAnotherUser(object sender, EventArgs e)
        {
            if (IsParticipant)
            {
                IsParticipant = false;
                IsJury = true;
                IsModerator = false;
                IsOrganizer = false;

                L_AnotherLogin.Text = "Регистрация модератора";

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

                L_AnotherLogin.Text = "Регистрация организатора";

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

                L_AnotherLogin.Text = "Регистрация участника";

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

                L_AnotherLogin.Text = "Регистрация жюри";

                LIncorrectLogin.Text = "";
                LIncorrectLogin.Visible = false;
                return;
            }
        }
        //---

        //++++Registration Button
        private void BtnLogin_Click(object sender, EventArgs e)
        {
            if (IsParticipant)
            {
                //LoginParticipant();
            }
            else if (IsJury)
            {
                //LoginJury();
            }
            else if (IsModerator)
            {
                //LoginModerator();
            }
            else if (IsOrganizer)
            {
                //LoginOrganizer();
            }
        }
        //---

        /*private void LoginCommunity(object sender, EventArgs e)
        {
            if (!IsDriver)
            {
                TB_Email.Text = ""; TB_Phone.Text = ""; TB_Login.Text = ""; TB_Password.Text = ""; CB_Country.Text = ""; TB_DriverPass.Text = "";
                LLoginDriver.Text = "Регистрация клиента";
                TLP_DriverPass.Visible = true;
                TLP_Country.Visible = true;
                LIncorrectLogin.Visible = false;
                TB_Email.ShortcutsEnabled = false;

                IsDriver = true;
            }
            else
            {
                TB_Email.Text = ""; TB_Phone.Text = ""; TB_Login.Text = ""; TB_Password.Text = ""; CB_Country.Text = "";
                LLoginDriver.Text = "Регистрация водителя";
                TLP_DriverPass.Visible = false;
                TLP_Country.Visible = false;
                LIncorrectLogin.Visible = false;
                TB_Email.ShortcutsEnabled = true;

                IsDriver = false;
            }
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            if (!IsDriver)
            {
                if (TB_Email.Text == "" || TB_Phone.Text == "" || TB_Login.Text == "" || TB_Password.Text == "")
                {
                    LIncorrectLogin.Text = "Заполните все поля";
                    LIncorrectLogin.Visible = true;
                }
                else
                {
                    if (isValidEmail(TB_Email.Text) && isValidPhone(TB_Phone.Text) && isValidPassword(TB_Password.Text))
                    {
                        CAPTCHA_Form cAPTCHA_Form = new CAPTCHA_Form();
                        cAPTCHA_Form.ShowDialog();

                        if (CAPTCHA_Form.CAPTCHA)
                        {
                            using (SqlConnection connection = new SqlConnection(ConnectionAdress))
                            {
                                connection.Open();

                                string Salt1 = "6r-2"; string Salt2 = "&0sw";
                                string SaltPassword = Salt1 + TB_Password.Text + Salt2;
                                string Password = GetHash(SaltPassword);

                                string SQL = "insert into Taxi.Users ([E-mail],[Phone],[Login],[Password]) " +
                                " values ('" + TB_Email.Text + "', '" + TB_Phone.Text + "', '"
                                + TB_Login.Text + "', '" + Password + "')";

                                SqlCommand command = new SqlCommand(SQL, connection);
                                try
                                {
                                    command.ExecuteNonQuery();
                                    ClientForm.IsDriver = false;
                                    ClientForm.UserLogin = TB_Login.Text;
                                    this.Hide();
                                    ClientForm userForm = new ClientForm();
                                    userForm.Show();
                                }
                                catch
                                {
                                    LIncorrectLogin.Text = "Этот логин уже занят \n другим пользователем";
                                    LIncorrectLogin.Visible = true;
                                }
                            }
                        }
                        else
                        {
                            LIncorrectLogin.Text = "Подтвердите что вы не робот";
                            LIncorrectLogin.Visible = true;
                        }
                    }
                    else
                    {
                        LIncorrectLogin.Text = "Введены некорректные данные!\nПроверьте их и попробуйте снова.";
                        LIncorrectLogin.Visible = true;
                    }
                }
            }
            else
            {
                if (TB_Email.Text == "" || TB_Phone.Text == "" || TB_Login.Text == "" || TB_Password.Text == "" || TB_DriverPass.Text == "" || CB_Country.Text == "")
                {
                    LIncorrectLogin.Text = "Заполните все поля";
                    LIncorrectLogin.Visible = true;
                }
                else
                {
                    if (isValidDriverPass(TB_DriverPass.Text) && isValidPassword(TB_Password.Text) && isValidEmail(TB_Email.Text) && isValidPhone(TB_Phone.Text))
                    {
                        CAPTCHA_Form cAPTCHA_Form = new CAPTCHA_Form();
                        cAPTCHA_Form.ShowDialog();

                        if (CAPTCHA_Form.CAPTCHA)
                        {
                            using (SqlConnection connection = new SqlConnection(ConnectionAdress))
                            {
                                connection.Open();

                                // посыпаем солью
                                string Salt1 = "6r-2"; string Salt2 = "&0sw";
                                string SaltPassword = Salt1 + TB_Password.Text + Salt2;
                                string Password = GetHash(SaltPassword);

                                string SQL = "insert into Taxi.Drivers ([E-mail],[Phone],[Driver's Passport],[Country],[Login],[Password]) " +
                                 "values ('" + TB_Email.Text + "', '" + TB_Phone.Text + "', '"
                                 + TB_DriverPass.Text + "', '" + CB_Country.Text + "', '" + TB_Login.Text + "', '" + Password + "')";

                                SqlCommand command = new SqlCommand(SQL, connection);
                                try
                                {
                                    //command.ExecuteNonQuery();
                                    ClientForm.IsDriver = true;
                                    ClientForm.UserLogin = TB_Login.Text;
                                    this.Hide();
                                    ClientForm clientForm = new ClientForm();
                                    clientForm.Show();
                                }
                                catch
                                {
                                    LIncorrectLogin.Text = "Ошибка регистрации. \nПроверьте вводимые данные \nили сообщите вашему администратору.";
                                    LIncorrectLogin.Visible = true;
                                }
                            }
                        }
                        else
                        {
                            LIncorrectLogin.Text = "Подтвердите что вы не робот";
                            LIncorrectLogin.Visible = true;
                        }
                    }

                }
            }
        }

        private bool isValidEmail(string email)
        {
            string pattern = "[.\\-_a-z0-9]+@([a-z0-9][\\-a-z0-9]+\\.)+[a-z]{2,6}";
            Match isMatch = Regex.Match(email, pattern, RegexOptions.IgnoreCase);
            if (isMatch.Success)
            {
                LIncorrectLogin.Text = "";
                LIncorrectLogin.Visible = false;
                return true;
            }
            else
            {
                LIncorrectLogin.Text = "E-mail введен неккоректно";
                LIncorrectLogin.Visible = true;
                return false;
            }
        }
        public bool isValidPhone(string strIn)
        {
            string strOut = "";
            string strPattern = @"(\+7|8|\b)[\(\s-]*(\d)[\s-]*(\d)[\s-]*(\d)[)\s-]*(\d)[\s-]*(\d)[\s-]*(\d)[\s-]*(\d)[\s-]*(\d)[\s-]*(\d)[\s-]*(\d)";
            MatchCollection mm = Regex.Matches(strIn, strPattern);
            foreach (Match m in mm)
            {
                strOut += Regex.Replace(m.Value, "^" + strPattern + "$", "+7($2$3$4)$5$6$7-$8$9-$10$11");
            }
            if (strOut == "")
            {
                LIncorrectLogin.Text = "Номер телефона введен неккоректно";
                LIncorrectLogin.Visible = true;
                return false;

            }
            else
            {
                LIncorrectLogin.Text = "";
                LIncorrectLogin.Visible = false;
                TB_Phone.Text = strOut;
                return true;
            }

        }

        public bool isValidPassword(string PassIn)
        {
            if (PassIn.Length >= 6)
            {
                LIncorrectLogin.Text = "";
                LIncorrectLogin.Visible = false;
                return true;
            }
            else
            {
                LIncorrectLogin.Text = "Пароль должен содержать\nне меньше 6 символов.";
                LIncorrectLogin.Visible = true;
                return false;
            }
        }

        public bool isValidDriverPass(string strIn)
        {
            if (strIn.Length == 9)
            {
                LIncorrectLogin.Text = "";
                LIncorrectLogin.Visible = false;
                return true;
            }
            else
            {
                LIncorrectLogin.Text = "Номер водительского удостоверения\nдолжен содержать 9 цифр.";
                LIncorrectLogin.Visible = true;
                return false;
            }
        }


        private void ValidatePhone(object sender, EventArgs e)
        {
            isValidPhone(TB_Phone.Text);
        }

        private void ValidatePassword(object sender, EventArgs e)
        {
            isValidPassword(TB_Password.Text);
        }

        private void ValiadteDriverPass(object sender, KeyPressEventArgs e)
        {
            if (IsDriver) isValidDriverPass(TB_DriverPass.Text);
        }

        private void ValidateDriverPass(object sender, EventArgs e)
        {
            if (IsDriver) isValidDriverPass(TB_DriverPass.Text);
        }*/
    }
}
