namespace iBanking
{
    partial class Login_form
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
            this.label_UserName = new System.Windows.Forms.Label();
            this.label_Password = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.label_AdminLogin = new System.Windows.Forms.Label();
            this.txtBoxUserName = new System.Windows.Forms.TextBox();
            this.txtBoxPassword = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label_UserName
            // 
            this.label_UserName.AutoSize = true;
            this.label_UserName.Location = new System.Drawing.Point(27, 96);
            this.label_UserName.Name = "label_UserName";
            this.label_UserName.Size = new System.Drawing.Size(63, 13);
            this.label_UserName.TabIndex = 0;
            this.label_UserName.Text = "User Name:";
            // 
            // label_Password
            // 
            this.label_Password.AutoSize = true;
            this.label_Password.Location = new System.Drawing.Point(27, 156);
            this.label_Password.Name = "label_Password";
            this.label_Password.Size = new System.Drawing.Size(56, 13);
            this.label_Password.TabIndex = 1;
            this.label_Password.Text = "Password:";
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(363, 225);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 23);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // label_AdminLogin
            // 
            this.label_AdminLogin.AutoSize = true;
            this.label_AdminLogin.Location = new System.Drawing.Point(27, 25);
            this.label_AdminLogin.Name = "label_AdminLogin";
            this.label_AdminLogin.Size = new System.Drawing.Size(68, 13);
            this.label_AdminLogin.TabIndex = 3;
            this.label_AdminLogin.Text = "Admin Login:";
            // 
            // txtBoxUserName
            // 
            this.txtBoxUserName.Location = new System.Drawing.Point(89, 93);
            this.txtBoxUserName.Name = "txtBoxUserName";
            this.txtBoxUserName.Size = new System.Drawing.Size(184, 20);
            this.txtBoxUserName.TabIndex = 4;
            // 
            // txtBoxPassword
            // 
            this.txtBoxPassword.Location = new System.Drawing.Point(89, 153);
            this.txtBoxPassword.Name = "txtBoxPassword";
            this.txtBoxPassword.PasswordChar = '*';
            this.txtBoxPassword.Size = new System.Drawing.Size(184, 20);
            this.txtBoxPassword.TabIndex = 5;
            // 
            // Login_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(578, 304);
            this.Controls.Add(this.txtBoxPassword);
            this.Controls.Add(this.txtBoxUserName);
            this.Controls.Add(this.label_AdminLogin);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.label_Password);
            this.Controls.Add(this.label_UserName);
            this.Name = "Login_form";
            this.Text = "login_form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_UserName;
        private System.Windows.Forms.Label label_Password;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label label_AdminLogin;
        private System.Windows.Forms.TextBox txtBoxUserName;
        private System.Windows.Forms.TextBox txtBoxPassword;
    }
}