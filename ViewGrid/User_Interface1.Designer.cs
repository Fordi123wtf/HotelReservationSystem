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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(User_Interface1));
            this.btn_SignUp_1 = new System.Windows.Forms.Button();
            this.btn_LogIn_1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_SignUp_1
            // 
            this.btn_SignUp_1.BackColor = System.Drawing.Color.SaddleBrown;
            this.btn_SignUp_1.FlatAppearance.BorderSize = 0;
            this.btn_SignUp_1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_SignUp_1.ForeColor = System.Drawing.Color.Snow;
            this.btn_SignUp_1.Location = new System.Drawing.Point(367, 503);
            this.btn_SignUp_1.Name = "btn_SignUp_1";
            this.btn_SignUp_1.Size = new System.Drawing.Size(75, 49);
            this.btn_SignUp_1.TabIndex = 4;
            this.btn_SignUp_1.Text = "Sign up";
            this.btn_SignUp_1.UseVisualStyleBackColor = false;
            this.btn_SignUp_1.Click += new System.EventHandler(this.btn_SignUp_1_Click);
            // 
            // btn_LogIn_1
            // 
            this.btn_LogIn_1.BackColor = System.Drawing.Color.SaddleBrown;
            this.btn_LogIn_1.FlatAppearance.BorderSize = 0;
            this.btn_LogIn_1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_LogIn_1.ForeColor = System.Drawing.Color.Snow;
            this.btn_LogIn_1.Location = new System.Drawing.Point(200, 503);
            this.btn_LogIn_1.Name = "btn_LogIn_1";
            this.btn_LogIn_1.Size = new System.Drawing.Size(75, 49);
            this.btn_LogIn_1.TabIndex = 3;
            this.btn_LogIn_1.Text = "Log in";
            this.btn_LogIn_1.UseVisualStyleBackColor = false;
            this.btn_LogIn_1.Click += new System.EventHandler(this.btn_LogIn_1_Click);
            // 
            // label2
            // 
            this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
            this.label2.Location = new System.Drawing.Point(-27, 207);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(676, 273);
            this.label2.TabIndex = 6;
            this.label2.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(38, 166);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(556, 29);
            this.label1.TabIndex = 7;
            this.label1.Text = "WELCOME TO ISLANG DE LOS TROPICA";
            // 
            // label3
            // 
            this.label3.Image = ((System.Drawing.Image)(resources.GetObject("label3.Image")));
            this.label3.Location = new System.Drawing.Point(214, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(213, 129);
            this.label3.TabIndex = 8;
            // 
            // User_Interface1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(639, 593);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_SignUp_1);
            this.Controls.Add(this.btn_LogIn_1);
            this.Name = "User_Interface1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ccccccdvx5";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_SignUp_1;
        private System.Windows.Forms.Button btn_LogIn_1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
    }
}