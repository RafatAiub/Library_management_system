﻿namespace libraryManagementSystem
{
    partial class view_student_info
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Semester = new System.Windows.Forms.Label();
            this.Name = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.student_email = new System.Windows.Forms.TextBox();
            this.student_contact = new System.Windows.Forms.TextBox();
            this.student_department = new System.Windows.Forms.TextBox();
            this.student_enrollment_no = new System.Windows.Forms.TextBox();
            this.student_sem = new System.Windows.Forms.TextBox();
            this.student_name = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(123, -2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(949, 256);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(2, 94);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(115, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Search";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.Semester);
            this.panel1.Controls.Add(this.Name);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.student_email);
            this.panel1.Controls.Add(this.student_contact);
            this.panel1.Controls.Add(this.student_department);
            this.panel1.Controls.Add(this.student_enrollment_no);
            this.panel1.Controls.Add(this.student_sem);
            this.panel1.Controls.Add(this.student_name);
            this.panel1.Location = new System.Drawing.Point(124, 266);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(948, 172);
            this.panel1.TabIndex = 3;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(507, 108);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Email:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(275, 107);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Contact:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Department:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(468, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Enrollment no:";
            // 
            // Semester
            // 
            this.Semester.AutoSize = true;
            this.Semester.Location = new System.Drawing.Point(275, 62);
            this.Semester.Name = "Semester";
            this.Semester.Size = new System.Drawing.Size(54, 13);
            this.Semester.TabIndex = 9;
            this.Semester.Text = "Semester:";
            // 
            // Name
            // 
            this.Name.AutoSize = true;
            this.Name.Location = new System.Drawing.Point(46, 62);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(38, 13);
            this.Name.TabIndex = 8;
            this.Name.Text = "Name:";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button2.Location = new System.Drawing.Point(723, 104);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 31);
            this.button2.TabIndex = 7;
            this.button2.Text = "update";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Info;
            this.button1.Location = new System.Drawing.Point(723, 56);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 33);
            this.button1.TabIndex = 6;
            this.button1.Text = "select file";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // student_email
            // 
            this.student_email.Location = new System.Drawing.Point(548, 105);
            this.student_email.Name = "student_email";
            this.student_email.Size = new System.Drawing.Size(100, 20);
            this.student_email.TabIndex = 5;
            // 
            // student_contact
            // 
            this.student_contact.Location = new System.Drawing.Point(335, 104);
            this.student_contact.Name = "student_contact";
            this.student_contact.Size = new System.Drawing.Size(100, 20);
            this.student_contact.TabIndex = 4;
            // 
            // student_department
            // 
            this.student_department.Location = new System.Drawing.Point(90, 108);
            this.student_department.Name = "student_department";
            this.student_department.Size = new System.Drawing.Size(100, 20);
            this.student_department.TabIndex = 3;
            // 
            // student_enrollment_no
            // 
            this.student_enrollment_no.Location = new System.Drawing.Point(548, 62);
            this.student_enrollment_no.Name = "student_enrollment_no";
            this.student_enrollment_no.Size = new System.Drawing.Size(100, 20);
            this.student_enrollment_no.TabIndex = 2;
            // 
            // student_sem
            // 
            this.student_sem.Location = new System.Drawing.Point(335, 59);
            this.student_sem.Name = "student_sem";
            this.student_sem.Size = new System.Drawing.Size(100, 20);
            this.student_sem.TabIndex = 1;
            // 
            // student_name
            // 
            this.student_name.Location = new System.Drawing.Point(90, 59);
            this.student_name.Name = "student_name";
            this.student_name.Size = new System.Drawing.Size(100, 20);
            this.student_name.TabIndex = 0;
            // 
            // view_student_info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1070, 436);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "view_student_info";
            this.Text = "view_student_info";
            this.Load += new System.EventHandler(this.view_student_info_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Semester;
        private System.Windows.Forms.Label Name;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox student_email;
        private System.Windows.Forms.TextBox student_contact;
        private System.Windows.Forms.TextBox student_department;
        private System.Windows.Forms.TextBox student_enrollment_no;
        private System.Windows.Forms.TextBox student_sem;
        private System.Windows.Forms.TextBox student_name;
    }
}