namespace OTC_Handler
{
    partial class CreateAccount
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
            this.btnRespBack = new System.Windows.Forms.Button();
            this.btnSaveResponderAcct = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbNewUsername = new System.Windows.Forms.TextBox();
            this.mtbNewPassword = new System.Windows.Forms.MaskedTextBox();
            this.tbResponderAddress = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.mtbConfNewPassword = new System.Windows.Forms.MaskedTextBox();
            this.tbResponderName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbNewContactNo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(98, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Responder Account";
            // 
            // btnRespBack
            // 
            this.btnRespBack.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRespBack.Location = new System.Drawing.Point(26, 313);
            this.btnRespBack.Margin = new System.Windows.Forms.Padding(4);
            this.btnRespBack.Name = "btnRespBack";
            this.btnRespBack.Size = new System.Drawing.Size(140, 49);
            this.btnRespBack.TabIndex = 1;
            this.btnRespBack.Text = "<< Back";
            this.btnRespBack.UseVisualStyleBackColor = true;
            this.btnRespBack.Click += new System.EventHandler(this.btnRespBack_Click);
            // 
            // btnSaveResponderAcct
            // 
            this.btnSaveResponderAcct.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveResponderAcct.Location = new System.Drawing.Point(222, 313);
            this.btnSaveResponderAcct.Margin = new System.Windows.Forms.Padding(4);
            this.btnSaveResponderAcct.Name = "btnSaveResponderAcct";
            this.btnSaveResponderAcct.Size = new System.Drawing.Size(151, 49);
            this.btnSaveResponderAcct.TabIndex = 2;
            this.btnSaveResponderAcct.Text = "Save Account";
            this.btnSaveResponderAcct.UseVisualStyleBackColor = true;
            this.btnSaveResponderAcct.Click += new System.EventHandler(this.btnSaveResponderAcct_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 45);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "New Username:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 83);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "New Password:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(22, 153);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 19);
            this.label4.TabIndex = 5;
            this.label4.Text = "Name (First, Last):";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(22, 118);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 19);
            this.label5.TabIndex = 6;
            this.label5.Text = "Confirm Password:";
            // 
            // tbNewUsername
            // 
            this.tbNewUsername.Location = new System.Drawing.Point(165, 42);
            this.tbNewUsername.Margin = new System.Windows.Forms.Padding(4);
            this.tbNewUsername.Name = "tbNewUsername";
            this.tbNewUsername.Size = new System.Drawing.Size(208, 26);
            this.tbNewUsername.TabIndex = 8;
            this.tbNewUsername.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // mtbNewPassword
            // 
            this.mtbNewPassword.Location = new System.Drawing.Point(165, 80);
            this.mtbNewPassword.Margin = new System.Windows.Forms.Padding(4);
            this.mtbNewPassword.Name = "mtbNewPassword";
            this.mtbNewPassword.PasswordChar = '*';
            this.mtbNewPassword.Size = new System.Drawing.Size(208, 26);
            this.mtbNewPassword.TabIndex = 9;
            this.mtbNewPassword.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox1_MaskInputRejected);
            // 
            // tbResponderAddress
            // 
            this.tbResponderAddress.Location = new System.Drawing.Point(165, 221);
            this.tbResponderAddress.Margin = new System.Windows.Forms.Padding(4);
            this.tbResponderAddress.Multiline = true;
            this.tbResponderAddress.Name = "tbResponderAddress";
            this.tbResponderAddress.Size = new System.Drawing.Size(208, 80);
            this.tbResponderAddress.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(22, 221);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 19);
            this.label7.TabIndex = 13;
            this.label7.Text = "Address:";
            // 
            // mtbConfNewPassword
            // 
            this.mtbConfNewPassword.Location = new System.Drawing.Point(165, 115);
            this.mtbConfNewPassword.Margin = new System.Windows.Forms.Padding(4);
            this.mtbConfNewPassword.Name = "mtbConfNewPassword";
            this.mtbConfNewPassword.PasswordChar = '*';
            this.mtbConfNewPassword.Size = new System.Drawing.Size(208, 26);
            this.mtbConfNewPassword.TabIndex = 14;
            // 
            // tbResponderName
            // 
            this.tbResponderName.Location = new System.Drawing.Point(165, 150);
            this.tbResponderName.Margin = new System.Windows.Forms.Padding(4);
            this.tbResponderName.Name = "tbResponderName";
            this.tbResponderName.Size = new System.Drawing.Size(208, 26);
            this.tbResponderName.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 187);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 19);
            this.label6.TabIndex = 16;
            this.label6.Text = "Contact No.:";
            // 
            // tbNewContactNo
            // 
            this.tbNewContactNo.Location = new System.Drawing.Point(165, 184);
            this.tbNewContactNo.Name = "tbNewContactNo";
            this.tbNewContactNo.Size = new System.Drawing.Size(208, 26);
            this.tbNewContactNo.TabIndex = 17;
            // 
            // CreateAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 375);
            this.Controls.Add(this.tbNewContactNo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbResponderName);
            this.Controls.Add(this.mtbConfNewPassword);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbResponderAddress);
            this.Controls.Add(this.mtbNewPassword);
            this.Controls.Add(this.tbNewUsername);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSaveResponderAcct);
            this.Controls.Add(this.btnRespBack);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CreateAccount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Create Account";
            this.Load += new System.EventHandler(this.CreateAccount_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRespBack;
        private System.Windows.Forms.Button btnSaveResponderAcct;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbNewUsername;
        private System.Windows.Forms.MaskedTextBox mtbNewPassword;
        private System.Windows.Forms.TextBox tbResponderAddress;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox mtbConfNewPassword;
        private System.Windows.Forms.TextBox tbResponderName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbNewContactNo;
    }
}