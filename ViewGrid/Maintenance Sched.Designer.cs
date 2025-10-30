namespace ViewGrid
{
    partial class Maintenance_Sched
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
            this.btnEditMain = new System.Windows.Forms.Button();
            this.btnAddMain = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMain = new System.Windows.Forms.TextBox();
            this.DataMaintenance = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtRoomNumber = new System.Windows.Forms.TextBox();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.DateMaintenance = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.DataMaintenance)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEditMain
            // 
            this.btnEditMain.BackColor = System.Drawing.Color.SaddleBrown;
            this.btnEditMain.ForeColor = System.Drawing.Color.DarkSalmon;
            this.btnEditMain.Location = new System.Drawing.Point(914, 141);
            this.btnEditMain.Name = "btnEditMain";
            this.btnEditMain.Size = new System.Drawing.Size(103, 30);
            this.btnEditMain.TabIndex = 13;
            this.btnEditMain.Text = "EDIT";
            this.btnEditMain.UseVisualStyleBackColor = false;
            // 
            // btnAddMain
            // 
            this.btnAddMain.BackColor = System.Drawing.Color.SaddleBrown;
            this.btnAddMain.ForeColor = System.Drawing.Color.DarkSalmon;
            this.btnAddMain.Location = new System.Drawing.Point(796, 141);
            this.btnAddMain.Name = "btnAddMain";
            this.btnAddMain.Size = new System.Drawing.Size(103, 30);
            this.btnAddMain.TabIndex = 12;
            this.btnAddMain.Text = "ADD";
            this.btnAddMain.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Sienna;
            this.label2.Location = new System.Drawing.Point(12, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "Search:";
            // 
            // txtMain
            // 
            this.txtMain.Location = new System.Drawing.Point(12, 151);
            this.txtMain.Name = "txtMain";
            this.txtMain.Size = new System.Drawing.Size(347, 20);
            this.txtMain.TabIndex = 10;
            // 
            // DataMaintenance
            // 
            this.DataMaintenance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataMaintenance.Location = new System.Drawing.Point(12, 181);
            this.DataMaintenance.Name = "DataMaintenance";
            this.DataMaintenance.Size = new System.Drawing.Size(1005, 459);
            this.DataMaintenance.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Sienna;
            this.label1.Location = new System.Drawing.Point(12, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(328, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "MAINTENANCE SCHEDULING";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SaddleBrown;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1034, 60);
            this.panel1.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Sienna;
            this.label3.Location = new System.Drawing.Point(414, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 16);
            this.label3.TabIndex = 15;
            this.label3.Text = "Room Number:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Sienna;
            this.label4.Location = new System.Drawing.Point(414, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 16);
            this.label4.TabIndex = 16;
            this.label4.Text = "Status:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Sienna;
            this.label5.Location = new System.Drawing.Point(414, 141);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 16);
            this.label5.TabIndex = 17;
            this.label5.Text = "Maintenance Date:";
            // 
            // txtRoomNumber
            // 
            this.txtRoomNumber.Location = new System.Drawing.Point(559, 84);
            this.txtRoomNumber.Name = "txtRoomNumber";
            this.txtRoomNumber.Size = new System.Drawing.Size(174, 20);
            this.txtRoomNumber.TabIndex = 18;
            // 
            // txtStatus
            // 
            this.txtStatus.Location = new System.Drawing.Point(559, 112);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(174, 20);
            this.txtStatus.TabIndex = 19;
            // 
            // DateMaintenance
            // 
            this.DateMaintenance.Location = new System.Drawing.Point(559, 141);
            this.DateMaintenance.Name = "DateMaintenance";
            this.DateMaintenance.Size = new System.Drawing.Size(174, 20);
            this.DateMaintenance.TabIndex = 20;
            // 
            // Maintenance_Sched
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(1034, 661);
            this.Controls.Add(this.DateMaintenance);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.txtRoomNumber);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnEditMain);
            this.Controls.Add(this.btnAddMain);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMain);
            this.Controls.Add(this.DataMaintenance);
            this.Controls.Add(this.label1);
            this.Name = "Maintenance_Sched";
            this.Text = "Maintenance_Sched";
            ((System.ComponentModel.ISupportInitialize)(this.DataMaintenance)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEditMain;
        private System.Windows.Forms.Button btnAddMain;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMain;
        private System.Windows.Forms.DataGridView DataMaintenance;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtRoomNumber;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.DateTimePicker DateMaintenance;
    }
}