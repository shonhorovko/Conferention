﻿/*
 * CLASS: Base class for implementing Personal Area functionality (ClientForm)
 * WHO CREATED: shonkhorovkirill2005@gmail.com (Shonkhorov Kirill)
 * DATE: 08.04.23
*/
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Conferention.Classes;

namespace Conferention.Forms
{
    public partial class ClientForm : Form
    {
        //+++User's roles
        public static bool IsParticipant = false;
        public static bool IsJury = false;
        public static bool IsModerator = false;
        public static bool IsOrganizer = false;
        //---

        //+++User's Data
        private string UserIcon;
        public static string UserEmail;
        //---

        //+++Form's Data
        public bool DataIsEdit = false;
        //---

        //+++Connection String
        public static string ConnectionAdress = ConnectionString.strconn;
        //---

        //+++Main Constructor
        public ClientForm()
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

        //+++Choose Icon Button Event
        private void ChooseIcon(object sender, EventArgs e)
        {
            if (OFD.ShowDialog() == DialogResult.OK)
            {
                UserIcon = OFD.FileName;
                PBIcon.Image = Image.FromFile(UserIcon);

                using (SqlConnection connection = new SqlConnection(ConnectionAdress))
                {
                    try
                    {
                        connection.Open();
                        string SQL = "";
                        if (IsParticipant) SQL = "UPDATE conferention.[Участники] SET[фото] = '" + UserIcon + "' WHERE [Почта] = '" + UserEmail + "'";
                        else if(IsJury) SQL = "UPDATE conferention.[Жюри] SET[фото] = '" + UserIcon + "' WHERE [почта] = '" + UserEmail + "'";
                        else if (IsModerator) SQL = "UPDATE conferention.[Модераторы] SET[фото] = '" + UserIcon + "' WHERE [почта] = '" + UserEmail + "'";
                        else if(IsOrganizer) SQL = "UPDATE conferention.[Организаторы] SET[фото] = '" + UserIcon + "' WHERE [Почта] = '" + UserEmail + "'";

                        SqlCommand command = new SqlCommand(SQL, connection);
                        command.ExecuteReader();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message + "\nСервер выдал непредвиденную ошибку. Обратитесь к своему системному администратору для устранения неполадок.");
                    }
                }
            }
        }
        //---

        //+++Exit Account
        private void BExitAccount_Click(object sender, EventArgs e)
        {
            IsParticipant = false;
            IsJury = false;
            IsModerator = false;
            IsOrganizer = false;

            UserEmail = null;
            UserIcon = null;

            this.Hide();
            SignInForm signInForm = new SignInForm();
            signInForm.Show();
        }
        //---

        private void ShowEditFields(object sender, EventArgs e)
        {
            if (DataIsEdit)
            {
                DataIsEdit = false;
                TLP_Label.Visible = false;
                TLP_EditFields.Visible = true;

                BChangeProfile.Text = "Сохранить";
            }
            else
            {
                DataIsEdit = true;
                TLP_Label.Visible = true;
                TLP_EditFields.Visible = false;

                BChangeProfile.Text = "Редактировать профиль";
            }

        }


