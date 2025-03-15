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
using System.Runtime.ConstrainedExecution;

namespace Inventory_Management_System
{
    public partial class UserModuleForm: Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\AplikasiWindows\Inventory Management System\Inventory Management System\dbIMS.mdf;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();

        public UserModuleForm()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if(txtPassword.Text != txtRePassword.Text)
                {
                    MessageBox.Show("Password tidak sama", "Saving User", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (MessageBox.Show("Ingin save user ini?", "Saving User", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cmd = new SqlCommand("INSERT INTO tbUser (username, fullname, password, phone) VALUES (@username, @fullname, @password, @phone)", con);
                    cmd.Parameters.AddWithValue("@username", txtUsername.Text);
                    cmd.Parameters.AddWithValue("@fullname", txtFullname.Text);
                    cmd.Parameters.AddWithValue("@password", txtPassword.Text);
                    cmd.Parameters.AddWithValue("@phone", txtPhone.Text);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("User berhasil disimpan", "Saving User", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
                if(MessageBox.Show("Ingin update user ini?", "Updating User", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cmd = new SqlCommand("UPDATE tbUser SET fullname = @fullname, password = @password, phone = @phone WHERE username = @username", con);                  
                    cmd.Parameters.AddWithValue("@username", txtUsername.Text);
                    cmd.Parameters.AddWithValue("@fullname", txtFullname.Text);
                    cmd.Parameters.AddWithValue("@password", txtPassword.Text);
                    cmd.Parameters.AddWithValue("@phone", txtPhone.Text);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("User berhasil diupdate", "Updating User", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        
        private void Clear()
        {
            txtUsername.Clear();
            txtFullname.Clear();
            txtPassword.Clear();
            txtRePassword.Clear();
            txtPhone.Clear();
        }
    }
}
