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
    public partial class LoginForm: Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\AplikasiWindows\Inventory Management System\Inventory Management System\dbIMS.mdf;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dr;

        public LoginForm()
        {
            InitializeComponent();
        }

        private void checkBoxShowpass_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxShowpass.Checked)
            {
                textBoxpass.UseSystemPasswordChar = false;
            }
            else
            {
                textBoxpass.UseSystemPasswordChar = true;
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                cmd = new SqlCommand("SELECT * FROM tbUser WHERE username = @username AND password = @password", con);
                cmd.Parameters.AddWithValue("@username", textBoxusername.Text);
                cmd.Parameters.AddWithValue("@password", textBoxpass.Text);
                con.Open();
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    MessageBox.Show("Welcome " + dr["fullname"].ToString(), "Login Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MainForm mainForm = new MainForm();                   
                    this.Hide();
                    mainForm.Show();
                }
                else
                {
                    MessageBox.Show("Login gagal", "Login Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
