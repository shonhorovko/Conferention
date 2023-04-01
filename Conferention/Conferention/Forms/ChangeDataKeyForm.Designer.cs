namespace Conferention.Forms
{
    partial class ChangeDataKeyForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangeDataKeyForm));
            this.BSave = new System.Windows.Forms.Button();
            this.TB_Login = new System.Windows.Forms.TextBox();
            this.TB_Pass = new System.Windows.Forms.TextBox();
            this.LLogin = new System.Windows.Forms.Label();
            this.LPass1 = new System.Windows.Forms.Label();
            this.GBMain = new System.Windows.Forms.GroupBox();
            this.TB_OldPass = new System.Windows.Forms.TextBox();
            this.LOldPass = new System.Windows.Forms.Label();
            this.PB_ShowPass1 = new System.Windows.Forms.PictureBox();
            this.PB_ShowPass2 = new System.Windows.Forms.PictureBox();
            this.LPass2 = new System.Windows.Forms.Label();
            this.TB_PassIsTrue = new System.Windows.Forms.TextBox();
            this.GBMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PB_ShowPass1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_ShowPass2)).BeginInit();
            this.SuspendLayout();
            // 
            // BSave
            // 
            this.BSave.Location = new System.Drawing.Point(173, 210);
            this.BSave.Name = "BSave";
            this.BSave.Size = new System.Drawing.Size(104, 36);
            this.BSave.TabIndex = 0;
            this.BSave.Text = "Сохранить";
            this.BSave.UseVisualStyleBackColor = true;
            this.BSave.Click += new System.EventHandler(this.BSave_Click);
            // 
            // TB_Login
            // 
            this.TB_Login.Location = new System.Drawing.Point(199, 35);
            this.TB_Login.MaxLength = 255;
            this.TB_Login.Name = "TB_Login";
            this.TB_Login.Size = new System.Drawing.Size(185, 31);
            this.TB_Login.TabIndex = 1;
            // 
            // TB_Pass
            // 
            this.TB_Pass.Location = new System.Drawing.Point(199, 109);
            this.TB_Pass.MaxLength = 255;
            this.TB_Pass.Name = "TB_Pass";
            this.TB_Pass.PasswordChar = '*';
            this.TB_Pass.Size = new System.Drawing.Size(185, 31);
            this.TB_Pass.TabIndex = 2;
            // 
            // LLogin
            // 
            this.LLogin.AutoSize = true;
            this.LLogin.Font = new System.Drawing.Font("Calibri", 14.25F);
            this.LLogin.Location = new System.Drawing.Point(78, 38);
            this.LLogin.Name = "LLogin";
            this.LLogin.Size = new System.Drawing.Size(115, 23);
            this.LLogin.TabIndex = 3;
            this.LLogin.Text = "Новый логин";
            // 
            // LPass1
            // 
            this.LPass1.AutoSize = true;
            this.LPass1.Font = new System.Drawing.Font("Calibri", 14.25F);
            this.LPass1.Location = new System.Drawing.Point(67, 112);
            this.LPass1.Name = "LPass1";
            this.LPass1.Size = new System.Drawing.Size(126, 23);
            this.LPass1.TabIndex = 4;
            this.LPass1.Text = "Новый пароль";
            // 
            // GBMain
            // 
            this.GBMain.Controls.Add(this.TB_OldPass);
            this.GBMain.Controls.Add(this.LOldPass);
            this.GBMain.Controls.Add(this.PB_ShowPass1);
            this.GBMain.Controls.Add(this.LPass1);
            this.GBMain.Controls.Add(this.TB_Login);
            this.GBMain.Controls.Add(this.PB_ShowPass2);
            this.GBMain.Controls.Add(this.LLogin);
            this.GBMain.Controls.Add(this.TB_Pass);
            this.GBMain.Controls.Add(this.LPass2);
            this.GBMain.Controls.Add(this.TB_PassIsTrue);
            this.GBMain.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GBMain.Location = new System.Drawing.Point(12, 12);
            this.GBMain.Name = "GBMain";
            this.GBMain.Size = new System.Drawing.Size(427, 192);
            this.GBMain.TabIndex = 5;
            this.GBMain.TabStop = false;
            this.GBMain.Text = "Изменение логина и пароля";
            // 
            // TB_OldPass
            // 
            this.TB_OldPass.Location = new System.Drawing.Point(199, 72);
            this.TB_OldPass.MaxLength = 255;
            this.TB_OldPass.Name = "TB_OldPass";
            this.TB_OldPass.PasswordChar = '*';
            this.TB_OldPass.Size = new System.Drawing.Size(185, 31);
            this.TB_OldPass.TabIndex = 9;
            // 
            // LOldPass
            // 
            this.LOldPass.AutoSize = true;
            this.LOldPass.Font = new System.Drawing.Font("Calibri", 14.25F);
            this.LOldPass.Location = new System.Drawing.Point(62, 75);
            this.LOldPass.Name = "LOldPass";
            this.LOldPass.Size = new System.Drawing.Size(131, 23);
            this.LOldPass.TabIndex = 10;
            this.LOldPass.Text = "Старый пароль";
            // 
            // PB_ShowPass1
            // 
            this.PB_ShowPass1.Image = ((System.Drawing.Image)(resources.GetObject("PB_ShowPass1.Image")));
            this.PB_ShowPass1.Location = new System.Drawing.Point(390, 112);
            this.PB_ShowPass1.Name = "PB_ShowPass1";
            this.PB_ShowPass1.Size = new System.Drawing.Size(25, 25);
            this.PB_ShowPass1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PB_ShowPass1.TabIndex = 8;
            this.PB_ShowPass1.TabStop = false;
            this.PB_ShowPass1.Click += new System.EventHandler(this.ShowPass);
            // 
            // PB_ShowPass2
            // 
            this.PB_ShowPass2.Image = ((System.Drawing.Image)(resources.GetObject("PB_ShowPass2.Image")));
            this.PB_ShowPass2.Location = new System.Drawing.Point(390, 149);
            this.PB_ShowPass2.Name = "PB_ShowPass2";
            this.PB_ShowPass2.Size = new System.Drawing.Size(25, 25);
            this.PB_ShowPass2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PB_ShowPass2.TabIndex = 7;
            this.PB_ShowPass2.TabStop = false;
            this.PB_ShowPass2.Click += new System.EventHandler(this.ShowPassIsTrue);
            // 
            // LPass2
            // 
            this.LPass2.AutoSize = true;
            this.LPass2.Font = new System.Drawing.Font("Calibri", 14.25F);
            this.LPass2.Location = new System.Drawing.Point(17, 149);
            this.LPass2.Name = "LPass2";
            this.LPass2.Size = new System.Drawing.Size(176, 23);
            this.LPass2.TabIndex = 6;
            this.LPass2.Text = "Подтвердите пароль";
            // 
            // TB_PassIsTrue
            // 
            this.TB_PassIsTrue.Location = new System.Drawing.Point(199, 146);
            this.TB_PassIsTrue.MaxLength = 255;
            this.TB_PassIsTrue.Name = "TB_PassIsTrue";
            this.TB_PassIsTrue.PasswordChar = '*';
            this.TB_PassIsTrue.Size = new System.Drawing.Size(185, 31);
            this.TB_PassIsTrue.TabIndex = 5;
            // 
            // ChangeDataKeyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(451, 250);
            this.Controls.Add(this.GBMain);
            this.Controls.Add(this.BSave);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Font = new System.Drawing.Font("Calibri", 14.25F);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(467, 289);
            this.MinimumSize = new System.Drawing.Size(467, 289);
            this.Name = "ChangeDataKeyForm";
            this.Text = "OZON";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormClosed);
            this.GBMain.ResumeLayout(false);
            this.GBMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PB_ShowPass1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_ShowPass2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BSave;
        private System.Windows.Forms.TextBox TB_Login;
        private System.Windows.Forms.TextBox TB_Pass;
        private System.Windows.Forms.Label LLogin;
        private System.Windows.Forms.Label LPass1;
        private System.Windows.Forms.GroupBox GBMain;
        private System.Windows.Forms.TextBox TB_OldPass;
        private System.Windows.Forms.Label LOldPass;
        private System.Windows.Forms.PictureBox PB_ShowPass1;
        private System.Windows.Forms.PictureBox PB_ShowPass2;
        private System.Windows.Forms.Label LPass2;
        private System.Windows.Forms.TextBox TB_PassIsTrue;
    }
}