using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Conferention.Classes;
using Conferention.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Conferention.Forms
{
    public partial class ChangeDataKeyForm : Form
    {
        public bool PassIsShow1 = false;
        public bool PassIsShow2 = false;
        public static bool IsDriver;
        public static string ConnectionAdress = ConnectionString.strconn;
        public static string UserLogin = ClientForm.UserLogin;

        public ChangeDataKeyForm()
        {
            InitializeComponent();
        }

        public static string GetHash(string password)
        {
            using (var hash = SHA256.Create())
            {
                return string.Concat(hash.ComputeHash(Encoding.UTF8.
                GetBytes(password)).
                Select(x => x.ToString("X2")));
            }
        }

        private void BSave_Click(object sender, EventArgs e)
        {
            string NewLogin = TB_Login.Text;
            string OldPass = TB_OldPass.Text;
            string NewPass = TB_Pass.Text;
            string CheckPass = TB_PassIsTrue.Text;

            string MyPass = "";

            using (SqlConnection connection = new SqlConnection(ConnectionAdress))
            {
                connection.Open();

                string Salt1 = "6r-2"; string Salt2 = "&0sw";
                if (IsDriver)
                {
                    string SQL = "SELECT * FROM Taxi.Drivers WHERE Login = '" + UserLogin + "'";

                    SqlDataAdapter adapter = new SqlDataAdapter(SQL, connection);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    foreach (DataRow row in dt.Rows)
                    {
                        MyPass = row["Password"].ToString();
                    }

                    OldPass = Salt1 + OldPass + Salt2;
                    OldPass = GetHash(OldPass);

                    if(OldPass == MyPass)
                    {
                        if (isValidPassword(NewPass))
                        {
                            if (NewPass == CheckPass)
                            {
                                NewPass = Salt1 + NewPass + Salt2;
                                SQL = "UPDATE Taxi.Drivers SET [Login] = '" + NewLogin + "', [Password] = '" + GetHash(NewPass) + "' WHERE Login = '" + UserLogin + "'";
                                SqlCommand command = new SqlCommand(SQL, connection);
                                command.ExecuteNonQuery();

                                MessageBox.Show("Данные успешно изменены!");

                                ClientForm.IsDriver = true;
                                ClientForm.UserLogin = TB_Login.Text;
                                this.Hide();
                                ClientForm clientForm = new ClientForm();
                                clientForm.Show();
                            }
                            else
                            {
                                MessageBox.Show("Новый пароль не подтверждён!");
                            }
                        }
                        
                    }
                    else
                    {
                        MessageBox.Show("Неверный пароль!");
                    }
                }
                else
                {
                    string SQL = "SELECT * FROM Taxi.Users WHERE Login = '" + UserLogin + "'";

                    SqlDataAdapter adapter = new SqlDataAdapter(SQL, connection);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    foreach (DataRow row in dt.Rows)
                    {
                        MyPass = row["Password"].ToString();
                    }

                    OldPass = Salt1 + OldPass + Salt2;
                    OldPass = GetHash(OldPass);

                    if (OldPass == MyPass)
                    {
                        if (isValidPassword(NewPass))
                        {
                            if (NewPass == CheckPass)
                            {
                                NewPass = Salt1 + NewPass + Salt2;
                                SQL = "UPDATE Taxi.Users SET [Login] = '" + NewLogin + "', [Password] = '" + GetHash(NewPass) + "' WHERE Login = '" + UserLogin + "'";
                                SqlCommand command = new SqlCommand(SQL, connection);
                                command.ExecuteNonQuery();

                                MessageBox.Show("Данные успешно изменены!");

                                ClientForm.IsDriver = false;
                                ClientForm.UserLogin = TB_Login.Text;
                                this.Hide();
                                ClientForm clientForm = new ClientForm();
                                clientForm.Show();
                            }
                            else
                            {
                                MessageBox.Show("Новый пароль не подтверждён!");
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Неверный пароль!");
                    }
                }
            }
        }

        public bool isValidPassword(string PassIn)
        {
            if (PassIn.Length >= 6)
            {
                return true;
            }
            else
            {
                MessageBox.Show("Пароль должен быть длинее 6 символов!");
                return false;
            }
        }

        private void FormClosed(object sender, FormClosingEventArgs e)
        {
            if(IsDriver) ClientForm.IsDriver = true;
            else ClientForm.IsDriver = false;

            ClientForm.UserLogin = UserLogin;
            this.Hide();
            ClientForm clientForm = new ClientForm();
            clientForm.Show();
        }

        private void ShowPass(object sender, EventArgs e)
        {
            
            if (!PassIsShow1)
            {
                TB_Pass.PasswordChar = '\0';
                PassIsShow1 = true;
            }
            else
            {
               
                TB_Pass.PasswordChar = '*';
                PassIsShow1 = false;
            }
            
        }

        private void ShowPassIsTrue(object sender, EventArgs e)
        {
            if (!PassIsShow2)
            {
                TB_PassIsTrue.PasswordChar = '\0';
                PassIsShow2 = true;
            }
            else
            {

                TB_PassIsTrue.PasswordChar = '*';
                PassIsShow2 = false;
            }
        }
    }
}
