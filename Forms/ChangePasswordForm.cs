using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UsersManagement.General;
using UsersManagement.Models;

namespace UsersManagement.Forms
{
    public partial class ChangePasswordForm : TemplateForm
    {
        public ChangePasswordForm()
        {
            InitializeComponent();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.Escape))
            {
                this.Close();
                return true;
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }


        private void BtnChangePassword_Click(object sender, EventArgs e)
        {
            if (IsFormValid())
            {
                Users user = new Users();
                user.UserName = Session.UserName;
                user.OldPassword = TxbOldPassord.Text;
                user.Password = TxbNewPassword.Text;

                // Verify existing password
                if (IsOldPasswordVerified(user))
                {
                    // Change password
                    if (UpdatePassword(user))
                    {
                        MessageBox.Show("Password updated.", "Correct",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearForm();
                        
                    } else
                    {
                        MessageBox.Show("Error trying to updated password.", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                } else
                {
                    MessageBox.Show("Old password is grong.", "Validation Error", 
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void ClearForm()
        {
            TxbOldPassord.Text = string.Empty;
            TxbNewPassword.Text = string.Empty;
            TxbConfirmPassword.Text = string.Empty;
        }
        
        // Validar que el old password exista en BD
        private bool IsOldPasswordVerified(Users user)
        {
            using (SqlConnection conn = new SqlConnection(AppConnection.GetConnectionString()))
            {
                using (SqlCommand cmd = new SqlCommand("usp_User_VerifyLogin", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("@UserName", SqlDbType.NVarChar).Value = user.UserName;
                    cmd.Parameters.Add("@Password", SqlDbType.NVarChar).Value = SecureData.EncryptData(user.OldPassword);

                    if (conn.State != ConnectionState.Open)
                    {
                        conn.Open();
                    }

                    SqlDataReader sdr = cmd.ExecuteReader();

                    if (sdr.HasRows)
                    {
                        return true;
                    } else
                    {
                        return false;
                    }
                }
            }
        }

        private bool UpdatePassword(Users user)
        {
            using (SqlConnection conn = new SqlConnection(AppConnection.GetConnectionString()))
            {
                using (SqlCommand cmd = new SqlCommand("usp_User_ChangePassword", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("@UserName", SqlDbType.NVarChar).Value = user.UserName;
                    cmd.Parameters.Add("@Password", SqlDbType.NVarChar).Value = SecureData.EncryptData(user.Password);
                    cmd.Parameters.Add("@CreatedBy", SqlDbType.NVarChar).Value = Environment.UserDomainName;

                    if (conn.State != ConnectionState.Open)
                        conn.Open();

                    var noRowsAffected = cmd.ExecuteNonQuery();

                    if (noRowsAffected == 1)
                    {
                        return true;
                    } else
                    {
                        return false;
                    }
                }
            }
        }



        private bool IsFormValid()
        {
            if (TxbOldPassord.Text == string.Empty)
            {
                MessageBox.Show("Please specify old password.", "Validation Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                TxbOldPassord.Focus();
                return false;
            }

            if (TxbNewPassword.Text == string.Empty)
            {
                MessageBox.Show("Please specify new password", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                TxbNewPassword.Focus();
                return false;
            }

            if (TxbConfirmPassword.Text == string.Empty)
            {
                MessageBox.Show("Please confirm the new passsword", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                TxbConfirmPassword.Focus();
                return false;
            }

            if (TxbNewPassword.Text != TxbConfirmPassword.Text)
            {
                MessageBox.Show("New and confirm password dont match.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private void BtnExitApp_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
