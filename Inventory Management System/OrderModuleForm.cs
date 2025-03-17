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
        #region METHODS
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
        #endregion METHODS      
    }
}
