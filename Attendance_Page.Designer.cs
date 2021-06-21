namespace Addis_River_Side_Attendance_System
{
    partial class Attendance_Page
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Attendance_Page));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.rbEntrance = new System.Windows.Forms.RadioButton();
            this.rbLeave = new System.Windows.Forms.RadioButton();
            this.btnAdmin = new System.Windows.Forms.Button();
            this.txtLeaveTime_Display = new System.Windows.Forms.TextBox();
            this.txtStarttime_Display = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.LeaveLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtName_Display = new System.Windows.Forms.TextBox();
            this.txtID_Display = new System.Windows.Forms.TextBox();
            this.pb_Display = new System.Windows.Forms.PictureBox();
            this.lblFingerPrintVerify = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Display)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.BackgroundImage = global::Addis_River_Side_Attendance_System.Properties.Resources.FINGER1;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.btnAdmin);
            this.panel1.Controls.Add(this.txtLeaveTime_Display);
            this.panel1.Controls.Add(this.txtStarttime_Display);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.LeaveLabel);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtName_Display);
            this.panel1.Controls.Add(this.txtID_Display);
            this.panel1.Controls.Add(this.pb_Display);
            this.panel1.Controls.Add(this.lblFingerPrintVerify);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(978, 410);
            this.panel1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(917, 374);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(31, 23);
            this.button1.TabIndex = 26;
            this.button1.Text = "Refresh";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.rbEntrance);
            this.panel2.Controls.Add(this.rbLeave);
            this.panel2.Location = new System.Drawing.Point(3, 11);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(87, 37);
            this.panel2.TabIndex = 25;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(23, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 13);
            this.label7.TabIndex = 26;
            this.label7.Text = "Leave";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(23, 2);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 13);
            this.label8.TabIndex = 27;
            this.label8.Text = "Entrance";
            // 
            // rbEntrance
            // 
            this.rbEntrance.AutoSize = true;
            this.rbEntrance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbEntrance.ForeColor = System.Drawing.Color.White;
            this.rbEntrance.Location = new System.Drawing.Point(3, 2);
            this.rbEntrance.Name = "rbEntrance";
            this.rbEntrance.Size = new System.Drawing.Size(14, 13);
            this.rbEntrance.TabIndex = 11;
            this.rbEntrance.UseVisualStyleBackColor = true;
            this.rbEntrance.CheckedChanged += new System.EventHandler(this.rbEntrance_CheckedChanged);
            // 
            // rbLeave
            // 
            this.rbLeave.AutoSize = true;
            this.rbLeave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbLeave.ForeColor = System.Drawing.Color.White;
            this.rbLeave.Location = new System.Drawing.Point(3, 19);
            this.rbLeave.Name = "rbLeave";
            this.rbLeave.Size = new System.Drawing.Size(14, 13);
            this.rbLeave.TabIndex = 18;
            this.rbLeave.UseVisualStyleBackColor = true;
            this.rbLeave.CheckedChanged += new System.EventHandler(this.rbLeave_CheckedChanged);
            // 
            // btnAdmin
            // 
            this.btnAdmin.BackColor = System.Drawing.Color.Transparent;
            this.btnAdmin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAdmin.FlatAppearance.BorderSize = 0;
            this.btnAdmin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdmin.Image = global::Addis_River_Side_Attendance_System.Properties.Resources.Admin_Icon;
            this.btnAdmin.Location = new System.Drawing.Point(0, 367);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(39, 37);
            this.btnAdmin.TabIndex = 19;
            this.btnAdmin.UseVisualStyleBackColor = false;
            this.btnAdmin.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtLeaveTime_Display
            // 
            this.txtLeaveTime_Display.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLeaveTime_Display.Location = new System.Drawing.Point(99, 338);
            this.txtLeaveTime_Display.Multiline = true;
            this.txtLeaveTime_Display.Name = "txtLeaveTime_Display";
            this.txtLeaveTime_Display.ReadOnly = true;
            this.txtLeaveTime_Display.Size = new System.Drawing.Size(205, 25);
            this.txtLeaveTime_Display.TabIndex = 16;
            this.txtLeaveTime_Display.TextChanged += new System.EventHandler(this.txtLeaveTime_Display_TextChanged);
            // 
            // txtStarttime_Display
            // 
            this.txtStarttime_Display.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStarttime_Display.Location = new System.Drawing.Point(99, 308);
            this.txtStarttime_Display.Multiline = true;
            this.txtStarttime_Display.Name = "txtStarttime_Display";
            this.txtStarttime_Display.ReadOnly = true;
            this.txtStarttime_Display.Size = new System.Drawing.Size(205, 25);
            this.txtStarttime_Display.TabIndex = 15;
            this.txtStarttime_Display.TextChanged += new System.EventHandler(this.txtStarttime_Display_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(4, 250);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 13);
            this.label10.TabIndex = 14;
            this.label10.Text = "Emp ID :";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(4, 280);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(51, 13);
            this.label11.TabIndex = 13;
            this.label11.Text = "Name  :";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // LeaveLabel
            // 
            this.LeaveLabel.AutoSize = true;
            this.LeaveLabel.BackColor = System.Drawing.Color.Transparent;
            this.LeaveLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LeaveLabel.ForeColor = System.Drawing.Color.White;
            this.LeaveLabel.Location = new System.Drawing.Point(4, 338);
            this.LeaveLabel.Name = "LeaveLabel";
            this.LeaveLabel.Size = new System.Drawing.Size(91, 13);
            this.LeaveLabel.TabIndex = 8;
            this.LeaveLabel.Text = "Leaving Time :";
            this.LeaveLabel.Click += new System.EventHandler(this.label6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(4, 311);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Starting Time :";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(11, 456);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 20);
            this.label3.TabIndex = 5;
            // 
            // txtName_Display
            // 
            this.txtName_Display.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName_Display.Location = new System.Drawing.Point(99, 277);
            this.txtName_Display.Multiline = true;
            this.txtName_Display.Name = "txtName_Display";
            this.txtName_Display.ReadOnly = true;
            this.txtName_Display.Size = new System.Drawing.Size(205, 25);
            this.txtName_Display.TabIndex = 4;
            this.txtName_Display.TextChanged += new System.EventHandler(this.txtName_Display_TextChanged);
            // 
            // txtID_Display
            // 
            this.txtID_Display.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID_Display.Location = new System.Drawing.Point(99, 247);
            this.txtID_Display.Multiline = true;
            this.txtID_Display.Name = "txtID_Display";
            this.txtID_Display.ReadOnly = true;
            this.txtID_Display.Size = new System.Drawing.Size(205, 25);
            this.txtID_Display.TabIndex = 2;
            this.txtID_Display.TextChanged += new System.EventHandler(this.txtID_Display_TextChanged);
            // 
            // pb_Display
            // 
            this.pb_Display.BackColor = System.Drawing.Color.Transparent;
            this.pb_Display.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pb_Display.InitialImage = ((System.Drawing.Image)(resources.GetObject("pb_Display.InitialImage")));
            this.pb_Display.Location = new System.Drawing.Point(126, 93);
            this.pb_Display.Name = "pb_Display";
            this.pb_Display.Size = new System.Drawing.Size(158, 138);
            this.pb_Display.TabIndex = 1;
            this.pb_Display.TabStop = false;
            this.pb_Display.Click += new System.EventHandler(this.pb_Display_Click);
            // 
            // lblFingerPrintVerify
            // 
            this.lblFingerPrintVerify.BackColor = System.Drawing.Color.Transparent;
            this.lblFingerPrintVerify.Image = global::Addis_River_Side_Attendance_System.Properties.Resources.FP;
            this.lblFingerPrintVerify.Location = new System.Drawing.Point(26, 105);
            this.lblFingerPrintVerify.Name = "lblFingerPrintVerify";
            this.lblFingerPrintVerify.Size = new System.Drawing.Size(82, 112);
            this.lblFingerPrintVerify.TabIndex = 3;
            this.lblFingerPrintVerify.Click += new System.EventHandler(this.label2_Click);
            // 
            // Attendance_Page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(975, 409);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Attendance_Page";
            this.Text = "Attendance Software";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Display)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblFingerPrintVerify;
        private System.Windows.Forms.TextBox txtID_Display;
        private System.Windows.Forms.PictureBox pb_Display;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtName_Display;
        private System.Windows.Forms.RadioButton rbEntrance;
        private System.Windows.Forms.Label LeaveLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtLeaveTime_Display;
        private System.Windows.Forms.TextBox txtStarttime_Display;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.RadioButton rbLeave;
        private System.Windows.Forms.Button btnAdmin;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button1;
    }
}