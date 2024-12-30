namespace Semester_1_Assignment_1
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.linklblWelcome = new System.Windows.Forms.LinkLabel();
            this.linklblLogOut = new System.Windows.Forms.LinkLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnManageLec = new System.Windows.Forms.Button();
            this.btnManageMod = new System.Windows.Forms.Button();
            this.btnManageAss = new System.Windows.Forms.Button();
            this.btnSearchAss = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // linklblWelcome
            // 
            this.linklblWelcome.AutoSize = true;
            this.linklblWelcome.Font = new System.Drawing.Font("Microsoft Himalaya", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linklblWelcome.Location = new System.Drawing.Point(486, 25);
            this.linklblWelcome.Name = "linklblWelcome";
            this.linklblWelcome.Size = new System.Drawing.Size(81, 27);
            this.linklblWelcome.TabIndex = 0;
            this.linklblWelcome.TabStop = true;
            this.linklblWelcome.Text = "Welcome";
            this.linklblWelcome.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklblWelcome_LinkClicked);
            // 
            // linklblLogOut
            // 
            this.linklblLogOut.AutoSize = true;
            this.linklblLogOut.Font = new System.Drawing.Font("Microsoft Himalaya", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linklblLogOut.Location = new System.Drawing.Point(876, 25);
            this.linklblLogOut.Name = "linklblLogOut";
            this.linklblLogOut.Size = new System.Drawing.Size(73, 27);
            this.linklblLogOut.TabIndex = 1;
            this.linklblLogOut.TabStop = true;
            this.linklblLogOut.Text = "Log Out";
            this.linklblLogOut.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklblLogOut_LinkClicked);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(13, 56);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(954, 71);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(13, 401);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(954, 71);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            // 
            // btnManageLec
            // 
            this.btnManageLec.Font = new System.Drawing.Font("Microsoft Himalaya", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageLec.Location = new System.Drawing.Point(13, 337);
            this.btnManageLec.Name = "btnManageLec";
            this.btnManageLec.Size = new System.Drawing.Size(234, 58);
            this.btnManageLec.TabIndex = 8;
            this.btnManageLec.Text = "Manage Lecturers";
            this.btnManageLec.UseVisualStyleBackColor = true;
            this.btnManageLec.Click += new System.EventHandler(this.btnManageLec_Click);
            // 
            // btnManageMod
            // 
            this.btnManageMod.Font = new System.Drawing.Font("Microsoft Himalaya", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageMod.Location = new System.Drawing.Point(253, 337);
            this.btnManageMod.Name = "btnManageMod";
            this.btnManageMod.Size = new System.Drawing.Size(234, 58);
            this.btnManageMod.TabIndex = 9;
            this.btnManageMod.Text = "Manage Modules";
            this.btnManageMod.UseVisualStyleBackColor = true;
            this.btnManageMod.Click += new System.EventHandler(this.btnManageMod_Click);
            // 
            // btnManageAss
            // 
            this.btnManageAss.Font = new System.Drawing.Font("Microsoft Himalaya", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageAss.Location = new System.Drawing.Point(493, 337);
            this.btnManageAss.Name = "btnManageAss";
            this.btnManageAss.Size = new System.Drawing.Size(234, 58);
            this.btnManageAss.TabIndex = 10;
            this.btnManageAss.Text = "Manage Assessment";
            this.btnManageAss.UseVisualStyleBackColor = true;
            this.btnManageAss.Click += new System.EventHandler(this.btnManageAss_Click);
            // 
            // btnSearchAss
            // 
            this.btnSearchAss.Font = new System.Drawing.Font("Microsoft Himalaya", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchAss.Location = new System.Drawing.Point(733, 337);
            this.btnSearchAss.Name = "btnSearchAss";
            this.btnSearchAss.Size = new System.Drawing.Size(234, 58);
            this.btnSearchAss.TabIndex = 11;
            this.btnSearchAss.Text = "Search Assessment";
            this.btnSearchAss.UseVisualStyleBackColor = true;
            this.btnSearchAss.Click += new System.EventHandler(this.btnSearchAss_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Semester_1_Assignment_1.Properties.Resources.Manage_Module;
            this.pictureBox2.Location = new System.Drawing.Point(253, 133);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(234, 207);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::Semester_1_Assignment_1.Properties.Resources.search_Assessment;
            this.pictureBox4.Location = new System.Drawing.Point(733, 133);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(234, 207);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 7;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Semester_1_Assignment_1.Properties.Resources.Manage_Assessment;
            this.pictureBox3.Location = new System.Drawing.Point(493, 133);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(234, 207);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 6;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(13, 133);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(234, 207);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Baskerville Old Face", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(139, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(697, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "© Copy Rights Reserved. Nelson Mandela University.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Himalaya", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(214, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(526, 38);
            this.label2.TabIndex = 0;
            this.label2.Text = "Landing Page: Have access to your work schedule";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(970, 484);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnSearchAss);
            this.Controls.Add(this.btnManageAss);
            this.Controls.Add(this.btnManageMod);
            this.Controls.Add(this.btnManageLec);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.linklblLogOut);
            this.Controls.Add(this.linklblWelcome);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form3";
            this.Text = "LandingPage";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel linklblWelcome;
        private System.Windows.Forms.LinkLabel linklblLogOut;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Button btnManageLec;
        private System.Windows.Forms.Button btnManageMod;
        private System.Windows.Forms.Button btnManageAss;
        private System.Windows.Forms.Button btnSearchAss;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}