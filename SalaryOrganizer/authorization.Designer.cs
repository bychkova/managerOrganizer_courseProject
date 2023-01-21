namespace SalaryOrganizer
{
    partial class authorization
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
            this.loginField = new System.Windows.Forms.TextBox();
            this.passwordField = new System.Windows.Forms.TextBox();
            this.authoBtn = new MaterialSkin.Controls.MaterialRaisedButton();
            this.SuspendLayout();
            // 
            // loginField
            // 
            this.loginField.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginField.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.loginField.Location = new System.Drawing.Point(38, 97);
            this.loginField.Name = "loginField";
            this.loginField.Size = new System.Drawing.Size(241, 29);
            this.loginField.TabIndex = 0;
            this.loginField.Text = "Имя пользователя";
            this.loginField.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // passwordField
            // 
            this.passwordField.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passwordField.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.passwordField.Location = new System.Drawing.Point(38, 158);
            this.passwordField.Name = "passwordField";
            this.passwordField.PasswordChar = '*';
            this.passwordField.Size = new System.Drawing.Size(241, 29);
            this.passwordField.TabIndex = 1;
            this.passwordField.Text = "Пароль";
            this.passwordField.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // authoBtn
            // 
            this.authoBtn.Depth = 0;
            this.authoBtn.Location = new System.Drawing.Point(38, 222);
            this.authoBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.authoBtn.Name = "authoBtn";
            this.authoBtn.Primary = true;
            this.authoBtn.Size = new System.Drawing.Size(241, 38);
            this.authoBtn.TabIndex = 2;
            this.authoBtn.Text = "войти";
            this.authoBtn.UseVisualStyleBackColor = true;
            // 
            // authorization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 301);
            this.Controls.Add(this.authoBtn);
            this.Controls.Add(this.passwordField);
            this.Controls.Add(this.loginField);
            this.MaximumSize = new System.Drawing.Size(322, 301);
            this.MinimumSize = new System.Drawing.Size(322, 301);
            this.Name = "authorization";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "авторизация";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox loginField;
        private System.Windows.Forms.TextBox passwordField;
        private MaterialSkin.Controls.MaterialRaisedButton authoBtn;
    }
}