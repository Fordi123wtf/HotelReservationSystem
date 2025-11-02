namespace ViewGrid
{
    partial class User_Interface1
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
            this.btn_SignUp_1 = new System.Windows.Forms.Button();
            this.btn_LogIn_1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(121, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Ano pangalan ng sistim natin?";
            // 
            // btn_SignUp_1
            // 
            this.btn_SignUp_1.Location = new System.Drawing.Point(253, 182);
            this.btn_SignUp_1.Name = "btn_SignUp_1";
            this.btn_SignUp_1.Size = new System.Drawing.Size(75, 49);
            this.btn_SignUp_1.TabIndex = 4;
            this.btn_SignUp_1.Text = "Sign up";
            this.btn_SignUp_1.UseVisualStyleBackColor = true;
            this.btn_SignUp_1.Click += new System.EventHandler(this.btn_SignUp_1_Click);
            // 
            // btn_LogIn_1
            // 
            this.btn_LogIn_1.Location = new System.Drawing.Point(76, 182);
            this.btn_LogIn_1.Name = "btn_LogIn_1";
            this.btn_LogIn_1.Size = new System.Drawing.Size(75, 49);
            this.btn_LogIn_1.TabIndex = 3;
            this.btn_LogIn_1.Text = "Log in";
            this.btn_LogIn_1.UseVisualStyleBackColor = true;
            this.btn_LogIn_1.Click += new System.EventHandler(this.btn_LogIn_1_Click);
            // 
            // User_Interface1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 302);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_SignUp_1);
            this.Controls.Add(this.btn_LogIn_1);
            this.Name = "User_Interface1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "User_Interface1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_SignUp_1;
        private System.Windows.Forms.Button btn_LogIn_1;
    }
}