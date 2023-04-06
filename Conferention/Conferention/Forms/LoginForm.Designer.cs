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
            this.BtnLogin = new System.Windows.Forms.Button();
            this.LHaveAccount = new System.Windows.Forms.Label();
            this.LLoginDriver = new System.Windows.Forms.Label();
            this.LIncorrectLogin = new System.Windows.Forms.Label();
            this.tableLayoutPanel13 = new System.Windows.Forms.TableLayoutPanel();
            this.GBRegistration.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel13.SuspendLayout();
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
            this.GBRegistration.MinimumSize = new System.Drawing.Size(229, 359);
            this.GBRegistration.Name = "GBRegistration";
            this.GBRegistration.Padding = new System.Windows.Forms.Padding(4);
            this.GBRegistration.Size = new System.Drawing.Size(524, 416);
            this.GBRegistration.TabIndex = 3;
            this.GBRegistration.TabStop = false;
            this.GBRegistration.Text = "Регистрация";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.AutoSize = true;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel13, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.BtnLogin, 1, 4);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(4, 42);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 5;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.Size = new System.Drawing.Size(516, 370);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // BtnLogin
            // 
            this.BtnLogin.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BtnLogin.AutoSize = true;
            this.BtnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnLogin.Font = new System.Drawing.Font("Calibri", 12.25F, System.Drawing.FontStyle.Bold);
            this.BtnLogin.Location = new System.Drawing.Point(280, 84);
            this.BtnLogin.Margin = new System.Windows.Forms.Padding(4);
            this.BtnLogin.MinimumSize = new System.Drawing.Size(154, 42);
            this.BtnLogin.Name = "BtnLogin";
            this.BtnLogin.Size = new System.Drawing.Size(201, 42);
            this.BtnLogin.TabIndex = 23;
            this.BtnLogin.Text = "Зарегестрироваться";
            this.BtnLogin.UseVisualStyleBackColor = true;
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
            this.LHaveAccount.Size = new System.Drawing.Size(229, 22);
            this.LHaveAccount.TabIndex = 13;
            this.LHaveAccount.Text = "Есть аккаунт?";
            // 
            // LLoginDriver
            // 
            this.LLoginDriver.AutoSize = true;
            this.LLoginDriver.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LLoginDriver.Dock = System.Windows.Forms.DockStyle.Top;
            this.LLoginDriver.Font = new System.Drawing.Font("Calibri", 10.25F);
            this.LLoginDriver.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.LLoginDriver.Location = new System.Drawing.Point(4, 22);
            this.LLoginDriver.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LLoginDriver.Name = "LLoginDriver";
            this.LLoginDriver.Size = new System.Drawing.Size(229, 22);
            this.LLoginDriver.TabIndex = 14;
            this.LLoginDriver.Text = "Регистрация водителя";
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
            this.LIncorrectLogin.Size = new System.Drawing.Size(229, 22);
            this.LIncorrectLogin.TabIndex = 15;
            this.LIncorrectLogin.Text = "Неверный логин или пароль\r\n";
            this.LIncorrectLogin.Visible = false;
            // 
            // tableLayoutPanel13
            // 
            this.tableLayoutPanel13.AutoSize = true;
            this.tableLayoutPanel13.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel13.ColumnCount = 1;
            this.tableLayoutPanel13.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel13.Controls.Add(this.LIncorrectLogin, 0, 2);
            this.tableLayoutPanel13.Controls.Add(this.LLoginDriver, 0, 1);
            this.tableLayoutPanel13.Controls.Add(this.LHaveAccount, 0, 0);
            this.tableLayoutPanel13.Dock = System.Windows.Forms.DockStyle.Left;
            this.tableLayoutPanel13.Location = new System.Drawing.Point(4, 84);
            this.tableLayoutPanel13.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel13.Name = "tableLayoutPanel13";
            this.tableLayoutPanel13.RowCount = 3;
            this.tableLayoutPanel13.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel13.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel13.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel13.Size = new System.Drawing.Size(237, 282);
            this.tableLayoutPanel13.TabIndex = 21;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 29F);
            this.ClientSize = new System.Drawing.Size(698, 445);
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
            this.tableLayoutPanel13.ResumeLayout(false);
            this.tableLayoutPanel13.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox GBRegistration;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel13;
        private System.Windows.Forms.Label LIncorrectLogin;
        private System.Windows.Forms.Label LLoginDriver;
        private System.Windows.Forms.Label LHaveAccount;
        private System.Windows.Forms.Button BtnLogin;
    }
}
