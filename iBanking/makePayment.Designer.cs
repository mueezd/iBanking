namespace iBanking
{
    partial class makePayment
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
            this.lblPayment = new System.Windows.Forms.Label();
            this.lblPayTo = new System.Windows.Forms.Label();
            this.lblAgainst = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.comboBoxPayeeName = new System.Windows.Forms.ComboBox();
            this.textBoxAgainstOf = new System.Windows.Forms.TextBox();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnConfirmPayment = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblGetDate = new System.Windows.Forms.Label();
            this.textBoxAmount = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblAccountNo = new System.Windows.Forms.Label();
            this.lebel = new System.Windows.Forms.Label();
            this.lblAccountName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblPayment
            // 
            this.lblPayment.AutoSize = true;
            this.lblPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPayment.Location = new System.Drawing.Point(40, 33);
            this.lblPayment.Name = "lblPayment";
            this.lblPayment.Size = new System.Drawing.Size(78, 20);
            this.lblPayment.TabIndex = 0;
            this.lblPayment.Text = "Payment";
            // 
            // lblPayTo
            // 
            this.lblPayTo.AutoSize = true;
            this.lblPayTo.Location = new System.Drawing.Point(41, 181);
            this.lblPayTo.Name = "lblPayTo";
            this.lblPayTo.Size = new System.Drawing.Size(114, 13);
            this.lblPayTo.TabIndex = 1;
            this.lblPayTo.Text = "Pay To (Payee Name):";
            // 
            // lblAgainst
            // 
            this.lblAgainst.AutoSize = true;
            this.lblAgainst.Location = new System.Drawing.Point(41, 220);
            this.lblAgainst.Name = "lblAgainst";
            this.lblAgainst.Size = new System.Drawing.Size(59, 13);
            this.lblAgainst.TabIndex = 2;
            this.lblAgainst.Text = "Against Of:";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(41, 266);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(63, 13);
            this.lblDescription.TabIndex = 3;
            this.lblDescription.Text = "Description:";
            // 
            // comboBoxPayeeName
            // 
            this.comboBoxPayeeName.FormattingEnabled = true;
            this.comboBoxPayeeName.Location = new System.Drawing.Point(162, 177);
            this.comboBoxPayeeName.Name = "comboBoxPayeeName";
            this.comboBoxPayeeName.Size = new System.Drawing.Size(245, 21);
            this.comboBoxPayeeName.TabIndex = 4;
            // 
            // textBoxAgainstOf
            // 
            this.textBoxAgainstOf.Location = new System.Drawing.Point(162, 220);
            this.textBoxAgainstOf.Name = "textBoxAgainstOf";
            this.textBoxAgainstOf.Size = new System.Drawing.Size(245, 20);
            this.textBoxAgainstOf.TabIndex = 5;
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Location = new System.Drawing.Point(162, 263);
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(245, 20);
            this.textBoxDescription.TabIndex = 6;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(200, 335);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(102, 33);
            this.btnClear.TabIndex = 11;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // btnConfirmPayment
            // 
            this.btnConfirmPayment.Location = new System.Drawing.Point(308, 335);
            this.btnConfirmPayment.Name = "btnConfirmPayment";
            this.btnConfirmPayment.Size = new System.Drawing.Size(102, 33);
            this.btnConfirmPayment.TabIndex = 10;
            this.btnConfirmPayment.Text = "Confirm Payment";
            this.btnConfirmPayment.UseVisualStyleBackColor = true;
            this.btnConfirmPayment.Click += new System.EventHandler(this.btnConfirmPayment_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Date:";
            // 
            // lblGetDate
            // 
            this.lblGetDate.AutoSize = true;
            this.lblGetDate.Location = new System.Drawing.Point(159, 73);
            this.lblGetDate.Name = "lblGetDate";
            this.lblGetDate.Size = new System.Drawing.Size(33, 13);
            this.lblGetDate.TabIndex = 13;
            this.lblGetDate.Text = "Date:";
            // 
            // textBoxAmount
            // 
            this.textBoxAmount.Location = new System.Drawing.Point(162, 300);
            this.textBoxAmount.Name = "textBoxAmount";
            this.textBoxAmount.Size = new System.Drawing.Size(245, 20);
            this.textBoxAmount.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 303);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Amount";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Account No:";
            // 
            // lblAccountNo
            // 
            this.lblAccountNo.AutoSize = true;
            this.lblAccountNo.Location = new System.Drawing.Point(159, 116);
            this.lblAccountNo.Name = "lblAccountNo";
            this.lblAccountNo.Size = new System.Drawing.Size(67, 13);
            this.lblAccountNo.TabIndex = 17;
            this.lblAccountNo.Text = "Account No:";
            // 
            // lebel
            // 
            this.lebel.AutoSize = true;
            this.lebel.Location = new System.Drawing.Point(41, 149);
            this.lebel.Name = "lebel";
            this.lebel.Size = new System.Drawing.Size(81, 13);
            this.lebel.TabIndex = 18;
            this.lebel.Text = "Account Name:";
            // 
            // lblAccountName
            // 
            this.lblAccountName.AutoSize = true;
            this.lblAccountName.Location = new System.Drawing.Point(159, 149);
            this.lblAccountName.Name = "lblAccountName";
            this.lblAccountName.Size = new System.Drawing.Size(81, 13);
            this.lblAccountName.TabIndex = 19;
            this.lblAccountName.Text = "Account Name:";
            // 
            // makePayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 434);
            this.Controls.Add(this.lblAccountName);
            this.Controls.Add(this.lebel);
            this.Controls.Add(this.lblAccountNo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxAmount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblGetDate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnConfirmPayment);
            this.Controls.Add(this.textBoxDescription);
            this.Controls.Add(this.textBoxAgainstOf);
            this.Controls.Add(this.comboBoxPayeeName);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblAgainst);
            this.Controls.Add(this.lblPayTo);
            this.Controls.Add(this.lblPayment);
            this.Name = "makePayment";
            this.Text = "Payment";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPayment;
        private System.Windows.Forms.Label lblPayTo;
        private System.Windows.Forms.Label lblAgainst;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.ComboBox comboBoxPayeeName;
        private System.Windows.Forms.TextBox textBoxAgainstOf;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnConfirmPayment;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblGetDate;
        private System.Windows.Forms.TextBox textBoxAmount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblAccountNo;
        private System.Windows.Forms.Label lebel;
        private System.Windows.Forms.Label lblAccountName;
    }
}