namespace iBanking
{
    partial class withdrawForm
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
            this.lblDate = new System.Windows.Forms.Label();
            this.labelWidthTite = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxAccountNo = new System.Windows.Forms.TextBox();
            this.textBoxAccountName = new System.Windows.Forms.TextBox();
            this.textBoxBalance = new System.Windows.Forms.TextBox();
            this.textBoxAmount = new System.Windows.Forms.TextBox();
            this.comboBoxMode = new System.Windows.Forms.ComboBox();
            this.btnGetDetails = new System.Windows.Forms.Button();
            this.btnCompleateTrans = new System.Windows.Forms.Button();
            this.textBoxRemarks = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Date:";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(99, 78);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(35, 13);
            this.lblDate.TabIndex = 1;
            this.lblDate.Text = "label2";
            this.lblDate.Click += new System.EventHandler(this.label2_Click);
            // 
            // labelWidthTite
            // 
            this.labelWidthTite.AutoSize = true;
            this.labelWidthTite.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWidthTite.Location = new System.Drawing.Point(40, 30);
            this.labelWidthTite.Name = "labelWidthTite";
            this.labelWidthTite.Size = new System.Drawing.Size(106, 20);
            this.labelWidthTite.TabIndex = 2;
            this.labelWidthTite.Text = "Withdrawals";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Account No:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Account Name:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(41, 209);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Balance:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(41, 268);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Mode:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(41, 323);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Amount:";
            // 
            // textBoxAccountNo
            // 
            this.textBoxAccountNo.Location = new System.Drawing.Point(137, 110);
            this.textBoxAccountNo.Name = "textBoxAccountNo";
            this.textBoxAccountNo.Size = new System.Drawing.Size(300, 20);
            this.textBoxAccountNo.TabIndex = 8;
            // 
            // textBoxAccountName
            // 
            this.textBoxAccountName.Location = new System.Drawing.Point(137, 154);
            this.textBoxAccountName.Name = "textBoxAccountName";
            this.textBoxAccountName.Size = new System.Drawing.Size(300, 20);
            this.textBoxAccountName.TabIndex = 9;
            // 
            // textBoxBalance
            // 
            this.textBoxBalance.Location = new System.Drawing.Point(137, 209);
            this.textBoxBalance.Name = "textBoxBalance";
            this.textBoxBalance.Size = new System.Drawing.Size(300, 20);
            this.textBoxBalance.TabIndex = 10;
            // 
            // textBoxAmount
            // 
            this.textBoxAmount.Location = new System.Drawing.Point(137, 320);
            this.textBoxAmount.Name = "textBoxAmount";
            this.textBoxAmount.Size = new System.Drawing.Size(300, 20);
            this.textBoxAmount.TabIndex = 11;
            // 
            // comboBoxMode
            // 
            this.comboBoxMode.FormattingEnabled = true;
            this.comboBoxMode.Location = new System.Drawing.Point(137, 265);
            this.comboBoxMode.Name = "comboBoxMode";
            this.comboBoxMode.Size = new System.Drawing.Size(300, 21);
            this.comboBoxMode.TabIndex = 12;
            // 
            // btnGetDetails
            // 
            this.btnGetDetails.Location = new System.Drawing.Point(443, 108);
            this.btnGetDetails.Name = "btnGetDetails";
            this.btnGetDetails.Size = new System.Drawing.Size(151, 23);
            this.btnGetDetails.TabIndex = 13;
            this.btnGetDetails.Text = "Get Details";
            this.btnGetDetails.UseVisualStyleBackColor = true;
            this.btnGetDetails.Click += new System.EventHandler(this.btnGetDetails_Click);
            // 
            // btnCompleateTrans
            // 
            this.btnCompleateTrans.Location = new System.Drawing.Point(286, 417);
            this.btnCompleateTrans.Name = "btnCompleateTrans";
            this.btnCompleateTrans.Size = new System.Drawing.Size(151, 23);
            this.btnCompleateTrans.TabIndex = 14;
            this.btnCompleateTrans.Text = "Complete Transection";
            this.btnCompleateTrans.UseVisualStyleBackColor = true;
            this.btnCompleateTrans.Click += new System.EventHandler(this.btnCompleateTrans_Click);
            // 
            // textBoxRemarks
            // 
            this.textBoxRemarks.Location = new System.Drawing.Point(137, 368);
            this.textBoxRemarks.Name = "textBoxRemarks";
            this.textBoxRemarks.Size = new System.Drawing.Size(300, 20);
            this.textBoxRemarks.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 371);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Remarks";
            // 
            // withdrawForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 481);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxRemarks);
            this.Controls.Add(this.btnCompleateTrans);
            this.Controls.Add(this.btnGetDetails);
            this.Controls.Add(this.comboBoxMode);
            this.Controls.Add(this.textBoxAmount);
            this.Controls.Add(this.textBoxBalance);
            this.Controls.Add(this.textBoxAccountName);
            this.Controls.Add(this.textBoxAccountNo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelWidthTite);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.label1);
            this.Name = "withdrawForm";
            this.Text = "withdrawForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label labelWidthTite;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxAccountNo;
        private System.Windows.Forms.TextBox textBoxAccountName;
        private System.Windows.Forms.TextBox textBoxBalance;
        private System.Windows.Forms.TextBox textBoxAmount;
        private System.Windows.Forms.ComboBox comboBoxMode;
        private System.Windows.Forms.Button btnGetDetails;
        private System.Windows.Forms.Button btnCompleateTrans;
        private System.Windows.Forms.TextBox textBoxRemarks;
        private System.Windows.Forms.Label label3;
    }
}