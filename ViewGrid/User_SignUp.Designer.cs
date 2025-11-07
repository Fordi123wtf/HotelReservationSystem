namespace ViewGrid
{
    partial class User_SignUp
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
            this.lblResult = new System.Windows.Forms.Label();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnFinish = new System.Windows.Forms.Button();
            this.txtAnswer = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.lblRetry = new System.Windows.Forms.Label();
            this.lblCaptcha = new System.Windows.Forms.Label();
            this.txt_securityQuestion = new System.Windows.Forms.ComboBox();
            this.txt_secuQuestion2 = new System.Windows.Forms.TextBox();
            this.txt_Cpassword = new System.Windows.Forms.TextBox();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.txt_contactNo = new System.Windows.Forms.TextBox();
            this.txt_address = new System.Windows.Forms.TextBox();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_LName = new System.Windows.Forms.TextBox();
            this.txt_FName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtp_birthdate = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(204, 512);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(42, 13);
            this.lblResult.TabIndex = 53;
            this.lblResult.Text = "Answer";
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(216, 550);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(75, 23);
            this.btnReturn.TabIndex = 52;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnFinish
            // 
            this.btnFinish.Location = new System.Drawing.Point(99, 550);
            this.btnFinish.Name = "btnFinish";
            this.btnFinish.Size = new System.Drawing.Size(75, 23);
            this.btnFinish.TabIndex = 51;
            this.btnFinish.Text = "Finish";
            this.btnFinish.UseVisualStyleBackColor = true;
            this.btnFinish.Click += new System.EventHandler(this.btnFinish_Click);
            // 
            // txtAnswer
            // 
            this.txtAnswer.Location = new System.Drawing.Point(87, 508);
            this.txtAnswer.Name = "txtAnswer";
            this.txtAnswer.Size = new System.Drawing.Size(111, 20);
            this.txtAnswer.TabIndex = 50;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(84, 492);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(42, 13);
            this.label13.TabIndex = 49;
            this.label13.Text = "Answer";
            // 
            // lblRetry
            // 
            this.lblRetry.AutoSize = true;
            this.lblRetry.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRetry.ForeColor = System.Drawing.Color.Red;
            this.lblRetry.Location = new System.Drawing.Point(175, 470);
            this.lblRetry.Name = "lblRetry";
            this.lblRetry.Size = new System.Drawing.Size(32, 13);
            this.lblRetry.TabIndex = 48;
            this.lblRetry.Text = "Retry";
            // 
            // lblCaptcha
            // 
            this.lblCaptcha.AutoSize = true;
            this.lblCaptcha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCaptcha.Location = new System.Drawing.Point(84, 468);
            this.lblCaptcha.Name = "lblCaptcha";
            this.lblCaptcha.Size = new System.Drawing.Size(57, 16);
            this.lblCaptcha.TabIndex = 47;
            this.lblCaptcha.Text = "Captcha";
            // 
            // txt_securityQuestion
            // 
            this.txt_securityQuestion.FormattingEnabled = true;
            this.txt_securityQuestion.Items.AddRange(new object[] {
            "1+1",
            "Ano grade mo boss?",
            "Ano ba tlaga ilalagay ko dito?",
            "Joke lang yung nilalagay ko dito",
            "What do you call a priest that becomes a lawyer?"});
            this.txt_securityQuestion.Location = new System.Drawing.Point(87, 423);
            this.txt_securityQuestion.Name = "txt_securityQuestion";
            this.txt_securityQuestion.Size = new System.Drawing.Size(241, 21);
            this.txt_securityQuestion.TabIndex = 46;
            // 
            // txt_secuQuestion2
            // 
            this.txt_secuQuestion2.Location = new System.Drawing.Point(87, 445);
            this.txt_secuQuestion2.Name = "txt_secuQuestion2";
            this.txt_secuQuestion2.Size = new System.Drawing.Size(241, 20);
            this.txt_secuQuestion2.TabIndex = 45;
            // 
            // txt_Cpassword
            // 
            this.txt_Cpassword.Location = new System.Drawing.Point(85, 381);
            this.txt_Cpassword.Name = "txt_Cpassword";
            this.txt_Cpassword.Size = new System.Drawing.Size(243, 20);
            this.txt_Cpassword.TabIndex = 44;
            // 
            // txt_password
            // 
            this.txt_password.Location = new System.Drawing.Point(85, 338);
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(243, 20);
            this.txt_password.TabIndex = 43;
            // 
            // txt_contactNo
            // 
            this.txt_contactNo.Location = new System.Drawing.Point(86, 296);
            this.txt_contactNo.Name = "txt_contactNo";
            this.txt_contactNo.Size = new System.Drawing.Size(242, 20);
            this.txt_contactNo.TabIndex = 42;
            // 
            // txt_address
            // 
            this.txt_address.Location = new System.Drawing.Point(85, 212);
            this.txt_address.Name = "txt_address";
            this.txt_address.Size = new System.Drawing.Size(243, 20);
            this.txt_address.TabIndex = 40;
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(85, 170);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(243, 20);
            this.txt_email.TabIndex = 39;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(84, 407);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(90, 13);
            this.label10.TabIndex = 38;
            this.label10.Text = "Security Question";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(83, 365);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 13);
            this.label9.TabIndex = 37;
            this.label9.Text = "Confirm Password";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(82, 322);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 13);
            this.label8.TabIndex = 36;
            this.label8.Text = "Password";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(82, 280);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 13);
            this.label7.TabIndex = 35;
            this.label7.Text = "Contact No#";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(83, 238);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 34;
            this.label6.Text = "Birthdate";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(83, 196);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 33;
            this.label5.Text = "Address";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(83, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 32;
            this.label4.Text = "Email";
            // 
            // txt_LName
            // 
            this.txt_LName.Location = new System.Drawing.Point(216, 128);
            this.txt_LName.Name = "txt_LName";
            this.txt_LName.Size = new System.Drawing.Size(112, 20);
            this.txt_LName.TabIndex = 31;
            // 
            // txt_FName
            // 
            this.txt_FName.Location = new System.Drawing.Point(86, 128);
            this.txt_FName.Name = "txt_FName";
            this.txt_FName.Size = new System.Drawing.Size(112, 20);
            this.txt_FName.TabIndex = 30;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(213, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 29;
            this.label3.Text = "Last Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(83, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 28;
            this.label2.Text = "First Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Sienna;
            this.label1.Location = new System.Drawing.Point(81, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 25);
            this.label1.TabIndex = 27;
            this.label1.Text = "Sign Up";
            // 
            // dtp_birthdate
            // 
            this.dtp_birthdate.Location = new System.Drawing.Point(87, 255);
            this.dtp_birthdate.Name = "dtp_birthdate";
            this.dtp_birthdate.Size = new System.Drawing.Size(200, 20);
            this.dtp_birthdate.TabIndex = 54;
            // 
            // User_SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(1034, 661);
            this.Controls.Add(this.dtp_birthdate);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnFinish);
            this.Controls.Add(this.txtAnswer);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.lblRetry);
            this.Controls.Add(this.lblCaptcha);
            this.Controls.Add(this.txt_securityQuestion);
            this.Controls.Add(this.txt_secuQuestion2);
            this.Controls.Add(this.txt_Cpassword);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.txt_contactNo);
            this.Controls.Add(this.txt_address);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_LName);
            this.Controls.Add(this.txt_FName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "User_SignUp";
            this.Text = "User_SignUp";
            this.Load += new System.EventHandler(this.User_SignUp_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnFinish;
        private System.Windows.Forms.TextBox txtAnswer;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblRetry;
        private System.Windows.Forms.Label lblCaptcha;
        private System.Windows.Forms.ComboBox txt_securityQuestion;
        private System.Windows.Forms.TextBox txt_secuQuestion2;
        private System.Windows.Forms.TextBox txt_Cpassword;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.TextBox txt_contactNo;
        private System.Windows.Forms.TextBox txt_address;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_LName;
        private System.Windows.Forms.TextBox txt_FName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtp_birthdate;
    }
}