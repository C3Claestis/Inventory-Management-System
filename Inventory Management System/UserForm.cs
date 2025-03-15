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

namespace Inventory_Management_System
{
    public partial class UserForm: Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\AplikasiWindows\Inventory Management System\Inventory Management System\dbIMS.mdf;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dr;

        public UserForm()
        {
            InitializeComponent();
            LoadData();
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            UserModuleForm userModuleForm = new UserModuleForm();
            userModuleForm.btnSave.Enabled = true;
            userModuleForm.btnUpdate.Enabled = false;
            userModuleForm.ShowDialog();
            LoadData();
        }

        private void dgvUser_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dgvUser.Columns[e.ColumnIndex].Name;
            if(colName == "Edit")
            {
                UserModuleForm userModuleForm = new UserModuleForm();
                userModuleForm.txtUsername.Text = dgvUser.Rows[e.RowIndex].Cells[1].Value.ToString();
                userModuleForm.txtFullname.Text = dgvUser.Rows[e.RowIndex].Cells[2].Value.ToString();
                userModuleForm.txtPassword.Text = dgvUser.Rows[e.RowIndex].Cells[3].Value.ToString();
                userModuleForm.txtPhone.Text = dgvUser.Rows[e.RowIndex].Cells[4].Value.ToString();

                userModuleForm.btnSave.Enabled = false;
                userModuleForm.btnUpdate.Enabled = true;
                userModuleForm.txtUsername.Enabled = false;
                userModuleForm.ShowDialog();
            }
            else if (colName == "Delete")
            {
                if (MessageBox.Show("Ingin delete user ini?", "Deleting User", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cmd = new SqlCommand("DELETE FROM tbUser WHERE username = @username", con);
                    con.Open();
                    cmd.Parameters.AddWithValue("@username", dgvUser.Rows[e.RowIndex].Cells[1].Value.ToString());
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("User berhasil dihapus", "Deleting User", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                }
            }

            LoadData();
        }

        #region METHODS
        public void LoadData()
        {
            int i = 0;
            dgvUser.Rows.Clear();
            cmd = new SqlCommand("SELECT * FROM tbUser", con);
            con.Open();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                i += 1;
                dgvUser.Rows.Add(i, dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString());
            }
            dr.Close();
            con.Close();
        }
        #endregion METHODS
    }
}
