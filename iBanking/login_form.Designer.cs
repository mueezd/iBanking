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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.checkBoxViewPassword = new System.Windows.Forms.CheckBox();
            this.txtBoxPassword = new System.Windows.Forms.TextBox();
            this.txtBoxUserName = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.label_Password = new System.Windows.Forms.Label();
            this.label_UserName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.linkLabelRegisterNow = new System.Windows.Forms.LinkLabel();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.checkBoxViewPassword);
            this.groupBox1.Controls.Add(this.txtBoxPassword);
            this.groupBox1.Controls.Add(this.txtBoxUserName);
            this.groupBox1.Controls.Add(this.btnLogin);
            this.groupBox1.Controls.Add(this.label_Password);
            this.groupBox1.Controls.Add(this.label_UserName);
            this.groupBox1.Location = new System.Drawing.Point(123, 53);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(339, 190);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "User Login";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(136, 136);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "Cancel";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // checkBoxViewPassword
            // 
            this.checkBoxViewPassword.AutoSize = true;
            this.checkBoxViewPassword.Location = new System.Drawing.Point(108, 102);
            this.checkBoxViewPassword.Name = "checkBoxViewPassword";
            this.checkBoxViewPassword.Size = new System.Drawing.Size(98, 17);
            this.checkBoxViewPassword.TabIndex = 13;
            this.checkBoxViewPassword.Text = "View Password";
            this.checkBoxViewPassword.UseVisualStyleBackColor = true;
            // 
            // txtBoxPassword
            // 
            this.txtBoxPassword.Location = new System.Drawing.Point(108, 75);
            this.txtBoxPassword.Name = "txtBoxPassword";
            this.txtBoxPassword.Size = new System.Drawing.Size(184, 20);
            this.txtBoxPassword.TabIndex = 12;
            this.txtBoxPassword.UseSystemPasswordChar = true;
            // 
            // txtBoxUserName
            // 
            this.txtBoxUserName.Location = new System.Drawing.Point(108, 32);
            this.txtBoxUserName.Name = "txtBoxUserName";
            this.txtBoxUserName.Size = new System.Drawing.Size(184, 20);
            this.txtBoxUserName.TabIndex = 11;
            this.txtBoxUserName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxUserName_KeyPress);
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(217, 136);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 23);
            this.btnLogin.TabIndex = 10;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // label_Password
            // 
            this.label_Password.AutoSize = true;
            this.label_Password.Location = new System.Drawing.Point(46, 78);
            this.label_Password.Name = "label_Password";
            this.label_Password.Size = new System.Drawing.Size(56, 13);
            this.label_Password.TabIndex = 9;
            this.label_Password.Text = "Password:";
            // 
            // label_UserName
            // 
            this.label_UserName.AutoSize = true;
            this.label_UserName.Location = new System.Drawing.Point(46, 35);
            this.label_UserName.Name = "label_UserName";
            this.label_UserName.Size = new System.Drawing.Size(63, 13);
            this.label_UserName.TabIndex = 8;
            this.label_UserName.Text = "User Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(233, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "Banking Software for Retail Bank";
            // 
            // linkLabelRegisterNow
            // 
            this.linkLabelRegisterNow.AutoSize = true;
            this.linkLabelRegisterNow.Location = new System.Drawing.Point(391, 246);
            this.linkLabelRegisterNow.Name = "linkLabelRegisterNow";
            this.linkLabelRegisterNow.Size = new System.Drawing.Size(71, 13);
            this.linkLabelRegisterNow.TabIndex = 10;
            this.linkLabelRegisterNow.TabStop = true;
            this.linkLabelRegisterNow.Text = "Register Now";
            this.linkLabelRegisterNow.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelRegisterNow_LinkClicked);
            // 
            // Login_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(578, 304);
            this.Controls.Add(this.linkLabelRegisterNow);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Login_form";
            this.Text = "User Login - Banking Software for Retail Bank";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox checkBoxViewPassword;
        private System.Windows.Forms.TextBox txtBoxPassword;
        private System.Windows.Forms.TextBox txtBoxUserName;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label label_Password;
        private System.Windows.Forms.Label label_UserName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel linkLabelRegisterNow;
    }
}