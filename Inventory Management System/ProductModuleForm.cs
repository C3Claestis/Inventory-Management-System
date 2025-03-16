using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Inventory_Management_System
{
    public partial class ProductModuleForm: Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\AplikasiWindows\Inventory Management System\Inventory Management System\dbIMS.mdf;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dr;

        public ProductModuleForm()
        {
            InitializeComponent();
            LoadCategory();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Ingin save product ini?", "Saving Product", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cmd = new SqlCommand("INSERT INTO tbProduct (pname, pqty, pprice, pdescription, pcategory) VALUES (@pname, @pqty, @pprice, @pdescription, @pcategory)", con);
                    cmd.Parameters.AddWithValue("@pname", txtProductName.Text);
                    cmd.Parameters.AddWithValue("@pqty", Convert.ToInt32(txtQty.Text));
                    cmd.Parameters.AddWithValue("@pprice", Convert.ToInt32(txtPrice.Text));
                    cmd.Parameters.AddWithValue("@pdescription", txtDesc.Text);
                    cmd.Parameters.AddWithValue("@pcategory", cmbCategory.Text);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("Product berhasil disimpan", "Saving Product", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Ingin update product ini?", "Updating Product", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cmd = new SqlCommand("UPDATE tbProduct SET pname=@pname,pqty=@pqty,pprice=@pprice,pdescription=@pdescription,pcategory=@pcategory WHERE pid LIKE '" + labelpId.Text + "' ", con);
                    cmd.Parameters.AddWithValue("@pname", txtProductName.Text);
                    cmd.Parameters.AddWithValue("@pqty", txtQty.Text);
                    cmd.Parameters.AddWithValue("@pprice", txtPrice.Text);
                    cmd.Parameters.AddWithValue("@pdescription", txtDesc.Text);
                    cmd.Parameters.AddWithValue("@pcategory", cmbCategory.Text);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Product berhasil diupdate", "Updating Product", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Dispose();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();

            btnSave.Enabled = true;
            btnUpdate.Enabled = false;            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        #region METHODS
        public void Clear()
        {
            txtProductName.Clear();
            txtPrice.Clear();
            txtQty.Clear();
            txtDesc.Clear();
            cmbCategory.Text = "";
        }
        public void LoadCategory()
        {
            cmbCategory.Items.Clear();
            con.Open();
            cmd = new SqlCommand("SELECT catname FROM tbCategory", con);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cmbCategory.Items.Add(dr[0].ToString());
            }
            dr.Close();
            con.Close();
        }
        #endregion METHODS
    }
}
