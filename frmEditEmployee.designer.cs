﻿namespace SRePS
{
    partial class frmEditEmployee
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
            System.Windows.Forms.Label lblPass;
            System.Windows.Forms.Label lblUserName;
            System.Windows.Forms.Label lblPosition;
            System.Windows.Forms.Label lblConfirmPass;
            this.e_PassTextBox = new System.Windows.Forms.TextBox();
            this.e_UserNameTextBox = new System.Windows.Forms.TextBox();
            this.e_PositionTextBox = new System.Windows.Forms.TextBox();
            this.e_ConfirmPassTextBox = new System.Windows.Forms.TextBox();
            this.rdFemale = new System.Windows.Forms.RadioButton();
            this.rdMale = new System.Windows.Forms.RadioButton();
            this.lblGender = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnEditEmployee = new System.Windows.Forms.Button();
            this.menuBar = new System.Windows.Forms.MenuStrip();
            this.accountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.employeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salesReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dailyReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.weeklyReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.monthlyReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.predictionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            lblPass = new System.Windows.Forms.Label();
            lblUserName = new System.Windows.Forms.Label();
            lblPosition = new System.Windows.Forms.Label();
            lblConfirmPass = new System.Windows.Forms.Label();
            this.menuBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblPass
            // 
            lblPass.AutoSize = true;
            lblPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblPass.Location = new System.Drawing.Point(278, 266);
            lblPass.Name = "lblPass";
            lblPass.Size = new System.Drawing.Size(112, 25);
            lblPass.TabIndex = 7;
            lblPass.Text = "Password:";
            lblPass.Click += new System.EventHandler(this.lblPName_Click);
            // 
            // lblUserName
            // 
            lblUserName.AutoSize = true;
            lblUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblUserName.Location = new System.Drawing.Point(278, 220);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new System.Drawing.Size(125, 25);
            lblUserName.TabIndex = 6;
            lblUserName.Text = "User Name:";
            // 
            // lblPosition
            // 
            lblPosition.AutoSize = true;
            lblPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblPosition.Location = new System.Drawing.Point(278, 357);
            lblPosition.Name = "lblPosition";
            lblPosition.Size = new System.Drawing.Size(95, 25);
            lblPosition.TabIndex = 11;
            lblPosition.Text = "Position:";
            // 
            // lblConfirmPass
            // 
            lblConfirmPass.AutoSize = true;
            lblConfirmPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblConfirmPass.Location = new System.Drawing.Point(278, 311);
            lblConfirmPass.Name = "lblConfirmPass";
            lblConfirmPass.Size = new System.Drawing.Size(192, 25);
            lblConfirmPass.TabIndex = 10;
            lblConfirmPass.Text = "Confirm Password:";
            lblConfirmPass.Click += new System.EventHandler(this.label2_Click);
            // 
            // e_PassTextBox
            // 
            this.e_PassTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.e_PassTextBox.Location = new System.Drawing.Point(479, 263);
            this.e_PassTextBox.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.e_PassTextBox.Name = "e_PassTextBox";
            this.e_PassTextBox.Size = new System.Drawing.Size(416, 31);
            this.e_PassTextBox.TabIndex = 9;
            // 
            // e_UserNameTextBox
            // 
            this.e_UserNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.e_UserNameTextBox.Location = new System.Drawing.Point(479, 217);
            this.e_UserNameTextBox.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.e_UserNameTextBox.Name = "e_UserNameTextBox";
            this.e_UserNameTextBox.Size = new System.Drawing.Size(416, 31);
            this.e_UserNameTextBox.TabIndex = 8;
            // 
            // e_PositionTextBox
            // 
            this.e_PositionTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.e_PositionTextBox.Location = new System.Drawing.Point(479, 357);
            this.e_PositionTextBox.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.e_PositionTextBox.Name = "e_PositionTextBox";
            this.e_PositionTextBox.Size = new System.Drawing.Size(416, 31);
            this.e_PositionTextBox.TabIndex = 13;
            // 
            // e_ConfirmPassTextBox
            // 
            this.e_ConfirmPassTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.e_ConfirmPassTextBox.Location = new System.Drawing.Point(479, 311);
            this.e_ConfirmPassTextBox.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.e_ConfirmPassTextBox.Name = "e_ConfirmPassTextBox";
            this.e_ConfirmPassTextBox.Size = new System.Drawing.Size(416, 31);
            this.e_ConfirmPassTextBox.TabIndex = 12;
            // 
            // rdFemale
            // 
            this.rdFemale.AutoSize = true;
            this.rdFemale.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdFemale.Location = new System.Drawing.Point(597, 405);
            this.rdFemale.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rdFemale.Name = "rdFemale";
            this.rdFemale.Size = new System.Drawing.Size(102, 29);
            this.rdFemale.TabIndex = 16;
            this.rdFemale.TabStop = true;
            this.rdFemale.Text = "Female";
            this.rdFemale.UseVisualStyleBackColor = true;
            // 
            // rdMale
            // 
            this.rdMale.AutoSize = true;
            this.rdMale.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdMale.Location = new System.Drawing.Point(477, 405);
            this.rdMale.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rdMale.Name = "rdMale";
            this.rdMale.Size = new System.Drawing.Size(80, 29);
            this.rdMale.TabIndex = 15;
            this.rdMale.TabStop = true;
            this.rdMale.Text = "Male";
            this.rdMale.UseVisualStyleBackColor = true;
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGender.Location = new System.Drawing.Point(278, 405);
            this.lblGender.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(83, 25);
            this.lblGender.TabIndex = 14;
            this.lblGender.Text = "Gender:";
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(597, 453);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(126, 42);
            this.btnCancel.TabIndex = 18;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // btnEditEmployee
            // 
            this.btnEditEmployee.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnEditEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditEmployee.Location = new System.Drawing.Point(453, 453);
            this.btnEditEmployee.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEditEmployee.Name = "btnEditEmployee";
            this.btnEditEmployee.Size = new System.Drawing.Size(126, 42);
            this.btnEditEmployee.TabIndex = 17;
            this.btnEditEmployee.Text = "&Edit";
            this.btnEditEmployee.UseVisualStyleBackColor = false;
            // 
            // menuBar
            // 
            this.menuBar.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.menuBar.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.accountToolStripMenuItem,
            this.homeToolStripMenuItem,
            this.productToolStripMenuItem,
            this.salesToolStripMenuItem,
            this.employeeToolStripMenuItem,
            this.salesReportToolStripMenuItem,
            this.predictionToolStripMenuItem});
            this.menuBar.Location = new System.Drawing.Point(0, 0);
            this.menuBar.Name = "menuBar";
            this.menuBar.Size = new System.Drawing.Size(1212, 33);
            this.menuBar.TabIndex = 19;
            this.menuBar.Text = "menuStrip1";
            // 
            // accountToolStripMenuItem
            // 
            this.accountToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logOutToolStripMenuItem});
            this.accountToolStripMenuItem.Name = "accountToolStripMenuItem";
            this.accountToolStripMenuItem.Size = new System.Drawing.Size(89, 29);
            this.accountToolStripMenuItem.Text = "Account";
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(161, 30);
            this.logOutToolStripMenuItem.Text = "Log Out";
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(73, 29);
            this.homeToolStripMenuItem.Text = "Home";
            // 
            // productToolStripMenuItem
            // 
            this.productToolStripMenuItem.Name = "productToolStripMenuItem";
            this.productToolStripMenuItem.Size = new System.Drawing.Size(86, 29);
            this.productToolStripMenuItem.Text = "Product";
            // 
            // salesToolStripMenuItem
            // 
            this.salesToolStripMenuItem.Name = "salesToolStripMenuItem";
            this.salesToolStripMenuItem.Size = new System.Drawing.Size(64, 29);
            this.salesToolStripMenuItem.Text = "Sales";
            // 
            // employeeToolStripMenuItem
            // 
            this.employeeToolStripMenuItem.Name = "employeeToolStripMenuItem";
            this.employeeToolStripMenuItem.Size = new System.Drawing.Size(102, 29);
            this.employeeToolStripMenuItem.Text = "Employee";
            // 
            // salesReportToolStripMenuItem
            // 
            this.salesReportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dailyReportToolStripMenuItem,
            this.weeklyReportToolStripMenuItem,
            this.monthlyReportToolStripMenuItem});
            this.salesReportToolStripMenuItem.Name = "salesReportToolStripMenuItem";
            this.salesReportToolStripMenuItem.Size = new System.Drawing.Size(122, 29);
            this.salesReportToolStripMenuItem.Text = "Sales Report";
            // 
            // dailyReportToolStripMenuItem
            // 
            this.dailyReportToolStripMenuItem.Name = "dailyReportToolStripMenuItem";
            this.dailyReportToolStripMenuItem.Size = new System.Drawing.Size(220, 30);
            this.dailyReportToolStripMenuItem.Text = "Daily Report";
            // 
            // weeklyReportToolStripMenuItem
            // 
            this.weeklyReportToolStripMenuItem.Name = "weeklyReportToolStripMenuItem";
            this.weeklyReportToolStripMenuItem.Size = new System.Drawing.Size(220, 30);
            this.weeklyReportToolStripMenuItem.Text = "Weekly Report";
            // 
            // monthlyReportToolStripMenuItem
            // 
            this.monthlyReportToolStripMenuItem.Name = "monthlyReportToolStripMenuItem";
            this.monthlyReportToolStripMenuItem.Size = new System.Drawing.Size(220, 30);
            this.monthlyReportToolStripMenuItem.Text = "Monthly Report";
            // 
            // predictionToolStripMenuItem
            // 
            this.predictionToolStripMenuItem.Name = "predictionToolStripMenuItem";
            this.predictionToolStripMenuItem.Size = new System.Drawing.Size(103, 29);
            this.predictionToolStripMenuItem.Text = "Prediction";
            // 
            // frmEditEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1212, 678);
            this.Controls.Add(this.menuBar);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnEditEmployee);
            this.Controls.Add(this.rdFemale);
            this.Controls.Add(this.rdMale);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(lblPosition);
            this.Controls.Add(this.e_PositionTextBox);
            this.Controls.Add(lblConfirmPass);
            this.Controls.Add(this.e_ConfirmPassTextBox);
            this.Controls.Add(lblPass);
            this.Controls.Add(this.e_PassTextBox);
            this.Controls.Add(lblUserName);
            this.Controls.Add(this.e_UserNameTextBox);
            this.Name = "frmEditEmployee";
            this.Text = "Family Aid Pharmacy Inc. SRePS - Edit Employee";
            this.menuBar.ResumeLayout(false);
            this.menuBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox e_PassTextBox;
        private System.Windows.Forms.TextBox e_UserNameTextBox;
        private System.Windows.Forms.TextBox e_PositionTextBox;
        private System.Windows.Forms.TextBox e_ConfirmPassTextBox;
        private System.Windows.Forms.RadioButton rdFemale;
        private System.Windows.Forms.RadioButton rdMale;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnEditEmployee;
        private System.Windows.Forms.MenuStrip menuBar;
        private System.Windows.Forms.ToolStripMenuItem accountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem employeeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salesReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dailyReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem weeklyReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem monthlyReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem predictionToolStripMenuItem;
    }
}