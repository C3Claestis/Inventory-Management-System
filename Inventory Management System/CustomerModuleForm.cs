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
    public partial class CustomerModuleForm: Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\AplikasiWindows\Inventory Management System\Inventory Management System\dbIMS.mdf;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();

        public CustomerModuleForm()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {              
                if (MessageBox.Show("Ingin save customer ini?", "Saving Customer", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cmd = new SqlCommand("INSERT INTO tbCustomer (cname, cphone) VALUES (@cname, @cphone)", con);
                    cmd.Parameters.AddWithValue("@cname", txtFullname.Text);
                    cmd.Parameters.AddWithValue("@cphone", txtPhone.Text);                    
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("Customer berhasil disimpan", "Saving Customer", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
                if (MessageBox.Show("Ingin update customer ini?", "Updating Customer", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cmd = new SqlCommand("UPDATE tbCustomer SET cname=@cname,cphone=@cphone WHERE cid LIKE '" + labelcsId.Text + "' ", con);                
                    cmd.Parameters.AddWithValue("@cname", txtFullname.Text);                 
                    cmd.Parameters.AddWithValue("@cphone", txtPhone.Text);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Customer berhasil diupdate", "Updating Customer", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void Clear()
        {         
            txtFullname.Clear();        
            txtPhone.Clear();
        }
    }
}
