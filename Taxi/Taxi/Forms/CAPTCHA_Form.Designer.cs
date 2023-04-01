namespace Conferention.Forms
{
    partial class CAPTCHA_Form
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
            this.pbCAPCHA = new System.Windows.Forms.PictureBox();
            this.tbCAPCHA = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbCAPCHA)).BeginInit();
            this.SuspendLayout();
            // 
            // pbCAPCHA
            // 
            this.pbCAPCHA.Location = new System.Drawing.Point(14, 73);
            this.pbCAPCHA.Margin = new System.Windows.Forms.Padding(5);
            this.pbCAPCHA.Name = "pbCAPCHA";
            this.pbCAPCHA.Size = new System.Drawing.Size(198, 94);
            this.pbCAPCHA.TabIndex = 0;
            this.pbCAPCHA.TabStop = false;
            // 
            // tbCAPCHA
            // 
            this.tbCAPCHA.Location = new System.Drawing.Point(14, 177);
            this.tbCAPCHA.Margin = new System.Windows.Forms.Padding(5);
            this.tbCAPCHA.Name = "tbCAPCHA";
            this.tbCAPCHA.Size = new System.Drawing.Size(198, 31);
            this.tbCAPCHA.TabIndex = 1;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Calibri", 10.25F);
            this.btnUpdate.Location = new System.Drawing.Point(14, 218);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(5);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(94, 34);
            this.btnUpdate.TabIndex = 2;
            this.btnUpdate.Text = "Обновить";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnOK
            // 
            this.btnOK.Font = new System.Drawing.Font("Calibri", 10.25F);
            this.btnOK.Location = new System.Drawing.Point(118, 218);
            this.btnOK.Margin = new System.Windows.Forms.Padding(5);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(94, 34);
            this.btnOK.TabIndex = 3;
            this.btnOK.Text = "ОК";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // CAPTCHA_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(224, 261);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.tbCAPCHA);
            this.Controls.Add(this.pbCAPCHA);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(240, 300);
            this.MinimumSize = new System.Drawing.Size(240, 300);
            this.Name = "CAPTCHA_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "CAPTCHA";
            this.Load += new System.EventHandler(this.FCAPCHA_Load);
            this.Controls.SetChildIndex(this.pbCAPCHA, 0);
            this.Controls.SetChildIndex(this.tbCAPCHA, 0);
            this.Controls.SetChildIndex(this.btnUpdate, 0);
            this.Controls.SetChildIndex(this.btnOK, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pbCAPCHA)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.PictureBox pbCAPCHA;
        private System.Windows.Forms.TextBox tbCAPCHA;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnOK;

        #endregion
    }
}