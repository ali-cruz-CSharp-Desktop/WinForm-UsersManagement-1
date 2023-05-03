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
    public partial class ViewRolesForm : TemplateForm
    {
        public ViewRolesForm()
        {
            InitializeComponent();
            LoadDataIntoDataGridView();
        }

        private void LoadDataIntoDataGridView()
        {
            using (SqlConnection conn = new SqlConnection(AppConnection.GetConnectionString()))
            {
                using (SqlCommand cmd = new SqlCommand("usp_Roles_LoadDataIntoDGV", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    if (conn.State != ConnectionState.Open)
                        conn.Open();

                    DataTable dtRoles = new DataTable();

                    SqlDataReader dr = cmd.ExecuteReader();
                    dtRoles.Load(dr);

                    RolesDGV.DataSource = dtRoles;

                }

            }
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void newRoleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RolesForm rf = new RolesForm();
            rf.ShowDialog();
            LoadDataIntoDataGridView();

        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            if (SearchBtn.Text != string.Empty)
            {
                using (SqlConnection conn = new SqlConnection(AppConnection.GetConnectionString()))
                {
                    using (SqlCommand cmd = new SqlCommand("usp_Roles_SearchByTitle", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@RoleTitle", SearchTxb.Text.Trim());

                        if (conn.State != ConnectionState.Open)
                            conn.Open();

                        DataTable dtRole = new DataTable();
                        SqlDataReader dr = cmd.ExecuteReader();

                        if (dr.HasRows)
                        {
                            dtRole.Load(dr);
                            RolesDGV.DataSource = dtRole;
                        } else
                        {
                            MessageBox.Show("No maching role is found", "No record", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }



                    }
                }
            }
        }

        private void refreshRecordsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadDataIntoDataGridView();
            SearchTxb.Clear();
            SearchTxb.Focus();
        }

        private void RolesDGV_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (RolesDGV.Rows.Count > 0)
            {
                int RolId = Convert.ToInt32(RolesDGV.SelectedRows[0].Cells[0].Value);

                RolesForm rolesForm = new RolesForm();
                rolesForm.RolId = RolId;
                rolesForm.IsUpdate = true;
                rolesForm.ShowDialog();

                LoadDataIntoDataGridView();
            }
        }
    }
}
