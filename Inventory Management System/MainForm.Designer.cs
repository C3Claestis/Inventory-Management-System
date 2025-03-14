namespace Inventory_Management_System
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnOrders = new Guna.UI2.WinForms.Guna2ImageButton();
            this.btnUser = new Guna.UI2.WinForms.Guna2ImageButton();
            this.btnCategory = new Guna.UI2.WinForms.Guna2ImageButton();
            this.btnCustomer = new Guna.UI2.WinForms.Guna2ImageButton();
            this.btnProduct = new Guna.UI2.WinForms.Guna2ImageButton();
            this.guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnExit = new Guna.UI2.WinForms.Guna2ImageButton();
            this.panelMain = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(5);
            this.panel1.Size = new System.Drawing.Size(1024, 25);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Silver;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 753);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(5);
            this.panel2.Size = new System.Drawing.Size(1024, 15);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LightGray;
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.btnOrders);
            this.panel3.Controls.Add(this.btnUser);
            this.panel3.Controls.Add(this.btnCategory);
            this.panel3.Controls.Add(this.btnCustomer);
            this.panel3.Controls.Add(this.btnProduct);
            this.panel3.Controls.Add(this.guna2CirclePictureBox1);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 25);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1024, 140);
            this.panel3.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(210, 108);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 23);
            this.label6.TabIndex = 16;
            this.label6.Text = "Product";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(730, 108);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 23);
            this.label5.TabIndex = 15;
            this.label5.Text = "Orders";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(600, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 23);
            this.label3.TabIndex = 14;
            this.label3.Text = "Users";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(340, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 23);
            this.label2.TabIndex = 13;
            this.label2.Text = "Customers";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(470, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 23);
            this.label4.TabIndex = 12;
            this.label4.Text = "Categories";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnOrders
            // 
            this.btnOrders.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnOrders.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image1")));
            this.btnOrders.HoverState.ImageSize = new System.Drawing.Size(64, 54);
            this.btnOrders.Image = ((System.Drawing.Image)(resources.GetObject("btnOrders.Image")));
            this.btnOrders.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnOrders.ImageRotate = 0F;
            this.btnOrders.ImageSize = new System.Drawing.Size(64, 54);
            this.btnOrders.Location = new System.Drawing.Point(754, 51);
            this.btnOrders.Name = "btnOrders";
            this.btnOrders.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnOrders.Size = new System.Drawing.Size(64, 54);
            this.btnOrders.TabIndex = 9;
            // 
            // btnUser
            // 
            this.btnUser.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnUser.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image2")));
            this.btnUser.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnUser.Image = ((System.Drawing.Image)(resources.GetObject("btnUser.Image")));
            this.btnUser.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnUser.ImageRotate = 0F;
            this.btnUser.Location = new System.Drawing.Point(624, 51);
            this.btnUser.Name = "btnUser";
            this.btnUser.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnUser.Size = new System.Drawing.Size(64, 54);
            this.btnUser.TabIndex = 8;
            this.btnUser.Click += new System.EventHandler(this.btnUser_Click);
            // 
            // btnCategory
            // 
            this.btnCategory.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnCategory.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image3")));
            this.btnCategory.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnCategory.Image = ((System.Drawing.Image)(resources.GetObject("btnCategory.Image")));
            this.btnCategory.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnCategory.ImageRotate = 0F;
            this.btnCategory.Location = new System.Drawing.Point(494, 51);
            this.btnCategory.Name = "btnCategory";
            this.btnCategory.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnCategory.Size = new System.Drawing.Size(64, 54);
            this.btnCategory.TabIndex = 7;
            // 
            // btnCustomer
            // 
            this.btnCustomer.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnCustomer.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image4")));
            this.btnCustomer.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnCustomer.Image = ((System.Drawing.Image)(resources.GetObject("btnCustomer.Image")));
            this.btnCustomer.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnCustomer.ImageRotate = 0F;
            this.btnCustomer.Location = new System.Drawing.Point(364, 51);
            this.btnCustomer.Name = "btnCustomer";
            this.btnCustomer.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnCustomer.Size = new System.Drawing.Size(64, 54);
            this.btnCustomer.TabIndex = 6;
            // 
            // btnProduct
            // 
            this.btnProduct.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnProduct.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image5")));
            this.btnProduct.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnProduct.Image = ((System.Drawing.Image)(resources.GetObject("btnProduct.Image")));
            this.btnProduct.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnProduct.ImageRotate = 0F;
            this.btnProduct.Location = new System.Drawing.Point(234, 51);
            this.btnProduct.Name = "btnProduct";
            this.btnProduct.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnProduct.Size = new System.Drawing.Size(64, 54);
            this.btnProduct.TabIndex = 3;
            // 
            // guna2CirclePictureBox1
            // 
            this.guna2CirclePictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2CirclePictureBox1.Image")));
            this.guna2CirclePictureBox1.ImageRotate = 0F;
            this.guna2CirclePictureBox1.Location = new System.Drawing.Point(25, 21);
            this.guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
            this.guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox1.Size = new System.Drawing.Size(100, 100);
            this.guna2CirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2CirclePictureBox1.TabIndex = 3;
            this.guna2CirclePictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(400, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(239, 23);
            this.label1.TabIndex = 5;
            this.label1.Text = "Inventory Management";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnExit.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            this.btnExit.HoverState.ImageSize = new System.Drawing.Size(25, 25);
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnExit.ImageRotate = 0F;
            this.btnExit.ImageSize = new System.Drawing.Size(25, 25);
            this.btnExit.Location = new System.Drawing.Point(999, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.ShadowDecoration.Color = System.Drawing.Color.Transparent;
            this.btnExit.Size = new System.Drawing.Size(25, 25);
            this.btnExit.TabIndex = 13;
            // 
            // panelMain
            // 
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 165);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1024, 588);
            this.panelMain.TabIndex = 3;
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1024, 768);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main From";
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2ImageButton btnProduct;
        private Guna.UI2.WinForms.Guna2ImageButton btnOrders;
        private Guna.UI2.WinForms.Guna2ImageButton btnUser;
        private Guna.UI2.WinForms.Guna2ImageButton btnCategory;
        private Guna.UI2.WinForms.Guna2ImageButton btnCustomer;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2ImageButton btnExit;
        private System.Windows.Forms.Panel panelMain;
    }
}