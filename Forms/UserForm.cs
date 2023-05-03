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
    public partial class UserForm : TemplateForm
    {
        private Users user;
        Users.ModeUser userFormMode;

        public UserForm(Users user)
        {
            InitializeComponent();
            this.user = user;
            userFormMode = (Users.ModeUser)user.Mode;
            System.Diagnostics.Debug.WriteLine($"Consructor.  Mode Init: {userFormMode.ToString()}");
        }

        // MODO de inicio, prepara el UserForm de acuerdo al modo (new, update)
        private void UserForm_Load(object sender, EventArgs e)
        {
            System.Diagnostics.Debug.WriteLine("Load");
            LoadDataIntoRolesComboBox();
            
            switch (userFormMode)
            {
                case Users.ModeUser.Update:
                    ResetFormControl();
                    PrecargaDataToEditUser();
                    TxbUserName.Enabled = false;
                    deleteToolStripMenuItem.Enabled = true;
                    saveInformationToolStripMenuItem.Text = "Update Data |";
                    break;
                case Users.ModeUser.Create:
                    ResetFormControl();
                    saveInformationToolStripMenuItem.Text = "Save Info |";
                    // Default
                    rolescb.SelectedIndex = 2;
                    break;
            }
        }

        // Precarga el userForm para editar
        private void PrecargaDataToEditUser()
        {
            TxbUserName.Text = user.UserName;
            TxbPassword.Text = user.Password;
            rolescb.SelectedValue = user.RoleID;
            TexBDescripcion.Text = user.Description;
            checkBox1.Checked = user.IsActive;
        }

        // Llena ComboBox Roles desde BD.
        private void LoadDataIntoRolesComboBox()
        {
            using (SqlConnection conn = new SqlConnection(AppConnection.GetConnectionString()))
            {
                using (SqlCommand cmd = new SqlCommand("usp_Roles_LoadDataIntoComboBox", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    if (conn.State != ConnectionState.Open)
                        conn.Open();

                    DataTable dtRoles = new DataTable();

                    SqlDataReader dr = cmd.ExecuteReader();
                    dtRoles.Load(dr);

                    if (dtRoles.Rows.Count > 0)
                    {
                        rolescb.DataSource = dtRoles;
                        rolescb.DisplayMember = "RoleTitle";
                        rolescb.ValueMember = "RoleId";
                    }
                }
            }
        }

        // Save / Update
        private void saveInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (IsFormValid())
            {
                LlenaObjetoUser();

                switch (userFormMode)
                {
                    case Users.ModeUser.Create:
                        InsertNewUser(user);
                        break;
                    case Users.ModeUser.Update:
                        UpdateUser(user);
                        break;
                }                
            }
        }

        // Llena objeto user con los datos del formulario
        private void LlenaObjetoUser()
        {
            user.UserName = TxbUserName.Text.Trim();
            user.Password = SecureData.EncryptData(TxbPassword.Text.Trim());
            user.RoleID = Convert.ToInt32(rolescb.SelectedValue.ToString());
            user.IsActive = checkBox1.Checked;
            user.Description = TexBDescripcion.Text.Trim();
            user.CreatedBy = System.Environment.UserDomainName;
        }

        // Guarda userForm en BD.
        private void InsertNewUser(Users user)
        {
            // SAVE //insert
            try
            {
                using (SqlConnection conn = new SqlConnection(AppConnection.GetConnectionString()))
                {
                    using (SqlCommand cmd = new SqlCommand("usp_Users_InsertNewUser", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@UserName", user.UserName);
                        cmd.Parameters.AddWithValue("@Password", user.Password);
                        cmd.Parameters.AddWithValue("@RoleID", user.RoleID);
                        cmd.Parameters.AddWithValue("@IsActivated", user.IsActive);
                        cmd.Parameters.AddWithValue("@Description", user.Description);
                        cmd.Parameters.AddWithValue("@CreatedBy", user.CreatedBy);

                        if (conn.State != ConnectionState.Open)
                        {
                            conn.Open();
                        }

                        var NoRowsAffected = cmd.ExecuteNonQuery();

                        if (NoRowsAffected == 1)
                        {
                            MessageBox.Show("User is successfully saved in DB", "Success", 
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ResetFormControl();
                        } else
                        {
                            MessageBox.Show("User could not be saved in DB. Try again.", "Error", 
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }                        
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        // Actualiza registro seleccionado en BD
        private void UpdateUser(Users user)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(AppConnection.GetConnectionString()))
                {
                    using (SqlCommand cmd = new SqlCommand("usp_Users_UpdateUser", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.Add("@UserName",     SqlDbType.NVarChar).Value = user.UserName;
                        cmd.Parameters.Add("@Password",     SqlDbType.NVarChar).Value = user.Password;
                        cmd.Parameters.Add("@RoleID",       SqlDbType.Int).Value =      user.RoleID;
                        cmd.Parameters.Add("@IsActivated",  SqlDbType.Bit).Value =      user.IsActive;
                        cmd.Parameters.Add("@Description",  SqlDbType.NVarChar).Value = user.Description;
                        cmd.Parameters.Add("@CreatedBy",    SqlDbType.NVarChar).Value = user.CreatedBy;

                        if (conn.State != ConnectionState.Open)
                        {
                            conn.Open();
                        }

                        var NoRowsAffected = cmd.ExecuteNonQuery();

                        // Solo se debe afectar un usuario por llamado
                        if (NoRowsAffected == 1)
                        {
                            MessageBox.Show($"User {user.UserName} successfully updated", "Updated", 
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ResetFormControl();
                        } else
                        {
                            MessageBox.Show($"User {user.UserName} was not updated. Try again.", "Error",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }                
            } catch (Exception ex)
            {
                MessageBox.Show($"There is an error when trying to update user {user.UserName}\n " +
                        $"Details: {ex.Message.ToString()}", "Error", MessageBoxButtons.OK, 
                        MessageBoxIcon.Error);
            }
        }

        // Eliminar registro usuario
        private void DeleteUser(Users user)
        {
            DialogResult result = MessageBox.Show($"¿Do you want to delete user {user.UserName}?", 
                "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection(AppConnection.GetConnectionString()))
                    {
                        using (SqlCommand cmd = new SqlCommand("usp_Users_DeleteByUserName", conn))
                        {
                            cmd.CommandType = CommandType.StoredProcedure;

                            cmd.Parameters.Add("@UserName", SqlDbType.NVarChar).Value = user.UserName;

                            if (conn.State != ConnectionState.Open)
                                conn.Open();

                            var NoRowsAffected = cmd.ExecuteNonQuery();

                            // Se elimina solo un elemento a la vez
                            if (NoRowsAffected == 1)
                            {
                                MessageBox.Show($"User {user.UserName} successfully deleted", "Deleted",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                                ResetFormControl();
                            }
                            else
                            {
                                MessageBox.Show($"There is an error trying to delete {user.UserName}. Try again",
                                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"There is an error trying to delete user.\nDetail: {ex.Message.ToString()}",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void ResetFormControl()
        {
            TxbUserName.Clear();
            TxbPassword.Clear();
            checkBox1.Checked = false;
            TexBDescripcion.Clear();
            rolescb.SelectedIndex = 0;
            TxbUserName.Enabled = true;
            deleteToolStripMenuItem.Enabled = false;
        }

        private bool IsFormValid()
        {
            if (TxbUserName.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Username is Required.", "Validation Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                TxbUserName.Focus();
                return false;
            }

            if (TxbPassword.Text.Length < 8)
            {
                MessageBox.Show("Password length should be bigger 8 or more characters", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                TxbUserName.Focus();
                return false;
            }

            if (TexBDescripcion.Text.Length < 5)
            {
                MessageBox.Show("Description it should be bigger than 4 characters.", 
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }



            return true;
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {           
            LlenaObjetoUser();
            userFormMode = Users.ModeUser.Delete;
            switch (userFormMode)
            {
                case Users.ModeUser.Delete:
                    DeleteUser(user);
                    break;
            }
        }

    }
}
