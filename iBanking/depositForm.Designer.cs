namespace iBanking
{
    partial class Mode
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
            this.label1 = new System.Windows.Forms.Label();
            this.lbldate = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxEnterAcNo = new System.Windows.Forms.TextBox();
            this.textBoxAccountName = new System.Windows.Forms.TextBox();
            this.textBoxoldBalance = new System.Windows.Forms.TextBox();
            this.comboBoxMode = new System.Windows.Forms.ComboBox();
            this.textBoxDepositAmount = new System.Windows.Forms.TextBox();
            this.btnGetDetails = new System.Windows.Forms.Button();
            this.btnDeposit = new System.Windows.Forms.Button();
            this.textBoxRemarks = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lilDepositTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Current Date:";
            // 
            // lbldate
            // 
            this.lbldate.AutoSize = true;
            this.lbldate.Location = new System.Drawing.Point(127, 70);
            this.lbldate.Name = "lbldate";
            this.lbldate.Size = new System.Drawing.Size(35, 13);
            this.lbldate.TabIndex = 1;
            this.lbldate.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Enter Account Number:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Account Name:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 220);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Old Balance:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(36, 262);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Mode:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(36, 308);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Deposit Amount:";
            // 
            // textBoxEnterAcNo
            // 
            this.textBoxEnterAcNo.Location = new System.Drawing.Point(160, 125);
            this.textBoxEnterAcNo.Name = "textBoxEnterAcNo";
            this.textBoxEnterAcNo.Size = new System.Drawing.Size(276, 20);
            this.textBoxEnterAcNo.TabIndex = 7;
            // 
            // textBoxAccountName
            // 
            this.textBoxAccountName.Location = new System.Drawing.Point(160, 172);
            this.textBoxAccountName.Name = "textBoxAccountName";
            this.textBoxAccountName.Size = new System.Drawing.Size(276, 20);
            this.textBoxAccountName.TabIndex = 8;
            // 
            // textBoxoldBalance
            // 
            this.textBoxoldBalance.Location = new System.Drawing.Point(160, 217);
            this.textBoxoldBalance.Name = "textBoxoldBalance";
            this.textBoxoldBalance.Size = new System.Drawing.Size(276, 20);
            this.textBoxoldBalance.TabIndex = 9;
            // 
            // comboBoxMode
            // 
            this.comboBoxMode.FormattingEnabled = true;
            this.comboBoxMode.Location = new System.Drawing.Point(160, 259);
            this.comboBoxMode.Name = "comboBoxMode";
            this.comboBoxMode.Size = new System.Drawing.Size(276, 21);
            this.comboBoxMode.TabIndex = 10;
            // 
            // textBoxDepositAmount
            // 
            this.textBoxDepositAmount.Location = new System.Drawing.Point(160, 305);
            this.textBoxDepositAmount.Name = "textBoxDepositAmount";
            this.textBoxDepositAmount.Size = new System.Drawing.Size(276, 20);
            this.textBoxDepositAmount.TabIndex = 11;
            // 
            // btnGetDetails
            // 
            this.btnGetDetails.Location = new System.Drawing.Point(458, 123);
            this.btnGetDetails.Name = "btnGetDetails";
            this.btnGetDetails.Size = new System.Drawing.Size(122, 23);
            this.btnGetDetails.TabIndex = 12;
            this.btnGetDetails.Text = "Get Details";
            this.btnGetDetails.UseVisualStyleBackColor = true;
            this.btnGetDetails.Click += new System.EventHandler(this.btnGetDetails_Click);
            // 
            // btnDeposit
            // 
            this.btnDeposit.Location = new System.Drawing.Point(314, 405);
            this.btnDeposit.Name = "btnDeposit";
            this.btnDeposit.Size = new System.Drawing.Size(122, 23);
            this.btnDeposit.TabIndex = 13;
            this.btnDeposit.Text = "Deposit";
            this.btnDeposit.UseVisualStyleBackColor = true;
            this.btnDeposit.Click += new System.EventHandler(this.btnDeposit_Click);
            // 
            // textBoxRemarks
            // 
            this.textBoxRemarks.Location = new System.Drawing.Point(160, 350);
            this.textBoxRemarks.Name = "textBoxRemarks";
            this.textBoxRemarks.Size = new System.Drawing.Size(276, 20);
            this.textBoxRemarks.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 353);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Remarks:";
            // 
            // lilDepositTitle
            // 
            this.lilDepositTitle.AutoSize = true;
            this.lilDepositTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lilDepositTitle.Location = new System.Drawing.Point(33, 30);
            this.lilDepositTitle.Name = "lilDepositTitle";
            this.lilDepositTitle.Size = new System.Drawing.Size(71, 20);
            this.lilDepositTitle.TabIndex = 16;
            this.lilDepositTitle.Text = "Deposit";
            // 
            // Mode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 450);
            this.Controls.Add(this.lilDepositTitle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxRemarks);
            this.Controls.Add(this.btnDeposit);
            this.Controls.Add(this.btnGetDetails);
            this.Controls.Add(this.textBoxDepositAmount);
            this.Controls.Add(this.comboBoxMode);
            this.Controls.Add(this.textBoxoldBalance);
            this.Controls.Add(this.textBoxAccountName);
            this.Controls.Add(this.textBoxEnterAcNo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbldate);
            this.Controls.Add(this.label1);
            this.Name = "Mode";
            this.Text = "depositForm";
            this.Load += new System.EventHandler(this.depositForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbldate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxEnterAcNo;
        private System.Windows.Forms.TextBox textBoxAccountName;
        private System.Windows.Forms.TextBox textBoxoldBalance;
        private System.Windows.Forms.ComboBox comboBoxMode;
        private System.Windows.Forms.TextBox textBoxDepositAmount;
        private System.Windows.Forms.Button btnGetDetails;
        private System.Windows.Forms.Button btnDeposit;
        private System.Windows.Forms.TextBox textBoxRemarks;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lilDepositTitle;
    }
}