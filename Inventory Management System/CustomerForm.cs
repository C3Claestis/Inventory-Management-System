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
    public partial class CustomerForm: Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\AplikasiWindows\Inventory Management System\Inventory Management System\dbIMS.mdf;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dr;

        public CustomerForm()
        {
            InitializeComponent();
            LoadData();
        }
        private void btnAddUser_Click(object sender, EventArgs e)
        {
            CustomerModuleForm customerModuleForm = new CustomerModuleForm();
            customerModuleForm.btnSave.Enabled = true;
            customerModuleForm.btnUpdate.Enabled = false;
            customerModuleForm.ShowDialog();
            LoadData();
        }
        private void dgvCustomer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dgvCustomer.Columns[e.ColumnIndex].Name;
            if (colName == "Edit")
            {
                CustomerModuleForm customerModuleForm = new CustomerModuleForm();

                customerModuleForm.labelcsId.Text = dgvCustomer.Rows[e.RowIndex].Cells[1].Value.ToString();
                customerModuleForm.txtFullname.Text = dgvCustomer.Rows[e.RowIndex].Cells[2].Value.ToString();
                customerModuleForm.txtPhone.Text = dgvCustomer.Rows[e.RowIndex].Cells[3].Value.ToString();

                customerModuleForm.btnSave.Enabled = false;
                customerModuleForm.btnUpdate.Enabled = true;
            
                customerModuleForm.ShowDialog();
            }
            else if (colName == "Delete")
            {
                if (MessageBox.Show("Ingin delete customer ini?", "Deleting Customer", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cmd = new SqlCommand("DELETE FROM tbCustomer WHERE cid = @cid", con);
                    con.Open();
                    cmd.Parameters.AddWithValue("@cid", dgvCustomer.Rows[e.RowIndex].Cells[1].Value.ToString());
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Customer berhasil dihapus", "Deleting Customer", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                }
            }

            LoadData();
        }

        #region METHODS
        public void LoadData()
        {
            int i = 0;
            dgvCustomer.Rows.Clear();
            cmd = new SqlCommand("SELECT * FROM tbCustomer", con);
            con.Open();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                i += 1;
                dgvCustomer.Rows.Add(i, dr[0].ToString(), dr[1].ToString(), dr[2].ToString());
            }
            dr.Close();
            con.Close();
        }
        #endregion METHODS
    }
}
