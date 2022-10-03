namespace iBanking
{
    partial class formProcessInterest
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
            this.btnProcessInterest = new System.Windows.Forms.Button();
            this.dataGridViewProcessInterest = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProcessInterest)).BeginInit();
            this.SuspendLayout();
            // 
            // btnProcessInterest
            // 
            this.btnProcessInterest.Location = new System.Drawing.Point(595, 36);
            this.btnProcessInterest.Name = "btnProcessInterest";
            this.btnProcessInterest.Size = new System.Drawing.Size(153, 33);
            this.btnProcessInterest.TabIndex = 0;
            this.btnProcessInterest.Text = "Process Interest";
            this.btnProcessInterest.UseVisualStyleBackColor = true;
            this.btnProcessInterest.Click += new System.EventHandler(this.btnProcessInterest_Click);
            // 
            // dataGridViewProcessInterest
            // 
            this.dataGridViewProcessInterest.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProcessInterest.Location = new System.Drawing.Point(36, 94);
            this.dataGridViewProcessInterest.Name = "dataGridViewProcessInterest";
            this.dataGridViewProcessInterest.Size = new System.Drawing.Size(712, 306);
            this.dataGridViewProcessInterest.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Process Interest";
            // 
            // formProcessInterest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(781, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewProcessInterest);
            this.Controls.Add(this.btnProcessInterest);
            this.Name = "formProcessInterest";
            this.Text = "Process Interest";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProcessInterest)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnProcessInterest;
        private System.Windows.Forms.DataGridView dataGridViewProcessInterest;
        private System.Windows.Forms.Label label1;
    }
}