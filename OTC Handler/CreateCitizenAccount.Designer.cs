namespace OTC_Handler
{
    partial class CreateCitizenAccount
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbEmergencyContactAddr = new System.Windows.Forms.TextBox();
            this.tbEmergencyContactNo = new System.Windows.Forms.TextBox();
            this.tbEmergencyContactName = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tbAddress = new System.Windows.Forms.TextBox();
            this.btnCancelSave = new System.Windows.Forms.Button();
            this.btnSaveCitizen = new System.Windows.Forms.Button();
            this.tbCitFN = new System.Windows.Forms.TextBox();
            this.tbCitLN = new System.Windows.Forms.TextBox();
            this.rdMale = new System.Windows.Forms.RadioButton();
            this.rdFemale = new System.Windows.Forms.RadioButton();
            this.mcDOB = new System.Windows.Forms.MonthCalendar();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.cbCivilStat = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.tbPhoneNumber = new System.Windows.Forms.TextBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.lblShortError = new System.Windows.Forms.Label();
            this.tbErrorFixRecommend = new System.Windows.Forms.TextBox();
            this.numAge = new System.Windows.Forms.NumericUpDown();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAge)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(378, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add Citizen";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 50);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "First Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 80);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Last Name: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(47, 112);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Gender:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(66, 143);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 19);
            this.label5.TabIndex = 4;
            this.label5.Text = "Age:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(35, 173);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 19);
            this.label6.TabIndex = 5;
            this.label6.Text = "Birth Date:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(24, 375);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 19);
            this.label7.TabIndex = 6;
            this.label7.Text = "Civil Status:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(44, 409);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 19);
            this.label9.TabIndex = 8;
            this.label9.Text = "Address";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbEmergencyContactAddr);
            this.groupBox1.Controls.Add(this.tbEmergencyContactNo);
            this.groupBox1.Controls.Add(this.tbEmergencyContactName);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(473, 44);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(426, 242);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "In Case Of Emergency";
            // 
            // tbEmergencyContactAddr
            // 
            this.tbEmergencyContactAddr.AcceptsReturn = true;
            this.tbEmergencyContactAddr.Location = new System.Drawing.Point(165, 104);
            this.tbEmergencyContactAddr.Margin = new System.Windows.Forms.Padding(4);
            this.tbEmergencyContactAddr.MaxLength = 500;
            this.tbEmergencyContactAddr.Multiline = true;
            this.tbEmergencyContactAddr.Name = "tbEmergencyContactAddr";
            this.tbEmergencyContactAddr.Size = new System.Drawing.Size(232, 108);
            this.tbEmergencyContactAddr.TabIndex = 5;
            // 
            // tbEmergencyContactNo
            // 
            this.tbEmergencyContactNo.Location = new System.Drawing.Point(168, 70);
            this.tbEmergencyContactNo.Margin = new System.Windows.Forms.Padding(4);
            this.tbEmergencyContactNo.MaxLength = 15;
            this.tbEmergencyContactNo.Name = "tbEmergencyContactNo";
            this.tbEmergencyContactNo.Size = new System.Drawing.Size(232, 26);
            this.tbEmergencyContactNo.TabIndex = 4;
            this.tbEmergencyContactNo.TextChanged += new System.EventHandler(this.tbEmergencyContactNo_TextChanged);
            // 
            // tbEmergencyContactName
            // 
            this.tbEmergencyContactName.Location = new System.Drawing.Point(168, 36);
            this.tbEmergencyContactName.Margin = new System.Windows.Forms.Padding(4);
            this.tbEmergencyContactName.MaxLength = 40;
            this.tbEmergencyContactName.Name = "tbEmergencyContactName";
            this.tbEmergencyContactName.Size = new System.Drawing.Size(232, 26);
            this.tbEmergencyContactName.TabIndex = 3;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(27, 107);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(114, 19);
            this.label11.TabIndex = 2;
            this.label11.Text = "Contact Address:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(27, 73);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(130, 19);
            this.label10.TabIndex = 1;
            this.label10.Text = "Contact Phone No.:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(27, 39);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(105, 19);
            this.label8.TabIndex = 0;
            this.label8.Text = "Contact Name: ";
            // 
            // tbAddress
            // 
            this.tbAddress.Location = new System.Drawing.Point(120, 409);
            this.tbAddress.Margin = new System.Windows.Forms.Padding(4);
            this.tbAddress.MaxLength = 500;
            this.tbAddress.Multiline = true;
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.Size = new System.Drawing.Size(330, 134);
            this.tbAddress.TabIndex = 10;
            // 
            // btnCancelSave
            // 
            this.btnCancelSave.Location = new System.Drawing.Point(593, 499);
            this.btnCancelSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelSave.Name = "btnCancelSave";
            this.btnCancelSave.Size = new System.Drawing.Size(112, 34);
            this.btnCancelSave.TabIndex = 11;
            this.btnCancelSave.Text = "Cancel";
            this.btnCancelSave.UseVisualStyleBackColor = true;
            this.btnCancelSave.Click += new System.EventHandler(this.btnCancelSave_Click);
            // 
            // btnSaveCitizen
            // 
            this.btnSaveCitizen.Location = new System.Drawing.Point(473, 499);
            this.btnSaveCitizen.Margin = new System.Windows.Forms.Padding(4);
            this.btnSaveCitizen.Name = "btnSaveCitizen";
            this.btnSaveCitizen.Size = new System.Drawing.Size(112, 34);
            this.btnSaveCitizen.TabIndex = 12;
            this.btnSaveCitizen.Text = "Save Citizen";
            this.btnSaveCitizen.UseVisualStyleBackColor = true;
            this.btnSaveCitizen.Click += new System.EventHandler(this.btnSaveCitizen_Click);
            // 
            // tbCitFN
            // 
            this.tbCitFN.Location = new System.Drawing.Point(120, 47);
            this.tbCitFN.Margin = new System.Windows.Forms.Padding(4);
            this.tbCitFN.MaxLength = 40;
            this.tbCitFN.Name = "tbCitFN";
            this.tbCitFN.Size = new System.Drawing.Size(330, 26);
            this.tbCitFN.TabIndex = 13;
            this.tbCitFN.TextChanged += new System.EventHandler(this.tbCitFN_TextChanged);
            // 
            // tbCitLN
            // 
            this.tbCitLN.Location = new System.Drawing.Point(120, 77);
            this.tbCitLN.Margin = new System.Windows.Forms.Padding(4);
            this.tbCitLN.MaxLength = 40;
            this.tbCitLN.Name = "tbCitLN";
            this.tbCitLN.Size = new System.Drawing.Size(330, 26);
            this.tbCitLN.TabIndex = 14;
            // 
            // rdMale
            // 
            this.rdMale.AutoSize = true;
            this.rdMale.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdMale.Location = new System.Drawing.Point(120, 110);
            this.rdMale.Margin = new System.Windows.Forms.Padding(4);
            this.rdMale.Name = "rdMale";
            this.rdMale.Size = new System.Drawing.Size(58, 23);
            this.rdMale.TabIndex = 15;
            this.rdMale.TabStop = true;
            this.rdMale.Text = "Male";
            this.rdMale.UseVisualStyleBackColor = true;
            this.rdMale.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rdFemale
            // 
            this.rdFemale.AutoSize = true;
            this.rdFemale.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdFemale.Location = new System.Drawing.Point(186, 110);
            this.rdFemale.Margin = new System.Windows.Forms.Padding(4);
            this.rdFemale.Name = "rdFemale";
            this.rdFemale.Size = new System.Drawing.Size(71, 23);
            this.rdFemale.TabIndex = 16;
            this.rdFemale.TabStop = true;
            this.rdFemale.Text = "Female";
            this.rdFemale.UseVisualStyleBackColor = true;
            this.rdFemale.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // mcDOB
            // 
            this.mcDOB.Location = new System.Drawing.Point(120, 173);
            this.mcDOB.Margin = new System.Windows.Forms.Padding(14, 13, 14, 13);
            this.mcDOB.Name = "mcDOB";
            this.mcDOB.TabIndex = 18;
            // 
            // cbCivilStat
            // 
            this.cbCivilStat.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbCivilStat.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbCivilStat.FormattingEnabled = true;
            this.cbCivilStat.Location = new System.Drawing.Point(120, 372);
            this.cbCivilStat.Margin = new System.Windows.Forms.Padding(4);
            this.cbCivilStat.Name = "cbCivilStat";
            this.cbCivilStat.Size = new System.Drawing.Size(180, 27);
            this.cbCivilStat.Sorted = true;
            this.cbCivilStat.TabIndex = 19;
            this.cbCivilStat.Text = "--Click to Select--";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(-1, 340);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(104, 19);
            this.label12.TabIndex = 20;
            this.label12.Text = "Phone Number:";
            // 
            // tbPhoneNumber
            // 
            this.tbPhoneNumber.Location = new System.Drawing.Point(120, 340);
            this.tbPhoneNumber.Margin = new System.Windows.Forms.Padding(4);
            this.tbPhoneNumber.MaxLength = 15;
            this.tbPhoneNumber.Name = "tbPhoneNumber";
            this.tbPhoneNumber.Size = new System.Drawing.Size(301, 26);
            this.tbPhoneNumber.TabIndex = 21;
            this.tbPhoneNumber.TextChanged += new System.EventHandler(this.tbPhoneNumber_TextChanged);
            // 
            // lblShortError
            // 
            this.lblShortError.AutoSize = true;
            this.lblShortError.Location = new System.Drawing.Point(469, 290);
            this.lblShortError.Name = "lblShortError";
            this.lblShortError.Size = new System.Drawing.Size(269, 19);
            this.lblShortError.TabIndex = 22;
            this.lblShortError.Text = "Please complete all the fields before saving.";
            // 
            // tbErrorFixRecommend
            // 
            this.tbErrorFixRecommend.Enabled = false;
            this.tbErrorFixRecommend.Location = new System.Drawing.Point(473, 320);
            this.tbErrorFixRecommend.Multiline = true;
            this.tbErrorFixRecommend.Name = "tbErrorFixRecommend";
            this.tbErrorFixRecommend.ReadOnly = true;
            this.tbErrorFixRecommend.Size = new System.Drawing.Size(426, 168);
            this.tbErrorFixRecommend.TabIndex = 23;
            // 
            // numAge
            // 
            this.numAge.Location = new System.Drawing.Point(120, 136);
            this.numAge.Name = "numAge";
            this.numAge.Size = new System.Drawing.Size(120, 26);
            this.numAge.TabIndex = 24;
            this.numAge.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // CreateCitizenAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(941, 546);
            this.Controls.Add(this.numAge);
            this.Controls.Add(this.tbErrorFixRecommend);
            this.Controls.Add(this.lblShortError);
            this.Controls.Add(this.tbPhoneNumber);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.cbCivilStat);
            this.Controls.Add(this.mcDOB);
            this.Controls.Add(this.rdFemale);
            this.Controls.Add(this.rdMale);
            this.Controls.Add(this.tbCitLN);
            this.Controls.Add(this.tbCitFN);
            this.Controls.Add(this.btnSaveCitizen);
            this.Controls.Add(this.btnCancelSave);
            this.Controls.Add(this.tbAddress);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CreateCitizenAccount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Create Citizen Account";
            this.Load += new System.EventHandler(this.CreateCitizenAccount_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAge)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbAddress;
        private System.Windows.Forms.Button btnCancelSave;
        private System.Windows.Forms.Button btnSaveCitizen;
        private System.Windows.Forms.TextBox tbCitFN;
        private System.Windows.Forms.TextBox tbCitLN;
        private System.Windows.Forms.RadioButton rdMale;
        private System.Windows.Forms.RadioButton rdFemale;
        private System.Windows.Forms.MonthCalendar mcDOB;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ComboBox cbCivilStat;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tbPhoneNumber;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.TextBox tbEmergencyContactAddr;
        private System.Windows.Forms.TextBox tbEmergencyContactNo;
        private System.Windows.Forms.TextBox tbEmergencyContactName;
        private System.Windows.Forms.Label lblShortError;
        private System.Windows.Forms.TextBox tbErrorFixRecommend;
        private System.Windows.Forms.NumericUpDown numAge;
    }
}