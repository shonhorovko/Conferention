using System;

namespace Conferention.Forms
{
    partial class ClientForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientForm));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.PSettings = new System.Windows.Forms.Panel();
            this.GBmain = new System.Windows.Forms.GroupBox();
            this.BExitAccount = new System.Windows.Forms.Button();
            this.BChangeProfile = new System.Windows.Forms.Button();
            this.BAddIcon = new System.Windows.Forms.Button();
            this.GBinfo = new System.Windows.Forms.GroupBox();
            this.PInfo = new System.Windows.Forms.Panel();
            this.LBirthsday = new System.Windows.Forms.Label();
            this.LName = new System.Windows.Forms.Label();
            this.LAge = new System.Windows.Forms.Label();
            this.LEmail = new System.Windows.Forms.Label();
            this.LSurname = new System.Windows.Forms.Label();
            this.LPhone = new System.Windows.Forms.Label();
            this.EditFields = new System.Windows.Forms.Panel();
            this.CB_Country = new System.Windows.Forms.ComboBox();
            this.TB_Age = new System.Windows.Forms.TextBox();
            this.BChangePass = new System.Windows.Forms.Button();
            this.DTPbirthsday = new System.Windows.Forms.DateTimePicker();
            this.TB_Surname = new System.Windows.Forms.TextBox();
            this.TB_Name = new System.Windows.Forms.TextBox();
            this.TB_Email = new System.Windows.Forms.TextBox();
            this.TB_Phone = new System.Windows.Forms.TextBox();
            this.Birthsday = new System.Windows.Forms.Label();
            this.Age = new System.Windows.Forms.Label();
            this.Surname = new System.Windows.Forms.Label();
            this.Name = new System.Windows.Forms.Label();
            this.Phone = new System.Windows.Forms.Label();
            this.Email = new System.Windows.Forms.Label();
            this.PBIcon = new System.Windows.Forms.PictureBox();
            this.OFD = new System.Windows.Forms.OpenFileDialog();
            this.tableLayoutPanel1.SuspendLayout();
            this.GBmain.SuspendLayout();
            this.GBinfo.SuspendLayout();
            this.PInfo.SuspendLayout();
            this.EditFields.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.PSettings, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.GBmain, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(705, 430);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // PSettings
            // 
            this.PSettings.AutoSize = true;
            this.PSettings.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.PSettings.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PSettings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PSettings.Location = new System.Drawing.Point(3, 3);
            this.PSettings.MinimumSize = new System.Drawing.Size(150, 355);
            this.PSettings.Name = "PSettings";
            this.PSettings.Size = new System.Drawing.Size(150, 424);
            this.PSettings.TabIndex = 0;
            // 
            // GBmain
            // 
            this.GBmain.AutoSize = true;
            this.GBmain.Controls.Add(this.BExitAccount);
            this.GBmain.Controls.Add(this.BChangeProfile);
            this.GBmain.Controls.Add(this.BAddIcon);
            this.GBmain.Controls.Add(this.GBinfo);
            this.GBmain.Controls.Add(this.PBIcon);
            this.GBmain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GBmain.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GBmain.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.GBmain.Location = new System.Drawing.Point(159, 3);
            this.GBmain.Name = "GBmain";
            this.GBmain.Size = new System.Drawing.Size(543, 424);
            this.GBmain.TabIndex = 1;
            this.GBmain.TabStop = false;
            this.GBmain.Text = "Личный кабинет";
            // 
            // BExitAccount
            // 
            this.BExitAccount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BExitAccount.Font = new System.Drawing.Font("Calibri", 10.25F);
            this.BExitAccount.Location = new System.Drawing.Point(6, 231);
            this.BExitAccount.Name = "BExitAccount";
            this.BExitAccount.Size = new System.Drawing.Size(100, 47);
            this.BExitAccount.TabIndex = 7;
            this.BExitAccount.Text = "Выход из аккаунта";
            this.BExitAccount.UseVisualStyleBackColor = true;
            this.BExitAccount.Click += new System.EventHandler(this.BExitAccount_Click);
            // 
            // BChangeProfile
            // 
            this.BChangeProfile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BChangeProfile.Font = new System.Drawing.Font("Calibri", 9.25F);
            this.BChangeProfile.Location = new System.Drawing.Point(6, 178);
            this.BChangeProfile.Name = "BChangeProfile";
            this.BChangeProfile.Size = new System.Drawing.Size(100, 47);
            this.BChangeProfile.TabIndex = 6;
            this.BChangeProfile.Text = "Редактировать профиль";
            this.BChangeProfile.UseVisualStyleBackColor = true;
            this.BChangeProfile.Click += new System.EventHandler(this.BChangeProfile_Click);
            // 
            // BAddIcon
            // 
            this.BAddIcon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BAddIcon.Font = new System.Drawing.Font("Calibri", 10.25F);
            this.BAddIcon.Location = new System.Drawing.Point(6, 128);
            this.BAddIcon.Name = "BAddIcon";
            this.BAddIcon.Size = new System.Drawing.Size(100, 47);
            this.BAddIcon.TabIndex = 5;
            this.BAddIcon.Text = "Добавить иконку";
            this.BAddIcon.UseVisualStyleBackColor = true;
            this.BAddIcon.Click += new System.EventHandler(this.ChooseIcon);
            // 
            // GBinfo
            // 
            this.GBinfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GBinfo.Controls.Add(this.PInfo);
            this.GBinfo.Location = new System.Drawing.Point(112, 30);
            this.GBinfo.MaximumSize = new System.Drawing.Size(3090, 221);
            this.GBinfo.MinimumSize = new System.Drawing.Size(301, 130);
            this.GBinfo.Name = "GBinfo";
            this.GBinfo.Size = new System.Drawing.Size(422, 176);
            this.GBinfo.TabIndex = 4;
            this.GBinfo.TabStop = false;
            this.GBinfo.Text = "Логин";
            // 
            // PInfo
            // 
            this.PInfo.AutoScroll = true;
            this.PInfo.AutoSize = true;
            this.PInfo.Controls.Add(this.LBirthsday);
            this.PInfo.Controls.Add(this.LName);
            this.PInfo.Controls.Add(this.LAge);
            this.PInfo.Controls.Add(this.LEmail);
            this.PInfo.Controls.Add(this.LSurname);
            this.PInfo.Controls.Add(this.LPhone);
            this.PInfo.Controls.Add(this.EditFields);
            this.PInfo.Controls.Add(this.Birthsday);
            this.PInfo.Controls.Add(this.Age);
            this.PInfo.Controls.Add(this.Surname);
            this.PInfo.Controls.Add(this.Name);
            this.PInfo.Controls.Add(this.Phone);
            this.PInfo.Controls.Add(this.Email);
            this.PInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PInfo.Location = new System.Drawing.Point(3, 27);
            this.PInfo.Name = "PInfo";
            this.PInfo.Size = new System.Drawing.Size(416, 146);
            this.PInfo.TabIndex = 18;
            // 
            // LBirthsday
            // 
            this.LBirthsday.AutoSize = true;
            this.LBirthsday.Font = new System.Drawing.Font("Calibri", 12.25F);
            this.LBirthsday.Location = new System.Drawing.Point(15, 105);
            this.LBirthsday.Name = "LBirthsday";
            this.LBirthsday.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LBirthsday.Size = new System.Drawing.Size(126, 21);
            this.LBirthsday.TabIndex = 54;
            this.LBirthsday.Text = "Дата рождения:";
            this.LBirthsday.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // LName
            // 
            this.LName.AutoSize = true;
            this.LName.Font = new System.Drawing.Font("Calibri", 12.25F);
            this.LName.Location = new System.Drawing.Point(95, 0);
            this.LName.Name = "LName";
            this.LName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LName.Size = new System.Drawing.Size(46, 21);
            this.LName.TabIndex = 51;
            this.LName.Text = "Имя:";
            this.LName.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // LAge
            // 
            this.LAge.AutoSize = true;
            this.LAge.Font = new System.Drawing.Font("Calibri", 12.25F);
            this.LAge.Location = new System.Drawing.Point(70, 84);
            this.LAge.Name = "LAge";
            this.LAge.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LAge.Size = new System.Drawing.Size(71, 21);
            this.LAge.TabIndex = 53;
            this.LAge.Text = "Возраст:";
            this.LAge.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // LEmail
            // 
            this.LEmail.AutoSize = true;
            this.LEmail.Font = new System.Drawing.Font("Calibri", 12.25F);
            this.LEmail.Location = new System.Drawing.Point(83, 42);
            this.LEmail.Name = "LEmail";
            this.LEmail.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LEmail.Size = new System.Drawing.Size(58, 21);
            this.LEmail.TabIndex = 49;
            this.LEmail.Text = "E-mail:";
            this.LEmail.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // LSurname
            // 
            this.LSurname.AutoSize = true;
            this.LSurname.Font = new System.Drawing.Font("Calibri", 12.25F);
            this.LSurname.Location = new System.Drawing.Point(59, 21);
            this.LSurname.Name = "LSurname";
            this.LSurname.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LSurname.Size = new System.Drawing.Size(82, 21);
            this.LSurname.TabIndex = 52;
            this.LSurname.Text = "Фамилия:";
            this.LSurname.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // LPhone
            // 
            this.LPhone.AutoSize = true;
            this.LPhone.Font = new System.Drawing.Font("Calibri", 12.25F);
            this.LPhone.Location = new System.Drawing.Point(4, 63);
            this.LPhone.Name = "LPhone";
            this.LPhone.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LPhone.Size = new System.Drawing.Size(137, 21);
            this.LPhone.TabIndex = 50;
            this.LPhone.Text = "Номер телефона:";
            this.LPhone.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // EditFields
            // 
            this.EditFields.AutoSize = true;
            this.EditFields.Controls.Add(this.CB_Country);
            this.EditFields.Controls.Add(this.TB_Age);
            this.EditFields.Controls.Add(this.BChangePass);
            this.EditFields.Controls.Add(this.DTPbirthsday);
            this.EditFields.Controls.Add(this.TB_Surname);
            this.EditFields.Controls.Add(this.TB_Name);
            this.EditFields.Controls.Add(this.TB_Email);
            this.EditFields.Controls.Add(this.TB_Phone);
            this.EditFields.Location = new System.Drawing.Point(142, 0);
            this.EditFields.Name = "EditFields";
            this.EditFields.Size = new System.Drawing.Size(4779, 191);
            this.EditFields.TabIndex = 48;
            this.EditFields.Visible = false;
            // 
            // CB_Country
            // 
            this.CB_Country.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_Country.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold);
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
            this.CB_Country.Location = new System.Drawing.Point(0, 105);
            this.CB_Country.Name = "CB_Country";
            this.CB_Country.Size = new System.Drawing.Size(141, 21);
            this.CB_Country.TabIndex = 49;
            this.CB_Country.Visible = false;
            // 
            // TB_Age
            // 
            this.TB_Age.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TB_Age.Font = new System.Drawing.Font("Calibri", 8.25F);
            this.TB_Age.Location = new System.Drawing.Point(0, 84);
            this.TB_Age.MaximumSize = new System.Drawing.Size(141, 21);
            this.TB_Age.MaxLength = 9;
            this.TB_Age.Name = "TB_Age";
            this.TB_Age.Size = new System.Drawing.Size(141, 21);
            this.TB_Age.TabIndex = 48;
            this.TB_Age.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.InputAge);
            // 
            // BChangePass
            // 
            this.BChangePass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BChangePass.Font = new System.Drawing.Font("Calibri", 9.25F);
            this.BChangePass.Location = new System.Drawing.Point(147, 84);
            this.BChangePass.Name = "BChangePass";
            this.BChangePass.Size = new System.Drawing.Size(107, 42);
            this.BChangePass.TabIndex = 7;
            this.BChangePass.Text = "Изменить логин и пароль";
            this.BChangePass.UseVisualStyleBackColor = true;
            this.BChangePass.Click += new System.EventHandler(this.BChangePass_Click);
            // 
            // DTPbirthsday
            // 
            this.DTPbirthsday.CalendarFont = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DTPbirthsday.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DTPbirthsday.CustomFormat = "dd.MM.yyyy";
            this.DTPbirthsday.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DTPbirthsday.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DTPbirthsday.Location = new System.Drawing.Point(0, 105);
            this.DTPbirthsday.MaxDate = new System.DateTime(2023, 2, 3, 0, 0, 0, 0);
            this.DTPbirthsday.Name = "DTPbirthsday";
            this.DTPbirthsday.Size = new System.Drawing.Size(141, 21);
            this.DTPbirthsday.TabIndex = 7;
            this.DTPbirthsday.Value = new System.DateTime(2023, 2, 3, 0, 0, 0, 0);
            // 
            // TB_Surname
            // 
            this.TB_Surname.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TB_Surname.Font = new System.Drawing.Font("Calibri", 8.25F);
            this.TB_Surname.Location = new System.Drawing.Point(0, 21);
            this.TB_Surname.MaxLength = 255;
            this.TB_Surname.Name = "TB_Surname";
            this.TB_Surname.Size = new System.Drawing.Size(3620, 21);
            this.TB_Surname.TabIndex = 47;
            // 
            // TB_Name
            // 
            this.TB_Name.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TB_Name.Font = new System.Drawing.Font("Calibri", 8.25F);
            this.TB_Name.Location = new System.Drawing.Point(0, 0);
            this.TB_Name.MaxLength = 255;
            this.TB_Name.Name = "TB_Name";
            this.TB_Name.Size = new System.Drawing.Size(3620, 21);
            this.TB_Name.TabIndex = 39;
            // 
            // TB_Email
            // 
            this.TB_Email.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TB_Email.Font = new System.Drawing.Font("Calibri", 8.25F);
            this.TB_Email.Location = new System.Drawing.Point(0, 42);
            this.TB_Email.MaxLength = 255;
            this.TB_Email.Name = "TB_Email";
            this.TB_Email.Size = new System.Drawing.Size(3620, 21);
            this.TB_Email.TabIndex = 46;
            // 
            // TB_Phone
            // 
            this.TB_Phone.Font = new System.Drawing.Font("Calibri", 8.25F);
            this.TB_Phone.Location = new System.Drawing.Point(0, 63);
            this.TB_Phone.MaxLength = 32;
            this.TB_Phone.Name = "TB_Phone";
            this.TB_Phone.Size = new System.Drawing.Size(3620, 21);
            this.TB_Phone.TabIndex = 45;
            // 
            // Birthsday
            // 
            this.Birthsday.AutoSize = true;
            this.Birthsday.Font = new System.Drawing.Font("Calibri", 12.25F);
            this.Birthsday.ForeColor = System.Drawing.Color.White;
            this.Birthsday.Location = new System.Drawing.Point(138, 105);
            this.Birthsday.Name = "Birthsday";
            this.Birthsday.Size = new System.Drawing.Size(121, 21);
            this.Birthsday.TabIndex = 37;
            this.Birthsday.Text = "Дата рождения";
            // 
            // Age
            // 
            this.Age.AutoSize = true;
            this.Age.Font = new System.Drawing.Font("Calibri", 12.25F);
            this.Age.ForeColor = System.Drawing.Color.White;
            this.Age.Location = new System.Drawing.Point(138, 84);
            this.Age.Name = "Age";
            this.Age.Size = new System.Drawing.Size(66, 21);
            this.Age.TabIndex = 36;
            this.Age.Text = "Возраст";
            // 
            // Surname
            // 
            this.Surname.AutoSize = true;
            this.Surname.Font = new System.Drawing.Font("Calibri", 12.25F);
            this.Surname.ForeColor = System.Drawing.Color.White;
            this.Surname.Location = new System.Drawing.Point(138, 21);
            this.Surname.Name = "Surname";
            this.Surname.Size = new System.Drawing.Size(77, 21);
            this.Surname.TabIndex = 33;
            this.Surname.Text = "Фамилия";
            // 
            // Name
            // 
            this.Name.AutoSize = true;
            this.Name.Font = new System.Drawing.Font("Calibri", 12.25F);
            this.Name.ForeColor = System.Drawing.Color.White;
            this.Name.Location = new System.Drawing.Point(138, 0);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(41, 21);
            this.Name.TabIndex = 32;
            this.Name.Text = "Имя";
            // 
            // Phone
            // 
            this.Phone.AutoSize = true;
            this.Phone.Font = new System.Drawing.Font("Calibri", 12.25F);
            this.Phone.ForeColor = System.Drawing.Color.White;
            this.Phone.Location = new System.Drawing.Point(138, 63);
            this.Phone.Name = "Phone";
            this.Phone.Size = new System.Drawing.Size(132, 21);
            this.Phone.TabIndex = 31;
            this.Phone.Text = "Номер телефона";
            // 
            // Email
            // 
            this.Email.AutoSize = true;
            this.Email.Font = new System.Drawing.Font("Calibri", 12.25F);
            this.Email.ForeColor = System.Drawing.Color.White;
            this.Email.Location = new System.Drawing.Point(138, 42);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(53, 21);
            this.Email.TabIndex = 30;
            this.Email.Text = "E-mail";
            // 
            // PBIcon
            // 
            this.PBIcon.Location = new System.Drawing.Point(6, 30);
            this.PBIcon.Name = "PBIcon";
            this.PBIcon.Size = new System.Drawing.Size(100, 100);
            this.PBIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PBIcon.TabIndex = 1;
            this.PBIcon.TabStop = false;
            // 
            // OFD
            // 
            this.OFD.FileName = "Icon";
            this.OFD.Filter = "(*.png)|*.png|(*.jpg)|*.jpg";
            this.OFD.InitialDirectory = "C:\\Users";
            // 
            // ClientForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(705, 430);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(721, 469);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Taxi";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ExitProgram);
            this.Load += new System.EventHandler(this.UserForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.GBmain.ResumeLayout(false);
            this.GBinfo.ResumeLayout(false);
            this.GBinfo.PerformLayout();
            this.PInfo.ResumeLayout(false);
            this.PInfo.PerformLayout();
            this.EditFields.ResumeLayout(false);
            this.EditFields.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBIcon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel PSettings;
        private System.Windows.Forms.OpenFileDialog OFD;
        private System.Windows.Forms.GroupBox GBmain;
        private System.Windows.Forms.Button BExitAccount;
        private System.Windows.Forms.Button BChangeProfile;
        private System.Windows.Forms.Button BAddIcon;
        private System.Windows.Forms.GroupBox GBinfo;
        private System.Windows.Forms.Panel PInfo;
        private System.Windows.Forms.Label Birthsday;
        private System.Windows.Forms.Label Age;
        private System.Windows.Forms.Label Surname;
        private System.Windows.Forms.Label Name;
        private System.Windows.Forms.Label Phone;
        private System.Windows.Forms.Label Email;
        private System.Windows.Forms.PictureBox PBIcon;
        private System.Windows.Forms.Label LBirthsday;
        private System.Windows.Forms.Label LName;
        private System.Windows.Forms.Label LAge;
        private System.Windows.Forms.Label LEmail;
        private System.Windows.Forms.Label LSurname;
        private System.Windows.Forms.Label LPhone;
        private System.Windows.Forms.Panel EditFields;
        private System.Windows.Forms.ComboBox CB_Country;
        private System.Windows.Forms.TextBox TB_Age;
        private System.Windows.Forms.Button BChangePass;
        private System.Windows.Forms.DateTimePicker DTPbirthsday;
        private System.Windows.Forms.TextBox TB_Surname;
        private System.Windows.Forms.TextBox TB_Name;
        private System.Windows.Forms.TextBox TB_Email;
        private System.Windows.Forms.TextBox TB_Phone;
    }
}
