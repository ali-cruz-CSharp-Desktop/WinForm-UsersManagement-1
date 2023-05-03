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
    public partial class LoginForm : TemplateForm
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            if (IsFormValid())
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection(AppConnection.GetConnectionString()))
                    {
                        using (SqlCommand cmd = new SqlCommand("usp_User_VerifyLogin", conn))
                        {
                            cmd.CommandType = CommandType.StoredProcedure;

                            cmd.Parameters.Add("@UserName", SqlDbType.NVarChar).Value = TxbUserName.Text.Trim();
                            cmd.Parameters.Add("@Password", SqlDbType.NVarChar).Value = SecureData.EncryptData(TxbPassword.Text);

                            if (conn.State != ConnectionState.Open)
                                conn.Open();

                            DataTable res = new DataTable();
                            SqlDataReader sdr = cmd.ExecuteReader();

                            if (sdr.HasRows)
                            {
                                res.Load(sdr);
                                DataRow dr = res.Rows[0];
                                Session.UserName = dr["UserName"].ToString();
                                Session.RoleID = Convert.ToInt32(dr["RoleId"].ToString());

                                System.Diagnostics.Debug.WriteLine("Login OK");
                                DashboardForm dashboardForm = new DashboardForm();
                                dashboardForm.Show();
                                this.Hide();
                            } else {
                                MessageBox.Show("UserName or Password are incorrect. Verify and try again", 
                                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                } catch (Exception ex)
                {

                }
            }
        }

        private bool IsFormValid()
        {
            if (TxbUserName.Text.Trim() == string.Empty || TxbPassword.Text == string.Empty)
            {
                MessageBox.Show("User name or password are required.", "Error", 
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
