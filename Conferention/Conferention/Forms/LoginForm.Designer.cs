namespace Conferention.Forms
{
    partial class LoginForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.GBRegistration = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.TLP_CheckPassword = new System.Windows.Forms.TableLayoutPanel();
            this.TB_CheckPassword = new System.Windows.Forms.TextBox();
            this.L_CheckPassword = new System.Windows.Forms.Label();
            this.TLP_Password = new System.Windows.Forms.TableLayoutPanel();
            this.TB_Password = new System.Windows.Forms.TextBox();
            this.L_Password = new System.Windows.Forms.Label();
            this.TLP_Sex = new System.Windows.Forms.TableLayoutPanel();
            this.L_Sex = new System.Windows.Forms.Label();
            this.LB_Sex = new System.Windows.Forms.ListBox();
            this.TLP_Birthsday = new System.Windows.Forms.TableLayoutPanel();
            this.L_Birthsday = new System.Windows.Forms.Label();
            this.DTP_Birthsday = new System.Windows.Forms.DateTimePicker();
            this.TLP_Phone = new System.Windows.Forms.TableLayoutPanel();
            this.TB_Phone = new System.Windows.Forms.TextBox();
            this.L_Phone = new System.Windows.Forms.Label();
            this.TLP_Email = new System.Windows.Forms.TableLayoutPanel();
            this.TB_Email = new System.Windows.Forms.TextBox();
            this.L_Email = new System.Windows.Forms.Label();
            this.tableLayoutPanel13 = new System.Windows.Forms.TableLayoutPanel();
            this.LIncorrectLogin = new System.Windows.Forms.Label();
            this.L_AnotherLogin = new System.Windows.Forms.Label();
            this.LHaveAccount = new System.Windows.Forms.Label();
            this.BtnLogin = new System.Windows.Forms.Button();
            this.TLP_Name = new System.Windows.Forms.TableLayoutPanel();
            this.L_Name = new System.Windows.Forms.Label();
            this.TB_Name = new System.Windows.Forms.TextBox();
            this.TLP_Country = new System.Windows.Forms.TableLayoutPanel();
            this.L_Country = new System.Windows.Forms.Label();
            this.CB_Country = new System.Windows.Forms.ComboBox();
            this.GBRegistration.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.TLP_CheckPassword.SuspendLayout();
            this.TLP_Password.SuspendLayout();
            this.TLP_Sex.SuspendLayout();
            this.TLP_Birthsday.SuspendLayout();
            this.TLP_Phone.SuspendLayout();
            this.TLP_Email.SuspendLayout();
            this.tableLayoutPanel13.SuspendLayout();
            this.TLP_Name.SuspendLayout();
            this.TLP_Country.SuspendLayout();
            this.SuspendLayout();
            // 
            // GBRegistration
            // 
            this.GBRegistration.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GBRegistration.AutoSize = true;
            this.GBRegistration.Controls.Add(this.tableLayoutPanel2);
            this.GBRegistration.Font = new System.Drawing.Font("Calibri", 18.25F, System.Drawing.FontStyle.Bold);
            this.GBRegistration.Location = new System.Drawing.Point(161, 15);
            this.GBRegistration.Margin = new System.Windows.Forms.Padding(4);
            this.GBRegistration.MinimumSize = new System.Drawing.Size(524, 417);
            this.GBRegistration.Name = "GBRegistration";
            this.GBRegistration.Padding = new System.Windows.Forms.Padding(4);
            this.GBRegistration.Size = new System.Drawing.Size(526, 425);
            this.GBRegistration.TabIndex = 3;
            this.GBRegistration.TabStop = false;
            this.GBRegistration.Text = "Регистрация";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.AutoSize = true;
            this.tableLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.TLP_CheckPassword, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.TLP_Password, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.TLP_Sex, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.TLP_Birthsday, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.TLP_Phone, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.TLP_Email, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel13, 0, 5);
            this.tableLayoutPanel2.Controls.Add(this.BtnLogin, 1, 5);
            this.tableLayoutPanel2.Controls.Add(this.TLP_Name, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.TLP_Country, 1, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(4, 42);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 7;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(518, 379);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // TLP_CheckPassword
            // 
            this.TLP_CheckPassword.AutoSize = true;
            this.TLP_CheckPassword.ColumnCount = 1;
            this.TLP_CheckPassword.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TLP_CheckPassword.Controls.Add(this.TB_CheckPassword, 0, 1);
            this.TLP_CheckPassword.Controls.Add(this.L_CheckPassword, 0, 0);
            this.TLP_CheckPassword.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TLP_CheckPassword.Location = new System.Drawing.Point(261, 218);
            this.TLP_CheckPassword.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.TLP_CheckPassword.Name = "TLP_CheckPassword";
            this.TLP_CheckPassword.RowCount = 2;
            this.TLP_CheckPassword.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TLP_CheckPassword.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TLP_CheckPassword.Size = new System.Drawing.Size(255, 56);
            this.TLP_CheckPassword.TabIndex = 36;
            // 
            // TB_CheckPassword
            // 
            this.TB_CheckPassword.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TB_CheckPassword.Font = new System.Drawing.Font("Calibri", 10.25F);
            this.TB_CheckPassword.Location = new System.Drawing.Point(2, 25);
            this.TB_CheckPassword.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.TB_CheckPassword.MaxLength = 255;
            this.TB_CheckPassword.Name = "TB_CheckPassword";
            this.TB_CheckPassword.PasswordChar = '*';
            this.TB_CheckPassword.Size = new System.Drawing.Size(251, 28);
            this.TB_CheckPassword.TabIndex = 2;
            this.TB_CheckPassword.TextChanged += new System.EventHandler(this.EVENT_CheckPasswordToIdentity);
            // 
            // L_CheckPassword
            // 
            this.L_CheckPassword.AutoSize = true;
            this.L_CheckPassword.Font = new System.Drawing.Font("Calibri", 10.25F);
            this.L_CheckPassword.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.L_CheckPassword.Location = new System.Drawing.Point(2, 0);
            this.L_CheckPassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.L_CheckPassword.Name = "L_CheckPassword";
            this.L_CheckPassword.Size = new System.Drawing.Size(168, 22);
            this.L_CheckPassword.TabIndex = 0;
            this.L_CheckPassword.Text = "Подтвердите пароль";
            // 
            // TLP_Password
            // 
            this.TLP_Password.AutoSize = true;
            this.TLP_Password.ColumnCount = 1;
            this.TLP_Password.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TLP_Password.Controls.Add(this.TB_Password, 0, 1);
            this.TLP_Password.Controls.Add(this.L_Password, 0, 0);
            this.TLP_Password.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TLP_Password.Location = new System.Drawing.Point(2, 218);
            this.TLP_Password.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.TLP_Password.Name = "TLP_Password";
            this.TLP_Password.RowCount = 2;
            this.TLP_Password.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TLP_Password.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TLP_Password.Size = new System.Drawing.Size(255, 56);
            this.TLP_Password.TabIndex = 35;
            // 
            // TB_Password
            // 
            this.TB_Password.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TB_Password.Font = new System.Drawing.Font("Calibri", 10.25F);
            this.TB_Password.Location = new System.Drawing.Point(2, 25);
            this.TB_Password.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.TB_Password.MaxLength = 255;
            this.TB_Password.Name = "TB_Password";
            this.TB_Password.PasswordChar = '*';
            this.TB_Password.Size = new System.Drawing.Size(251, 28);
            this.TB_Password.TabIndex = 2;
            this.TB_Password.TextChanged += new System.EventHandler(this.EVENT_ValidationPassword);
            // 
            // L_Password
            // 
            this.L_Password.AutoSize = true;
            this.L_Password.Font = new System.Drawing.Font("Calibri", 10.25F);
            this.L_Password.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.L_Password.Location = new System.Drawing.Point(2, 0);
            this.L_Password.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.L_Password.Name = "L_Password";
            this.L_Password.Size = new System.Drawing.Size(66, 22);
            this.L_Password.TabIndex = 0;
            this.L_Password.Text = "Пароль";
            // 
            // TLP_Sex
            // 
            this.TLP_Sex.AutoSize = true;
            this.TLP_Sex.ColumnCount = 1;
            this.TLP_Sex.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TLP_Sex.Controls.Add(this.L_Sex, 0, 0);
            this.TLP_Sex.Controls.Add(this.LB_Sex, 0, 1);
            this.TLP_Sex.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TLP_Sex.Location = new System.Drawing.Point(261, 156);
            this.TLP_Sex.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.TLP_Sex.Name = "TLP_Sex";
            this.TLP_Sex.RowCount = 2;
            this.TLP_Sex.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TLP_Sex.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TLP_Sex.Size = new System.Drawing.Size(255, 56);
            this.TLP_Sex.TabIndex = 34;
            // 
            // L_Sex
            // 
            this.L_Sex.AutoSize = true;
            this.L_Sex.Font = new System.Drawing.Font("Calibri", 10.25F);
            this.L_Sex.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.L_Sex.Location = new System.Drawing.Point(2, 0);
            this.L_Sex.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.L_Sex.Name = "L_Sex";
            this.L_Sex.Size = new System.Drawing.Size(40, 22);
            this.L_Sex.TabIndex = 0;
            this.L_Sex.Text = "Пол";
            // 
            // LB_Sex
            // 
            this.LB_Sex.Dock = System.Windows.Forms.DockStyle.Top;
            this.LB_Sex.Font = new System.Drawing.Font("Calibri", 10.25F);
            this.LB_Sex.FormattingEnabled = true;
            this.LB_Sex.ItemHeight = 21;
            this.LB_Sex.Items.AddRange(new object[] {
            "мужской",
            "женский"});
            this.LB_Sex.Location = new System.Drawing.Point(2, 25);
            this.LB_Sex.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.LB_Sex.Name = "LB_Sex";
            this.LB_Sex.Size = new System.Drawing.Size(251, 25);
            this.LB_Sex.TabIndex = 1;
            // 
            // TLP_Birthsday
            // 
            this.TLP_Birthsday.AutoSize = true;
            this.TLP_Birthsday.ColumnCount = 1;
            this.TLP_Birthsday.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TLP_Birthsday.Controls.Add(this.L_Birthsday, 0, 0);
            this.TLP_Birthsday.Controls.Add(this.DTP_Birthsday, 0, 1);
            this.TLP_Birthsday.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TLP_Birthsday.Location = new System.Drawing.Point(2, 156);
            this.TLP_Birthsday.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.TLP_Birthsday.Name = "TLP_Birthsday";
            this.TLP_Birthsday.RowCount = 2;
            this.TLP_Birthsday.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TLP_Birthsday.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TLP_Birthsday.Size = new System.Drawing.Size(255, 56);
            this.TLP_Birthsday.TabIndex = 33;
            // 
            // L_Birthsday
            // 
            this.L_Birthsday.AutoSize = true;
            this.L_Birthsday.Font = new System.Drawing.Font("Calibri", 10.25F);
            this.L_Birthsday.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.L_Birthsday.Location = new System.Drawing.Point(2, 0);
            this.L_Birthsday.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.L_Birthsday.Name = "L_Birthsday";
            this.L_Birthsday.Size = new System.Drawing.Size(130, 22);
            this.L_Birthsday.TabIndex = 0;
            this.L_Birthsday.Text = "Дата рождения";
            // 
            // DTP_Birthsday
            // 
            this.DTP_Birthsday.CalendarFont = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DTP_Birthsday.Cursor = System.Windows.Forms.Cursors.Default;
            this.DTP_Birthsday.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DTP_Birthsday.Font = new System.Drawing.Font("Calibri", 10.25F);
            this.DTP_Birthsday.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTP_Birthsday.Location = new System.Drawing.Point(2, 25);
            this.DTP_Birthsday.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.DTP_Birthsday.Name = "DTP_Birthsday";
            this.DTP_Birthsday.Size = new System.Drawing.Size(251, 28);
            this.DTP_Birthsday.TabIndex = 1;
            // 
            // TLP_Phone
            // 
            this.TLP_Phone.AutoSize = true;
            this.TLP_Phone.ColumnCount = 1;
            this.TLP_Phone.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TLP_Phone.Controls.Add(this.TB_Phone, 0, 1);
            this.TLP_Phone.Controls.Add(this.L_Phone, 0, 0);
            this.TLP_Phone.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TLP_Phone.Location = new System.Drawing.Point(261, 94);
            this.TLP_Phone.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.TLP_Phone.Name = "TLP_Phone";
            this.TLP_Phone.RowCount = 2;
            this.TLP_Phone.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TLP_Phone.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TLP_Phone.Size = new System.Drawing.Size(255, 56);
            this.TLP_Phone.TabIndex = 32;
            // 
            // TB_Phone
            // 
            this.TB_Phone.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TB_Phone.Font = new System.Drawing.Font("Calibri", 10.25F);
            this.TB_Phone.Location = new System.Drawing.Point(2, 25);
            this.TB_Phone.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.TB_Phone.MaxLength = 32;
            this.TB_Phone.Name = "TB_Phone";
            this.TB_Phone.Size = new System.Drawing.Size(251, 28);
            this.TB_Phone.TabIndex = 2;
            this.TB_Phone.Leave += new System.EventHandler(this.EVENT_ValidationPhone);
            // 
            // L_Phone
            // 
            this.L_Phone.AutoSize = true;
            this.L_Phone.Font = new System.Drawing.Font("Calibri", 10.25F);
            this.L_Phone.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.L_Phone.Location = new System.Drawing.Point(2, 0);
            this.L_Phone.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.L_Phone.Name = "L_Phone";
            this.L_Phone.Size = new System.Drawing.Size(139, 22);
            this.L_Phone.TabIndex = 0;
            this.L_Phone.Text = "Номер телефона";
            // 
            // TLP_Email
            // 
            this.TLP_Email.AutoSize = true;
            this.TLP_Email.ColumnCount = 1;
            this.TLP_Email.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TLP_Email.Controls.Add(this.TB_Email, 0, 1);
            this.TLP_Email.Controls.Add(this.L_Email, 0, 0);
            this.TLP_Email.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TLP_Email.Location = new System.Drawing.Point(2, 94);
            this.TLP_Email.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.TLP_Email.Name = "TLP_Email";
            this.TLP_Email.RowCount = 2;
            this.TLP_Email.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TLP_Email.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TLP_Email.Size = new System.Drawing.Size(255, 56);
            this.TLP_Email.TabIndex = 31;
            // 
            // TB_Email
            // 
            this.TB_Email.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TB_Email.Font = new System.Drawing.Font("Calibri", 10.25F);
            this.TB_Email.Location = new System.Drawing.Point(2, 25);
            this.TB_Email.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.TB_Email.MaxLength = 255;
            this.TB_Email.Name = "TB_Email";
            this.TB_Email.Size = new System.Drawing.Size(251, 28);
            this.TB_Email.TabIndex = 2;
            this.TB_Email.TextChanged += new System.EventHandler(this.EVENT_ValidationEmail);
            // 
            // L_Email
            // 
            this.L_Email.AutoSize = true;
            this.L_Email.Font = new System.Drawing.Font("Calibri", 10.25F);
            this.L_Email.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.L_Email.Location = new System.Drawing.Point(2, 0);
            this.L_Email.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.L_Email.Name = "L_Email";
            this.L_Email.Size = new System.Drawing.Size(50, 22);
            this.L_Email.TabIndex = 0;
            this.L_Email.Text = "Email";
            // 
            // tableLayoutPanel13
            // 
            this.tableLayoutPanel13.AutoSize = true;
            this.tableLayoutPanel13.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel13.ColumnCount = 1;
            this.tableLayoutPanel13.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel13.Controls.Add(this.LIncorrectLogin, 0, 2);
            this.tableLayoutPanel13.Controls.Add(this.L_AnotherLogin, 0, 1);
            this.tableLayoutPanel13.Controls.Add(this.LHaveAccount, 0, 0);
            this.tableLayoutPanel13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel13.Location = new System.Drawing.Point(4, 281);
            this.tableLayoutPanel13.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel13.Name = "tableLayoutPanel13";
            this.tableLayoutPanel13.RowCount = 3;
            this.tableLayoutPanel13.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel13.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel13.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel13.Size = new System.Drawing.Size(251, 66);
            this.tableLayoutPanel13.TabIndex = 26;
            // 
            // LIncorrectLogin
            // 
            this.LIncorrectLogin.AutoSize = true;
            this.LIncorrectLogin.Cursor = System.Windows.Forms.Cursors.Default;
            this.LIncorrectLogin.Dock = System.Windows.Forms.DockStyle.Top;
            this.LIncorrectLogin.Font = new System.Drawing.Font("Calibri", 10.25F);
            this.LIncorrectLogin.ForeColor = System.Drawing.Color.Red;
            this.LIncorrectLogin.Location = new System.Drawing.Point(4, 44);
            this.LIncorrectLogin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LIncorrectLogin.Name = "LIncorrectLogin";
            this.LIncorrectLogin.Size = new System.Drawing.Size(243, 22);
            this.LIncorrectLogin.TabIndex = 15;
            this.LIncorrectLogin.Text = "Неверный Email или пароль\r\n";
            this.LIncorrectLogin.Visible = false;
            // 
            // L_AnotherLogin
            // 
            this.L_AnotherLogin.AutoSize = true;
            this.L_AnotherLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.L_AnotherLogin.Dock = System.Windows.Forms.DockStyle.Top;
            this.L_AnotherLogin.Font = new System.Drawing.Font("Calibri", 10.25F);
            this.L_AnotherLogin.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.L_AnotherLogin.Location = new System.Drawing.Point(4, 22);
            this.L_AnotherLogin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.L_AnotherLogin.Name = "L_AnotherLogin";
            this.L_AnotherLogin.Size = new System.Drawing.Size(243, 22);
            this.L_AnotherLogin.TabIndex = 14;
            this.L_AnotherLogin.Text = "Регистрация жюри ";
            this.L_AnotherLogin.Click += new System.EventHandler(this.LoginAnotherUser);
            this.L_AnotherLogin.MouseLeave += new System.EventHandler(this.CommunityLogOUT);
            this.L_AnotherLogin.MouseMove += new System.Windows.Forms.MouseEventHandler(this.CommunityLogIN);
            // 
            // LHaveAccount
            // 
            this.LHaveAccount.AutoSize = true;
            this.LHaveAccount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LHaveAccount.Dock = System.Windows.Forms.DockStyle.Top;
            this.LHaveAccount.Font = new System.Drawing.Font("Calibri", 10.25F);
            this.LHaveAccount.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.LHaveAccount.Location = new System.Drawing.Point(4, 0);
            this.LHaveAccount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LHaveAccount.Name = "LHaveAccount";
            this.LHaveAccount.Size = new System.Drawing.Size(243, 22);
            this.LHaveAccount.TabIndex = 13;
            this.LHaveAccount.Text = "Есть аккаунт?";
            this.LHaveAccount.Click += new System.EventHandler(this.SignInForm);
            this.LHaveAccount.MouseLeave += new System.EventHandler(this.DoLogOUT);
            this.LHaveAccount.MouseMove += new System.Windows.Forms.MouseEventHandler(this.DoLogIN);
            // 
            // BtnLogin
            // 
            this.BtnLogin.AutoSize = true;
            this.BtnLogin.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnLogin.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnLogin.Font = new System.Drawing.Font("Calibri", 12.25F, System.Drawing.FontStyle.Bold);
            this.BtnLogin.Location = new System.Drawing.Point(263, 281);
            this.BtnLogin.Margin = new System.Windows.Forms.Padding(4);
            this.BtnLogin.MinimumSize = new System.Drawing.Size(154, 42);
            this.BtnLogin.Name = "BtnLogin";
            this.BtnLogin.Size = new System.Drawing.Size(251, 42);
            this.BtnLogin.TabIndex = 24;
            this.BtnLogin.Text = "Зарегестрироваться";
            this.BtnLogin.UseVisualStyleBackColor = true;
            this.BtnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // TLP_Name
            // 
            this.TLP_Name.AutoSize = true;
            this.TLP_Name.ColumnCount = 1;
            this.TLP_Name.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TLP_Name.Controls.Add(this.L_Name, 0, 0);
            this.TLP_Name.Controls.Add(this.TB_Name, 0, 1);
            this.TLP_Name.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TLP_Name.Location = new System.Drawing.Point(2, 31);
            this.TLP_Name.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.TLP_Name.Name = "TLP_Name";
            this.TLP_Name.RowCount = 2;
            this.TLP_Name.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TLP_Name.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TLP_Name.Size = new System.Drawing.Size(255, 57);
            this.TLP_Name.TabIndex = 27;
            // 
            // L_Name
            // 
            this.L_Name.AutoSize = true;
            this.L_Name.Font = new System.Drawing.Font("Calibri", 10.25F);
            this.L_Name.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.L_Name.Location = new System.Drawing.Point(2, 0);
            this.L_Name.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.L_Name.Name = "L_Name";
            this.L_Name.Size = new System.Drawing.Size(47, 22);
            this.L_Name.TabIndex = 0;
            this.L_Name.Text = "ФИО";
            // 
            // TB_Name
            // 
            this.TB_Name.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TB_Name.Font = new System.Drawing.Font("Calibri", 10.25F);
            this.TB_Name.Location = new System.Drawing.Point(2, 25);
            this.TB_Name.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.TB_Name.MaxLength = 255;
            this.TB_Name.Name = "TB_Name";
            this.TB_Name.Size = new System.Drawing.Size(251, 28);
            this.TB_Name.TabIndex = 1;
            // 
            // TLP_Country
            // 
            this.TLP_Country.AutoSize = true;
            this.TLP_Country.ColumnCount = 1;
            this.TLP_Country.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TLP_Country.Controls.Add(this.L_Country, 0, 0);
            this.TLP_Country.Controls.Add(this.CB_Country, 0, 1);
            this.TLP_Country.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TLP_Country.Location = new System.Drawing.Point(261, 31);
            this.TLP_Country.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.TLP_Country.Name = "TLP_Country";
            this.TLP_Country.RowCount = 2;
            this.TLP_Country.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TLP_Country.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TLP_Country.Size = new System.Drawing.Size(255, 57);
            this.TLP_Country.TabIndex = 28;
            // 
            // L_Country
            // 
            this.L_Country.AutoSize = true;
            this.L_Country.Font = new System.Drawing.Font("Calibri", 10.25F);
            this.L_Country.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.L_Country.Location = new System.Drawing.Point(2, 0);
            this.L_Country.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.L_Country.Name = "L_Country";
            this.L_Country.Size = new System.Drawing.Size(64, 22);
            this.L_Country.TabIndex = 0;
            this.L_Country.Text = "Страна";
            // 
            // CB_Country
            // 
            this.CB_Country.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CB_Country.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_Country.Font = new System.Drawing.Font("Calibri", 10.25F);
            this.CB_Country.FormattingEnabled = true;
            this.CB_Country.Items.AddRange(new object[] {
            "Афганистан",
            "Албания",
            "Антарктида",
            "Алжир",
            "Американское Самоа",
            "Андорра",
            "Ангола",
            "Антигуа и Барбуда",
            "Азербайджан",
            "Аргентина",
            "Австралия",
            "Австрия",
            "Багамы",
            "Бахрейн",
            "Бангладеш",
            "Армения",
            "Барбадос",
            "Бельгия",
            "Бермуды",
            "Бутан",
            "Боливия, Многонациональное Государство",
            "Босния и Герцеговина",
            "Ботсвана",
            "Остров Буве",
            "Бразилия",
            "Белиз",
            "Британская территория в Индийском океане",
            "Соломоновы острова",
            "Виргинские острова, Британские",
            "Бруней-Даруссалам",
            "Болгария",
            "Мьянма",
            "Бурунди",
            "Беларусь",
            "Камбоджа",
            "Камерун",
            "Канада",
            "Кабо-Верде",
            "Острова Кайман",
            "Центрально-Африканская Республика",
            "Шри-Ланка",
            "Чад",
            "Чили",
            "Китай",
            "Тайвань (Китай)",
            "Остров Рождества",
            "Кокосовые (Килинг) острова",
            "Колумбия",
            "Коморы",
            "Майотта",
            "Конго",
            "Конго, Демократическая Республика",
            "Острова Кука",
            "Коста-Рика",
            "Хорватия",
            "Куба",
            "Кипр",
            "Чешская Республика",
            "Бенин",
            "Дания",
            "Доминика",
            "Доминиканская Республика",
            "Эквадор",
            "Эль-Сальвадор",
            "Экваториальная Гвинея",
            "Эфиопия",
            "Эритрея",
            "Эстония",
            "Фарерские острова",
            "Фолклендские острова (Мальвинские)",
            "Южная Джорджия и Южные Сандвичевы острова",
            "Фиджи",
            "Финляндия",
            "Эландские острова",
            "Франция",
            "Французская Гвиана",
            "Французская Полинезия",
            "Французские Южные территории",
            "Джибути",
            "Габон",
            "Грузия",
            "Гамбия",
            "Палестинская территория, оккупированная",
            "Германия",
            "Гана",
            "Гибралтар",
            "Кирибати",
            "Греция",
            "Гренландия",
            "Гренада",
            "Гваделупа",
            "Гуам",
            "Гватемала",
            "Гвинея",
            "Гайана",
            "Гаити",
            "Остров Херд и острова Макдональд",
            "Папский Престол (Государство — город Ватикан)",
            "Гондурас",
            "Гонконг",
            "Венгрия",
            "Исландия",
            "Индия",
            "Индонезия",
            "Иран, Исламская Республика",
            "Ирак",
            "Ирландия",
            "Израиль",
            "Италия",
            "Кот д\'Ивуар",
            "Ямайка",
            "Япония",
            "Казахстан",
            "Иордания",
            "Кения",
            "Корея, Народно-Демократическая Республика",
            "Корея, Республика",
            "Кувейт",
            "Киргизия",
            "Лаос",
            "Ливан",
            "Лесото",
            "Латвия",
            "Либерия",
            "Ливийская Арабская Джамахирия",
            "Лихтенштейн",
            "Литва",
            "Люксембург",
            "Макао",
            "Мадагаскар",
            "Малави",
            "Малайзия",
            "Мальдивы",
            "Мали",
            "Мальта",
            "Мартиника",
            "Мавритания",
            "Маврикий",
            "Мексика",
            "Монако",
            "Монголия",
            "Молдова, Республика",
            "Черногория",
            "Монтсеррат",
            "Марокко",
            "Мозамбик",
            "Оман",
            "Намибия",
            "Науру",
            "Непал",
            "Нидерланды",
            "Кюрасао",
            "Аруба",
            "Синт-Мартен",
            "Бонайре, Саба и Синт-Эстатиус",
            "Новая Каледония",
            "Вануату",
            "Новая Зеландия",
            "Никарагуа",
            "Нигер",
            "Нигерия",
            "Ниуэ",
            "Остров Норфолк",
            "Норвегия",
            "Северные Марианские острова",
            "Малые Тихоокеанские отдаленные острова Соединенных Штатов",
            "Микронезия, Федеративные Штаты",
            "Маршалловы острова",
            "Палау",
            "Пакистан",
            "Панама",
            "Папуа-Новая Гвинея",
            "Парагвай",
            "Перу",
            "Филиппины",
            "Питкерн",
            "Польша",
            "Португалия",
            "Гвинея-Бисау",
            "Тимор-Лесте",
            "Пуэрто-Рико",
            "Катар",
            "Реюньон",
            "Румыния",
            "Россия",
            "Руанда",
            "Сен-Бартельми",
            "Святая Елена, Остров вознесения, Тристан-да-Кунья",
            "Сент-Китс и Невис",
            "Ангилья",
            "Сент-Люсия",
            "Сен-Мартен",
            "Сент-Пьер и Микелон",
            "Сент-Винсент и Гренадины",
            "Сан-Марино",
            "Сан-Томе и Принсипи",
            "Саудовская Аравия",
            "Сенегал",
            "Сербия",
            "Сейшелы",
            "Сьерра-Леоне",
            "Сингапур",
            "Словакия",
            "Вьетнам",
            "Словения",
            "Сомали",
            "Южная Африка",
            "Зимбабве",
            "Испания",
            "Южный Судан",
            "Судан",
            "Западная Сахара",
            "Суринам",
            "Шпицберген и Ян Майен",
            "Свазиленд",
            "Швеция",
            "Швейцария",
            "Сирийская Арабская Республика",
            "Таджикистан",
            "Таиланд",
            "Того",
            "Токелау",
            "Тонга",
            "Тринидад и Тобаго",
            "Объединенные Арабские Эмираты",
            "Тунис",
            "Турция",
            "Туркмения",
            "Острова Теркс и Кайкос",
            "Тувалу",
            "Уганда",
            "Украина",
            "Республика Македония",
            "Египет",
            "Соединенное Королевство",
            "Гернси",
            "Джерси",
            "Остров Мэн",
            "Танзания, Объединенная Республика",
            "Соединенные Штаты",
            "Виргинские острова, США",
            "Буркина-Фасо",
            "Уругвай",
            "Узбекистан",
            "Венесуэла Боливарианская Республика",
            "Уоллис и Футуна",
            "Самоа",
            "Йемен",
            "Замбия",
            "Абхазия",
            "Южная Осетия"});
            this.CB_Country.Location = new System.Drawing.Point(2, 25);
            this.CB_Country.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.CB_Country.Name = "CB_Country";
            this.CB_Country.Size = new System.Drawing.Size(251, 29);
            this.CB_Country.TabIndex = 1;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 29F);
            this.ClientSize = new System.Drawing.Size(701, 455);
            this.Controls.Add(this.GBRegistration);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MinimumSize = new System.Drawing.Size(716, 492);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ExitProgram);
            this.Controls.SetChildIndex(this.GBRegistration, 0);
            this.GBRegistration.ResumeLayout(false);
            this.GBRegistration.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.TLP_CheckPassword.ResumeLayout(false);
            this.TLP_CheckPassword.PerformLayout();
            this.TLP_Password.ResumeLayout(false);
            this.TLP_Password.PerformLayout();
            this.TLP_Sex.ResumeLayout(false);
            this.TLP_Sex.PerformLayout();
            this.TLP_Birthsday.ResumeLayout(false);
            this.TLP_Birthsday.PerformLayout();
            this.TLP_Phone.ResumeLayout(false);
            this.TLP_Phone.PerformLayout();
            this.TLP_Email.ResumeLayout(false);
            this.TLP_Email.PerformLayout();
            this.tableLayoutPanel13.ResumeLayout(false);
            this.tableLayoutPanel13.PerformLayout();
            this.TLP_Name.ResumeLayout(false);
            this.TLP_Name.PerformLayout();
            this.TLP_Country.ResumeLayout(false);
            this.TLP_Country.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox GBRegistration;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button BtnLogin;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel13;
        private System.Windows.Forms.Label L_AnotherLogin;
        private System.Windows.Forms.Label LHaveAccount;
        private System.Windows.Forms.TableLayoutPanel TLP_CheckPassword;
        private System.Windows.Forms.TextBox TB_CheckPassword;
        private System.Windows.Forms.Label L_CheckPassword;
        private System.Windows.Forms.TableLayoutPanel TLP_Password;
        private System.Windows.Forms.TextBox TB_Password;
        private System.Windows.Forms.Label L_Password;
        private System.Windows.Forms.TableLayoutPanel TLP_Sex;
        private System.Windows.Forms.Label L_Sex;
        private System.Windows.Forms.ListBox LB_Sex;
        private System.Windows.Forms.TableLayoutPanel TLP_Birthsday;
        private System.Windows.Forms.Label L_Birthsday;
        private System.Windows.Forms.TableLayoutPanel TLP_Phone;
        private System.Windows.Forms.TextBox TB_Phone;
        private System.Windows.Forms.Label L_Phone;
        private System.Windows.Forms.TableLayoutPanel TLP_Email;
        private System.Windows.Forms.TextBox TB_Email;
        private System.Windows.Forms.Label L_Email;
        private System.Windows.Forms.TableLayoutPanel TLP_Name;
        private System.Windows.Forms.Label L_Name;
        private System.Windows.Forms.TextBox TB_Name;
        private System.Windows.Forms.TableLayoutPanel TLP_Country;
        private System.Windows.Forms.Label L_Country;
        private System.Windows.Forms.ComboBox CB_Country;
        private System.Windows.Forms.DateTimePicker DTP_Birthsday;
        public System.Windows.Forms.Label LIncorrectLogin;
    }
}
