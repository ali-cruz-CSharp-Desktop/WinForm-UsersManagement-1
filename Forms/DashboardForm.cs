using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UsersManagement.General;
using UsersManagement.Models;

namespace UsersManagement.Forms
{
    public partial class DashboardForm : TemplateForm
    {
        public DashboardForm()
        {
            InitializeComponent();
            LblUser.Text = Session.UserName;
            LblAccessLevel.Text = Session.RoleID.ToString();
            LblToday.Text = DateTime.Now.ToString("dd-MM-yyyy");
            LblTime.Text = DateTime.Now.ToString("HH:mm");

            MonitorApp monitorApp = new MonitorApp();
            monitorApp.ConectToServer();
        }

        private void exitApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void newUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Users user = new Users();
            user.Mode = Users.ModeUser.Create;

            UserForm userForm = new UserForm(user);
            userForm.ShowDialog();
        }

        private void viewUsersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewUsersForm viewUsers = new ViewUsersForm();
            viewUsers.ShowDialog();
        }

        private void newRoleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RolesForm rolesForm = new RolesForm();
            rolesForm.ShowDialog();
        }

        private void viewRolesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewRolesForm viewRoles = new ViewRolesForm();
            viewRoles.ShowDialog();
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangePasswordForm changePassForm = new ChangePasswordForm();
            changePassForm.ShowDialog();
        }

        private void BtnExitApp_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnViewStudents_Click(object sender, EventArgs e)
        {
            
        }

        private void DashboardForm_Activated(object sender, EventArgs e)
        {
            SetupUserAccess();

        }

        private void SetupUserAccess()
        {
            switch (Session.RoleID)
            {
                case 1:
                    LblAccessLevel.Text = "Full";
                    adminToolStripMenuItem.Visible = true;
                    break;
                case 3:
                    LblAccessLevel.Text = "Normal";
                    break;
                case 1004:
                    LblAccessLevel.Text = "Limited";
                    break;
            }

        }

        private void BtnAddRole_Click(object sender, EventArgs e)
        {
            if (Session.RoleID == 1)
            {

            } else
            {
                MessageBox.Show("You are not allowed to perform this operation.", "Access denied", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DashboardForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
