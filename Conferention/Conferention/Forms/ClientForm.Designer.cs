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
            this.TLP_Info_Main = new System.Windows.Forms.TableLayoutPanel();
            this.L_Country = new System.Windows.Forms.Label();
            this.L_Role = new System.Windows.Forms.Label();
            this.L_Sex = new System.Windows.Forms.Label();
            this.L_Birthsday = new System.Windows.Forms.Label();
            this.L_Phone = new System.Windows.Forms.Label();
            this.L_Email = new System.Windows.Forms.Label();
            this.L_Name = new System.Windows.Forms.Label();
            this.T_L_Name = new System.Windows.Forms.Label();
            this.T_L_Email = new System.Windows.Forms.Label();
            this.T_L_Country = new System.Windows.Forms.Label();
            this.T_L_Sex = new System.Windows.Forms.Label();
            this.T_L_Phone = new System.Windows.Forms.Label();
            this.T_L_Birthsday = new System.Windows.Forms.Label();
            this.T_L_Role = new System.Windows.Forms.Label();
            this.PBIcon = new System.Windows.Forms.PictureBox();
            this.OFD = new System.Windows.Forms.OpenFileDialog();
            this.tableLayoutPanel1.SuspendLayout();
            this.GBmain.SuspendLayout();
            this.GBinfo.SuspendLayout();
            this.TLP_Info_Main.SuspendLayout();
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
            this.GBmain.Size = new System.Drawing.Size(541, 416);
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
            // 
            // GBinfo
            // 
            this.GBinfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GBinfo.Controls.Add(this.TLP_Info_Main);
            this.GBinfo.Location = new System.Drawing.Point(112, 30);
            this.GBinfo.MinimumSize = new System.Drawing.Size(301, 130);
            this.GBinfo.Name = "GBinfo";
            this.GBinfo.Size = new System.Drawing.Size(420, 377);
            this.GBinfo.TabIndex = 4;
            this.GBinfo.TabStop = false;
            this.GBinfo.Text = "Логин";
            // 
            // TLP_Info_Main
            // 
            this.TLP_Info_Main.ColumnCount = 2;
            this.TLP_Info_Main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.TLP_Info_Main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.TLP_Info_Main.Controls.Add(this.L_Country, 1, 5);
            this.TLP_Info_Main.Controls.Add(this.L_Role, 0, 6);
            this.TLP_Info_Main.Controls.Add(this.L_Sex, 1, 4);
            this.TLP_Info_Main.Controls.Add(this.L_Birthsday, 1, 3);
            this.TLP_Info_Main.Controls.Add(this.L_Phone, 1, 2);
            this.TLP_Info_Main.Controls.Add(this.L_Email, 1, 1);
            this.TLP_Info_Main.Controls.Add(this.L_Name, 1, 0);
            this.TLP_Info_Main.Controls.Add(this.T_L_Name, 0, 0);
            this.TLP_Info_Main.Controls.Add(this.T_L_Email, 0, 1);
            this.TLP_Info_Main.Controls.Add(this.T_L_Country, 0, 5);
            this.TLP_Info_Main.Controls.Add(this.T_L_Sex, 0, 4);
            this.TLP_Info_Main.Controls.Add(this.T_L_Phone, 0, 2);
            this.TLP_Info_Main.Controls.Add(this.T_L_Birthsday, 0, 3);
            this.TLP_Info_Main.Controls.Add(this.T_L_Role, 0, 6);
            this.TLP_Info_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TLP_Info_Main.Location = new System.Drawing.Point(3, 32);
            this.TLP_Info_Main.Name = "TLP_Info_Main";
            this.TLP_Info_Main.RowCount = 7;
            this.TLP_Info_Main.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TLP_Info_Main.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TLP_Info_Main.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TLP_Info_Main.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TLP_Info_Main.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TLP_Info_Main.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TLP_Info_Main.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TLP_Info_Main.Size = new System.Drawing.Size(414, 342);
            this.TLP_Info_Main.TabIndex = 0;
            // 
            // L_Country
            // 
            this.L_Country.AutoSize = true;
            this.L_Country.Dock = System.Windows.Forms.DockStyle.Left;
            this.L_Country.Font = new System.Drawing.Font("Calibri", 12.25F, System.Drawing.FontStyle.Bold);
            this.L_Country.ForeColor = System.Drawing.Color.Black;
            this.L_Country.Location = new System.Drawing.Point(180, 130);
            this.L_Country.Name = "L_Country";
            this.L_Country.Size = new System.Drawing.Size(123, 26);
            this.L_Country.TabIndex = 8;
            this.L_Country.Text = "Пустое поле";
            // 
            // L_Role
            // 
            this.L_Role.AutoSize = true;
            this.L_Role.Dock = System.Windows.Forms.DockStyle.Left;
            this.L_Role.Font = new System.Drawing.Font("Calibri", 12.25F, System.Drawing.FontStyle.Bold);
            this.L_Role.ForeColor = System.Drawing.Color.Black;
            this.L_Role.Location = new System.Drawing.Point(180, 156);
            this.L_Role.Name = "L_Role";
            this.L_Role.Size = new System.Drawing.Size(123, 186);
            this.L_Role.TabIndex = 12;
            this.L_Role.Text = "Пустое поле";
            // 
            // L_Sex
            // 
            this.L_Sex.AutoSize = true;
            this.L_Sex.Dock = System.Windows.Forms.DockStyle.Left;
            this.L_Sex.Font = new System.Drawing.Font("Calibri", 12.25F, System.Drawing.FontStyle.Bold);
            this.L_Sex.ForeColor = System.Drawing.Color.Black;
            this.L_Sex.Location = new System.Drawing.Point(180, 104);
            this.L_Sex.Name = "L_Sex";
            this.L_Sex.Size = new System.Drawing.Size(123, 26);
            this.L_Sex.TabIndex = 11;
            this.L_Sex.Text = "Пустое поле";
            // 
            // L_Birthsday
            // 
            this.L_Birthsday.AutoSize = true;
            this.L_Birthsday.Dock = System.Windows.Forms.DockStyle.Left;
            this.L_Birthsday.Font = new System.Drawing.Font("Calibri", 12.25F, System.Drawing.FontStyle.Bold);
            this.L_Birthsday.ForeColor = System.Drawing.Color.Black;
            this.L_Birthsday.Location = new System.Drawing.Point(180, 78);
            this.L_Birthsday.Name = "L_Birthsday";
            this.L_Birthsday.Size = new System.Drawing.Size(123, 26);
            this.L_Birthsday.TabIndex = 10;
            this.L_Birthsday.Text = "Пустое поле";
            // 
            // L_Phone
            // 
            this.L_Phone.AutoSize = true;
            this.L_Phone.Dock = System.Windows.Forms.DockStyle.Left;
            this.L_Phone.Font = new System.Drawing.Font("Calibri", 12.25F, System.Drawing.FontStyle.Bold);
            this.L_Phone.ForeColor = System.Drawing.Color.Black;
            this.L_Phone.Location = new System.Drawing.Point(180, 52);
            this.L_Phone.Name = "L_Phone";
            this.L_Phone.Size = new System.Drawing.Size(123, 26);
            this.L_Phone.TabIndex = 9;
            this.L_Phone.Text = "Пустое поле";
            // 
            // L_Email
            // 
            this.L_Email.AutoSize = true;
            this.L_Email.Dock = System.Windows.Forms.DockStyle.Left;
            this.L_Email.Font = new System.Drawing.Font("Calibri", 12.25F, System.Drawing.FontStyle.Bold);
            this.L_Email.ForeColor = System.Drawing.Color.Black;
            this.L_Email.Location = new System.Drawing.Point(180, 26);
            this.L_Email.Name = "L_Email";
            this.L_Email.Size = new System.Drawing.Size(123, 26);
            this.L_Email.TabIndex = 8;
            this.L_Email.Text = "Пустое поле";
            // 
            // L_Name
            // 
            this.L_Name.AutoSize = true;
            this.L_Name.Dock = System.Windows.Forms.DockStyle.Left;
            this.L_Name.Font = new System.Drawing.Font("Calibri", 12.25F, System.Drawing.FontStyle.Bold);
            this.L_Name.ForeColor = System.Drawing.Color.Black;
            this.L_Name.Location = new System.Drawing.Point(180, 0);
            this.L_Name.Name = "L_Name";
            this.L_Name.Size = new System.Drawing.Size(123, 26);
            this.L_Name.TabIndex = 7;
            this.L_Name.Text = "Пустое поле";
            // 
            // T_L_Name
            // 
            this.T_L_Name.AutoSize = true;
            this.T_L_Name.Dock = System.Windows.Forms.DockStyle.Right;
            this.T_L_Name.Font = new System.Drawing.Font("Calibri", 12.25F, System.Drawing.FontStyle.Bold);
            this.T_L_Name.ForeColor = System.Drawing.Color.White;
            this.T_L_Name.Location = new System.Drawing.Point(113, 0);
            this.T_L_Name.Name = "T_L_Name";
            this.T_L_Name.Size = new System.Drawing.Size(61, 26);
            this.T_L_Name.TabIndex = 0;
            this.T_L_Name.Text = "ФИО:";
            // 
            // T_L_Email
            // 
            this.T_L_Email.AutoSize = true;
            this.T_L_Email.Dock = System.Windows.Forms.DockStyle.Right;
            this.T_L_Email.Font = new System.Drawing.Font("Calibri", 12.25F, System.Drawing.FontStyle.Bold);
            this.T_L_Email.ForeColor = System.Drawing.Color.White;
            this.T_L_Email.Location = new System.Drawing.Point(104, 26);
            this.T_L_Email.Name = "T_L_Email";
            this.T_L_Email.Size = new System.Drawing.Size(70, 26);
            this.T_L_Email.TabIndex = 5;
            this.T_L_Email.Text = "Почта:";
            // 
            // T_L_Country
            // 
            this.T_L_Country.AutoSize = true;
            this.T_L_Country.Dock = System.Windows.Forms.DockStyle.Right;
            this.T_L_Country.Font = new System.Drawing.Font("Calibri", 12.25F, System.Drawing.FontStyle.Bold);
            this.T_L_Country.ForeColor = System.Drawing.Color.White;
            this.T_L_Country.Location = new System.Drawing.Point(95, 130);
            this.T_L_Country.Name = "T_L_Country";
            this.T_L_Country.Size = new System.Drawing.Size(79, 26);
            this.T_L_Country.TabIndex = 4;
            this.T_L_Country.Text = "Страна:";
            // 
            // T_L_Sex
            // 
            this.T_L_Sex.AutoSize = true;
            this.T_L_Sex.Dock = System.Windows.Forms.DockStyle.Right;
            this.T_L_Sex.Font = new System.Drawing.Font("Calibri", 12.25F, System.Drawing.FontStyle.Bold);
            this.T_L_Sex.ForeColor = System.Drawing.Color.White;
            this.T_L_Sex.Location = new System.Drawing.Point(121, 104);
            this.T_L_Sex.Name = "T_L_Sex";
            this.T_L_Sex.Size = new System.Drawing.Size(53, 26);
            this.T_L_Sex.TabIndex = 3;
            this.T_L_Sex.Text = "Пол:";
            // 
            // T_L_Phone
            // 
            this.T_L_Phone.AutoSize = true;
            this.T_L_Phone.Dock = System.Windows.Forms.DockStyle.Right;
            this.T_L_Phone.Font = new System.Drawing.Font("Calibri", 12.25F, System.Drawing.FontStyle.Bold);
            this.T_L_Phone.ForeColor = System.Drawing.Color.White;
            this.T_L_Phone.Location = new System.Drawing.Point(3, 52);
            this.T_L_Phone.Name = "T_L_Phone";
            this.T_L_Phone.Size = new System.Drawing.Size(171, 26);
            this.T_L_Phone.TabIndex = 2;
            this.T_L_Phone.Text = "Номер телефона:";
            // 
            // T_L_Birthsday
            // 
            this.T_L_Birthsday.AutoSize = true;
            this.T_L_Birthsday.Dock = System.Windows.Forms.DockStyle.Right;
            this.T_L_Birthsday.Font = new System.Drawing.Font("Calibri", 12.25F, System.Drawing.FontStyle.Bold);
            this.T_L_Birthsday.ForeColor = System.Drawing.Color.White;
            this.T_L_Birthsday.Location = new System.Drawing.Point(16, 78);
            this.T_L_Birthsday.Name = "T_L_Birthsday";
            this.T_L_Birthsday.Size = new System.Drawing.Size(158, 26);
            this.T_L_Birthsday.TabIndex = 1;
            this.T_L_Birthsday.Text = "Дата рождения:";
            // 
            // T_L_Role
            // 
            this.T_L_Role.AutoSize = true;
            this.T_L_Role.Dock = System.Windows.Forms.DockStyle.Right;
            this.T_L_Role.Font = new System.Drawing.Font("Calibri", 12.25F, System.Drawing.FontStyle.Bold);
            this.T_L_Role.ForeColor = System.Drawing.Color.White;
            this.T_L_Role.Location = new System.Drawing.Point(113, 156);
            this.T_L_Role.Name = "T_L_Role";
            this.T_L_Role.Size = new System.Drawing.Size(61, 186);
            this.T_L_Role.TabIndex = 6;
            this.T_L_Role.Text = "Роль:";
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
            this.GBinfo.ResumeLayout(false);
            this.TLP_Info_Main.ResumeLayout(false);
            this.TLP_Info_Main.PerformLayout();
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
        private System.Windows.Forms.PictureBox PBIcon;
        private System.Windows.Forms.TableLayoutPanel TLP_Info_Main;
        private System.Windows.Forms.Label L_Country;
        private System.Windows.Forms.Label L_Role;
        private System.Windows.Forms.Label L_Sex;
        private System.Windows.Forms.Label L_Birthsday;
        private System.Windows.Forms.Label L_Phone;
        private System.Windows.Forms.Label L_Email;
        private System.Windows.Forms.Label L_Name;
        private System.Windows.Forms.Label T_L_Name;
        private System.Windows.Forms.Label T_L_Email;
        private System.Windows.Forms.Label T_L_Country;
        private System.Windows.Forms.Label T_L_Sex;
        private System.Windows.Forms.Label T_L_Phone;
        private System.Windows.Forms.Label T_L_Birthsday;
        private System.Windows.Forms.Label T_L_Role;
    }
}
