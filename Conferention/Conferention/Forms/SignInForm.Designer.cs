namespace Conferention.Forms
{
    partial class SignInForm
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.TBPassword = new System.Windows.Forms.TextBox();
            this.LPassword = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.TBLogin = new System.Windows.Forms.TextBox();
            this.LLogin = new System.Windows.Forms.Label();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.LIncorrectLogin = new System.Windows.Forms.Label();
            this.LAnotherLogin = new System.Windows.Forms.Label();
            this.LNonRegistered = new System.Windows.Forms.Label();
            this.BtnLogin = new System.Windows.Forms.Button();
            this.GBRegistration = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.GBRegistration.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel4, 0, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 33);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.00001F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(195, 249);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.AutoSize = true;
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.TBPassword, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.LPassword, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 82);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.Size = new System.Drawing.Size(189, 55);
            this.tableLayoutPanel2.TabIndex = 6;
            // 
            // TBPassword
            // 
            this.TBPassword.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TBPassword.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TBPassword.Location = new System.Drawing.Point(3, 21);
            this.TBPassword.MaxLength = 255;
            this.TBPassword.Name = "TBPassword";
            this.TBPassword.PasswordChar = '*';
            this.TBPassword.Size = new System.Drawing.Size(183, 31);
            this.TBPassword.TabIndex = 5;
            // 
            // LPassword
            // 
            this.LPassword.AutoSize = true;
            this.LPassword.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.LPassword.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.LPassword.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.LPassword.Location = new System.Drawing.Point(3, 0);
            this.LPassword.Name = "LPassword";
            this.LPassword.Size = new System.Drawing.Size(183, 18);
            this.LPassword.TabIndex = 4;
            this.LPassword.Text = "Пароль";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.TBLogin, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.LLogin, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 6);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(189, 70);
            this.tableLayoutPanel3.TabIndex = 7;
            // 
            // TBLogin
            // 
            this.TBLogin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TBLogin.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TBLogin.Location = new System.Drawing.Point(3, 38);
            this.TBLogin.MaxLength = 255;
            this.TBLogin.Name = "TBLogin";
            this.TBLogin.Size = new System.Drawing.Size(183, 31);
            this.TBLogin.TabIndex = 10;
            // 
            // LLogin
            // 
            this.LLogin.AutoSize = true;
            this.LLogin.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.LLogin.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.LLogin.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.LLogin.Location = new System.Drawing.Point(3, 17);
            this.LLogin.Name = "LLogin";
            this.LLogin.Size = new System.Drawing.Size(183, 18);
            this.LLogin.TabIndex = 9;
            this.LLogin.Text = "Email";
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.AutoSize = true;
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel5, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.BtnLogin, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 143);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(189, 99);
            this.tableLayoutPanel4.TabIndex = 9;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.AutoSize = true;
            this.tableLayoutPanel5.ColumnCount = 1;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Controls.Add(this.LIncorrectLogin, 0, 2);
            this.tableLayoutPanel5.Controls.Add(this.LAnotherLogin, 0, 1);
            this.tableLayoutPanel5.Controls.Add(this.LNonRegistered, 0, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 42);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 3;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(183, 54);
            this.tableLayoutPanel5.TabIndex = 15;
            // 
            // LIncorrectLogin
            // 
            this.LIncorrectLogin.AutoSize = true;
            this.LIncorrectLogin.Cursor = System.Windows.Forms.Cursors.Default;
            this.LIncorrectLogin.Dock = System.Windows.Forms.DockStyle.Top;
            this.LIncorrectLogin.Font = new System.Drawing.Font("Calibri", 10.25F);
            this.LIncorrectLogin.ForeColor = System.Drawing.Color.Red;
            this.LIncorrectLogin.Location = new System.Drawing.Point(3, 36);
            this.LIncorrectLogin.Name = "LIncorrectLogin";
            this.LIncorrectLogin.Size = new System.Drawing.Size(177, 17);
            this.LIncorrectLogin.TabIndex = 15;
            this.LIncorrectLogin.Text = "Неверный Email или пароль";
            this.LIncorrectLogin.Visible = false;
            // 
            // LAnotherLogin
            // 
            this.LAnotherLogin.AutoSize = true;
            this.LAnotherLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LAnotherLogin.Dock = System.Windows.Forms.DockStyle.Top;
            this.LAnotherLogin.Font = new System.Drawing.Font("Calibri", 10.25F);
            this.LAnotherLogin.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.LAnotherLogin.Location = new System.Drawing.Point(3, 18);
            this.LAnotherLogin.Name = "LAnotherLogin";
            this.LAnotherLogin.Size = new System.Drawing.Size(177, 17);
            this.LAnotherLogin.TabIndex = 14;
            this.LAnotherLogin.Text = "Войти как жюри?";
            this.LAnotherLogin.Click += new System.EventHandler(this.LoginAnotherUser);
            this.LAnotherLogin.MouseLeave += new System.EventHandler(this.AnotherLogIOUT);
            this.LAnotherLogin.MouseMove += new System.Windows.Forms.MouseEventHandler(this.AnotherLogIN);
            // 
            // LNonRegistered
            // 
            this.LNonRegistered.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LNonRegistered.Dock = System.Windows.Forms.DockStyle.Top;
            this.LNonRegistered.Font = new System.Drawing.Font("Calibri", 10.25F);
            this.LNonRegistered.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.LNonRegistered.Location = new System.Drawing.Point(3, 0);
            this.LNonRegistered.Name = "LNonRegistered";
            this.LNonRegistered.Size = new System.Drawing.Size(177, 18);
            this.LNonRegistered.TabIndex = 13;
            this.LNonRegistered.Text = "Ещё не зарегестрированы?";
            this.LNonRegistered.Click += new System.EventHandler(this.LoginForm);
            this.LNonRegistered.MouseLeave += new System.EventHandler(this.NonRegisteredOUT);
            this.LNonRegistered.MouseMove += new System.Windows.Forms.MouseEventHandler(this.NonRegisteredIN);
            // 
            // BtnLogin
            // 
            this.BtnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnLogin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnLogin.Font = new System.Drawing.Font("Calibri", 12.25F, System.Drawing.FontStyle.Bold);
            this.BtnLogin.Location = new System.Drawing.Point(3, 3);
            this.BtnLogin.MinimumSize = new System.Drawing.Size(128, 33);
            this.BtnLogin.Name = "BtnLogin";
            this.BtnLogin.Size = new System.Drawing.Size(183, 33);
            this.BtnLogin.TabIndex = 11;
            this.BtnLogin.Text = "Войти";
            this.BtnLogin.UseVisualStyleBackColor = true;
            this.BtnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // GBRegistration
            // 
            this.GBRegistration.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GBRegistration.Controls.Add(this.tableLayoutPanel1);
            this.GBRegistration.Font = new System.Drawing.Font("Calibri", 18.25F, System.Drawing.FontStyle.Bold);
            this.GBRegistration.Location = new System.Drawing.Point(199, 45);
            this.GBRegistration.MinimumSize = new System.Drawing.Size(191, 285);
            this.GBRegistration.Name = "GBRegistration";
            this.GBRegistration.Size = new System.Drawing.Size(201, 285);
            this.GBRegistration.TabIndex = 2;
            this.GBRegistration.TabStop = false;
            this.GBRegistration.Text = "Вход";
            // 
            // SignInForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.ClientSize = new System.Drawing.Size(583, 359);
            this.Controls.Add(this.GBRegistration);
            this.MinimumSize = new System.Drawing.Size(599, 398);
            this.Name = "SignInForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ExitProgram);
            this.Controls.SetChildIndex(this.GBRegistration, 0);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.GBRegistration.ResumeLayout(false);
            this.GBRegistration.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox GBRegistration;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TextBox TBPassword;
        private System.Windows.Forms.Label LPassword;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label LLogin;
        private System.Windows.Forms.TextBox TBLogin;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Label LIncorrectLogin;
        private System.Windows.Forms.Label LAnotherLogin;
        private System.Windows.Forms.Label LNonRegistered;
        private System.Windows.Forms.Button BtnLogin;
    }
}
