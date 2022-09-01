namespace iBanking
{
    partial class updationForm
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
            this.lblAccountNo = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblDateOfBirth = new System.Windows.Forms.Label();
            this.lblFathersName = new System.Windows.Forms.Label();
            this.lblMothersName = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblPhoneNo = new System.Windows.Forms.Label();
            this.lblState = new System.Windows.Forms.Label();
            this.textBoxAccountNo = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxFathersName = new System.Windows.Forms.TextBox();
            this.textBoxMothersName = new System.Windows.Forms.TextBox();
            this.textBoxAddress = new System.Windows.Forms.TextBox();
            this.textBoxPhoneNo = new System.Windows.Forms.TextBox();
            this.textBoxState = new System.Windows.Forms.TextBox();
            this.dateTimePickerDoB = new System.Windows.Forms.DateTimePicker();
            this.btnDetails = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.groupBoxGender = new System.Windows.Forms.GroupBox();
            this.rbOthers = new System.Windows.Forms.RadioButton();
            this.rbFemale = new System.Windows.Forms.RadioButton();
            this.rbMale = new System.Windows.Forms.RadioButton();
            this.groupBoxMaritialStatus = new System.Windows.Forms.GroupBox();
            this.rbUnMarried = new System.Windows.Forms.RadioButton();
            this.rbMarried = new System.Windows.Forms.RadioButton();
            this.pictureBoxCustomerPicture = new System.Windows.Forms.PictureBox();
            this.btnUploadPicture = new System.Windows.Forms.Button();
            this.dataGridViewCustomerDetails = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.lblShowId = new System.Windows.Forms.Label();
            this.groupBoxGender.SuspendLayout();
            this.groupBoxMaritialStatus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCustomerPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCustomerDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Update Form";
            // 
            // lblAccountNo
            // 
            this.lblAccountNo.AutoSize = true;
            this.lblAccountNo.Location = new System.Drawing.Point(26, 141);
            this.lblAccountNo.Name = "lblAccountNo";
            this.lblAccountNo.Size = new System.Drawing.Size(67, 13);
            this.lblAccountNo.TabIndex = 1;
            this.lblAccountNo.Text = "Account No:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(26, 180);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(38, 13);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Name:";
            // 
            // lblDateOfBirth
            // 
            this.lblDateOfBirth.AutoSize = true;
            this.lblDateOfBirth.Location = new System.Drawing.Point(26, 220);
            this.lblDateOfBirth.Name = "lblDateOfBirth";
            this.lblDateOfBirth.Size = new System.Drawing.Size(71, 13);
            this.lblDateOfBirth.TabIndex = 3;
            this.lblDateOfBirth.Text = "Date Of Birth:";
            // 
            // lblFathersName
            // 
            this.lblFathersName.AutoSize = true;
            this.lblFathersName.Location = new System.Drawing.Point(26, 265);
            this.lblFathersName.Name = "lblFathersName";
            this.lblFathersName.Size = new System.Drawing.Size(78, 13);
            this.lblFathersName.TabIndex = 4;
            this.lblFathersName.Text = "Father\'s Name:";
            // 
            // lblMothersName
            // 
            this.lblMothersName.AutoSize = true;
            this.lblMothersName.Location = new System.Drawing.Point(26, 311);
            this.lblMothersName.Name = "lblMothersName";
            this.lblMothersName.Size = new System.Drawing.Size(81, 13);
            this.lblMothersName.TabIndex = 5;
            this.lblMothersName.Text = "Mother\'s Name:";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(26, 354);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(48, 13);
            this.lblAddress.TabIndex = 6;
            this.lblAddress.Text = "Address:";
            // 
            // lblPhoneNo
            // 
            this.lblPhoneNo.AutoSize = true;
            this.lblPhoneNo.Location = new System.Drawing.Point(26, 408);
            this.lblPhoneNo.Name = "lblPhoneNo";
            this.lblPhoneNo.Size = new System.Drawing.Size(58, 13);
            this.lblPhoneNo.TabIndex = 7;
            this.lblPhoneNo.Text = "Phone No:";
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.Location = new System.Drawing.Point(26, 460);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(35, 13);
            this.lblState.TabIndex = 8;
            this.lblState.Text = "State:";
            // 
            // textBoxAccountNo
            // 
            this.textBoxAccountNo.Location = new System.Drawing.Point(118, 138);
            this.textBoxAccountNo.Name = "textBoxAccountNo";
            this.textBoxAccountNo.Size = new System.Drawing.Size(311, 20);
            this.textBoxAccountNo.TabIndex = 9;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(118, 177);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(311, 20);
            this.textBoxName.TabIndex = 10;
            // 
            // textBoxFathersName
            // 
            this.textBoxFathersName.Location = new System.Drawing.Point(118, 262);
            this.textBoxFathersName.Name = "textBoxFathersName";
            this.textBoxFathersName.Size = new System.Drawing.Size(311, 20);
            this.textBoxFathersName.TabIndex = 11;
            // 
            // textBoxMothersName
            // 
            this.textBoxMothersName.Location = new System.Drawing.Point(118, 308);
            this.textBoxMothersName.Name = "textBoxMothersName";
            this.textBoxMothersName.Size = new System.Drawing.Size(311, 20);
            this.textBoxMothersName.TabIndex = 12;
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.Location = new System.Drawing.Point(118, 351);
            this.textBoxAddress.Multiline = true;
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(311, 45);
            this.textBoxAddress.TabIndex = 13;
            // 
            // textBoxPhoneNo
            // 
            this.textBoxPhoneNo.Location = new System.Drawing.Point(118, 405);
            this.textBoxPhoneNo.Name = "textBoxPhoneNo";
            this.textBoxPhoneNo.Size = new System.Drawing.Size(311, 20);
            this.textBoxPhoneNo.TabIndex = 14;
            // 
            // textBoxState
            // 
            this.textBoxState.Location = new System.Drawing.Point(118, 457);
            this.textBoxState.Name = "textBoxState";
            this.textBoxState.Size = new System.Drawing.Size(311, 20);
            this.textBoxState.TabIndex = 15;
            // 
            // dateTimePickerDoB
            // 
            this.dateTimePickerDoB.Location = new System.Drawing.Point(118, 216);
            this.dateTimePickerDoB.Name = "dateTimePickerDoB";
            this.dateTimePickerDoB.Size = new System.Drawing.Size(311, 20);
            this.dateTimePickerDoB.TabIndex = 16;
            // 
            // btnDetails
            // 
            this.btnDetails.Location = new System.Drawing.Point(444, 138);
            this.btnDetails.Name = "btnDetails";
            this.btnDetails.Size = new System.Drawing.Size(75, 23);
            this.btnDetails.TabIndex = 17;
            this.btnDetails.Text = "Details";
            this.btnDetails.UseVisualStyleBackColor = true;
            this.btnDetails.Click += new System.EventHandler(this.btnDetails_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(444, 175);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 18;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(118, 544);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(145, 23);
            this.btnUpdate.TabIndex = 19;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(284, 544);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(145, 23);
            this.btnDelete.TabIndex = 20;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // groupBoxGender
            // 
            this.groupBoxGender.Controls.Add(this.rbOthers);
            this.groupBoxGender.Controls.Add(this.rbFemale);
            this.groupBoxGender.Controls.Add(this.rbMale);
            this.groupBoxGender.Location = new System.Drawing.Point(457, 360);
            this.groupBoxGender.Name = "groupBoxGender";
            this.groupBoxGender.Size = new System.Drawing.Size(302, 61);
            this.groupBoxGender.TabIndex = 21;
            this.groupBoxGender.TabStop = false;
            this.groupBoxGender.Text = "Gender";
            // 
            // rbOthers
            // 
            this.rbOthers.AutoSize = true;
            this.rbOthers.Location = new System.Drawing.Point(235, 30);
            this.rbOthers.Name = "rbOthers";
            this.rbOthers.Size = new System.Drawing.Size(56, 17);
            this.rbOthers.TabIndex = 2;
            this.rbOthers.TabStop = true;
            this.rbOthers.Text = "Others";
            this.rbOthers.UseVisualStyleBackColor = true;
            // 
            // rbFemale
            // 
            this.rbFemale.AutoSize = true;
            this.rbFemale.Location = new System.Drawing.Point(128, 30);
            this.rbFemale.Name = "rbFemale";
            this.rbFemale.Size = new System.Drawing.Size(59, 17);
            this.rbFemale.TabIndex = 1;
            this.rbFemale.TabStop = true;
            this.rbFemale.Text = "Female";
            this.rbFemale.UseVisualStyleBackColor = true;
            // 
            // rbMale
            // 
            this.rbMale.AutoSize = true;
            this.rbMale.Location = new System.Drawing.Point(25, 30);
            this.rbMale.Name = "rbMale";
            this.rbMale.Size = new System.Drawing.Size(48, 17);
            this.rbMale.TabIndex = 0;
            this.rbMale.TabStop = true;
            this.rbMale.Text = "Male";
            this.rbMale.UseVisualStyleBackColor = true;
            // 
            // groupBoxMaritialStatus
            // 
            this.groupBoxMaritialStatus.Controls.Add(this.rbUnMarried);
            this.groupBoxMaritialStatus.Controls.Add(this.rbMarried);
            this.groupBoxMaritialStatus.Location = new System.Drawing.Point(457, 456);
            this.groupBoxMaritialStatus.Name = "groupBoxMaritialStatus";
            this.groupBoxMaritialStatus.Size = new System.Drawing.Size(302, 56);
            this.groupBoxMaritialStatus.TabIndex = 22;
            this.groupBoxMaritialStatus.TabStop = false;
            this.groupBoxMaritialStatus.Text = "Maritial Status";
            // 
            // rbUnMarried
            // 
            this.rbUnMarried.AutoSize = true;
            this.rbUnMarried.Location = new System.Drawing.Point(128, 28);
            this.rbUnMarried.Name = "rbUnMarried";
            this.rbUnMarried.Size = new System.Drawing.Size(77, 17);
            this.rbUnMarried.TabIndex = 1;
            this.rbUnMarried.TabStop = true;
            this.rbUnMarried.Text = "Un-Married";
            this.rbUnMarried.UseVisualStyleBackColor = true;
            // 
            // rbMarried
            // 
            this.rbMarried.AutoSize = true;
            this.rbMarried.Location = new System.Drawing.Point(25, 28);
            this.rbMarried.Name = "rbMarried";
            this.rbMarried.Size = new System.Drawing.Size(60, 17);
            this.rbMarried.TabIndex = 0;
            this.rbMarried.TabStop = true;
            this.rbMarried.Text = "Married";
            this.rbMarried.UseVisualStyleBackColor = true;
            // 
            // pictureBoxCustomerPicture
            // 
            this.pictureBoxCustomerPicture.Location = new System.Drawing.Point(560, 138);
            this.pictureBoxCustomerPicture.Name = "pictureBoxCustomerPicture";
            this.pictureBoxCustomerPicture.Size = new System.Drawing.Size(160, 165);
            this.pictureBoxCustomerPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCustomerPicture.TabIndex = 23;
            this.pictureBoxCustomerPicture.TabStop = false;
            // 
            // btnUploadPicture
            // 
            this.btnUploadPicture.Location = new System.Drawing.Point(560, 320);
            this.btnUploadPicture.Name = "btnUploadPicture";
            this.btnUploadPicture.Size = new System.Drawing.Size(160, 23);
            this.btnUploadPicture.TabIndex = 24;
            this.btnUploadPicture.Text = "Upload Picture";
            this.btnUploadPicture.UseVisualStyleBackColor = true;
            this.btnUploadPicture.Click += new System.EventHandler(this.btnUploadPicture_Click);
            // 
            // dataGridViewCustomerDetails
            // 
            this.dataGridViewCustomerDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCustomerDetails.Location = new System.Drawing.Point(765, 30);
            this.dataGridViewCustomerDetails.Name = "dataGridViewCustomerDetails";
            this.dataGridViewCustomerDetails.Size = new System.Drawing.Size(455, 555);
            this.dataGridViewCustomerDetails.TabIndex = 25;
            this.dataGridViewCustomerDetails.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCustomerDetails_CellClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 16);
            this.label2.TabIndex = 26;
            this.label2.Text = "Customer Id:";
            // 
            // lblShowId
            // 
            this.lblShowId.AutoSize = true;
            this.lblShowId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShowId.Location = new System.Drawing.Point(125, 84);
            this.lblShowId.Name = "lblShowId";
            this.lblShowId.Size = new System.Drawing.Size(15, 16);
            this.lblShowId.TabIndex = 27;
            this.lblShowId.Text = "0";
            // 
            // updationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1232, 597);
            this.Controls.Add(this.lblShowId);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridViewCustomerDetails);
            this.Controls.Add(this.btnUploadPicture);
            this.Controls.Add(this.pictureBoxCustomerPicture);
            this.Controls.Add(this.groupBoxMaritialStatus);
            this.Controls.Add(this.groupBoxGender);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnDetails);
            this.Controls.Add(this.dateTimePickerDoB);
            this.Controls.Add(this.textBoxState);
            this.Controls.Add(this.textBoxPhoneNo);
            this.Controls.Add(this.textBoxAddress);
            this.Controls.Add(this.textBoxMothersName);
            this.Controls.Add(this.textBoxFathersName);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.textBoxAccountNo);
            this.Controls.Add(this.lblState);
            this.Controls.Add(this.lblPhoneNo);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.lblMothersName);
            this.Controls.Add(this.lblFathersName);
            this.Controls.Add(this.lblDateOfBirth);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblAccountNo);
            this.Controls.Add(this.label1);
            this.Name = "updationForm";
            this.Text = "updationForm";
            this.Load += new System.EventHandler(this.updationForm_Load);
            this.groupBoxGender.ResumeLayout(false);
            this.groupBoxGender.PerformLayout();
            this.groupBoxMaritialStatus.ResumeLayout(false);
            this.groupBoxMaritialStatus.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCustomerPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCustomerDetails)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblAccountNo;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblDateOfBirth;
        private System.Windows.Forms.Label lblFathersName;
        private System.Windows.Forms.Label lblMothersName;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblPhoneNo;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.TextBox textBoxAccountNo;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxFathersName;
        private System.Windows.Forms.TextBox textBoxMothersName;
        private System.Windows.Forms.TextBox textBoxAddress;
        private System.Windows.Forms.TextBox textBoxPhoneNo;
        private System.Windows.Forms.TextBox textBoxState;
        private System.Windows.Forms.DateTimePicker dateTimePickerDoB;
        private System.Windows.Forms.Button btnDetails;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.GroupBox groupBoxGender;
        private System.Windows.Forms.GroupBox groupBoxMaritialStatus;
        private System.Windows.Forms.PictureBox pictureBoxCustomerPicture;
        private System.Windows.Forms.Button btnUploadPicture;
        private System.Windows.Forms.RadioButton rbOthers;
        private System.Windows.Forms.RadioButton rbFemale;
        private System.Windows.Forms.RadioButton rbMale;
        private System.Windows.Forms.RadioButton rbUnMarried;
        private System.Windows.Forms.RadioButton rbMarried;
        private System.Windows.Forms.DataGridView dataGridViewCustomerDetails;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblShowId;
    }
}