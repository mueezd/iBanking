namespace iBanking
{
    partial class addPayee
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
            this.lblPayeeName = new System.Windows.Forms.Label();
            this.lblEmailId = new System.Windows.Forms.Label();
            this.lblPhoneNo = new System.Windows.Forms.Label();
            this.textBoxPayeeName = new System.Windows.Forms.TextBox();
            this.textBoxEmailId = new System.Windows.Forms.TextBox();
            this.textBoxPhoneNo = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.dataGridViewPayee = new System.Windows.Forms.DataGridView();
            this.btnClear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPayee)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add Payee";
            // 
            // lblPayeeName
            // 
            this.lblPayeeName.AutoSize = true;
            this.lblPayeeName.Location = new System.Drawing.Point(39, 88);
            this.lblPayeeName.Name = "lblPayeeName";
            this.lblPayeeName.Size = new System.Drawing.Size(71, 13);
            this.lblPayeeName.TabIndex = 1;
            this.lblPayeeName.Text = "Payee Name:";
            // 
            // lblEmailId
            // 
            this.lblEmailId.AutoSize = true;
            this.lblEmailId.Location = new System.Drawing.Point(39, 138);
            this.lblEmailId.Name = "lblEmailId";
            this.lblEmailId.Size = new System.Drawing.Size(47, 13);
            this.lblEmailId.TabIndex = 2;
            this.lblEmailId.Text = "Email Id:";
            // 
            // lblPhoneNo
            // 
            this.lblPhoneNo.AutoSize = true;
            this.lblPhoneNo.Location = new System.Drawing.Point(39, 190);
            this.lblPhoneNo.Name = "lblPhoneNo";
            this.lblPhoneNo.Size = new System.Drawing.Size(58, 13);
            this.lblPhoneNo.TabIndex = 3;
            this.lblPhoneNo.Text = "Phone No:";
            // 
            // textBoxPayeeName
            // 
            this.textBoxPayeeName.Location = new System.Drawing.Point(116, 85);
            this.textBoxPayeeName.Name = "textBoxPayeeName";
            this.textBoxPayeeName.Size = new System.Drawing.Size(295, 20);
            this.textBoxPayeeName.TabIndex = 4;
            // 
            // textBoxEmailId
            // 
            this.textBoxEmailId.Location = new System.Drawing.Point(116, 135);
            this.textBoxEmailId.Name = "textBoxEmailId";
            this.textBoxEmailId.Size = new System.Drawing.Size(295, 20);
            this.textBoxEmailId.TabIndex = 5;
            // 
            // textBoxPhoneNo
            // 
            this.textBoxPhoneNo.Location = new System.Drawing.Point(116, 187);
            this.textBoxPhoneNo.Name = "textBoxPhoneNo";
            this.textBoxPhoneNo.Size = new System.Drawing.Size(295, 20);
            this.textBoxPhoneNo.TabIndex = 6;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(309, 284);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(102, 33);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // dataGridViewPayee
            // 
            this.dataGridViewPayee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPayee.Location = new System.Drawing.Point(449, 85);
            this.dataGridViewPayee.Name = "dataGridViewPayee";
            this.dataGridViewPayee.Size = new System.Drawing.Size(434, 232);
            this.dataGridViewPayee.TabIndex = 8;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(201, 284);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(102, 33);
            this.btnClear.TabIndex = 9;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // addPayee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(898, 339);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.dataGridViewPayee);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.textBoxPhoneNo);
            this.Controls.Add(this.textBoxEmailId);
            this.Controls.Add(this.textBoxPayeeName);
            this.Controls.Add(this.lblPhoneNo);
            this.Controls.Add(this.lblEmailId);
            this.Controls.Add(this.lblPayeeName);
            this.Controls.Add(this.label1);
            this.Name = "addPayee";
            this.Text = "Add Payee";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPayee)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPayeeName;
        private System.Windows.Forms.Label lblEmailId;
        private System.Windows.Forms.Label lblPhoneNo;
        private System.Windows.Forms.TextBox textBoxPayeeName;
        private System.Windows.Forms.TextBox textBoxEmailId;
        private System.Windows.Forms.TextBox textBoxPhoneNo;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridView dataGridViewPayee;
        private System.Windows.Forms.Button btnClear;
    }
}