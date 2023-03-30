namespace Taxi.Forms
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
            this.BtnLogin = new System.Windows.Forms.Button();
            this.GBRegistration = new System.Windows.Forms.GroupBox();
            this.TLPMain = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.TLP_DriverPass = new System.Windows.Forms.TableLayoutPanel();
            this.TB_DriverPass = new System.Windows.Forms.TextBox();
            this.LDriversPass = new System.Windows.Forms.Label();
            this.TLP_Password = new System.Windows.Forms.TableLayoutPanel();
            this.TB_Password = new System.Windows.Forms.TextBox();
            this.LPassword = new System.Windows.Forms.Label();
            this.TLP_Login = new System.Windows.Forms.TableLayoutPanel();
            this.TB_Login = new System.Windows.Forms.TextBox();
            this.LLogin = new System.Windows.Forms.Label();
            this.tableLayoutPanel13 = new System.Windows.Forms.TableLayoutPanel();
            this.LIncorrectLogin = new System.Windows.Forms.Label();
            this.LLoginDriver = new System.Windows.Forms.Label();
            this.LHaveAccount = new System.Windows.Forms.Label();
            this.TLP_Country = new System.Windows.Forms.TableLayoutPanel();
            this.LCountry = new System.Windows.Forms.Label();
            this.CB_Country = new System.Windows.Forms.ComboBox();
            this.TLP_Pnone = new System.Windows.Forms.TableLayoutPanel();
            this.TB_Phone = new System.Windows.Forms.TextBox();
            this.LPhone = new System.Windows.Forms.Label();
            this.TLP_Email = new System.Windows.Forms.TableLayoutPanel();
            this.TB_Email = new System.Windows.Forms.TextBox();
            this.LEmail = new System.Windows.Forms.Label();
            this.GBRegistration.SuspendLayout();
            this.TLPMain.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.TLP_DriverPass.SuspendLayout();
            this.TLP_Password.SuspendLayout();
            this.TLP_Login.SuspendLayout();
            this.tableLayoutPanel13.SuspendLayout();
            this.TLP_Country.SuspendLayout();
            this.TLP_Pnone.SuspendLayout();
            this.TLP_Email.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnLogin
            // 
            this.BtnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnLogin.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnLogin.Font = new System.Drawing.Font("Calibri", 12.25F, System.Drawing.FontStyle.Bold);
            this.BtnLogin.Location = new System.Drawing.Point(311, 212);
            this.BtnLogin.MinimumSize = new System.Drawing.Size(128, 33);
            this.BtnLogin.Name = "BtnLogin";
            this.BtnLogin.Size = new System.Drawing.Size(303, 33);
            this.BtnLogin.TabIndex = 23;
            this.BtnLogin.Text = "Зарегестрироваться";
            this.BtnLogin.UseVisualStyleBackColor = true;
            this.BtnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // GBRegistration
            // 
            this.GBRegistration.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GBRegistration.AutoSize = true;
            this.GBRegistration.Controls.Add(this.TLPMain);
            this.GBRegistration.Font = new System.Drawing.Font("Calibri", 18.25F, System.Drawing.FontStyle.Bold);
            this.GBRegistration.Location = new System.Drawing.Point(134, 12);
            this.GBRegistration.MinimumSize = new System.Drawing.Size(191, 285);
            this.GBRegistration.Name = "GBRegistration";
            this.GBRegistration.Size = new System.Drawing.Size(629, 383);
            this.GBRegistration.TabIndex = 3;
            this.GBRegistration.TabStop = false;
            this.GBRegistration.Text = "Регистрация";
            // 
            // TLPMain
            // 
            this.TLPMain.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.TLPMain.ColumnCount = 1;
            this.TLPMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TLPMain.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.TLPMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TLPMain.Location = new System.Drawing.Point(3, 33);
            this.TLPMain.Name = "TLPMain";
            this.TLPMain.RowCount = 1;
            this.TLPMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TLPMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 347F));
            this.TLPMain.Size = new System.Drawing.Size(623, 347);
            this.TLPMain.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.AutoSize = true;
            this.tableLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.TLP_DriverPass, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.TLP_Password, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.TLP_Login, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.BtnLogin, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel13, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.TLP_Country, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.TLP_Pnone, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.TLP_Email, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 6;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.00001F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(617, 341);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // TLP_DriverPass
            // 
            this.TLP_DriverPass.AutoSize = true;
            this.TLP_DriverPass.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.TLP_DriverPass.ColumnCount = 1;
            this.TLP_DriverPass.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.TLP_DriverPass.Controls.Add(this.TB_DriverPass, 0, 1);
            this.TLP_DriverPass.Controls.Add(this.LDriversPass, 0, 0);
            this.TLP_DriverPass.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TLP_DriverPass.Location = new System.Drawing.Point(3, 90);
            this.TLP_DriverPass.Name = "TLP_DriverPass";
            this.TLP_DriverPass.RowCount = 2;
            this.TLP_DriverPass.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TLP_DriverPass.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TLP_DriverPass.Size = new System.Drawing.Size(302, 55);
            this.TLP_DriverPass.TabIndex = 6;
            this.TLP_DriverPass.Visible = false;
            // 
            // TB_DriverPass
            // 
            this.TB_DriverPass.Dock = System.Windows.Forms.DockStyle.Top;
            this.TB_DriverPass.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TB_DriverPass.Location = new System.Drawing.Point(3, 21);
            this.TB_DriverPass.MaxLength = 9;
            this.TB_DriverPass.Name = "TB_DriverPass";
            this.TB_DriverPass.Size = new System.Drawing.Size(296, 31);
            this.TB_DriverPass.TabIndex = 11;
            this.TB_DriverPass.TextChanged += new System.EventHandler(this.ValidateDriverPass);
            this.TB_DriverPass.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValiadteDriverPass);
            // 
            // LDriversPass
            // 
            this.LDriversPass.AutoSize = true;
            this.LDriversPass.Dock = System.Windows.Forms.DockStyle.Top;
            this.LDriversPass.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.LDriversPass.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.LDriversPass.Location = new System.Drawing.Point(3, 0);
            this.LDriversPass.Name = "LDriversPass";
            this.LDriversPass.Size = new System.Drawing.Size(296, 18);
            this.LDriversPass.TabIndex = 10;
            this.LDriversPass.Text = "№ Водителького удостоверения";
            // 
            // TLP_Password
            // 
            this.TLP_Password.AutoSize = true;
            this.TLP_Password.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.TLP_Password.ColumnCount = 1;
            this.TLP_Password.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.TLP_Password.Controls.Add(this.TB_Password, 0, 1);
            this.TLP_Password.Controls.Add(this.LPassword, 0, 0);
            this.TLP_Password.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TLP_Password.Location = new System.Drawing.Point(311, 151);
            this.TLP_Password.Name = "TLP_Password";
            this.TLP_Password.RowCount = 2;
            this.TLP_Password.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TLP_Password.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TLP_Password.Size = new System.Drawing.Size(303, 55);
            this.TLP_Password.TabIndex = 5;
            // 
            // TB_Password
            // 
            this.TB_Password.Dock = System.Windows.Forms.DockStyle.Top;
            this.TB_Password.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TB_Password.Location = new System.Drawing.Point(3, 21);
            this.TB_Password.MaxLength = 255;
            this.TB_Password.Name = "TB_Password";
            this.TB_Password.PasswordChar = '*';
            this.TB_Password.Size = new System.Drawing.Size(297, 31);
            this.TB_Password.TabIndex = 11;
            this.TB_Password.TextChanged += new System.EventHandler(this.ValidatePassword);
            // 
            // LPassword
            // 
            this.LPassword.AutoSize = true;
            this.LPassword.Dock = System.Windows.Forms.DockStyle.Top;
            this.LPassword.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.LPassword.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.LPassword.Location = new System.Drawing.Point(3, 0);
            this.LPassword.Name = "LPassword";
            this.LPassword.Size = new System.Drawing.Size(297, 18);
            this.LPassword.TabIndex = 10;
            this.LPassword.Text = "Пароль";
            // 
            // TLP_Login
            // 
            this.TLP_Login.AutoSize = true;
            this.TLP_Login.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.TLP_Login.ColumnCount = 1;
            this.TLP_Login.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.TLP_Login.Controls.Add(this.TB_Login, 0, 1);
            this.TLP_Login.Controls.Add(this.LLogin, 0, 0);
            this.TLP_Login.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TLP_Login.Location = new System.Drawing.Point(3, 151);
            this.TLP_Login.Name = "TLP_Login";
            this.TLP_Login.RowCount = 2;
            this.TLP_Login.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TLP_Login.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TLP_Login.Size = new System.Drawing.Size(302, 55);
            this.TLP_Login.TabIndex = 6;
            // 
            // TB_Login
            // 
            this.TB_Login.Dock = System.Windows.Forms.DockStyle.Top;
            this.TB_Login.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TB_Login.Location = new System.Drawing.Point(3, 21);
            this.TB_Login.MaxLength = 255;
            this.TB_Login.Name = "TB_Login";
            this.TB_Login.Size = new System.Drawing.Size(296, 31);
            this.TB_Login.TabIndex = 11;
            // 
            // LLogin
            // 
            this.LLogin.AutoSize = true;
            this.LLogin.Dock = System.Windows.Forms.DockStyle.Top;
            this.LLogin.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.LLogin.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.LLogin.Location = new System.Drawing.Point(3, 0);
            this.LLogin.Name = "LLogin";
            this.LLogin.Size = new System.Drawing.Size(296, 18);
            this.LLogin.TabIndex = 10;
            this.LLogin.Text = "Логин";
            // 
            // tableLayoutPanel13
            // 
            this.tableLayoutPanel13.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel13.ColumnCount = 1;
            this.tableLayoutPanel13.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel13.Controls.Add(this.LIncorrectLogin, 0, 2);
            this.tableLayoutPanel13.Controls.Add(this.LLoginDriver, 0, 1);
            this.tableLayoutPanel13.Controls.Add(this.LHaveAccount, 0, 0);
            this.tableLayoutPanel13.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel13.Location = new System.Drawing.Point(3, 212);
            this.tableLayoutPanel13.Name = "tableLayoutPanel13";
            this.tableLayoutPanel13.RowCount = 3;
            this.tableLayoutPanel13.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel13.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel13.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel13.Size = new System.Drawing.Size(302, 100);
            this.tableLayoutPanel13.TabIndex = 21;
            // 
            // LIncorrectLogin
            // 
            this.LIncorrectLogin.AutoSize = true;
            this.LIncorrectLogin.Cursor = System.Windows.Forms.Cursors.Default;
            this.LIncorrectLogin.Dock = System.Windows.Forms.DockStyle.Top;
            this.LIncorrectLogin.Font = new System.Drawing.Font("Calibri", 10.25F);
            this.LIncorrectLogin.ForeColor = System.Drawing.Color.Red;
            this.LIncorrectLogin.Location = new System.Drawing.Point(3, 34);
            this.LIncorrectLogin.Name = "LIncorrectLogin";
            this.LIncorrectLogin.Size = new System.Drawing.Size(296, 17);
            this.LIncorrectLogin.TabIndex = 15;
            this.LIncorrectLogin.Text = "Неверный логин или пароль\r\n";
            this.LIncorrectLogin.Visible = false;
            // 
            // LLoginDriver
            // 
            this.LLoginDriver.AutoSize = true;
            this.LLoginDriver.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LLoginDriver.Dock = System.Windows.Forms.DockStyle.Top;
            this.LLoginDriver.Font = new System.Drawing.Font("Calibri", 10.25F);
            this.LLoginDriver.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.LLoginDriver.Location = new System.Drawing.Point(3, 17);
            this.LLoginDriver.Name = "LLoginDriver";
            this.LLoginDriver.Size = new System.Drawing.Size(296, 17);
            this.LLoginDriver.TabIndex = 14;
            this.LLoginDriver.Text = "Регистрация водителя";
            this.LLoginDriver.Click += new System.EventHandler(this.LoginCommunity);
            this.LLoginDriver.MouseLeave += new System.EventHandler(this.CommunityLogOUT);
            this.LLoginDriver.MouseMove += new System.Windows.Forms.MouseEventHandler(this.CommunityLogIN);
            // 
            // LHaveAccount
            // 
            this.LHaveAccount.AutoSize = true;
            this.LHaveAccount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LHaveAccount.Dock = System.Windows.Forms.DockStyle.Top;
            this.LHaveAccount.Font = new System.Drawing.Font("Calibri", 10.25F);
            this.LHaveAccount.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.LHaveAccount.Location = new System.Drawing.Point(3, 0);
            this.LHaveAccount.Name = "LHaveAccount";
            this.LHaveAccount.Size = new System.Drawing.Size(296, 17);
            this.LHaveAccount.TabIndex = 13;
            this.LHaveAccount.Text = "Есть аккаунт?";
            this.LHaveAccount.Click += new System.EventHandler(this.SignInForm);
            this.LHaveAccount.MouseLeave += new System.EventHandler(this.DoLogOUT);
            this.LHaveAccount.MouseMove += new System.Windows.Forms.MouseEventHandler(this.DoLogIN);
            // 
            // TLP_Country
            // 
            this.TLP_Country.AutoSize = true;
            this.TLP_Country.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.TLP_Country.ColumnCount = 1;
            this.TLP_Country.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.TLP_Country.Controls.Add(this.LCountry, 0, 0);
            this.TLP_Country.Controls.Add(this.CB_Country, 0, 1);
            this.TLP_Country.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TLP_Country.Location = new System.Drawing.Point(311, 90);
            this.TLP_Country.Name = "TLP_Country";
            this.TLP_Country.RowCount = 2;
            this.TLP_Country.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TLP_Country.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TLP_Country.Size = new System.Drawing.Size(303, 55);
            this.TLP_Country.TabIndex = 5;
            this.TLP_Country.Visible = false;
            // 
            // LCountry
            // 
            this.LCountry.AutoSize = true;
            this.LCountry.Dock = System.Windows.Forms.DockStyle.Top;
            this.LCountry.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.LCountry.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.LCountry.Location = new System.Drawing.Point(3, 0);
            this.LCountry.Name = "LCountry";
            this.LCountry.Size = new System.Drawing.Size(297, 18);
            this.LCountry.TabIndex = 10;
            this.LCountry.Text = "Страна";
            // 
            // CB_Country
            // 
            this.CB_Country.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CB_Country.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_Country.Font = new System.Drawing.Font("Calibri", 14.25F);
            this.CB_Country.FormattingEnabled = true;
            this.CB_Country.Items.AddRange(new object[] {
            "Австралия",
            "Австрия",
            "Азербайджан",
            "Албания",
            "Алжир",
            "Ангола",
            "Андорра",
            "Антигуа и Барбуда",
            "Аргентина",
            "Армения",
            "Афганистан",
            "Багамы",
            "Бангладеш",
            "Барбадос",
            "Бахрейн",
            "Белоруссия",
            "Белиз",
            "Бельгия",
            "Бенин",
            "Болгария",
            "Боливия",
            "Босния и Герцеговина",
            "Ботсвана",
            "Бразилия",
            "Бруней",
            "Буркина-Фасо",
            "Бурунди",
            "Бутан",
            "Вануату",
            "Великобритания",
            "Венгрия",
            "Венесуэла",
            "Восточный Тимор",
            "Вьетнам",
            "Габон",
            "Гаити",
            "Гайана",
            "Гамбия",
            "Гана",
            "Гватемала",
            "Гвинея",
            "Гвинея-Бисау",
            "Германия",
            "Гондурас",
            "Гренада",
            "Греция",
            "Грузия",
            "Дания",
            "Джибути",
            "Доминика",
            "Доминикана",
            "Египет",
            "Замбия",
            "Зимбабве",
            "Израиль",
            "Индия",
            "Индонезия",
            "Иордания",
            "Ирак",
            "Иран",
            "Ирландия",
            "Исландия",
            "Испания",
            "Италия",
            "Йемен",
            "Кабо-Верде",
            "Казахстан",
            "Камбоджа",
            "Камерун",
            "Канада",
            "Катар",
            "Кения",
            "Кипр",
            "Киргизия",
            "Кирибати",
            "Китай",
            "Колумбия",
            "Коморы",
            "Конго",
            "ДР Конго",
            "КНДР",
            "Корея",
            "Коста-Рика",
            "Кот-д’Ивуар",
            "Куба",
            "Кувейт",
            "Лаос",
            "Латвия",
            "Лесото",
            "Либерия",
            "Ливан",
            "Ливия",
            "Литва",
            "Лихтенштейн",
            "Люксембург",
            "Маврикий",
            "Мавритания",
            "Мадагаскар",
            "Малави",
            "Малайзия",
            "Мали",
            "Мальдивы",
            "Мальта",
            "Марокко",
            "Маршалловы Острова",
            "Мексика",
            "Микронезия",
            "Мозамбик",
            "Молдавия",
            "Монако",
            "Монголия",
            "Мьянма",
            "Намибия",
            "Науру",
            "Непал",
            "Нигер",
            "Нигерия",
            "Нидерланды",
            "Никарагуа",
            "Новая Зеландия",
            "Норвегия",
            "ОАЭ",
            "Оман",
            "Пакистан",
            "Палау",
            "Панама",
            "Папуа — Новая Гвинея",
            "Парагвай",
            "Перу",
            "Польша",
            "Португалия",
            "Россия",
            "Руанда",
            "Румыния",
            "Сальвадор",
            "Самоа",
            "Сан-Марино",
            "Сан-Томе и Принсипи",
            "Саудовская Аравия",
            "Северная Македония",
            "Сейшелы",
            "Сенегал",
            "Сент-Винсент и Гренадины",
            "Сент-Китс и Невис",
            "Сент-Люсия",
            "Сербия",
            "Сингапур",
            "Сирия",
            "Словакия",
            "Словения",
            "США",
            "Соломоновы Острова",
            "Сомали",
            "Судан",
            "Суринам",
            "Сьерра-Леоне",
            "Таджикистан",
            "Таиланд",
            "Танзания",
            "Того",
            "Тонга",
            "Тринидад и Тобаго",
            "Тувалу",
            "Тунис",
            "Туркменистан",
            "Турция",
            "Уганда",
            "Узбекистан",
            "Украина",
            "Уругвай",
            "Фиджи",
            "Филиппины",
            "Финляндия",
            "Франция",
            "Хорватия",
            "ЦАР",
            "Чад",
            "Черногория",
            "Чехия",
            "Чили",
            "Швейцария",
            "Швеция",
            "Шри-Ланка",
            "Эквадор",
            "Экваториальная Гвинея",
            "Эритрея",
            "Эсватини",
            "Эстония",
            "Эфиопия",
            "ЮАР",
            "Южный Судан",
            "Ямайка",
            "Япония"});
            this.CB_Country.Location = new System.Drawing.Point(3, 21);
            this.CB_Country.Name = "CB_Country";
            this.CB_Country.Size = new System.Drawing.Size(297, 31);
            this.CB_Country.TabIndex = 11;
            // 
            // TLP_Pnone
            // 
            this.TLP_Pnone.AutoSize = true;
            this.TLP_Pnone.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.TLP_Pnone.ColumnCount = 1;
            this.TLP_Pnone.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.TLP_Pnone.Controls.Add(this.TB_Phone, 0, 1);
            this.TLP_Pnone.Controls.Add(this.LPhone, 0, 0);
            this.TLP_Pnone.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TLP_Pnone.Location = new System.Drawing.Point(311, 29);
            this.TLP_Pnone.Name = "TLP_Pnone";
            this.TLP_Pnone.RowCount = 2;
            this.TLP_Pnone.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TLP_Pnone.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TLP_Pnone.Size = new System.Drawing.Size(303, 55);
            this.TLP_Pnone.TabIndex = 5;
            // 
            // TB_Phone
            // 
            this.TB_Phone.Dock = System.Windows.Forms.DockStyle.Top;
            this.TB_Phone.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TB_Phone.Location = new System.Drawing.Point(3, 21);
            this.TB_Phone.MaxLength = 32;
            this.TB_Phone.Name = "TB_Phone";
            this.TB_Phone.Size = new System.Drawing.Size(297, 31);
            this.TB_Phone.TabIndex = 11;
            this.TB_Phone.Leave += new System.EventHandler(this.ValidatePhone);
            // 
            // LPhone
            // 
            this.LPhone.AutoSize = true;
            this.LPhone.Dock = System.Windows.Forms.DockStyle.Top;
            this.LPhone.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.LPhone.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.LPhone.Location = new System.Drawing.Point(3, 0);
            this.LPhone.Name = "LPhone";
            this.LPhone.Size = new System.Drawing.Size(297, 18);
            this.LPhone.TabIndex = 10;
            this.LPhone.Text = "Номер телефона";
            // 
            // TLP_Email
            // 
            this.TLP_Email.AutoSize = true;
            this.TLP_Email.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.TLP_Email.ColumnCount = 1;
            this.TLP_Email.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.TLP_Email.Controls.Add(this.TB_Email, 0, 1);
            this.TLP_Email.Controls.Add(this.LEmail, 0, 0);
            this.TLP_Email.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TLP_Email.Location = new System.Drawing.Point(3, 29);
            this.TLP_Email.Name = "TLP_Email";
            this.TLP_Email.RowCount = 2;
            this.TLP_Email.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TLP_Email.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TLP_Email.Size = new System.Drawing.Size(302, 55);
            this.TLP_Email.TabIndex = 5;
            // 
            // TB_Email
            // 
            this.TB_Email.Dock = System.Windows.Forms.DockStyle.Top;
            this.TB_Email.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TB_Email.Location = new System.Drawing.Point(3, 21);
            this.TB_Email.MaxLength = 255;
            this.TB_Email.Name = "TB_Email";
            this.TB_Email.Size = new System.Drawing.Size(296, 31);
            this.TB_Email.TabIndex = 11;
            // 
            // LEmail
            // 
            this.LEmail.AutoSize = true;
            this.LEmail.Dock = System.Windows.Forms.DockStyle.Top;
            this.LEmail.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.LEmail.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.LEmail.Location = new System.Drawing.Point(3, 0);
            this.LEmail.Name = "LEmail";
            this.LEmail.Size = new System.Drawing.Size(296, 18);
            this.LEmail.TabIndex = 10;
            this.LEmail.Text = "E-mail";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.ClientSize = new System.Drawing.Size(775, 407);
            this.Controls.Add(this.GBRegistration);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ExitProgram);
            this.Controls.SetChildIndex(this.GBRegistration, 0);
            this.GBRegistration.ResumeLayout(false);
            this.TLPMain.ResumeLayout(false);
            this.TLPMain.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.TLP_DriverPass.ResumeLayout(false);
            this.TLP_DriverPass.PerformLayout();
            this.TLP_Password.ResumeLayout(false);
            this.TLP_Password.PerformLayout();
            this.TLP_Login.ResumeLayout(false);
            this.TLP_Login.PerformLayout();
            this.tableLayoutPanel13.ResumeLayout(false);
            this.tableLayoutPanel13.PerformLayout();
            this.TLP_Country.ResumeLayout(false);
            this.TLP_Country.PerformLayout();
            this.TLP_Pnone.ResumeLayout(false);
            this.TLP_Pnone.PerformLayout();
            this.TLP_Email.ResumeLayout(false);
            this.TLP_Email.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox GBRegistration;
        private System.Windows.Forms.TableLayoutPanel TLPMain;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel TLP_Password;
        private System.Windows.Forms.TextBox TB_Password;
        private System.Windows.Forms.Label LPassword;
        private System.Windows.Forms.TableLayoutPanel TLP_Login;
        private System.Windows.Forms.TextBox TB_Login;
        private System.Windows.Forms.Label LLogin;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel13;
        private System.Windows.Forms.Label LIncorrectLogin;
        private System.Windows.Forms.Label LLoginDriver;
        private System.Windows.Forms.Label LHaveAccount;
        private System.Windows.Forms.TableLayoutPanel TLP_Country;
        private System.Windows.Forms.Label LCountry;
        private System.Windows.Forms.TableLayoutPanel TLP_Pnone;
        private System.Windows.Forms.TextBox TB_Phone;
        private System.Windows.Forms.Label LPhone;
        private System.Windows.Forms.TableLayoutPanel TLP_Email;
        private System.Windows.Forms.TextBox TB_Email;
        private System.Windows.Forms.Label LEmail;
        private System.Windows.Forms.ComboBox CB_Country;
        private System.Windows.Forms.Button BtnLogin;
        private System.Windows.Forms.TableLayoutPanel TLP_DriverPass;
        private System.Windows.Forms.TextBox TB_DriverPass;
        private System.Windows.Forms.Label LDriversPass;
    }
}
