
namespace UsersManagement.Forms
{
    partial class DashboardForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.studentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newStudentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewStudentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitApplicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changePasswordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewUsersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rolesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newRoleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewRolesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userAccessToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.LblAccessLevel = new System.Windows.Forms.Label();
            this.LblUser = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.LblTime = new System.Windows.Forms.Label();
            this.LblToday = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.BtnAddStudent = new System.Windows.Forms.Button();
            this.BtnViewStudents = new System.Windows.Forms.Button();
            this.BtnExitApp = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.BtnAddRole = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.changePasswordToolStripMenuItem,
            this.adminToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.studentsToolStripMenuItem,
            this.exitApplicationToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.fileToolStripMenuItem.Text = "File |";
            // 
            // studentsToolStripMenuItem
            // 
            this.studentsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newStudentToolStripMenuItem,
            this.viewStudentToolStripMenuItem});
            this.studentsToolStripMenuItem.Name = "studentsToolStripMenuItem";
            this.studentsToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.studentsToolStripMenuItem.Text = "Students";
            // 
            // newStudentToolStripMenuItem
            // 
            this.newStudentToolStripMenuItem.Name = "newStudentToolStripMenuItem";
            this.newStudentToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.newStudentToolStripMenuItem.Text = "New Student";
            // 
            // viewStudentToolStripMenuItem
            // 
            this.viewStudentToolStripMenuItem.Name = "viewStudentToolStripMenuItem";
            this.viewStudentToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.viewStudentToolStripMenuItem.Text = "View Students";
            // 
            // exitApplicationToolStripMenuItem
            // 
            this.exitApplicationToolStripMenuItem.Name = "exitApplicationToolStripMenuItem";
            this.exitApplicationToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.exitApplicationToolStripMenuItem.Text = "Exit Application";
            this.exitApplicationToolStripMenuItem.Click += new System.EventHandler(this.exitApplicationToolStripMenuItem_Click);
            // 
            // changePasswordToolStripMenuItem
            // 
            this.changePasswordToolStripMenuItem.Name = "changePasswordToolStripMenuItem";
            this.changePasswordToolStripMenuItem.Size = new System.Drawing.Size(119, 20);
            this.changePasswordToolStripMenuItem.Text = "Change Password |";
            this.changePasswordToolStripMenuItem.Click += new System.EventHandler(this.changePasswordToolStripMenuItem_Click);
            // 
            // adminToolStripMenuItem
            // 
            this.adminToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usersToolStripMenuItem,
            this.rolesToolStripMenuItem,
            this.userAccessToolStripMenuItem});
            this.adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            this.adminToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.adminToolStripMenuItem.Text = "Admin";
            this.adminToolStripMenuItem.Visible = false;
            // 
            // usersToolStripMenuItem
            // 
            this.usersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newUserToolStripMenuItem,
            this.viewUsersToolStripMenuItem});
            this.usersToolStripMenuItem.Name = "usersToolStripMenuItem";
            this.usersToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.usersToolStripMenuItem.Text = "Users";
            // 
            // newUserToolStripMenuItem
            // 
            this.newUserToolStripMenuItem.Name = "newUserToolStripMenuItem";
            this.newUserToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.newUserToolStripMenuItem.Text = "New User";
            this.newUserToolStripMenuItem.Click += new System.EventHandler(this.newUserToolStripMenuItem_Click);
            // 
            // viewUsersToolStripMenuItem
            // 
            this.viewUsersToolStripMenuItem.Name = "viewUsersToolStripMenuItem";
            this.viewUsersToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.viewUsersToolStripMenuItem.Text = "View Users";
            this.viewUsersToolStripMenuItem.Click += new System.EventHandler(this.viewUsersToolStripMenuItem_Click);
            // 
            // rolesToolStripMenuItem
            // 
            this.rolesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newRoleToolStripMenuItem,
            this.viewRolesToolStripMenuItem});
            this.rolesToolStripMenuItem.Name = "rolesToolStripMenuItem";
            this.rolesToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.rolesToolStripMenuItem.Text = "Roles";
            // 
            // newRoleToolStripMenuItem
            // 
            this.newRoleToolStripMenuItem.Name = "newRoleToolStripMenuItem";
            this.newRoleToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.newRoleToolStripMenuItem.Text = "New Role";
            this.newRoleToolStripMenuItem.Click += new System.EventHandler(this.newRoleToolStripMenuItem_Click);
            // 
            // viewRolesToolStripMenuItem
            // 
            this.viewRolesToolStripMenuItem.Name = "viewRolesToolStripMenuItem";
            this.viewRolesToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.viewRolesToolStripMenuItem.Text = "View Roles";
            this.viewRolesToolStripMenuItem.Click += new System.EventHandler(this.viewRolesToolStripMenuItem_Click);
            // 
            // userAccessToolStripMenuItem
            // 
            this.userAccessToolStripMenuItem.Name = "userAccessToolStripMenuItem";
            this.userAccessToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.userAccessToolStripMenuItem.Text = "User Access";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 63F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.BtnAddStudent, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.BtnViewStudents, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.BtnExitApp, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.panel4, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.button1, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.button2, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.BtnAddRole, 1, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(-4, 31);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 122F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 122F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(807, 483);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.tableLayoutPanel1.SetColumnSpan(this.panel1, 5);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(801, 74);
            this.panel1.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 38.25F);
            this.label5.Location = new System.Drawing.Point(139, 7);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(503, 59);
            this.label5.TabIndex = 0;
            this.label5.Text = "Management System";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.LblAccessLevel);
            this.panel2.Controls.Add(this.LblUser);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(53, 83);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(225, 114);
            this.panel2.TabIndex = 1;
            // 
            // LblAccessLevel
            // 
            this.LblAccessLevel.AutoSize = true;
            this.LblAccessLevel.Location = new System.Drawing.Point(91, 72);
            this.LblAccessLevel.Name = "LblAccessLevel";
            this.LblAccessLevel.Size = new System.Drawing.Size(77, 13);
            this.LblAccessLevel.TabIndex = 3;
            this.LblAccessLevel.Text = "Access Level: ";
            // 
            // LblUser
            // 
            this.LblUser.AutoSize = true;
            this.LblUser.Location = new System.Drawing.Point(94, 29);
            this.LblUser.Name = "LblUser";
            this.LblUser.Size = new System.Drawing.Size(58, 13);
            this.LblUser.TabIndex = 2;
            this.LblUser.Text = "Welcome: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Access Level: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome: ";
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Controls.Add(this.LblTime);
            this.panel3.Controls.Add(this.LblToday);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Location = new System.Drawing.Point(515, 83);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(225, 114);
            this.panel3.TabIndex = 2;
            // 
            // LblTime
            // 
            this.LblTime.AutoSize = true;
            this.LblTime.Location = new System.Drawing.Point(76, 71);
            this.LblTime.Name = "LblTime";
            this.LblTime.Size = new System.Drawing.Size(36, 13);
            this.LblTime.TabIndex = 5;
            this.LblTime.Text = "Time: ";
            // 
            // LblToday
            // 
            this.LblToday.AutoSize = true;
            this.LblToday.Location = new System.Drawing.Point(75, 33);
            this.LblToday.Name = "LblToday";
            this.LblToday.Size = new System.Drawing.Size(43, 13);
            this.LblToday.TabIndex = 4;
            this.LblToday.Text = "Today: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Time: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Today: ";
            // 
            // BtnAddStudent
            // 
            this.BtnAddStudent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnAddStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.BtnAddStudent.Image = global::UsersManagement.Properties.Resources.plus__1_;
            this.BtnAddStudent.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnAddStudent.Location = new System.Drawing.Point(53, 332);
            this.BtnAddStudent.Name = "BtnAddStudent";
            this.BtnAddStudent.Size = new System.Drawing.Size(225, 101);
            this.BtnAddStudent.TabIndex = 3;
            this.BtnAddStudent.Text = "Add Student";
            this.BtnAddStudent.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnAddStudent.UseVisualStyleBackColor = true;
            // 
            // BtnViewStudents
            // 
            this.BtnViewStudents.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnViewStudents.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.BtnViewStudents.Image = global::UsersManagement.Properties.Resources.list__1_;
            this.BtnViewStudents.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnViewStudents.Location = new System.Drawing.Point(284, 332);
            this.BtnViewStudents.Name = "BtnViewStudents";
            this.BtnViewStudents.Size = new System.Drawing.Size(225, 101);
            this.BtnViewStudents.TabIndex = 4;
            this.BtnViewStudents.Text = "View Students";
            this.BtnViewStudents.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnViewStudents.UseVisualStyleBackColor = true;
            this.BtnViewStudents.Click += new System.EventHandler(this.BtnViewStudents_Click);
            // 
            // BtnExitApp
            // 
            this.BtnExitApp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnExitApp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.BtnExitApp.Image = global::UsersManagement.Properties.Resources.power;
            this.BtnExitApp.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnExitApp.Location = new System.Drawing.Point(515, 332);
            this.BtnExitApp.Name = "BtnExitApp";
            this.BtnExitApp.Size = new System.Drawing.Size(225, 101);
            this.BtnExitApp.TabIndex = 5;
            this.BtnExitApp.Text = "Exit App";
            this.BtnExitApp.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnExitApp.UseVisualStyleBackColor = true;
            this.BtnExitApp.Click += new System.EventHandler(this.BtnExitApp_Click);
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BackColor = System.Drawing.Color.SlateGray;
            this.tableLayoutPanel1.SetColumnSpan(this.panel4, 5);
            this.panel4.Location = new System.Drawing.Point(3, 447);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(801, 33);
            this.panel4.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.button1.Image = global::UsersManagement.Properties.Resources.list__1_;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.Location = new System.Drawing.Point(284, 210);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(225, 101);
            this.button1.TabIndex = 7;
            this.button1.Text = "View Students";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.button2.Image = global::UsersManagement.Properties.Resources.list__1_;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button2.Location = new System.Drawing.Point(515, 210);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(225, 101);
            this.button2.TabIndex = 8;
            this.button2.Text = "View Students";
            this.button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // BtnAddRole
            // 
            this.BtnAddRole.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnAddRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.BtnAddRole.Image = global::UsersManagement.Properties.Resources.list__1_;
            this.BtnAddRole.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnAddRole.Location = new System.Drawing.Point(53, 210);
            this.BtnAddRole.Name = "BtnAddRole";
            this.BtnAddRole.Size = new System.Drawing.Size(225, 101);
            this.BtnAddRole.TabIndex = 9;
            this.BtnAddRole.Text = "Add Role";
            this.BtnAddRole.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnAddRole.UseVisualStyleBackColor = true;
            this.BtnAddRole.Click += new System.EventHandler(this.BtnAddRole_Click);
            // 
            // DashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 508);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "DashboardForm";
            this.ShowInTaskbar = true;
            this.Text = "DashboardForm";
            this.Activated += new System.EventHandler(this.DashboardForm_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DashboardForm_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changePasswordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adminToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button BtnAddStudent;
        private System.Windows.Forms.Button BtnViewStudents;
        private System.Windows.Forms.Button BtnExitApp;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label LblAccessLevel;
        private System.Windows.Forms.Label LblUser;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LblTime;
        private System.Windows.Forms.Label LblToday;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ToolStripMenuItem studentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newStudentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewStudentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitApplicationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewUsersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rolesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newRoleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewRolesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userAccessToolStripMenuItem;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button BtnAddRole;
    }
}