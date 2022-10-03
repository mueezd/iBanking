namespace iBanking
{
    partial class balanceSheetForm
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
            this.textBoxAccountNo = new System.Windows.Forms.TextBox();
            this.btnShow = new System.Windows.Forms.Button();
            this.dataGridViewWithdrawal = new System.Windows.Forms.DataGridView();
            this.dataGridViewDeposit = new System.Windows.Forms.DataGridView();
            this.dataGridViewTransfer = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.GvPayments = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewWithdrawal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDeposit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTransfer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GvPayments)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Transaction History";
            // 
            // textBoxAccountNo
            // 
            this.textBoxAccountNo.Location = new System.Drawing.Point(40, 60);
            this.textBoxAccountNo.Name = "textBoxAccountNo";
            this.textBoxAccountNo.Size = new System.Drawing.Size(323, 20);
            this.textBoxAccountNo.TabIndex = 1;
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(381, 58);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(104, 23);
            this.btnShow.TabIndex = 2;
            this.btnShow.Text = "Show";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // dataGridViewWithdrawal
            // 
            this.dataGridViewWithdrawal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewWithdrawal.Location = new System.Drawing.Point(40, 119);
            this.dataGridViewWithdrawal.Name = "dataGridViewWithdrawal";
            this.dataGridViewWithdrawal.Size = new System.Drawing.Size(323, 373);
            this.dataGridViewWithdrawal.TabIndex = 3;
            // 
            // dataGridViewDeposit
            // 
            this.dataGridViewDeposit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDeposit.Location = new System.Drawing.Point(375, 119);
            this.dataGridViewDeposit.Name = "dataGridViewDeposit";
            this.dataGridViewDeposit.Size = new System.Drawing.Size(323, 373);
            this.dataGridViewDeposit.TabIndex = 4;
            // 
            // dataGridViewTransfer
            // 
            this.dataGridViewTransfer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTransfer.Location = new System.Drawing.Point(710, 119);
            this.dataGridViewTransfer.Name = "dataGridViewTransfer";
            this.dataGridViewTransfer.Size = new System.Drawing.Size(323, 373);
            this.dataGridViewTransfer.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Account No:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Withdrawal Details:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(372, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Deposit Details:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(707, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Transfer Details:";
            // 
            // GvPayments
            // 
            this.GvPayments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GvPayments.Location = new System.Drawing.Point(1043, 119);
            this.GvPayments.Name = "GvPayments";
            this.GvPayments.Size = new System.Drawing.Size(323, 373);
            this.GvPayments.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1040, 94);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Payment Details:";
            // 
            // balanceSheetForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1389, 523);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.GvPayments);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridViewTransfer);
            this.Controls.Add(this.dataGridViewDeposit);
            this.Controls.Add(this.dataGridViewWithdrawal);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.textBoxAccountNo);
            this.Controls.Add(this.label1);
            this.Name = "balanceSheetForm";
            this.Text = "Transaction History";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewWithdrawal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDeposit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTransfer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GvPayments)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxAccountNo;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.DataGridView dataGridViewWithdrawal;
        private System.Windows.Forms.DataGridView dataGridViewDeposit;
        private System.Windows.Forms.DataGridView dataGridViewTransfer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView GvPayments;
        private System.Windows.Forms.Label label6;
    }
}