        /*private bool DoEditing = false;

//+++User's roles
public static bool IsParticipant = true;
public static bool IsJury = false;
public static bool IsModerator = false;
public static bool IsOrganizer = false;
//---

private string UserIcon;
public static string UserLogin;

public static string ConnectionAdress = ConnectionString.strconn;

public ClientForm()
{
InitializeComponent();
}

private void ExitProgram(object sender, FormClosedEventArgs e)
{
Application.Exit();
}

private void ChooseIcon(object sender, EventArgs e)
{
if (OFD.ShowDialog() == DialogResult.OK)
{
UserIcon = OFD.FileName;
PBIcon.Image = Image.FromFile(UserIcon);

using (SqlConnection connection = new SqlConnection(ConnectionAdress))
{
connection.Open();
string SQL = "UPDATE Taxi.Drivers SET[Icon] = '" + UserIcon + "' WHERE Login = '" + UserLogin + "'";
if (!IsDriver) SQL= "UPDATE Taxi.Users SET[Icon] = '" + UserIcon + "' WHERE Login = '" + UserLogin + "'";

SqlCommand command = new SqlCommand(SQL, connection);
command.ExecuteReader();
}
}
}

private void UpdateInfo()
{
using (SqlConnection connection = new SqlConnection(ConnectionAdress))
{
connection.Open();
string SQL = "SELECT * FROM Taxi.Drivers WHERE Login = '" + UserLogin + "'";
if (!IsDriver) SQL = "SELECT * FROM Taxi.Users WHERE Login = '" + UserLogin + "'";

SqlDataAdapter adapter = new SqlDataAdapter(SQL, connection);
DataTable dt = new DataTable();
adapter.Fill(dt);

foreach (DataRow row in dt.Rows)
{
GBinfo.Text = row["Login"].ToString();
Email.Text = row["E-mail"].ToString();
Phone.Text = row["Phone"].ToString();
Name.Text = row["First Name"].ToString();
Surname.Text = row["Second Name"].ToString();
UserIcon = row["Icon"].ToString();

if (!IsDriver)
{
LAge.Text = "Возраст";
LBirthsday.Text = "Дата рождения";

Age.Text = row["Age"].ToString();
Birthsday.Text = row["Birthsday"].ToString();

CB_Country.Visible = false;
DTPbirthsday.Visible = true;
}
else
{                
LAge.Text = "        В/У:";
LBirthsday.Text = "               Страна:";

Age.Text = row["Driver's Passport"].ToString();
Birthsday.Text = row["Country"].ToString();

CB_Country.Visible = true;
DTPbirthsday.Visible = false;

}

}
if (UserIcon == "") UserIcon = "C:\\Users\\shonk\\source\\repos\\Taxi\\ClassLibTaxi\\Resources\\EmptyIcon.png";
if (Name.Text == "") Name.Text = "Пустое поле";
if (Surname.Text == "") Surname.Text = "Пустое поле";
if (Age.Text == "") Age.Text = "Пустое поле";
if (Birthsday.Text == "") Birthsday.Text = "Пустое поле";

PBIcon.Image = Image.FromFile(UserIcon);


}
}

private void UserForm_Load(object sender, EventArgs e)
{
UpdateInfo();
}

private bool isValidEmail(string email)
{
string pattern = "[.\\-_a-z0-9]+@([a-z0-9][\\-a-z0-9]+\\.)+[a-z]{2,6}";
Match isMatch = Regex.Match(email, pattern, RegexOptions.IgnoreCase);
return isMatch.Success;
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
return false;
}
else
{
TB_Phone.Text = strOut;
return true;
}

}
public bool isValidDriverPass(string strIn)
{
if (strIn.Length < 9)
{
return false;
}
else
{
return true;
}

}

private void BChangeProfile_Click(object sender, EventArgs e)
{
if (!DoEditing)
{
BChangeProfile.Text = "Сохранить";
DoEditing = true;
EditFields.Visible = true;

TB_Name.Text = Name.Text;
TB_Surname.Text = Surname.Text;
TB_Email.Text = Email.Text;
TB_Phone.Text = Phone.Text;
}
else
{
if (!IsDriver)
{
if (isValidEmail(TB_Email.Text) && isValidPhone(TB_Phone.Text))
{
BChangeProfile.Text = "Редактировать профиль";
DoEditing = false;
EditFields.Visible = false;


using (SqlConnection connection = new SqlConnection(ConnectionAdress))
{
 connection.Open();
 string  SQL = "UPDATE Taxi.Users SET[First Name] = '" + TB_Name.Text + "', [Second Name] = '" + TB_Surname.Text
     + "', [E-mail] = '" + TB_Email.Text + "', [Phone] = '" + TB_Phone.Text + "', [Age] = '" + TB_Age.Text
     + "', [Birthsday] = '" + DTPbirthsday.Text + "' WHERE Login = '" + UserLogin + "'";

 SqlCommand command = new SqlCommand(SQL, connection);
 command.ExecuteReader();
}

TB_Name.Text = ""; TB_Surname.Text = ""; TB_Email.Text = "";
TB_Phone.Text = ""; TB_Age.Text = "";

UpdateInfo();
}
else
{
TB_Email.Text = Email.Text; TB_Phone.Text = Phone.Text; TB_Age.Text = Age.Text;

BChangeProfile.Text = "Редактировать профиль";
DoEditing = false;
EditFields.Visible = false;


using (SqlConnection connection = new SqlConnection(ConnectionAdress))
{
 connection.Open();
 string SQL = "UPDATE Taxi.Users SET[First Name] = '" + TB_Name.Text + "', [Second Name] = '" + TB_Surname.Text
     + "', [E-mail] = '" + TB_Email.Text + "', [Phone] = '" + TB_Phone.Text + "', [Age] = '" + TB_Age.Text
     + "', [Birthsday] = '" + DTPbirthsday.Text + "' WHERE Login = '" + UserLogin + "'";

 SqlCommand command = new SqlCommand(SQL, connection);
 command.ExecuteReader();
}

TB_Name.Text = ""; TB_Surname.Text = ""; TB_Email.Text = "";
TB_Phone.Text = ""; TB_Age.Text = "";

UpdateInfo();
}
}
else
{
if (isValidEmail(TB_Email.Text) && isValidPhone(TB_Phone.Text) && isValidDriverPass(TB_Age.Text))
{
BChangeProfile.Text = "Редактировать профиль";
DoEditing = false;
EditFields.Visible = false;


using (SqlConnection connection = new SqlConnection(ConnectionAdress))
{
 connection.Open();
 string SQL = "UPDATE Taxi.Drivers SET[First Name] = '" + TB_Name.Text + "', [Second Name] = '" + TB_Surname.Text
     + "', [E-mail] = '" + TB_Email.Text + "', [Phone] = '" + TB_Phone.Text + "', [Driver's Passport] = '" + TB_Age.Text
     + "', [Country] = '" + CB_Country.Text + "' WHERE Login = '" + UserLogin + "'";


 SqlCommand command = new SqlCommand(SQL, connection);
 command.ExecuteReader();
}

TB_Name.Text = ""; TB_Surname.Text = ""; TB_Email.Text = "";
TB_Phone.Text = ""; TB_Age.Text = "";

UpdateInfo();
}
else
{
TB_Email.Text = Email.Text; TB_Phone.Text = Phone.Text; TB_Age.Text = Age.Text;

BChangeProfile.Text = "Редактировать профиль";
DoEditing = false;
EditFields.Visible = false;


using (SqlConnection connection = new SqlConnection(ConnectionAdress))
{
 connection.Open();
 string SQL = "UPDATE Taxi.Drivers SET[First Name] = '" + TB_Name.Text + "', [Second Name] = '" + TB_Surname.Text
     + "', [E-mail] = '" + TB_Email.Text + "', [Phone] = '" + TB_Phone.Text + "', [Driver's Passport] = '" + TB_Age.Text
     + "', [Country] = '" + CB_Country.Text + "' WHERE Login = '" + UserLogin + "'";

 SqlCommand command = new SqlCommand(SQL, connection);
 command.ExecuteReader();
}

TB_Name.Text = ""; TB_Surname.Text = ""; TB_Email.Text = "";
TB_Phone.Text = ""; TB_Age.Text = "";

UpdateInfo();
}
}
}

}

private void BExitAccount_Click(object sender, EventArgs e)
{
UserLogin = "";
this.Hide();
SignInForm signInForm = new SignInForm();
signInForm.Show();
}

private void BChangePass_Click(object sender, EventArgs e)
{
if (IsDriver)
{
ChangeDataKeyForm.IsDriver = true;

}
else
{
ChangeDataKeyForm.IsDriver = false;
}

ChangeDataKeyForm.UserLogin = GBinfo.Text;
this.Hide();
ChangeDataKeyForm changeDataKeyForm = new ChangeDataKeyForm();
changeDataKeyForm.Show();
}

private void InputAge(object sender, KeyPressEventArgs e)
{
char number = e.KeyChar;

if (!Char.IsDigit(number))
{
e.Handled = true;
}
}*/
    }
}
