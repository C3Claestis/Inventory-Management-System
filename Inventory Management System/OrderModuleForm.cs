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
    public partial class OrderModuleForm: Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\AplikasiWindows\Inventory Management System\Inventory Management System\dbIMS.mdf;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dr;
        int qty = 0;

        public OrderModuleForm()
        {
            InitializeComponent();
            LoadCustomer();
            LoadProduct();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Dispose();            
        }
        private void txtSrchCust_TextChanged(object sender, EventArgs e)
        {
            LoadCustomer();
        }

        private void txtSrchPro_TextChanged(object sender, EventArgs e)
        {
            LoadProduct();
        }
        private void dgvCustomer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCId.Text = dgvCustomer.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtCname.Text = dgvCustomer.Rows[e.RowIndex].Cells[2].Value.ToString();
        }       

        private void dgvProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtPId.Text = dgvProduct.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtPname.Text = dgvProduct.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtPrice.Text = dgvProduct.Rows[e.RowIndex].Cells[4].Value.ToString();            
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            GetQty();

            if (Convert.ToInt32(numericUpDown1.Value) > qty)
            {
                MessageBox.Show("Quantity not enough", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                numericUpDown1.Value = qty;
                return;
            }

            if (Convert.ToInt32(numericUpDown1.Value) > 0)
            {
                int total = Convert.ToInt32(txtPrice.Text) * Convert.ToInt32(numericUpDown1.Value);
                txtTotal.Text = total.ToString();
            }                
        }

        private void btnOrderInsert_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtCId.Text.Trim() == "")
                {
                    MessageBox.Show("Pilih customer terlebih dahulu", "Order", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (txtPId.Text.Trim() == "")
                {
                    MessageBox.Show("Pilih product terlebih dahulu", "Order", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (MessageBox.Show("Ingin save order ini?", "Saving Order", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cmd = new SqlCommand("INSERT INTO tbOrder (orderdate, pid, cid, qty, price, total) VALUES (@orderdate, @pid, @cid, @qty, @price, @total)", con);
                    cmd.Parameters.AddWithValue("@orderdate", dateOrder.Value);
                    cmd.Parameters.AddWithValue("@pid", Convert.ToInt32(txtPId.Text));
                    cmd.Parameters.AddWithValue("@cid", Convert.ToInt32(txtCId.Text));
                    cmd.Parameters.AddWithValue("@qty", Convert.ToInt32(numericUpDown1.Value));
                    cmd.Parameters.AddWithValue("@price", Convert.ToInt32(txtPrice.Text));
                    cmd.Parameters.AddWithValue("@total", Convert.ToInt32(txtTotal.Text));
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();

                    cmd = new SqlCommand("UPDATE tbProduct SET pqty = (pqty - @pqty) WHERE pid LIKE '" + txtPId.Text+"' ", con);
                    cmd.Parameters.AddWithValue("@pqty", Convert.ToInt32(numericUpDown1.Value));

                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("Order berhasil disimpan", "Saving Order", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Clear();
                    LoadProduct();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            btnOrderInsert.Enabled = true;            
            Clear();
        }

        #region METHODS
        void Clear()
        {
            txtCId.Clear();
            txtCname.Clear();
            txtPId.Clear();
            dateOrder.Value = DateTime.Now;
            txtPrice.Clear();
            txtTotal.Clear();
            numericUpDown1.Value = 0;
        }
        public void LoadCustomer()
        {          
            int i = 0;
            dgvCustomer.Rows.Clear();
            cmd = new SqlCommand("SELECT cid, cname FROM tbCustomer WHERE CONCAT(cid,cname) LIKE '%"+txtSrchCust.Text+"%'", con);
            con.Open();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                i++;
                dgvCustomer.Rows.Add(i, dr[0].ToString(), dr[1].ToString());
            }
            dr.Close();
            con.Close();
        }

        public void LoadProduct()
        {
            int i = 0;
            dgvProduct.Rows.Clear();
            cmd = new SqlCommand("SELECT * FROM tbProduct WHERE CONCAT(pid,pname,pprice,pdescription,pcategory) LIKE '%"+txtSrchCust.Text+"%'", con);
            con.Open();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                i ++;
                dgvProduct.Rows.Add(i, dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString());
            }
            dr.Close();
            con.Close();
        }

        public void GetQty()
        {
            cmd = new SqlCommand("SELECT pqty FROM tbProduct WHERE pid='"+txtPId.Text+"'", con);
            con.Open();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                qty = Convert.ToInt32(dr[0].ToString());
            }
            dr.Close();
            con.Close();
        }
        #endregion METHODS                             
    }
}
