namespace FrmClubRegistration
{
    partial class FrmUpdateMember
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.LastNametb = new System.Windows.Forms.TextBox();
            this.FirstNametb = new System.Windows.Forms.TextBox();
            this.MiddleNametb = new System.Windows.Forms.TextBox();
            this.Agetb = new System.Windows.Forms.TextBox();
            this.studentID = new System.Windows.Forms.ComboBox();
            this.GenderCB = new System.Windows.Forms.ComboBox();
            this.ProgramCB = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Student ID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "First Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Last Name:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 160);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Middle Name:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 211);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Age:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 259);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Gender:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 315);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 13);
            this.label8.TabIndex = 5;
            this.label8.Text = "Program:";
            // 
            // LastNametb
            // 
            this.LastNametb.Location = new System.Drawing.Point(12, 76);
            this.LastNametb.Name = "LastNametb";
            this.LastNametb.Size = new System.Drawing.Size(272, 20);
            this.LastNametb.TabIndex = 7;
            // 
            // FirstNametb
            // 
            this.FirstNametb.Location = new System.Drawing.Point(15, 123);
            this.FirstNametb.Name = "FirstNametb";
            this.FirstNametb.Size = new System.Drawing.Size(269, 20);
            this.FirstNametb.TabIndex = 8;
            // 
            // MiddleNametb
            // 
            this.MiddleNametb.Location = new System.Drawing.Point(12, 176);
            this.MiddleNametb.Name = "MiddleNametb";
            this.MiddleNametb.Size = new System.Drawing.Size(272, 20);
            this.MiddleNametb.TabIndex = 9;
            // 
            // Agetb
            // 
            this.Agetb.Location = new System.Drawing.Point(15, 227);
            this.Agetb.Name = "Agetb";
            this.Agetb.Size = new System.Drawing.Size(116, 20);
            this.Agetb.TabIndex = 10;
            // 
            // studentID
            // 
            this.studentID.FormattingEnabled = true;
            this.studentID.Location = new System.Drawing.Point(12, 25);
            this.studentID.Name = "studentID";
            this.studentID.Size = new System.Drawing.Size(272, 21);
            this.studentID.TabIndex = 13;
            // 
            // GenderCB
            // 
            this.GenderCB.FormattingEnabled = true;
            this.GenderCB.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Other"});
            this.GenderCB.Location = new System.Drawing.Point(12, 275);
            this.GenderCB.Name = "GenderCB";
            this.GenderCB.Size = new System.Drawing.Size(160, 21);
            this.GenderCB.TabIndex = 14;
            // 
            // ProgramCB
            // 
            this.ProgramCB.FormattingEnabled = true;
            this.ProgramCB.Items.AddRange(new object[] {
            "BS in Computer Science",
            "BS in Information Technology",
            "BS in Hospitality Management",
            "BS in Computer Engineering"});
            this.ProgramCB.Location = new System.Drawing.Point(12, 331);
            this.ProgramCB.Name = "ProgramCB";
            this.ProgramCB.Size = new System.Drawing.Size(272, 21);
            this.ProgramCB.TabIndex = 15;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(96, 383);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(137, 43);
            this.button1.TabIndex = 16;
            this.button1.Text = "Confirm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmUpdateMember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 438);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ProgramCB);
            this.Controls.Add(this.GenderCB);
            this.Controls.Add(this.studentID);
            this.Controls.Add(this.Agetb);
            this.Controls.Add(this.MiddleNametb);
            this.Controls.Add(this.FirstNametb);
            this.Controls.Add(this.LastNametb);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "FrmUpdateMember";
            this.Text = "FrmUpdateMember";
            this.Load += new System.EventHandler(this.FrmUpdateMember_Load);
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
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox LastNametb;
        private System.Windows.Forms.TextBox FirstNametb;
        private System.Windows.Forms.TextBox MiddleNametb;
        private System.Windows.Forms.TextBox Agetb;
        private System.Windows.Forms.ComboBox studentID;
        private System.Windows.Forms.ComboBox GenderCB;
        private System.Windows.Forms.ComboBox ProgramCB;
        private System.Windows.Forms.Button button1;
    }
}