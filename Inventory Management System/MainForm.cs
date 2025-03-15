using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory_Management_System
{
    public partial class MainForm: Form
    {
        private Form activeForm = null;
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
           openChildForm(new UserForm(), "USERS");
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            openChildForm(new CustomerForm(), "CUSTOMERS");
        }

        private void btnCategory_Click(object sender, EventArgs e)
        {
            openChildForm(new CategoryForm(), "CATEGORIES");
        }

        #region METHODS
        private void openChildForm(Form childForm, string form)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelMain.Controls.Add(childForm);
            panelMain.Tag = childForm;
            labelForm.Text = form;
            childForm.BringToFront();
            childForm.Show();
        }
        #endregion METHODS                      
    }
}
