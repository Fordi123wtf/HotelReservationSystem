namespace ViewGrid
{
    partial class USER_BOOKINGCOMPLETE
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
            this.label2 = new System.Windows.Forms.Label();
            this.btnBookAnother = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label1.Location = new System.Drawing.Point(55, 162);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Your booking is complete,";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label2.Location = new System.Drawing.Point(55, 197);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Thank you for joining us!";
            // 
            // btnBookAnother
            // 
            this.btnBookAnother.BackColor = System.Drawing.Color.SaddleBrown;
            this.btnBookAnother.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBookAnother.ForeColor = System.Drawing.Color.White;
            this.btnBookAnother.Location = new System.Drawing.Point(33, 236);
            this.btnBookAnother.Name = "btnBookAnother";
            this.btnBookAnother.Size = new System.Drawing.Size(102, 43);
            this.btnBookAnother.TabIndex = 2;
            this.btnBookAnother.Text = "Book Another";
            this.btnBookAnother.UseVisualStyleBackColor = false;
            this.btnBookAnother.Click += new System.EventHandler(this.btnBookAnother_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.BackColor = System.Drawing.Color.SaddleBrown;
            this.btnReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReturn.ForeColor = System.Drawing.Color.White;
            this.btnReturn.Location = new System.Drawing.Point(153, 236);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(101, 43);
            this.btnReturn.TabIndex = 3;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = false;
            // 
            // USER_BOOKINGCOMPLETE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnBookAnother);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "USER_BOOKINGCOMPLETE";
            this.Text = "USER_BOOKINGCOMPLETE";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnBookAnother;
        private System.Windows.Forms.Button btnReturn;
    }
}