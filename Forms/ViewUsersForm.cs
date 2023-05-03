using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UsersManagement.General;
using UsersManagement.Models;

namespace UsersManagement.Forms
{
    public partial class ViewUsersForm : TemplateForm
    {

        Users user = new Users();

        public ViewUsersForm()
        {
            InitializeComponent();
            LoadDataIntoDataGridView();
        }

        // Llena el DGV con el listado de usuarios consultado en BD.
        private void LoadDataIntoDataGridView()
        {
            using (SqlConnection conn = new SqlConnection(AppConnection.GetConnectionString()))
            {
                using (SqlCommand cmd = new SqlCommand("usp_Users_Select_AllUsers", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    if (conn.State != ConnectionState.Open)
                        conn.Open();

                    DataTable dtUsers = new DataTable();
                    SqlDataReader sdr = cmd.ExecuteReader();
                    
                    if (sdr.HasRows)
                    {
                        dtUsers.Load(sdr);
                        UsersDGV.DataSource = dtUsers;
                        UsersDGV.Columns["RoleID"].Visible = false;
                    } else
                    {

                    }
                }
            }
        }

        // Ciera el formulario con la lista de usuarios.
        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Abre form para registrar nuevo usuario
        private void newUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Debug.WriteLine("\nNew User");
            user.Mode = Users.ModeUser.Create;
            UserForm userForm = new UserForm(user);
            userForm.ShowDialog();
            // limpiar form            
        }

        // Filtrar DGV
        private void SearchBtn_Click(object sender, EventArgs e)
        {
            try 
            {
                (UsersDGV.DataSource as DataTable).DefaultView.RowFilter =
                string.Format("CONVERT([UserName], System.String) LIKE '%{0}%'", SearchTxb.Text.Trim());
            } catch(Exception ex)
            {
                Console.WriteLine(ex);
            }            
        }

        // Recarga listado de usuarios consutando en BD.
        private void refresRecordsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadDataIntoDataGridView();
            SearchTxb.Text = string.Empty;
        }

        // Detecta doble click en DGV para llenar objeto y pasarlo al formUsuario
        private void UsersDGV_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            System.Diagnostics.Debug.WriteLine("\nEdit User");            

            if (UsersDGV.Rows.Count > 0)
            {
                user.UserName = UsersDGV.SelectedRows[0].Cells["UserName"].Value.ToString();
                user.Password = UsersDGV.SelectedRows[0].Cells["Password"].Value.ToString();
                user.RoleID = Convert.ToInt32(UsersDGV.SelectedRows[0].Cells["RoleID"].Value.ToString());
                user.IsActive = Convert.ToBoolean(UsersDGV.SelectedRows[0].Cells["IsActive"].Value.ToString());
                user.Description = UsersDGV.SelectedRows[0].Cells["Description"].Value.ToString();
                user.Mode = Users.ModeUser.Update;

                UserForm userForm = new UserForm(user);
                userForm.ShowDialog();
            }
        }

        private void ViewUsersForm_Activated(object sender, EventArgs e)
        {
            LoadDataIntoDataGridView();
        }
    }
}
