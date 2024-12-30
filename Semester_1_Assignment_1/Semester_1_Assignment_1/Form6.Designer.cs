namespace Semester_1_Assignment_1
{
    partial class Form6
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
            this.cmbBoxLecturers = new System.Windows.Forms.ComboBox();
            this.txtBoxModuleDesc = new System.Windows.Forms.TextBox();
            this.txtBoxModuleCode = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGoToLanding = new System.Windows.Forms.Button();
            this.btnAddModule = new System.Windows.Forms.Button();
            this.btnListModule = new System.Windows.Forms.Button();
            this.lstModules = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbBoxLecturers);
            this.groupBox1.Controls.Add(this.txtBoxModuleDesc);
            this.groupBox1.Controls.Add(this.txtBoxModuleCode);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnGoToLanding);
            this.groupBox1.Controls.Add(this.btnAddModule);
            this.groupBox1.Controls.Add(this.btnListModule);
            this.groupBox1.Controls.Add(this.lstModules);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(652, 426);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Student Module";
            // 
            // cmbBoxLecturers
            // 
            this.cmbBoxLecturers.FormattingEnabled = true;
            this.cmbBoxLecturers.Location = new System.Drawing.Point(307, 114);
            this.cmbBoxLecturers.Name = "cmbBoxLecturers";
            this.cmbBoxLecturers.Size = new System.Drawing.Size(339, 21);
            this.cmbBoxLecturers.TabIndex = 11;
            this.cmbBoxLecturers.SelectedIndexChanged += new System.EventHandler(this.cmbBoxLecturers_SelectedIndexChanged);
            // 
            // txtBoxModuleDesc
            // 
            this.txtBoxModuleDesc.Location = new System.Drawing.Point(372, 82);
            this.txtBoxModuleDesc.Name = "txtBoxModuleDesc";
            this.txtBoxModuleDesc.Size = new System.Drawing.Size(274, 20);
            this.txtBoxModuleDesc.TabIndex = 9;
            // 
            // txtBoxModuleCode
            // 
            this.txtBoxModuleCode.Location = new System.Drawing.Point(422, 45);
            this.txtBoxModuleCode.Name = "txtBoxModuleCode";
            this.txtBoxModuleCode.Size = new System.Drawing.Size(224, 20);
            this.txtBoxModuleCode.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Lecturer:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Module Description:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Module Code:";
            // 
            // btnGoToLanding
            // 
            this.btnGoToLanding.Font = new System.Drawing.Font("Bell MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGoToLanding.Location = new System.Drawing.Point(106, 158);
            this.btnGoToLanding.Name = "btnGoToLanding";
            this.btnGoToLanding.Size = new System.Drawing.Size(176, 44);
            this.btnGoToLanding.TabIndex = 3;
            this.btnGoToLanding.Text = "Go To Landing";
            this.btnGoToLanding.UseVisualStyleBackColor = true;
            this.btnGoToLanding.Click += new System.EventHandler(this.btnGoToLanding_Click);
            // 
            // btnAddModule
            // 
            this.btnAddModule.Font = new System.Drawing.Font("Bell MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddModule.Location = new System.Drawing.Point(288, 158);
            this.btnAddModule.Name = "btnAddModule";
            this.btnAddModule.Size = new System.Drawing.Size(176, 44);
            this.btnAddModule.TabIndex = 2;
            this.btnAddModule.Text = "Add Module";
            this.btnAddModule.UseVisualStyleBackColor = true;
            this.btnAddModule.Click += new System.EventHandler(this.btnAddModule_Click);
            // 
            // btnListModule
            // 
            this.btnListModule.Font = new System.Drawing.Font("Bell MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListModule.Location = new System.Drawing.Point(470, 158);
            this.btnListModule.Name = "btnListModule";
            this.btnListModule.Size = new System.Drawing.Size(176, 44);
            this.btnListModule.TabIndex = 1;
            this.btnListModule.Text = "List Module";
            this.btnListModule.UseVisualStyleBackColor = true;
            this.btnListModule.Click += new System.EventHandler(this.btnListModule_Click);
            // 
            // lstModules
            // 
            this.lstModules.FormattingEnabled = true;
            this.lstModules.Location = new System.Drawing.Point(6, 208);
            this.lstModules.Name = "lstModules";
            this.lstModules.Size = new System.Drawing.Size(640, 212);
            this.lstModules.TabIndex = 0;
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form6";
            this.Text = "Module";
            this.Load += new System.EventHandler(this.Form6_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbBoxLecturers;
        private System.Windows.Forms.TextBox txtBoxModuleDesc;
        private System.Windows.Forms.TextBox txtBoxModuleCode;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGoToLanding;
        private System.Windows.Forms.Button btnAddModule;
        private System.Windows.Forms.Button btnListModule;
        private System.Windows.Forms.ListBox lstModules;
    }
}