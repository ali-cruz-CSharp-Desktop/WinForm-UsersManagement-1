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

namespace UsersManagement.Forms
{
    public partial class RolesForm : TemplateForm
    {
        public RolesForm()
        {
            InitializeComponent();
        }

        public int RolId { get; set; }
        public bool IsUpdate { get; set; }

        private void saveInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData==(Keys.Escape))
            {
                this.Close();
                return true;
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (IsFormValid())
            {
                if (this.IsUpdate)
                {
                    // update
                    using (SqlConnection conn = new SqlConnection(AppConnection.GetConnectionString()))
                    {
                        using (SqlCommand cmd = new SqlCommand("usp_Roles_UpdateRoleByRoleId", conn))
                        {
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@RoleId", RolId);
                            cmd.Parameters.AddWithValue("@RoleTitle", titleTxb.Text.Trim());
                            cmd.Parameters.AddWithValue("@Description", descriptionTxb.Text.Trim());
                            cmd.Parameters.AddWithValue("@CreatedBy", "Admin");

                            if (conn.State != ConnectionState.Open)
                            {
                                conn.Open();
                            }

                            int NoRowsAffected = cmd.ExecuteNonQuery();

                            if (NoRowsAffected > 0)
                            {
                                MessageBox.Show("Role is successfully updated in DB", "Success", MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                            } else
                            {
                                MessageBox.Show("Role not changed in DB", "Information", MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                            }

                            ResetFormControl();
                        }
                    }

                } else
                {
                    // Insert
                    DialogResult result = MessageBox.Show("Are you sure to insert new role?", 
                        "New role", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        //insert
                        using (SqlConnection conn = new SqlConnection(AppConnection.GetConnectionString()))
                        {
                            using (SqlCommand cmd = new SqlCommand("usp_Roles_InsertNewRole", conn))
                            {
                                cmd.CommandType = CommandType.StoredProcedure;
                                cmd.Parameters.AddWithValue("@RoleTitle", titleTxb.Text.Trim());
                                cmd.Parameters.AddWithValue("@Description", descriptionTxb.Text.Trim());
                                cmd.Parameters.AddWithValue("@CreatedBy", "Admin");

                                try
                                {
                                    if (conn.State != ConnectionState.Open)
                                    {
                                        conn.Open();
                                    }
                                    
                                    // Retorna el primari key insertado
                                    //var rowAfected = cmd.ExecuteScalar();

                                    // Retorna -1 si no hay inserción y 1 si existe inserción.
                                    var rowAfected = cmd.ExecuteNonQuery();

                                    if (Convert.ToInt32(rowAfected) > 0)
                                    {
                                        MessageBox.Show("Role is successfully saved in DB", "Success", MessageBoxButtons.OK,
                                                MessageBoxIcon.Information);

                                        ResetFormControl();
                                    }
                                    else
                                    {
                                        MessageBox.Show("Error trying to inser new role", "Error", MessageBoxButtons.OK,
                                                   MessageBoxIcon.Error);

                                    }

                                } catch (Exception ex)
                                {
                                    MessageBox.Show("Error trying to inser new role", "Error", MessageBoxButtons.OK,
                                        MessageBoxIcon.Error);
                                }

                            }
                        }
                    }

                }
            }
        }

        private void ResetFormControl()
        {
            titleTxb.Clear();
            descriptionTxb.Clear();
            titleTxb.Focus();

            if (this.IsUpdate)
            {
                this.RolId = 0;
                this.IsUpdate = false;
                SaveBtn.Text = "Save Information";
                DeleteBtn.Enabled = false;
            }

        }

        private bool IsFormValid()
        {
            if (titleTxb.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Role Title is Required.", "Validation Error", MessageBoxButtons.OK, 
                    MessageBoxIcon.Error);
                titleTxb.Focus();
                return false;
            }

            if (descriptionTxb.Text.Length >= 50)
            {
                MessageBox.Show("Role Title length should be less to 50 characters", "Validation Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                titleTxb.Focus();
                return false;
            }

            return true;
        }

        private void RolesForm_Load(object sender, EventArgs e)
        {
            if (this.IsUpdate)
            {
                using (SqlConnection conn = new SqlConnection(AppConnection.GetConnectionString()))
                {
                    using (SqlCommand cmd = new SqlCommand("usp_Roles_ReloadDataForUpdate", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@RoleId", RolId);

                        if (conn.State != ConnectionState.Open)
                        {
                            conn.Open();
                        }

                        DataTable dtRole = new DataTable();
                        SqlDataReader dr = cmd.ExecuteReader();

                        dtRole.Load(dr);

                        DataRow row = dtRole.Rows[0];

                        titleTxb.Text = row["RoleTitle"].ToString();
                        descriptionTxb.Text = row["Description"].ToString();

                        SaveBtn.Text = "Update Role Information";
                        DeleteBtn.Enabled = true;



                    }
                }
            }
            
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (this.IsUpdate)
            {
                DialogResult result = MessageBox.Show("Are you sure yo want to delete this role?", 
                    "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    // Delete record from DB
                    using (SqlConnection conn = new SqlConnection(AppConnection.GetConnectionString()))
                    {
                        using (SqlCommand cmd = new SqlCommand("usp_Roles_DeleteById", conn))
                        {
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@RoleId", this.RolId);

                            if (conn.State != ConnectionState.Open)
                            {
                                conn.Open();
                            }

                            var rowsAffected = cmd.ExecuteNonQuery();
                            MessageBox.Show("Role is successfully deleted from the system", "Successfully Deleted",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ResetFormControl();
                        }

                    }

                }

            }
        }
    }
}
