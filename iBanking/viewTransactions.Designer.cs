namespace iBanking
{
    partial class viewTransactions
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
            this.gvDeposit = new System.Windows.Forms.DataGridView();
            this.gvWithdrawals = new System.Windows.Forms.DataGridView();
            this.gvTransfers = new System.Windows.Forms.DataGridView();
            this.gvPayments = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnViewDeposits = new System.Windows.Forms.Button();
            this.btnViewWithdrawals = new System.Windows.Forms.Button();
            this.btnViewTransfers = new System.Windows.Forms.Button();
            this.btnPayments = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gvDeposit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvWithdrawals)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvTransfers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPayments)).BeginInit();
            this.SuspendLayout();
            // 
            // gvDeposit
            // 
            this.gvDeposit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvDeposit.Location = new System.Drawing.Point(44, 83);
            this.gvDeposit.Name = "gvDeposit";
            this.gvDeposit.Size = new System.Drawing.Size(735, 150);
            this.gvDeposit.TabIndex = 0;
            // 
            // gvWithdrawals
            // 
            this.gvWithdrawals.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvWithdrawals.Location = new System.Drawing.Point(44, 275);
            this.gvWithdrawals.Name = "gvWithdrawals";
            this.gvWithdrawals.Size = new System.Drawing.Size(735, 150);
            this.gvWithdrawals.TabIndex = 1;
            // 
            // gvTransfers
            // 
            this.gvTransfers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvTransfers.Location = new System.Drawing.Point(44, 471);
            this.gvTransfers.Name = "gvTransfers";
            this.gvTransfers.Size = new System.Drawing.Size(735, 150);
            this.gvTransfers.TabIndex = 2;
            // 
            // gvPayments
            // 
            this.gvPayments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvPayments.Location = new System.Drawing.Point(44, 665);
            this.gvPayments.Name = "gvPayments";
            this.gvPayments.Size = new System.Drawing.Size(735, 150);
            this.gvPayments.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(41, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "View Transactions";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(42, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Deposits";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(42, 256);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Withdrawals";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(42, 452);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Transfers";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(42, 646);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Payments";
            // 
            // btnViewDeposits
            // 
            this.btnViewDeposits.Location = new System.Drawing.Point(654, 54);
            this.btnViewDeposits.Name = "btnViewDeposits";
            this.btnViewDeposits.Size = new System.Drawing.Size(124, 23);
            this.btnViewDeposits.TabIndex = 9;
            this.btnViewDeposits.Text = "View Deposits";
            this.btnViewDeposits.UseVisualStyleBackColor = true;
            this.btnViewDeposits.Click += new System.EventHandler(this.btnViewDeposits_Click);
            // 
            // btnViewWithdrawals
            // 
            this.btnViewWithdrawals.Location = new System.Drawing.Point(655, 246);
            this.btnViewWithdrawals.Name = "btnViewWithdrawals";
            this.btnViewWithdrawals.Size = new System.Drawing.Size(124, 23);
            this.btnViewWithdrawals.TabIndex = 10;
            this.btnViewWithdrawals.Text = "View Withdrawals";
            this.btnViewWithdrawals.UseVisualStyleBackColor = true;
            this.btnViewWithdrawals.Click += new System.EventHandler(this.btnViewWithdrawals_Click);
            // 
            // btnViewTransfers
            // 
            this.btnViewTransfers.Location = new System.Drawing.Point(654, 442);
            this.btnViewTransfers.Name = "btnViewTransfers";
            this.btnViewTransfers.Size = new System.Drawing.Size(124, 23);
            this.btnViewTransfers.TabIndex = 11;
            this.btnViewTransfers.Text = "View Transfers";
            this.btnViewTransfers.UseVisualStyleBackColor = true;
            this.btnViewTransfers.Click += new System.EventHandler(this.btnViewTransfers_Click);
            // 
            // btnPayments
            // 
            this.btnPayments.Location = new System.Drawing.Point(654, 636);
            this.btnPayments.Name = "btnPayments";
            this.btnPayments.Size = new System.Drawing.Size(124, 23);
            this.btnPayments.TabIndex = 12;
            this.btnPayments.Text = "View Payments";
            this.btnPayments.UseVisualStyleBackColor = true;
            this.btnPayments.Click += new System.EventHandler(this.btnPayments_Click);
            // 
            // viewTransactions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 827);
            this.Controls.Add(this.btnPayments);
            this.Controls.Add(this.btnViewTransfers);
            this.Controls.Add(this.btnViewWithdrawals);
            this.Controls.Add(this.btnViewDeposits);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gvPayments);
            this.Controls.Add(this.gvTransfers);
            this.Controls.Add(this.gvWithdrawals);
            this.Controls.Add(this.gvDeposit);
            this.Name = "viewTransactions";
            this.Text = "View Transactions";
            ((System.ComponentModel.ISupportInitialize)(this.gvDeposit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvWithdrawals)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvTransfers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPayments)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gvDeposit;
        private System.Windows.Forms.DataGridView gvWithdrawals;
        private System.Windows.Forms.DataGridView gvTransfers;
        private System.Windows.Forms.DataGridView gvPayments;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnViewDeposits;
        private System.Windows.Forms.Button btnViewWithdrawals;
        private System.Windows.Forms.Button btnViewTransfers;
        private System.Windows.Forms.Button btnPayments;
    }
}