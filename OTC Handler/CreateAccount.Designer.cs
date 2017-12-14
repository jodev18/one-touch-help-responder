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
            this.tbUsername = new System.Windows.Forms.TextBox();
            this.mtbPassword = new System.Windows.Forms.MaskedTextBox();
            this.tbAddress = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.mtbConfPassword = new System.Windows.Forms.MaskedTextBox();
            this.tbResponderName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Simoncini Garamond Std", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(68, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Responder Account";
            // 
            // btnRespBack
            // 
            this.btnRespBack.Font = new System.Drawing.Font("Simoncini Garamond Std", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRespBack.Location = new System.Drawing.Point(13, 241);
            this.btnRespBack.Name = "btnRespBack";
            this.btnRespBack.Size = new System.Drawing.Size(111, 47);
            this.btnRespBack.TabIndex = 1;
            this.btnRespBack.Text = "<< Back";
            this.btnRespBack.UseVisualStyleBackColor = true;
            // 
            // btnSaveResponderAcct
            // 
            this.btnSaveResponderAcct.Font = new System.Drawing.Font("Simoncini Garamond Std", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveResponderAcct.Location = new System.Drawing.Point(148, 241);
            this.btnSaveResponderAcct.Name = "btnSaveResponderAcct";
            this.btnSaveResponderAcct.Size = new System.Drawing.Size(140, 47);
            this.btnSaveResponderAcct.TabIndex = 2;
            this.btnSaveResponderAcct.Text = "Save Account";
            this.btnSaveResponderAcct.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Simoncini Garamond Std", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "New Username:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Simoncini Garamond Std", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "New Password:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Simoncini Garamond Std", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(9, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 19);
            this.label4.TabIndex = 5;
            this.label4.Text = "Name (First, Last):";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Simoncini Garamond Std", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(9, 97);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 19);
            this.label5.TabIndex = 6;
            this.label5.Text = "Confirm Password:";
            // 
            // tbUsername
            // 
            this.tbUsername.Location = new System.Drawing.Point(148, 46);
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(140, 20);
            this.tbUsername.TabIndex = 8;
            this.tbUsername.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // mtbPassword
            // 
            this.mtbPassword.Location = new System.Drawing.Point(148, 72);
            this.mtbPassword.Name = "mtbPassword";
            this.mtbPassword.Size = new System.Drawing.Size(140, 20);
            this.mtbPassword.TabIndex = 9;
            this.mtbPassword.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox1_MaskInputRejected);
            // 
            // tbAddress
            // 
            this.tbAddress.Location = new System.Drawing.Point(148, 151);
            this.tbAddress.Multiline = true;
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.Size = new System.Drawing.Size(140, 56);
            this.tbAddress.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Simoncini Garamond Std", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(9, 151);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 19);
            this.label7.TabIndex = 13;
            this.label7.Text = "Address:";
            // 
            // mtbConfPassword
            // 
            this.mtbConfPassword.Location = new System.Drawing.Point(148, 98);
            this.mtbConfPassword.Name = "mtbConfPassword";
            this.mtbConfPassword.Size = new System.Drawing.Size(140, 20);
            this.mtbConfPassword.TabIndex = 14;
            // 
            // tbResponderName
            // 
            this.tbResponderName.Location = new System.Drawing.Point(148, 125);
            this.tbResponderName.Name = "tbResponderName";
            this.tbResponderName.Size = new System.Drawing.Size(140, 20);
            this.tbResponderName.TabIndex = 15;
            // 
            // CreateAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 307);
            this.Controls.Add(this.tbResponderName);
            this.Controls.Add(this.mtbConfPassword);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbAddress);
            this.Controls.Add(this.mtbPassword);
            this.Controls.Add(this.tbUsername);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSaveResponderAcct);
            this.Controls.Add(this.btnRespBack);
            this.Controls.Add(this.label1);
            this.Name = "CreateAccount";
            this.Text = "CreateAccount";
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
        private System.Windows.Forms.TextBox tbUsername;
        private System.Windows.Forms.MaskedTextBox mtbPassword;
        private System.Windows.Forms.TextBox tbAddress;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox mtbConfPassword;
        private System.Windows.Forms.TextBox tbResponderName;
    }
}