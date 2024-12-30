namespace Semester_1_Assignment_1
{
    partial class Form5
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
            this.txtBoxSurname = new System.Windows.Forms.TextBox();
            this.txtBoxName = new System.Windows.Forms.TextBox();
            this.txtBoxLecturerCode = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lstLecturers = new System.Windows.Forms.ListBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.manageLecturerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addLecturerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listLecturersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.leaveLecturerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtBoxSurname);
            this.groupBox1.Controls.Add(this.txtBoxName);
            this.groupBox1.Controls.Add(this.txtBoxLecturerCode);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lstLecturers);
            this.groupBox1.Location = new System.Drawing.Point(12, 57);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(764, 349);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // txtBoxSurname
            // 
            this.txtBoxSurname.Location = new System.Drawing.Point(372, 77);
            this.txtBoxSurname.Name = "txtBoxSurname";
            this.txtBoxSurname.Size = new System.Drawing.Size(386, 20);
            this.txtBoxSurname.TabIndex = 6;
            // 
            // txtBoxName
            // 
            this.txtBoxName.Location = new System.Drawing.Point(445, 43);
            this.txtBoxName.Name = "txtBoxName";
            this.txtBoxName.Size = new System.Drawing.Size(313, 20);
            this.txtBoxName.TabIndex = 5;
            this.txtBoxName.TextChanged += new System.EventHandler(this.txtBoxName_TextChanged);
            // 
            // txtBoxLecturerCode
            // 
            this.txtBoxLecturerCode.Location = new System.Drawing.Point(445, 12);
            this.txtBoxLecturerCode.Name = "txtBoxLecturerCode";
            this.txtBoxLecturerCode.Size = new System.Drawing.Size(313, 20);
            this.txtBoxLecturerCode.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 14);
            this.label3.TabIndex = 3;
            this.label3.Text = "Student Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 14);
            this.label2.TabIndex = 2;
            this.label2.Text = "Lecturer Surname:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 14);
            this.label1.TabIndex = 1;
            this.label1.Text = "Lecturer Code:";
            // 
            // lstLecturers
            // 
            this.lstLecturers.FormattingEnabled = true;
            this.lstLecturers.Location = new System.Drawing.Point(6, 160);
            this.lstLecturers.Name = "lstLecturers";
            this.lstLecturers.Size = new System.Drawing.Size(752, 186);
            this.lstLecturers.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manageLecturerToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(788, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // manageLecturerToolStripMenuItem
            // 
            this.manageLecturerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addLecturerToolStripMenuItem,
            this.listLecturersToolStripMenuItem,
            this.leaveLecturerToolStripMenuItem});
            this.manageLecturerToolStripMenuItem.Name = "manageLecturerToolStripMenuItem";
            this.manageLecturerToolStripMenuItem.Size = new System.Drawing.Size(108, 20);
            this.manageLecturerToolStripMenuItem.Text = "Manage Lecturer";
            // 
            // addLecturerToolStripMenuItem
            // 
            this.addLecturerToolStripMenuItem.Name = "addLecturerToolStripMenuItem";
            this.addLecturerToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.addLecturerToolStripMenuItem.Text = "Add Lecturer";
            this.addLecturerToolStripMenuItem.Click += new System.EventHandler(this.addLecturerToolStripMenuItem_Click);
            // 
            // listLecturersToolStripMenuItem
            // 
            this.listLecturersToolStripMenuItem.Name = "listLecturersToolStripMenuItem";
            this.listLecturersToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.listLecturersToolStripMenuItem.Text = "List Lecturers";
            this.listLecturersToolStripMenuItem.Click += new System.EventHandler(this.listLecturersToolStripMenuItem_Click);
            // 
            // leaveLecturerToolStripMenuItem
            // 
            this.leaveLecturerToolStripMenuItem.Name = "leaveLecturerToolStripMenuItem";
            this.leaveLecturerToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.leaveLecturerToolStripMenuItem.Text = "Leave Lecturer";
            this.leaveLecturerToolStripMenuItem.Click += new System.EventHandler(this.leaveLecturerToolStripMenuItem_Click);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 418);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form5";
            this.Text = "Lecturer";
            this.Load += new System.EventHandler(this.Form5_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtBoxSurname;
        private System.Windows.Forms.TextBox txtBoxName;
        private System.Windows.Forms.TextBox txtBoxLecturerCode;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstLecturers;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem manageLecturerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addLecturerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listLecturersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem leaveLecturerToolStripMenuItem;
    }
}