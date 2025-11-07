namespace ViewGrid
{
    partial class User_MainMenu
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
            this.label3 = new System.Windows.Forms.Label();
            this.btn_logOut = new System.Windows.Forms.Button();
            this.btn_aboutUs = new System.Windows.Forms.Button();
            this.btn_roomTypes = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_book_a_Room = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(109, 431);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Changed your mind?";
            // 
            // btn_logOut
            // 
            this.btn_logOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_logOut.ForeColor = System.Drawing.Color.Sienna;
            this.btn_logOut.Location = new System.Drawing.Point(112, 447);
            this.btn_logOut.Name = "btn_logOut";
            this.btn_logOut.Size = new System.Drawing.Size(74, 27);
            this.btn_logOut.TabIndex = 12;
            this.btn_logOut.Text = "Log Out";
            this.btn_logOut.UseVisualStyleBackColor = true;
            this.btn_logOut.Click += new System.EventHandler(this.btn_logOut_Click);
            // 
            // btn_aboutUs
            // 
            this.btn_aboutUs.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_aboutUs.ForeColor = System.Drawing.Color.Sienna;
            this.btn_aboutUs.Location = new System.Drawing.Point(112, 329);
            this.btn_aboutUs.Name = "btn_aboutUs";
            this.btn_aboutUs.Size = new System.Drawing.Size(215, 64);
            this.btn_aboutUs.TabIndex = 11;
            this.btn_aboutUs.Text = "About Us";
            this.btn_aboutUs.UseVisualStyleBackColor = true;
            // 
            // btn_roomTypes
            // 
            this.btn_roomTypes.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_roomTypes.ForeColor = System.Drawing.Color.Sienna;
            this.btn_roomTypes.Location = new System.Drawing.Point(112, 259);
            this.btn_roomTypes.Name = "btn_roomTypes";
            this.btn_roomTypes.Size = new System.Drawing.Size(215, 64);
            this.btn_roomTypes.TabIndex = 10;
            this.btn_roomTypes.Text = "Room Types";
            this.btn_roomTypes.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(109, 243);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Want to get to know us?";
            // 
            // btn_book_a_Room
            // 
            this.btn_book_a_Room.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_book_a_Room.ForeColor = System.Drawing.Color.Sienna;
            this.btn_book_a_Room.Location = new System.Drawing.Point(112, 162);
            this.btn_book_a_Room.Name = "btn_book_a_Room";
            this.btn_book_a_Room.Size = new System.Drawing.Size(215, 64);
            this.btn_book_a_Room.TabIndex = 8;
            this.btn_book_a_Room.Text = "Book A Room";
            this.btn_book_a_Room.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(109, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Looking to stay with us?";
            // 
            // User_MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(1034, 661);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_logOut);
            this.Controls.Add(this.btn_aboutUs);
            this.Controls.Add(this.btn_roomTypes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_book_a_Room);
            this.Controls.Add(this.label1);
            this.Name = "User_MainMenu";
            this.Text = "User_MainMenu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_logOut;
        private System.Windows.Forms.Button btn_aboutUs;
        private System.Windows.Forms.Button btn_roomTypes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_book_a_Room;
        private System.Windows.Forms.Label label1;
    }
}