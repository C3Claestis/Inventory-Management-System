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
    public partial class CategoryForm: Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\AplikasiWindows\Inventory Management System\Inventory Management System\dbIMS.mdf;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dr;

        public CategoryForm()
        {
            InitializeComponent();
            LoadData();
        }
        private void btnAddUser_Click(object sender, EventArgs e)
        {
            CategoryModuleForm categoryModuleForm = new CategoryModuleForm();
            categoryModuleForm.btnSave.Enabled = true;
            categoryModuleForm.btnUpdate.Enabled = false;
            categoryModuleForm.ShowDialog();
            LoadData();
        }

        private void dgvCategory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dgvCategory.Columns[e.ColumnIndex].Name;
            if (colName == "Edit")
            {
                CategoryModuleForm categoryModuleForm = new CategoryModuleForm();

                categoryModuleForm.labelcategoryId.Text = dgvCategory.Rows[e.RowIndex].Cells[1].Value.ToString();
                categoryModuleForm.txtName.Text = dgvCategory.Rows[e.RowIndex].Cells[2].Value.ToString();

                categoryModuleForm.btnSave.Enabled = false;
                categoryModuleForm.btnUpdate.Enabled = true;

                categoryModuleForm.ShowDialog();
            }
            else if (colName == "Delete")
            {
                if (MessageBox.Show("Ingin delete category ini?", "Deleting Category", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cmd = new SqlCommand("DELETE FROM tbCategory WHERE catid = @catid", con);
                    con.Open();
                    cmd.Parameters.AddWithValue("@catid", dgvCategory.Rows[e.RowIndex].Cells[1].Value.ToString());
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Category berhasil dihapus", "Deleting Category", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                }
            }

            LoadData();
        }

        #region METHODS
        public void LoadData()
        {
            int i = 0;
            dgvCategory.Rows.Clear();
            cmd = new SqlCommand("SELECT * FROM tbCategory", con);
            con.Open();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                i += 1;
                dgvCategory.Rows.Add(i, dr[0].ToString(), dr[1].ToString());
            }
            dr.Close();
            con.Close();
        }
        #endregion METHODS  
    }
}
