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
    public partial class ProductForm: Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\AplikasiWindows\Inventory Management System\Inventory Management System\dbIMS.mdf;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dr;

        public ProductForm()
        {
            InitializeComponent();
            LoadData();
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            ProductModuleForm productModuleForm = new ProductModuleForm();
            productModuleForm.btnSave.Enabled = true;
            productModuleForm.btnUpdate.Enabled = false;
            productModuleForm.ShowDialog();
            LoadData();
        }
        private void dgvProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dgvProduct.Columns[e.ColumnIndex].Name;
            if (colName == "Edit")
            {
                ProductModuleForm productModuleForm = new ProductModuleForm();

                productModuleForm.labelpId.Text = dgvProduct.Rows[e.RowIndex].Cells[1].Value.ToString();
                productModuleForm.txtProductName.Text = dgvProduct.Rows[e.RowIndex].Cells[2].Value.ToString();
                productModuleForm.txtQty.Text = dgvProduct.Rows[e.RowIndex].Cells[3].Value.ToString();
                productModuleForm.txtPrice.Text = dgvProduct.Rows[e.RowIndex].Cells[4].Value.ToString();
                productModuleForm.txtDesc.Text = dgvProduct.Rows[e.RowIndex].Cells[5].Value.ToString();
                productModuleForm.cmbCategory.Text = dgvProduct.Rows[e.RowIndex].Cells[6].Value.ToString();

                productModuleForm.btnSave.Enabled = false;
                productModuleForm.btnUpdate.Enabled = true;

                productModuleForm.ShowDialog();
            }
            else if (colName == "Delete")
            {
                if (MessageBox.Show("Ingin delete product ini?", "Deleting Product", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cmd = new SqlCommand("DELETE FROM tbProduct WHERE pid = @pid", con);
                    con.Open();
                    cmd.Parameters.AddWithValue("@pid", dgvProduct.Rows[e.RowIndex].Cells[1].Value.ToString());
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Product berhasil dihapus", "Deleting Product", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                }
            }

            LoadData();
        }
        private void txtSrchPro_TextChanged(object sender, EventArgs e)
        {
            LoadData();
        }

        #region METHODS
        public void LoadData()
        {
            int i = 0;
            dgvProduct.Rows.Clear();
            cmd = new SqlCommand("SELECT * FROM tbProduct WHERE CONCAT(pname,pprice,pdescription,pcategory) LIKE '%"+txtSrchPro.Text+"%'", con);
            con.Open();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                i += 1;
                dgvProduct.Rows.Add(i, dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString());
            }
            dr.Close();
            con.Close();
        }
        #endregion METHODS       

        
    }
}
