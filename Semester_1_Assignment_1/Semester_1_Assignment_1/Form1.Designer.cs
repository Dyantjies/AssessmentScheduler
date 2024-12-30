namespace Semester_1_Assignment_1
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.linklblHaveAcc = new System.Windows.Forms.LinkLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtStudPassword = new System.Windows.Forms.TextBox();
            this.txtStudEmail = new System.Windows.Forms.TextBox();
            this.txtStudSurname = new System.Windows.Forms.TextBox();
            this.txtStudName = new System.Windows.Forms.TextBox();
            this.txtStudNo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCreateAcc = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.linklblHaveAcc);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.txtStudPassword);
            this.groupBox1.Controls.Add(this.txtStudEmail);
            this.groupBox1.Controls.Add(this.txtStudSurname);
            this.groupBox1.Controls.Add(this.txtStudName);
            this.groupBox1.Controls.Add(this.txtStudNo);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnCreateAcc);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(483, 426);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Student Registration";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // linklblHaveAcc
            // 
            this.linklblHaveAcc.AutoSize = true;
            this.linklblHaveAcc.Font = new System.Drawing.Font("Microsoft Himalaya", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linklblHaveAcc.Location = new System.Drawing.Point(103, 392);
            this.linklblHaveAcc.Name = "linklblHaveAcc";
            this.linklblHaveAcc.Size = new System.Drawing.Size(155, 21);
            this.linklblHaveAcc.TabIndex = 12;
            this.linklblHaveAcc.TabStop = true;
            this.linklblHaveAcc.Text = "Already have an account?";
            this.linklblHaveAcc.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklblHaveAcc_LinkClicked);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Semester_1_Assignment_1.Properties.Resources.student;
            this.pictureBox1.Location = new System.Drawing.Point(143, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(196, 207);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // txtStudPassword
            // 
            this.txtStudPassword.Location = new System.Drawing.Point(189, 344);
            this.txtStudPassword.Name = "txtStudPassword";
            this.txtStudPassword.Size = new System.Drawing.Size(273, 20);
            this.txtStudPassword.TabIndex = 10;
            this.txtStudPassword.TextChanged += new System.EventHandler(this.txtStudPassword_TextChanged);
            // 
            // txtStudEmail
            // 
            this.txtStudEmail.Location = new System.Drawing.Point(189, 316);
            this.txtStudEmail.Name = "txtStudEmail";
            this.txtStudEmail.Size = new System.Drawing.Size(273, 20);
            this.txtStudEmail.TabIndex = 9;
            // 
            // txtStudSurname
            // 
            this.txtStudSurname.Location = new System.Drawing.Point(189, 288);
            this.txtStudSurname.Name = "txtStudSurname";
            this.txtStudSurname.Size = new System.Drawing.Size(273, 20);
            this.txtStudSurname.TabIndex = 8;
            // 
            // txtStudName
            // 
            this.txtStudName.Location = new System.Drawing.Point(189, 259);
            this.txtStudName.Name = "txtStudName";
            this.txtStudName.Size = new System.Drawing.Size(273, 20);
            this.txtStudName.TabIndex = 7;
            this.txtStudName.TextChanged += new System.EventHandler(this.txtStudName_TextChanged);
            // 
            // txtStudNo
            // 
            this.txtStudNo.Location = new System.Drawing.Point(189, 232);
            this.txtStudNo.Name = "txtStudNo";
            this.txtStudNo.Size = new System.Drawing.Size(273, 20);
            this.txtStudNo.TabIndex = 6;
            this.txtStudNo.TextChanged += new System.EventHandler(this.txtStudNo_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 351);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Student Password:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 323);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Student Email:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 295);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Student Surname:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 266);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Student Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 240);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Student Number:";
            // 
            // btnCreateAcc
            // 
            this.btnCreateAcc.Font = new System.Drawing.Font("Microsoft Himalaya", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateAcc.Location = new System.Drawing.Point(306, 383);
            this.btnCreateAcc.Name = "btnCreateAcc";
            this.btnCreateAcc.Size = new System.Drawing.Size(156, 23);
            this.btnCreateAcc.TabIndex = 0;
            this.btnCreateAcc.Text = "Create Account";
            this.btnCreateAcc.UseVisualStyleBackColor = true;
            this.btnCreateAcc.Click += new System.EventHandler(this.btnCreateAcc_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Register";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.LinkLabel linklblHaveAcc;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtStudPassword;
        private System.Windows.Forms.TextBox txtStudEmail;
        private System.Windows.Forms.TextBox txtStudSurname;
        private System.Windows.Forms.TextBox txtStudName;
        private System.Windows.Forms.TextBox txtStudNo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCreateAcc;
    }
}

