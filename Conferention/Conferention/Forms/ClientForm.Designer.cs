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
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TLP_EditFields = new System.Windows.Forms.TableLayoutPanel();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.BExitAccount = new System.Windows.Forms.Button();
            this.BChangeProfile = new System.Windows.Forms.Button();
            this.BAddIcon = new System.Windows.Forms.Button();
            this.PBIcon = new System.Windows.Forms.PictureBox();
            this.OFD = new System.Windows.Forms.OpenFileDialog();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.GBmain.SuspendLayout();
            this.TLP_Info.SuspendLayout();
            this.TLP_TittleLabel.SuspendLayout();
            this.TLP_Label.SuspendLayout();
            this.TLP_EditFields.SuspendLayout();
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
            this.tableLayoutPanel1.Size = new System.Drawing.Size(703, 422);
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
            this.PSettings.Size = new System.Drawing.Size(150, 416);
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
            this.GBmain.Size = new System.Drawing.Size(541, 416);
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
            this.TLP_Info.Size = new System.Drawing.Size(420, 377);
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
            this.TLP_TittleLabel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TLP_TittleLabel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TLP_TittleLabel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TLP_TittleLabel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TLP_TittleLabel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TLP_TittleLabel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TLP_TittleLabel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TLP_TittleLabel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TLP_TittleLabel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TLP_TittleLabel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TLP_TittleLabel.Size = new System.Drawing.Size(193, 371);
            this.TLP_TittleLabel.TabIndex = 0;
            // 
            // T_L_Password
            // 
            this.T_L_Password.AutoSize = true;
            this.T_L_Password.Dock = System.Windows.Forms.DockStyle.Right;
            this.T_L_Password.Font = new System.Drawing.Font("Calibri", 13.25F, System.Drawing.FontStyle.Bold);
            this.T_L_Password.Location = new System.Drawing.Point(100, 252);
            this.T_L_Password.Name = "T_L_Password";
            this.T_L_Password.Size = new System.Drawing.Size(90, 119);
            this.T_L_Password.TabIndex = 9;
            this.T_L_Password.Text = "Пароль:";
            this.T_L_Password.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // T_L_Event
            // 
            this.T_L_Event.AutoSize = true;
            this.T_L_Event.Dock = System.Windows.Forms.DockStyle.Right;
            this.T_L_Event.Font = new System.Drawing.Font("Calibri", 13.25F, System.Drawing.FontStyle.Bold);
            this.T_L_Event.Location = new System.Drawing.Point(34, 224);
            this.T_L_Event.Name = "T_L_Event";
            this.T_L_Event.Size = new System.Drawing.Size(156, 28);
            this.T_L_Event.TabIndex = 8;
            this.T_L_Event.Tag = "Event";
            this.T_L_Event.Text = "Мероприятие:";
            this.T_L_Event.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // T_L_Direction
            // 
            this.T_L_Direction.AutoSize = true;
            this.T_L_Direction.Dock = System.Windows.Forms.DockStyle.Right;
            this.T_L_Direction.Font = new System.Drawing.Font("Calibri", 13.25F, System.Drawing.FontStyle.Bold);
            this.T_L_Direction.Location = new System.Drawing.Point(38, 196);
            this.T_L_Direction.Name = "T_L_Direction";
            this.T_L_Direction.Size = new System.Drawing.Size(152, 28);
            this.T_L_Direction.TabIndex = 7;
            this.T_L_Direction.Tag = "Direction";
            this.T_L_Direction.Text = "Направление:";
            this.T_L_Direction.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // T_L_Country
            // 
            this.T_L_Country.AutoSize = true;
            this.T_L_Country.Dock = System.Windows.Forms.DockStyle.Right;
            this.T_L_Country.Font = new System.Drawing.Font("Calibri", 13.25F, System.Drawing.FontStyle.Bold);
            this.T_L_Country.Location = new System.Drawing.Point(104, 168);
            this.T_L_Country.Name = "T_L_Country";
            this.T_L_Country.Size = new System.Drawing.Size(86, 28);
            this.T_L_Country.TabIndex = 6;
            this.T_L_Country.Text = "Страна:";
            this.T_L_Country.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // T_L_Sex
            // 
            this.T_L_Sex.AutoSize = true;
            this.T_L_Sex.Dock = System.Windows.Forms.DockStyle.Right;
            this.T_L_Sex.Font = new System.Drawing.Font("Calibri", 13.25F, System.Drawing.FontStyle.Bold);
            this.T_L_Sex.Location = new System.Drawing.Point(134, 140);
            this.T_L_Sex.Name = "T_L_Sex";
            this.T_L_Sex.Size = new System.Drawing.Size(56, 28);
            this.T_L_Sex.TabIndex = 5;
            this.T_L_Sex.Text = "Пол:";
            this.T_L_Sex.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // T_L_Birthsday
            // 
            this.T_L_Birthsday.AutoSize = true;
            this.T_L_Birthsday.Dock = System.Windows.Forms.DockStyle.Right;
            this.T_L_Birthsday.Font = new System.Drawing.Font("Calibri", 13.25F, System.Drawing.FontStyle.Bold);
            this.T_L_Birthsday.Location = new System.Drawing.Point(18, 112);
            this.T_L_Birthsday.Name = "T_L_Birthsday";
            this.T_L_Birthsday.Size = new System.Drawing.Size(172, 28);
            this.T_L_Birthsday.TabIndex = 4;
            this.T_L_Birthsday.Text = "Дата рождения:";
            this.T_L_Birthsday.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // T_L_Role
            // 
            this.T_L_Role.AutoSize = true;
            this.T_L_Role.Dock = System.Windows.Forms.DockStyle.Right;
            this.T_L_Role.Font = new System.Drawing.Font("Calibri", 13.25F, System.Drawing.FontStyle.Bold);
            this.T_L_Role.Location = new System.Drawing.Point(125, 84);
            this.T_L_Role.Name = "T_L_Role";
            this.T_L_Role.Size = new System.Drawing.Size(65, 28);
            this.T_L_Role.TabIndex = 3;
            this.T_L_Role.Text = "Роль:";
            this.T_L_Role.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // T_L_Phone
            // 
            this.T_L_Phone.AutoSize = true;
            this.T_L_Phone.Dock = System.Windows.Forms.DockStyle.Right;
            this.T_L_Phone.Font = new System.Drawing.Font("Calibri", 13.25F, System.Drawing.FontStyle.Bold);
            this.T_L_Phone.Location = new System.Drawing.Point(3, 56);
            this.T_L_Phone.Name = "T_L_Phone";
            this.T_L_Phone.Size = new System.Drawing.Size(187, 28);
            this.T_L_Phone.TabIndex = 2;
            this.T_L_Phone.Text = "Номер телефона:";
            this.T_L_Phone.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // T_L_Name
            // 
            this.T_L_Name.AutoSize = true;
            this.T_L_Name.Dock = System.Windows.Forms.DockStyle.Right;
            this.T_L_Name.Font = new System.Drawing.Font("Calibri", 13.25F, System.Drawing.FontStyle.Bold);
            this.T_L_Name.Location = new System.Drawing.Point(124, 0);
            this.T_L_Name.Name = "T_L_Name";
            this.T_L_Name.Size = new System.Drawing.Size(66, 28);
            this.T_L_Name.TabIndex = 0;
            this.T_L_Name.Text = "ФИО:";
            this.T_L_Name.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // T_L_Email
            // 
            this.T_L_Email.AutoSize = true;
            this.T_L_Email.Dock = System.Windows.Forms.DockStyle.Right;
            this.T_L_Email.Font = new System.Drawing.Font("Calibri", 13.25F, System.Drawing.FontStyle.Bold);
            this.T_L_Email.Location = new System.Drawing.Point(115, 28);
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
            this.TLP_Label.Controls.Add(this.label10, 0, 9);
            this.TLP_Label.Controls.Add(this.label9, 0, 8);
            this.TLP_Label.Controls.Add(this.label8, 0, 7);
            this.TLP_Label.Controls.Add(this.label7, 0, 6);
            this.TLP_Label.Controls.Add(this.label6, 0, 5);
            this.TLP_Label.Controls.Add(this.label5, 0, 4);
            this.TLP_Label.Controls.Add(this.label4, 0, 3);
            this.TLP_Label.Controls.Add(this.label3, 0, 2);
            this.TLP_Label.Controls.Add(this.label2, 0, 1);
            this.TLP_Label.Controls.Add(this.label1, 0, 0);
            this.TLP_Label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TLP_Label.Font = new System.Drawing.Font("Calibri", 12.25F, System.Drawing.FontStyle.Bold);
            this.TLP_Label.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.TLP_Label.Location = new System.Drawing.Point(202, 3);
            this.TLP_Label.Name = "TLP_Label";
            this.TLP_Label.RowCount = 10;
            this.TLP_Label.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TLP_Label.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TLP_Label.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TLP_Label.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TLP_Label.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TLP_Label.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TLP_Label.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TLP_Label.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TLP_Label.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TLP_Label.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TLP_Label.Size = new System.Drawing.Size(54, 371);
            this.TLP_Label.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label9.Font = new System.Drawing.Font("Calibri", 13.25F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(3, 224);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 28);
            this.label9.TabIndex = 8;
            this.label9.Text = "123";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label8.Font = new System.Drawing.Font("Calibri", 13.25F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(3, 196);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 28);
            this.label8.TabIndex = 7;
            this.label8.Tag = "Event";
            this.label8.Text = "123";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Font = new System.Drawing.Font("Calibri", 13.25F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(3, 168);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 28);
            this.label7.TabIndex = 6;
            this.label7.Tag = "Direction";
            this.label7.Text = "123";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Font = new System.Drawing.Font("Calibri", 13.25F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(3, 140);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 28);
            this.label6.TabIndex = 5;
            this.label6.Text = "123";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Font = new System.Drawing.Font("Calibri", 13.25F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(3, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 28);
            this.label5.TabIndex = 4;
            this.label5.Text = "123";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Calibri", 13.25F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(3, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 28);
            this.label4.TabIndex = 3;
            this.label4.Text = "123";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Calibri", 13.25F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(3, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 28);
            this.label3.TabIndex = 2;
            this.label3.Text = "123";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Calibri", 13.25F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(3, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "123";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Calibri", 13.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "123";
            // 
            // TLP_EditFields
            // 
            this.TLP_EditFields.AutoScroll = true;
            this.TLP_EditFields.AutoSize = true;
            this.TLP_EditFields.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.TLP_EditFields.ColumnCount = 1;
            this.TLP_EditFields.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.TLP_EditFields.Controls.Add(this.textBox8, 0, 7);
            this.TLP_EditFields.Controls.Add(this.textBox7, 0, 6);
            this.TLP_EditFields.Controls.Add(this.textBox6, 0, 5);
            this.TLP_EditFields.Controls.Add(this.textBox5, 0, 4);
            this.TLP_EditFields.Controls.Add(this.textBox4, 0, 3);
            this.TLP_EditFields.Controls.Add(this.textBox3, 0, 2);
            this.TLP_EditFields.Controls.Add(this.textBox2, 0, 1);
            this.TLP_EditFields.Controls.Add(this.textBox1, 0, 0);
            this.TLP_EditFields.Controls.Add(this.textBox9, 0, 8);
            this.TLP_EditFields.Controls.Add(this.button1, 0, 9);
            this.TLP_EditFields.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TLP_EditFields.Font = new System.Drawing.Font("Calibri", 12.25F, System.Drawing.FontStyle.Bold);
            this.TLP_EditFields.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.TLP_EditFields.Location = new System.Drawing.Point(262, 3);
            this.TLP_EditFields.Name = "TLP_EditFields";
            this.TLP_EditFields.RowCount = 10;
            this.TLP_EditFields.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TLP_EditFields.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TLP_EditFields.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TLP_EditFields.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TLP_EditFields.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TLP_EditFields.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TLP_EditFields.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TLP_EditFields.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TLP_EditFields.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TLP_EditFields.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TLP_EditFields.Size = new System.Drawing.Size(155, 371);
            this.TLP_EditFields.TabIndex = 2;
            this.TLP_EditFields.Visible = false;
            // 
            // textBox8
            // 
            this.textBox8.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox8.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.textBox8.Location = new System.Drawing.Point(3, 206);
            this.textBox8.Name = "textBox8";
            this.textBox8.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.textBox8.Size = new System.Drawing.Size(149, 23);
            this.textBox8.TabIndex = 7;
            this.textBox8.Tag = "Direction";
            this.textBox8.Text = "123";
            // 
            // textBox7
            // 
            this.textBox7.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox7.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.textBox7.Location = new System.Drawing.Point(3, 177);
            this.textBox7.Name = "textBox7";
            this.textBox7.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.textBox7.Size = new System.Drawing.Size(149, 23);
            this.textBox7.TabIndex = 6;
            this.textBox7.Text = "123";
            // 
            // textBox6
            // 
            this.textBox6.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox6.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.textBox6.Location = new System.Drawing.Point(3, 148);
            this.textBox6.Name = "textBox6";
            this.textBox6.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.textBox6.Size = new System.Drawing.Size(149, 23);
            this.textBox6.TabIndex = 5;
            this.textBox6.Text = "123";
            // 
            // textBox5
            // 
            this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox5.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.textBox5.Location = new System.Drawing.Point(3, 119);
            this.textBox5.Name = "textBox5";
            this.textBox5.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.textBox5.Size = new System.Drawing.Size(149, 23);
            this.textBox5.TabIndex = 4;
            this.textBox5.Text = "123";
            // 
            // textBox4
            // 
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox4.Enabled = false;
            this.textBox4.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.textBox4.Location = new System.Drawing.Point(3, 90);
            this.textBox4.Name = "textBox4";
            this.textBox4.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.textBox4.Size = new System.Drawing.Size(149, 23);
            this.textBox4.TabIndex = 3;
            this.textBox4.Text = "123";
            // 
            // textBox3
            // 
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox3.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.textBox3.Location = new System.Drawing.Point(3, 61);
            this.textBox3.Name = "textBox3";
            this.textBox3.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.textBox3.Size = new System.Drawing.Size(149, 23);
            this.textBox3.TabIndex = 2;
            this.textBox3.Text = "123";
            // 
            // textBox2
            // 
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox2.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.textBox2.Location = new System.Drawing.Point(3, 32);
            this.textBox2.Name = "textBox2";
            this.textBox2.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.textBox2.Size = new System.Drawing.Size(149, 23);
            this.textBox2.TabIndex = 1;
            this.textBox2.Text = "123";
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.textBox1.Location = new System.Drawing.Point(3, 3);
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.textBox1.Size = new System.Drawing.Size(149, 23);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "123";
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
            // textBox9
            // 
            this.textBox9.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox9.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.textBox9.Location = new System.Drawing.Point(3, 235);
            this.textBox9.Name = "textBox9";
            this.textBox9.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.textBox9.Size = new System.Drawing.Size(149, 23);
            this.textBox9.TabIndex = 8;
            this.textBox9.Tag = "Event";
            this.textBox9.Text = "123";
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.Location = new System.Drawing.Point(3, 264);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(149, 36);
            this.button1.TabIndex = 9;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label10.Font = new System.Drawing.Font("Calibri", 13.25F, System.Drawing.FontStyle.Bold);
            this.label10.Location = new System.Drawing.Point(3, 252);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(48, 119);
            this.label10.TabIndex = 9;
            this.label10.Text = "123";
            // 
            // ClientForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(703, 422);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(721, 469);
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
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.Button button1;
    }
}
