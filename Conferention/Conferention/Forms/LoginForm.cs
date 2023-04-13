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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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

        //+++Country Parsing Massive
        private string[] arrCountry = { };
        private int[] arrCountry_index = { };

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


        //+++Show ClientForm
        private void ShowClientForm(object sender, EventArgs e)
        {
            this.Hide();
            ClientForm ClientForm = new ClientForm();
            ClientForm.Show();
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

        //+++Salting password function
        private string SaltPassword()
        {
            string Salt1 = "6r-2"; string Salt2 = "&0sw";
            string SaltPassword = Salt1 + TB_Password.Text + Salt2;
            string Password = GetHash(SaltPassword);
            return Password;
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

        //+++Check fields
        private bool FieldsIsEmpty()
        {
            if (TB_Name.Text == "" || TB_Email.Text == "" || 
                TB_Phone.Text == "" || TB_Password.Text == "" || 
                TB_CheckPassword.Text == "" || CB_Country.SelectedIndex == -1)
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

        //+++Check Email
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
        //---

        //+++Check Phone
        private bool isValidPhone(string strIn)
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
                LIncorrectLogin.Text = "Номер телефона\nвведен неккоректно";
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
        //---

        //+++Check Password
        private bool isValidPassword(string PassIn)
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
        //---

        //+++Check Password
        private bool PasswordIsIdentity(string Password, string CheckPassword)
        {
            if (CheckPassword == Password)
            {
                LIncorrectLogin.Text = "";
                LIncorrectLogin.Visible = false;
                return true;
            }
            else
            {
                LIncorrectLogin.Text = "Пароли не совпадают.";
                LIncorrectLogin.Visible = true;
                return false;
            }
        }
        //---

        //+++CAPTCHA Security
        private void CAPTCHA_Security()
        {
            if (!CAPTCHA_Form.CAPTCHA)
            {
                CAPTCHA_Form capthcaForm = new CAPTCHA_Form();
                capthcaForm.Show();
            }
        }
        //---

        //+++Get Country Identity Num
        private int ParsingCountry(string country)
        {
            string SQL = "SELECT [Идентификатор] FROM conferention.[Страны] " +
                    "WHERE [Название страны] ='" + country + "'";
            using (SqlConnection connection = new SqlConnection(ConnectionAdress))
            {
                try
                {
                    connection.Open();

                    SqlDataAdapter sda = new SqlDataAdapter(SQL, connection);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    string Value = dt.Rows[0][0].ToString();
                    int CountryIdentity = Int32.Parse(Value);
                    return CountryIdentity;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + "\nСервер выдал непредвиденную ошибку. Обратитесь к своему системному администратору для устранения неполадок.");
                    return 0;
                }
            }
        }
        //---


        //+++Registration Button
        private void BtnLogin_Click(object sender, EventArgs e)
        {
            if (FieldsIsEmpty())
                if (isValidEmail(TB_Email.Text))
                    if (isValidPhone(TB_Phone.Text))
                        if (isValidPassword(TB_Password.Text))
                            if (PasswordIsIdentity(TB_Password.Text, TB_CheckPassword.Text))

                                CAPTCHA_Security();

                                if (CAPTCHA_Form.CAPTCHA)
                                {
                                    CAPTCHA_Form.CAPTCHA = false;

                                    string Name = TB_Name.Text;
                                    string Password = TB_Password.Text;
                                    string Email = TB_Email.Text;
                                    string Phone = TB_Phone.Text;
                                    string Country = CB_Country.Text;
                                    string Sex = LB_Sex.Text;
                                    string Birthsday = DTP_Birthsday.Text;

                                    int CountryIdentity = ParsingCountry(Country);

                                    if (IsParticipant)
                                    {
                                        string SQL = "insert into conferention.[Участники] " +
                                            "([ФИО],[страна],[Почта],[телефон],[дата_рождения],[пол],[пароль]) " +
                                            "values ('" + Name + "'," + CountryIdentity + ", '" + Email + "', '" + Phone +
                                            "', '" + Birthsday + "', '" + Sex + "', '" + Password + "')";

                                        if (TryToConnect(SQL))
                                        {
                                            ClientForm.IsParticipant = true;
                                            ClientForm.UserEmail = Email;
                                            this.Hide();
                                            ClientForm clientForm = new ClientForm();
                                            clientForm.Show();
                                        }
                                    }
                                    else if (IsJury)
                                    {
                                        string SQL = "insert into conferention.[Жюри] " +
                                            "([ФИО],[страна],[почта],[телефон],[дата рождения],[пол],[пароль]) " +
                                            "values ('" + Name + "'," + CountryIdentity + ", '" + Email + "', '" + Phone +
                                            "', '" + Birthsday + "', '" + Sex + "', '" + Password + "')";

                                        if (TryToConnect(SQL))
                                        {
                                            ClientForm.IsJury = true;
                                            ClientForm.UserEmail = Email;
                                            this.Hide();
                                            ClientForm clientForm = new ClientForm();
                                            clientForm.Show();
                                        }
                                    }
                                    else if (IsModerator)
                                    {
                                        string SQL = "insert into conferention.[Модераторы] " +
                                            "([ФИО],[страна],[почта],[телефон],[дата рождения],[пол],[пароль]) " +
                                            "values ('" + Name + "'," + CountryIdentity + ", '" + Email + "', '" + Phone +
                                            "', '" + Birthsday + "', '" + Sex + "', '" + Password + "')";

                                        if (TryToConnect(SQL))
                                        {
                                            ClientForm.IsModerator = true;
                                            ClientForm.UserEmail = Email;
                                            this.Hide();
                                            ClientForm clientForm = new ClientForm();
                                            clientForm.Show();
                                        }
                                    }
                                    else if (IsOrganizer)
                                    {
                                        string SQL = "insert into conferention.[Организаторы] " +
                                            "([ФИО],[страна],[Почта],[телефон],[Дата рождения],[пол],[пароль]) " +
                                            "values ('" + Name + "'," + CountryIdentity + ", '" + Email + "', '" + Phone +
                                            "', '" + Birthsday + "', '" + Sex + "', '" + Password + "')";

                                        if (TryToConnect(SQL))
                                        {
                                            ClientForm.IsOrganizer = true;
                                            ClientForm.UserEmail = Email;
                                            this.Hide();
                                            ClientForm clientForm = new ClientForm();
                                            clientForm.Show();
                                        }
                                    }
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
                    command.ExecuteNonQuery();
                    return true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + "\nСервер выдал непредвиденную ошибку. Обратитесь к своему системному администратору для устранения неполадок.");
                    return false;
                }
            }
        }
        //---

        //+++Event Func.
        private void EVENT_ValidationEmail(object sender, EventArgs e)
        {
            string Email = TB_Email.Text;
            isValidEmail(Email);
        }
        private void EVENT_ValidationPhone(object sender, EventArgs e)
        {
            string Phone = TB_Phone.Text;
            isValidPhone(Phone);
        }
        private void EVENT_ValidationPassword(object sender, EventArgs e)
        {
            string Password = TB_Password.Text;
            isValidPassword(Password);
        }
        private void EVENT_CheckPasswordToIdentity(object sender, EventArgs e)
        {
            string Password = TB_Password.Text;
            string CheckPassword = TB_CheckPassword.Text;
            PasswordIsIdentity(Password, CheckPassword);
        }
        //---
    }
}
