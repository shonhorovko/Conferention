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
            this.TLP_Info = new System.Windows.Forms.TableLayoutPanel();
            this.TLP_TittleLabel = new System.Windows.Forms.TableLayoutPanel();
            this.T_L_Password = new System.Windows.Forms.Label();
            this.T_L_Event = new System.Windows.Forms.Label();
            this.T_L_Direction = new System.Windows.Forms.Label();
            this.T_L_Country = new System.Windows.Forms.Label();
            this.T_L_Sex = new System.Windows.Forms.Label();
            this.T_L_Birthsday = new System.Windows.Forms.Label();
            this.T_L_Role = new System.Windows.Forms.Label();
            this.T_L_Phone = new System.Windows.Forms.Label();
            this.T_L_Name = new System.Windows.Forms.Label();
            this.T_L_Email = new System.Windows.Forms.Label();
            this.TLP_Label = new System.Windows.Forms.TableLayoutPanel();
            this.L_Password = new System.Windows.Forms.Label();
            this.L_Event = new System.Windows.Forms.Label();
            this.L_Direction = new System.Windows.Forms.Label();
            this.L_Country = new System.Windows.Forms.Label();
            this.L_Sex = new System.Windows.Forms.Label();
            this.L_Birthsday = new System.Windows.Forms.Label();
            this.L_Role = new System.Windows.Forms.Label();
            this.L_Phone = new System.Windows.Forms.Label();
            this.L_Email = new System.Windows.Forms.Label();
            this.L_Name = new System.Windows.Forms.Label();
            this.TLP_EditFields = new System.Windows.Forms.TableLayoutPanel();
            this.CB_Event = new System.Windows.Forms.ComboBox();
            this.CB_Direction = new System.Windows.Forms.ComboBox();
            this.CB_Country = new System.Windows.Forms.ComboBox();
            this.TB_Role = new System.Windows.Forms.TextBox();
            this.TB_Phone = new System.Windows.Forms.TextBox();
            this.TB_Email = new System.Windows.Forms.TextBox();
            this.TB_Name = new System.Windows.Forms.TextBox();
            this.B_ChangePassword = new System.Windows.Forms.Button();
            this.DTP_Birthsday = new System.Windows.Forms.DateTimePicker();
            this.FLP_Sex = new System.Windows.Forms.FlowLayoutPanel();
            this.RB_Male = new System.Windows.Forms.RadioButton();
            this.RB_Female = new System.Windows.Forms.RadioButton();
            this.BExitAccount = new System.Windows.Forms.Button();
            this.BChangeProfile = new System.Windows.Forms.Button();
            this.BAddIcon = new System.Windows.Forms.Button();
            this.PBIcon = new System.Windows.Forms.PictureBox();
            this.OFD = new System.Windows.Forms.OpenFileDialog();
            this.tableLayoutPanel1.SuspendLayout();
            this.GBmain.SuspendLayout();
            this.TLP_Info.SuspendLayout();
            this.TLP_TittleLabel.SuspendLayout();
            this.TLP_Label.SuspendLayout();
            this.TLP_EditFields.SuspendLayout();
            this.FLP_Sex.SuspendLayout();
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
            this.tableLayoutPanel1.Size = new System.Drawing.Size(542, 462);
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
            this.PSettings.Size = new System.Drawing.Size(150, 456);
            this.PSettings.TabIndex = 0;
            // 
            // GBmain
            // 
            this.GBmain.AutoSize = true;
            this.GBmain.Controls.Add(this.TLP_Info);
            this.GBmain.Controls.Add(this.BExitAccount);
            this.GBmain.Controls.Add(this.BChangeProfile);
            this.GBmain.Controls.Add(this.BAddIcon);
            this.GBmain.Controls.Add(this.PBIcon);
            this.GBmain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GBmain.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GBmain.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.GBmain.Location = new System.Drawing.Point(159, 3);
            this.GBmain.Name = "GBmain";
            this.GBmain.Size = new System.Drawing.Size(380, 456);
            this.GBmain.TabIndex = 1;
            this.GBmain.TabStop = false;
            this.GBmain.Text = "Личный кабинет";
            // 
            // TLP_Info
            // 
            this.TLP_Info.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TLP_Info.AutoScroll = true;
            this.TLP_Info.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.TLP_Info.ColumnCount = 3;
            this.TLP_Info.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.TLP_Info.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.TLP_Info.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.TLP_Info.Controls.Add(this.TLP_TittleLabel, 0, 0);
            this.TLP_Info.Controls.Add(this.TLP_Label, 1, 0);
            this.TLP_Info.Controls.Add(this.TLP_EditFields, 2, 0);
            this.TLP_Info.Location = new System.Drawing.Point(112, 30);
            this.TLP_Info.Name = "TLP_Info";
            this.TLP_Info.RowCount = 1;
            this.TLP_Info.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TLP_Info.Size = new System.Drawing.Size(259, 417);
            this.TLP_Info.TabIndex = 8;
            // 
            // TLP_TittleLabel
            // 
            this.TLP_TittleLabel.AutoScroll = true;
            this.TLP_TittleLabel.AutoSize = true;
            this.TLP_TittleLabel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.TLP_TittleLabel.ColumnCount = 1;
            this.TLP_TittleLabel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.TLP_TittleLabel.Controls.Add(this.T_L_Password, 0, 9);
            this.TLP_TittleLabel.Controls.Add(this.T_L_Event, 0, 8);
            this.TLP_TittleLabel.Controls.Add(this.T_L_Direction, 0, 7);
            this.TLP_TittleLabel.Controls.Add(this.T_L_Country, 0, 6);
            this.TLP_TittleLabel.Controls.Add(this.T_L_Sex, 0, 5);
            this.TLP_TittleLabel.Controls.Add(this.T_L_Birthsday, 0, 4);
            this.TLP_TittleLabel.Controls.Add(this.T_L_Role, 0, 3);
            this.TLP_TittleLabel.Controls.Add(this.T_L_Phone, 0, 2);
            this.TLP_TittleLabel.Controls.Add(this.T_L_Name, 0, 0);
            this.TLP_TittleLabel.Controls.Add(this.T_L_Email, 0, 1);
            this.TLP_TittleLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TLP_TittleLabel.Font = new System.Drawing.Font("Calibri", 12.25F, System.Drawing.FontStyle.Bold);
            this.TLP_TittleLabel.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.TLP_TittleLabel.Location = new System.Drawing.Point(3, 3);
            this.TLP_TittleLabel.Name = "TLP_TittleLabel";
            this.TLP_TittleLabel.RowCount = 10;
            this.TLP_TittleLabel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.TLP_TittleLabel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.TLP_TittleLabel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.TLP_TittleLabel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.TLP_TittleLabel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.TLP_TittleLabel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.TLP_TittleLabel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.TLP_TittleLabel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.TLP_TittleLabel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.TLP_TittleLabel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.TLP_TittleLabel.Size = new System.Drawing.Size(193, 441);
            this.TLP_TittleLabel.TabIndex = 0;
            // 
            // T_L_Password
            // 
            this.T_L_Password.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.T_L_Password.AutoSize = true;
            this.T_L_Password.Font = new System.Drawing.Font("Calibri", 13.25F, System.Drawing.FontStyle.Bold);
            this.T_L_Password.Location = new System.Drawing.Point(100, 404);
            this.T_L_Password.Name = "T_L_Password";
            this.T_L_Password.Size = new System.Drawing.Size(90, 28);
            this.T_L_Password.TabIndex = 9;
            this.T_L_Password.Text = "Пароль:";
            this.T_L_Password.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // T_L_Event
            // 
            this.T_L_Event.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.T_L_Event.AutoSize = true;
            this.T_L_Event.Font = new System.Drawing.Font("Calibri", 13.25F, System.Drawing.FontStyle.Bold);
            this.T_L_Event.Location = new System.Drawing.Point(34, 360);
            this.T_L_Event.Name = "T_L_Event";
            this.T_L_Event.Size = new System.Drawing.Size(156, 28);
            this.T_L_Event.TabIndex = 8;
            this.T_L_Event.Tag = "Event";
            this.T_L_Event.Text = "Мероприятие:";
            this.T_L_Event.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // T_L_Direction
            // 
            this.T_L_Direction.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.T_L_Direction.AutoSize = true;
            this.T_L_Direction.Font = new System.Drawing.Font("Calibri", 13.25F, System.Drawing.FontStyle.Bold);
            this.T_L_Direction.Location = new System.Drawing.Point(38, 316);
            this.T_L_Direction.Name = "T_L_Direction";
            this.T_L_Direction.Size = new System.Drawing.Size(152, 28);
            this.T_L_Direction.TabIndex = 7;
            this.T_L_Direction.Tag = "Direction";
            this.T_L_Direction.Text = "Направление:";
            this.T_L_Direction.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // T_L_Country
            // 
            this.T_L_Country.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.T_L_Country.AutoSize = true;
            this.T_L_Country.Font = new System.Drawing.Font("Calibri", 13.25F, System.Drawing.FontStyle.Bold);
            this.T_L_Country.Location = new System.Drawing.Point(104, 272);
            this.T_L_Country.Name = "T_L_Country";
            this.T_L_Country.Size = new System.Drawing.Size(86, 28);
            this.T_L_Country.TabIndex = 6;
            this.T_L_Country.Text = "Страна:";
            this.T_L_Country.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // T_L_Sex
            // 
            this.T_L_Sex.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.T_L_Sex.AutoSize = true;
            this.T_L_Sex.Font = new System.Drawing.Font("Calibri", 13.25F, System.Drawing.FontStyle.Bold);
            this.T_L_Sex.Location = new System.Drawing.Point(134, 228);
            this.T_L_Sex.Name = "T_L_Sex";
            this.T_L_Sex.Size = new System.Drawing.Size(56, 28);
            this.T_L_Sex.TabIndex = 5;
            this.T_L_Sex.Text = "Пол:";
            this.T_L_Sex.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // T_L_Birthsday
            // 
            this.T_L_Birthsday.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.T_L_Birthsday.AutoSize = true;
            this.T_L_Birthsday.Font = new System.Drawing.Font("Calibri", 13.25F, System.Drawing.FontStyle.Bold);
            this.T_L_Birthsday.Location = new System.Drawing.Point(18, 184);
            this.T_L_Birthsday.Name = "T_L_Birthsday";
            this.T_L_Birthsday.Size = new System.Drawing.Size(172, 28);
            this.T_L_Birthsday.TabIndex = 4;
            this.T_L_Birthsday.Text = "Дата рождения:";
            this.T_L_Birthsday.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // T_L_Role
            // 
            this.T_L_Role.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.T_L_Role.AutoSize = true;
            this.T_L_Role.Font = new System.Drawing.Font("Calibri", 13.25F, System.Drawing.FontStyle.Bold);
            this.T_L_Role.Location = new System.Drawing.Point(125, 140);
            this.T_L_Role.Name = "T_L_Role";
            this.T_L_Role.Size = new System.Drawing.Size(65, 28);
            this.T_L_Role.TabIndex = 3;
            this.T_L_Role.Text = "Роль:";
            this.T_L_Role.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // T_L_Phone
            // 
            this.T_L_Phone.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.T_L_Phone.AutoSize = true;
            this.T_L_Phone.Font = new System.Drawing.Font("Calibri", 13.25F, System.Drawing.FontStyle.Bold);
            this.T_L_Phone.Location = new System.Drawing.Point(3, 96);
            this.T_L_Phone.Name = "T_L_Phone";
            this.T_L_Phone.Size = new System.Drawing.Size(187, 28);
            this.T_L_Phone.TabIndex = 2;
            this.T_L_Phone.Text = "Номер телефона:";
            this.T_L_Phone.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // T_L_Name
            // 
            this.T_L_Name.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.T_L_Name.AutoSize = true;
            this.T_L_Name.Font = new System.Drawing.Font("Calibri", 13.25F, System.Drawing.FontStyle.Bold);
            this.T_L_Name.Location = new System.Drawing.Point(124, 8);
            this.T_L_Name.Name = "T_L_Name";
            this.T_L_Name.Size = new System.Drawing.Size(66, 28);
            this.T_L_Name.TabIndex = 0;
            this.T_L_Name.Text = "ФИО:";
            this.T_L_Name.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // T_L_Email
            // 
            this.T_L_Email.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.T_L_Email.AutoSize = true;
            this.T_L_Email.Font = new System.Drawing.Font("Calibri", 13.25F, System.Drawing.FontStyle.Bold);
            this.T_L_Email.Location = new System.Drawing.Point(115, 52);
            this.T_L_Email.Name = "T_L_Email";
            this.T_L_Email.Size = new System.Drawing.Size(75, 28);
            this.T_L_Email.TabIndex = 1;
            this.T_L_Email.Text = "Почта:";
            this.T_L_Email.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // TLP_Label
            // 
            this.TLP_Label.AutoScroll = true;
            this.TLP_Label.AutoSize = true;
            this.TLP_Label.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.TLP_Label.ColumnCount = 1;
            this.TLP_Label.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.TLP_Label.Controls.Add(this.L_Password, 0, 9);
            this.TLP_Label.Controls.Add(this.L_Event, 0, 8);
            this.TLP_Label.Controls.Add(this.L_Direction, 0, 7);
            this.TLP_Label.Controls.Add(this.L_Country, 0, 6);
            this.TLP_Label.Controls.Add(this.L_Sex, 0, 5);
            this.TLP_Label.Controls.Add(this.L_Birthsday, 0, 4);
            this.TLP_Label.Controls.Add(this.L_Role, 0, 3);
            this.TLP_Label.Controls.Add(this.L_Phone, 0, 2);
            this.TLP_Label.Controls.Add(this.L_Email, 0, 1);
            this.TLP_Label.Controls.Add(this.L_Name, 0, 0);
            this.TLP_Label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TLP_Label.Font = new System.Drawing.Font("Calibri", 12.25F, System.Drawing.FontStyle.Bold);
            this.TLP_Label.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.TLP_Label.Location = new System.Drawing.Point(202, 3);
            this.TLP_Label.Name = "TLP_Label";
            this.TLP_Label.RowCount = 10;
            this.TLP_Label.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.TLP_Label.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.TLP_Label.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.TLP_Label.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.TLP_Label.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.TLP_Label.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.TLP_Label.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.TLP_Label.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.TLP_Label.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.TLP_Label.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.TLP_Label.Size = new System.Drawing.Size(54, 441);
            this.TLP_Label.TabIndex = 1;
            // 
            // L_Password
            // 
            this.L_Password.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.L_Password.AutoSize = true;
            this.L_Password.Font = new System.Drawing.Font("Calibri", 13.25F, System.Drawing.FontStyle.Bold);
            this.L_Password.Location = new System.Drawing.Point(3, 404);
            this.L_Password.Name = "L_Password";
            this.L_Password.Size = new System.Drawing.Size(48, 28);
            this.L_Password.TabIndex = 9;
            this.L_Password.Text = "123";
            // 
            // L_Event
            // 
            this.L_Event.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.L_Event.AutoSize = true;
            this.L_Event.Font = new System.Drawing.Font("Calibri", 13.25F, System.Drawing.FontStyle.Bold);
            this.L_Event.Location = new System.Drawing.Point(3, 360);
            this.L_Event.Name = "L_Event";
            this.L_Event.Size = new System.Drawing.Size(48, 28);
            this.L_Event.TabIndex = 8;
            this.L_Event.Tag = "Event";
            this.L_Event.Text = "123";
            // 
            // L_Direction
            // 
            this.L_Direction.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.L_Direction.AutoSize = true;
            this.L_Direction.Font = new System.Drawing.Font("Calibri", 13.25F, System.Drawing.FontStyle.Bold);
            this.L_Direction.Location = new System.Drawing.Point(3, 316);
            this.L_Direction.Name = "L_Direction";
            this.L_Direction.Size = new System.Drawing.Size(48, 28);
            this.L_Direction.TabIndex = 7;
            this.L_Direction.Tag = "Direction";
            this.L_Direction.Text = "123";
            // 
            // L_Country
            // 
            this.L_Country.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.L_Country.AutoSize = true;
            this.L_Country.Font = new System.Drawing.Font("Calibri", 13.25F, System.Drawing.FontStyle.Bold);
            this.L_Country.Location = new System.Drawing.Point(3, 272);
            this.L_Country.Name = "L_Country";
            this.L_Country.Size = new System.Drawing.Size(48, 28);
            this.L_Country.TabIndex = 6;
            this.L_Country.Tag = "";
            this.L_Country.Text = "123";
            // 
            // L_Sex
            // 
            this.L_Sex.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.L_Sex.AutoSize = true;
            this.L_Sex.Font = new System.Drawing.Font("Calibri", 13.25F, System.Drawing.FontStyle.Bold);
            this.L_Sex.Location = new System.Drawing.Point(3, 228);
            this.L_Sex.Name = "L_Sex";
            this.L_Sex.Size = new System.Drawing.Size(48, 28);
            this.L_Sex.TabIndex = 5;
            this.L_Sex.Text = "123";
            // 
            // L_Birthsday
            // 
            this.L_Birthsday.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.L_Birthsday.AutoSize = true;
            this.L_Birthsday.Font = new System.Drawing.Font("Calibri", 13.25F, System.Drawing.FontStyle.Bold);
            this.L_Birthsday.Location = new System.Drawing.Point(3, 184);
            this.L_Birthsday.Name = "L_Birthsday";
            this.L_Birthsday.Size = new System.Drawing.Size(48, 28);
            this.L_Birthsday.TabIndex = 4;
            this.L_Birthsday.Text = "123";
            // 
            // L_Role
            // 
            this.L_Role.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.L_Role.AutoSize = true;
            this.L_Role.Font = new System.Drawing.Font("Calibri", 13.25F, System.Drawing.FontStyle.Bold);
            this.L_Role.Location = new System.Drawing.Point(3, 140);
            this.L_Role.Name = "L_Role";
            this.L_Role.Size = new System.Drawing.Size(48, 28);
            this.L_Role.TabIndex = 3;
            this.L_Role.Text = "123";
            // 
            // L_Phone
            // 
            this.L_Phone.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.L_Phone.AutoSize = true;
            this.L_Phone.Font = new System.Drawing.Font("Calibri", 13.25F, System.Drawing.FontStyle.Bold);
            this.L_Phone.Location = new System.Drawing.Point(3, 96);
            this.L_Phone.Name = "L_Phone";
            this.L_Phone.Size = new System.Drawing.Size(48, 28);
            this.L_Phone.TabIndex = 2;
            this.L_Phone.Text = "123";
            // 
            // L_Email
            // 
            this.L_Email.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.L_Email.AutoSize = true;
            this.L_Email.Font = new System.Drawing.Font("Calibri", 13.25F, System.Drawing.FontStyle.Bold);
            this.L_Email.Location = new System.Drawing.Point(3, 52);
            this.L_Email.Name = "L_Email";
            this.L_Email.Size = new System.Drawing.Size(48, 28);
            this.L_Email.TabIndex = 1;
            this.L_Email.Text = "123";
            // 
            // L_Name
            // 
            this.L_Name.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.L_Name.AutoSize = true;
            this.L_Name.Font = new System.Drawing.Font("Calibri", 13.25F, System.Drawing.FontStyle.Bold);
            this.L_Name.Location = new System.Drawing.Point(3, 8);
            this.L_Name.Name = "L_Name";
            this.L_Name.Size = new System.Drawing.Size(48, 28);
            this.L_Name.TabIndex = 0;
            this.L_Name.Text = "123";
            // 
            // TLP_EditFields
            // 
            this.TLP_EditFields.AutoScroll = true;
            this.TLP_EditFields.AutoSize = true;
            this.TLP_EditFields.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.TLP_EditFields.ColumnCount = 1;
            this.TLP_EditFields.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.TLP_EditFields.Controls.Add(this.CB_Event, 0, 8);
            this.TLP_EditFields.Controls.Add(this.CB_Direction, 0, 7);
            this.TLP_EditFields.Controls.Add(this.CB_Country, 0, 6);
            this.TLP_EditFields.Controls.Add(this.TB_Role, 0, 3);
            this.TLP_EditFields.Controls.Add(this.TB_Phone, 0, 2);
            this.TLP_EditFields.Controls.Add(this.TB_Email, 0, 1);
            this.TLP_EditFields.Controls.Add(this.TB_Name, 0, 0);
            this.TLP_EditFields.Controls.Add(this.B_ChangePassword, 0, 9);
            this.TLP_EditFields.Controls.Add(this.DTP_Birthsday, 0, 4);
            this.TLP_EditFields.Controls.Add(this.FLP_Sex, 0, 5);
            this.TLP_EditFields.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TLP_EditFields.Font = new System.Drawing.Font("Calibri", 12.25F, System.Drawing.FontStyle.Bold);
            this.TLP_EditFields.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.TLP_EditFields.Location = new System.Drawing.Point(262, 3);
            this.TLP_EditFields.Name = "TLP_EditFields";
            this.TLP_EditFields.RowCount = 10;
            this.TLP_EditFields.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.TLP_EditFields.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.TLP_EditFields.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.TLP_EditFields.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.TLP_EditFields.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.TLP_EditFields.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.TLP_EditFields.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.TLP_EditFields.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.TLP_EditFields.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.TLP_EditFields.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.TLP_EditFields.Size = new System.Drawing.Size(221, 441);
            this.TLP_EditFields.TabIndex = 2;
            this.TLP_EditFields.Visible = false;
            // 
            // CB_Event
            // 
            this.CB_Event.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.CB_Event.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_Event.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.CB_Event.FormattingEnabled = true;
            this.CB_Event.Items.AddRange(new object[] {
            "IT в бизнесе",
            "Разработка приложений",
            "IT-инфраструктура",
            "Стартапы",
            "Информационная безопасность"});
            this.CB_Event.Location = new System.Drawing.Point(2, 358);
            this.CB_Event.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.CB_Event.Name = "CB_Event";
            this.CB_Event.Size = new System.Drawing.Size(217, 31);
            this.CB_Event.TabIndex = 14;
            this.CB_Event.Tag = "Event";
            // 
            // CB_Direction
            // 
            this.CB_Direction.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.CB_Direction.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_Direction.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.CB_Direction.FormattingEnabled = true;
            this.CB_Direction.Items.AddRange(new object[] {
            "ИТ",
            "Биг Дата",
            "Дизайн",
            "Аналитика",
            "Информационная безопасность"});
            this.CB_Direction.Location = new System.Drawing.Point(2, 314);
            this.CB_Direction.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.CB_Direction.Name = "CB_Direction";
            this.CB_Direction.Size = new System.Drawing.Size(217, 31);
            this.CB_Direction.TabIndex = 13;
            this.CB_Direction.Tag = "Direction";
            // 
            // CB_Country
            // 
            this.CB_Country.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.CB_Country.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_Country.Font = new System.Drawing.Font("Calibri", 11.25F);
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
            this.CB_Country.Location = new System.Drawing.Point(2, 270);
            this.CB_Country.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.CB_Country.Name = "CB_Country";
            this.CB_Country.Size = new System.Drawing.Size(217, 31);
            this.CB_Country.TabIndex = 12;
            // 
            // TB_Role
            // 
            this.TB_Role.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TB_Role.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TB_Role.Enabled = false;
            this.TB_Role.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.TB_Role.Location = new System.Drawing.Point(3, 142);
            this.TB_Role.MaxLength = 11;
            this.TB_Role.Name = "TB_Role";
            this.TB_Role.ReadOnly = true;
            this.TB_Role.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.TB_Role.Size = new System.Drawing.Size(215, 23);
            this.TB_Role.TabIndex = 3;
            // 
            // TB_Phone
            // 
            this.TB_Phone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TB_Phone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TB_Phone.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.TB_Phone.Location = new System.Drawing.Point(3, 98);
            this.TB_Phone.MaxLength = 32;
            this.TB_Phone.Name = "TB_Phone";
            this.TB_Phone.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.TB_Phone.Size = new System.Drawing.Size(215, 23);
            this.TB_Phone.TabIndex = 2;
            // 
            // TB_Email
            // 
            this.TB_Email.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TB_Email.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TB_Email.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.TB_Email.Location = new System.Drawing.Point(3, 54);
            this.TB_Email.MaxLength = 255;
            this.TB_Email.Name = "TB_Email";
            this.TB_Email.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.TB_Email.Size = new System.Drawing.Size(215, 23);
            this.TB_Email.TabIndex = 1;
            // 
            // TB_Name
            // 
            this.TB_Name.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TB_Name.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TB_Name.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.TB_Name.Location = new System.Drawing.Point(3, 10);
            this.TB_Name.MaxLength = 255;
            this.TB_Name.Name = "TB_Name";
            this.TB_Name.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.TB_Name.Size = new System.Drawing.Size(215, 23);
            this.TB_Name.TabIndex = 0;
            // 
            // B_ChangePassword
            // 
            this.B_ChangePassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.B_ChangePassword.AutoSize = true;
            this.B_ChangePassword.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.B_ChangePassword.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.B_ChangePassword.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.B_ChangePassword.Location = new System.Drawing.Point(3, 402);
            this.B_ChangePassword.Name = "B_ChangePassword";
            this.B_ChangePassword.Size = new System.Drawing.Size(215, 33);
            this.B_ChangePassword.TabIndex = 9;
            this.B_ChangePassword.Text = "Сменить пароль";
            this.B_ChangePassword.UseVisualStyleBackColor = true;
            // 
            // DTP_Birthsday
            // 
            this.DTP_Birthsday.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.DTP_Birthsday.CalendarFont = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DTP_Birthsday.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.DTP_Birthsday.Location = new System.Drawing.Point(3, 183);
            this.DTP_Birthsday.Name = "DTP_Birthsday";
            this.DTP_Birthsday.Size = new System.Drawing.Size(215, 30);
            this.DTP_Birthsday.TabIndex = 10;
            // 
            // FLP_Sex
            // 
            this.FLP_Sex.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.FLP_Sex.AutoScroll = true;
            this.FLP_Sex.AutoSize = true;
            this.FLP_Sex.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.FLP_Sex.Controls.Add(this.RB_Male);
            this.FLP_Sex.Controls.Add(this.RB_Female);
            this.FLP_Sex.Location = new System.Drawing.Point(3, 225);
            this.FLP_Sex.Name = "FLP_Sex";
            this.FLP_Sex.Size = new System.Drawing.Size(215, 33);
            this.FLP_Sex.TabIndex = 11;
            // 
            // RB_Male
            // 
            this.RB_Male.AutoSize = true;
            this.RB_Male.Checked = true;
            this.RB_Male.Cursor = System.Windows.Forms.Cursors.Default;
            this.RB_Male.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RB_Male.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.RB_Male.Location = new System.Drawing.Point(3, 3);
            this.RB_Male.Name = "RB_Male";
            this.RB_Male.Size = new System.Drawing.Size(103, 27);
            this.RB_Male.TabIndex = 0;
            this.RB_Male.TabStop = true;
            this.RB_Male.Text = "мужской";
            this.RB_Male.UseVisualStyleBackColor = true;
            // 
            // RB_Female
            // 
            this.RB_Female.AutoSize = true;
            this.RB_Female.Cursor = System.Windows.Forms.Cursors.Default;
            this.RB_Female.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RB_Female.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.RB_Female.Location = new System.Drawing.Point(112, 3);
            this.RB_Female.Name = "RB_Female";
            this.RB_Female.Size = new System.Drawing.Size(100, 27);
            this.RB_Female.TabIndex = 1;
            this.RB_Female.Text = "женский";
            this.RB_Female.UseVisualStyleBackColor = true;
            // 
            // BExitAccount
            // 
            this.BExitAccount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BExitAccount.Font = new System.Drawing.Font("Calibri", 10.25F);
            this.BExitAccount.ForeColor = System.Drawing.SystemColors.InfoText;
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
            this.BChangeProfile.ForeColor = System.Drawing.SystemColors.InfoText;
            this.BChangeProfile.Location = new System.Drawing.Point(6, 178);
            this.BChangeProfile.Name = "BChangeProfile";
            this.BChangeProfile.Size = new System.Drawing.Size(100, 47);
            this.BChangeProfile.TabIndex = 6;
            this.BChangeProfile.Text = "Редактировать профиль";
            this.BChangeProfile.UseVisualStyleBackColor = true;
            this.BChangeProfile.Click += new System.EventHandler(this.ShowEditFields);
            // 
            // BAddIcon
            // 
            this.BAddIcon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BAddIcon.Font = new System.Drawing.Font("Calibri", 10.25F);
            this.BAddIcon.ForeColor = System.Drawing.SystemColors.InfoText;
            this.BAddIcon.Location = new System.Drawing.Point(6, 128);
            this.BAddIcon.Name = "BAddIcon";
            this.BAddIcon.Size = new System.Drawing.Size(100, 47);
            this.BAddIcon.TabIndex = 5;
            this.BAddIcon.Text = "Добавить иконку";
            this.BAddIcon.UseVisualStyleBackColor = true;
            this.BAddIcon.Click += new System.EventHandler(this.ChooseIcon);
            // 
            // PBIcon
            // 
            this.PBIcon.Image = ((System.Drawing.Image)(resources.GetObject("PBIcon.Image")));
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
            this.ClientSize = new System.Drawing.Size(542, 462);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(560, 509);
            this.Name = "ClientForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Conferention";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ExitProgram);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.GBmain.ResumeLayout(false);
            this.TLP_Info.ResumeLayout(false);
            this.TLP_Info.PerformLayout();
            this.TLP_TittleLabel.ResumeLayout(false);
            this.TLP_TittleLabel.PerformLayout();
            this.TLP_Label.ResumeLayout(false);
            this.TLP_Label.PerformLayout();
            this.TLP_EditFields.ResumeLayout(false);
            this.TLP_EditFields.PerformLayout();
            this.FLP_Sex.ResumeLayout(false);
            this.FLP_Sex.PerformLayout();
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
        private System.Windows.Forms.PictureBox PBIcon;
        private System.Windows.Forms.TableLayoutPanel TLP_Info;
        private System.Windows.Forms.TableLayoutPanel TLP_TittleLabel;
        private System.Windows.Forms.TableLayoutPanel TLP_Label;
        private System.Windows.Forms.TableLayoutPanel TLP_EditFields;
        private System.Windows.Forms.Label T_L_Password;
        private System.Windows.Forms.Label T_L_Event;
        private System.Windows.Forms.Label T_L_Direction;
        private System.Windows.Forms.Label T_L_Country;
        private System.Windows.Forms.Label T_L_Sex;
        private System.Windows.Forms.Label T_L_Birthsday;
        private System.Windows.Forms.Label T_L_Role;
        private System.Windows.Forms.Label T_L_Phone;
        private System.Windows.Forms.Label T_L_Name;
        private System.Windows.Forms.Label T_L_Email;
        private System.Windows.Forms.Label L_Event;
        private System.Windows.Forms.Label L_Direction;
        private System.Windows.Forms.Label L_Country;
        private System.Windows.Forms.Label L_Sex;
        private System.Windows.Forms.Label L_Birthsday;
        private System.Windows.Forms.Label L_Role;
        private System.Windows.Forms.Label L_Phone;
        private System.Windows.Forms.Label L_Email;
        private System.Windows.Forms.Label L_Name;
        private System.Windows.Forms.TextBox TB_Role;
        private System.Windows.Forms.TextBox TB_Phone;
        private System.Windows.Forms.TextBox TB_Email;
        private System.Windows.Forms.TextBox TB_Name;
        private System.Windows.Forms.Label L_Password;
        private System.Windows.Forms.Button B_ChangePassword;
        private System.Windows.Forms.DateTimePicker DTP_Birthsday;
        private System.Windows.Forms.FlowLayoutPanel FLP_Sex;
        private System.Windows.Forms.RadioButton RB_Male;
        private System.Windows.Forms.RadioButton RB_Female;
        private System.Windows.Forms.ComboBox CB_Event;
        private System.Windows.Forms.ComboBox CB_Direction;
        private System.Windows.Forms.ComboBox CB_Country;
    }
}
