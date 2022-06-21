
namespace firstProject
{
    partial class Manager_home
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Manager_home));
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.logout_btn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.manager_name = new System.Windows.Forms.Label();
            this.sparepartsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.inventoryMgmtDataSet1 = new firstProject.inventoryMgmtDataSet4();
            this.sparepartsTableAdapter = new firstProject.inventoryMgmtDataSet4TableAdapters.sparepartsTableAdapter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.unpaid_orders = new System.Windows.Forms.Button();
            this.slide_panel5 = new System.Windows.Forms.Panel();
            this.slide_panel4 = new System.Windows.Forms.Panel();
            this.slide_panel3 = new System.Windows.Forms.Panel();
            this.slide_panel2 = new System.Windows.Forms.Panel();
            this.slide_panel1 = new System.Windows.Forms.Panel();
            this.paid_orders = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.update = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.mainpanel3 = new System.Windows.Forms.Panel();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sparepartsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryMgmtDataSet1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Teal;
            this.panel3.Controls.Add(this.pictureBox2);
            this.panel3.Controls.Add(this.logout_btn);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.manager_name);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(206, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(864, 150);
            this.panel3.TabIndex = 68;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Teal;
            this.pictureBox2.ErrorImage = null;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(9, 8);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(106, 110);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 76;
            this.pictureBox2.TabStop = false;
            // 
            // logout_btn
            // 
            this.logout_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("logout_btn.BackgroundImage")));
            this.logout_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.logout_btn.Dock = System.Windows.Forms.DockStyle.Right;
            this.logout_btn.FlatAppearance.BorderSize = 0;
            this.logout_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logout_btn.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logout_btn.ForeColor = System.Drawing.Color.White;
            this.logout_btn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.logout_btn.Location = new System.Drawing.Point(787, 0);
            this.logout_btn.Margin = new System.Windows.Forms.Padding(2);
            this.logout_btn.Name = "logout_btn";
            this.logout_btn.Size = new System.Drawing.Size(77, 150);
            this.logout_btn.TabIndex = 68;
            this.logout_btn.Text = "Logout";
            this.logout_btn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.logout_btn.UseVisualStyleBackColor = true;
            this.logout_btn.Click += new System.EventHandler(this.logout_btn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F);
            this.label2.Location = new System.Drawing.Point(120, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(422, 36);
            this.label2.TabIndex = 67;
            this.label2.Text = "Inventory Management System";
            // 
            // manager_name
            // 
            this.manager_name.AutoSize = true;
            this.manager_name.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manager_name.ForeColor = System.Drawing.Color.White;
            this.manager_name.Location = new System.Drawing.Point(18, 128);
            this.manager_name.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.manager_name.Name = "manager_name";
            this.manager_name.Size = new System.Drawing.Size(88, 17);
            this.manager_name.TabIndex = 66;
            this.manager_name.Text = "Hello There,";
            // 
            // sparepartsBindingSource
            // 
            this.sparepartsBindingSource.DataMember = "spareparts";
            this.sparepartsBindingSource.DataSource = this.inventoryMgmtDataSet1;
            // 
            // inventoryMgmtDataSet1
            // 
            this.inventoryMgmtDataSet1.DataSetName = "inventoryMgmtDataSet1";
            this.inventoryMgmtDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sparepartsTableAdapter
            // 
            this.sparepartsTableAdapter.ClearBeforeFill = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.panel1.Controls.Add(this.unpaid_orders);
            this.panel1.Controls.Add(this.slide_panel5);
            this.panel1.Controls.Add(this.slide_panel4);
            this.panel1.Controls.Add(this.slide_panel3);
            this.panel1.Controls.Add(this.slide_panel2);
            this.panel1.Controls.Add(this.slide_panel1);
            this.panel1.Controls.Add(this.paid_orders);
            this.panel1.Controls.Add(this.delete);
            this.panel1.Controls.Add(this.update);
            this.panel1.Controls.Add(this.add);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(206, 589);
            this.panel1.TabIndex = 74;
            // 
            // unpaid_orders
            // 
            this.unpaid_orders.FlatAppearance.BorderSize = 0;
            this.unpaid_orders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.unpaid_orders.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unpaid_orders.ForeColor = System.Drawing.Color.White;
            this.unpaid_orders.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.unpaid_orders.Location = new System.Drawing.Point(18, 404);
            this.unpaid_orders.Margin = new System.Windows.Forms.Padding(2);
            this.unpaid_orders.Name = "unpaid_orders";
            this.unpaid_orders.Size = new System.Drawing.Size(189, 63);
            this.unpaid_orders.TabIndex = 59;
            this.unpaid_orders.Text = "   Unpaid Orders";
            this.unpaid_orders.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.unpaid_orders.UseVisualStyleBackColor = true;
            this.unpaid_orders.Click += new System.EventHandler(this.unpaid_orders_Click);
            // 
            // slide_panel5
            // 
            this.slide_panel5.BackColor = System.Drawing.Color.Teal;
            this.slide_panel5.Location = new System.Drawing.Point(0, 404);
            this.slide_panel5.Margin = new System.Windows.Forms.Padding(2);
            this.slide_panel5.Name = "slide_panel5";
            this.slide_panel5.Size = new System.Drawing.Size(12, 63);
            this.slide_panel5.TabIndex = 52;
            // 
            // slide_panel4
            // 
            this.slide_panel4.BackColor = System.Drawing.Color.Teal;
            this.slide_panel4.Location = new System.Drawing.Point(0, 341);
            this.slide_panel4.Margin = new System.Windows.Forms.Padding(2);
            this.slide_panel4.Name = "slide_panel4";
            this.slide_panel4.Size = new System.Drawing.Size(12, 63);
            this.slide_panel4.TabIndex = 52;
            // 
            // slide_panel3
            // 
            this.slide_panel3.BackColor = System.Drawing.Color.Teal;
            this.slide_panel3.Location = new System.Drawing.Point(0, 278);
            this.slide_panel3.Margin = new System.Windows.Forms.Padding(2);
            this.slide_panel3.Name = "slide_panel3";
            this.slide_panel3.Size = new System.Drawing.Size(12, 63);
            this.slide_panel3.TabIndex = 52;
            // 
            // slide_panel2
            // 
            this.slide_panel2.BackColor = System.Drawing.Color.Teal;
            this.slide_panel2.Location = new System.Drawing.Point(0, 215);
            this.slide_panel2.Margin = new System.Windows.Forms.Padding(2);
            this.slide_panel2.Name = "slide_panel2";
            this.slide_panel2.Size = new System.Drawing.Size(12, 63);
            this.slide_panel2.TabIndex = 52;
            // 
            // slide_panel1
            // 
            this.slide_panel1.BackColor = System.Drawing.Color.Teal;
            this.slide_panel1.Location = new System.Drawing.Point(0, 152);
            this.slide_panel1.Margin = new System.Windows.Forms.Padding(2);
            this.slide_panel1.Name = "slide_panel1";
            this.slide_panel1.Size = new System.Drawing.Size(12, 63);
            this.slide_panel1.TabIndex = 52;
            // 
            // paid_orders
            // 
            this.paid_orders.FlatAppearance.BorderSize = 0;
            this.paid_orders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.paid_orders.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paid_orders.ForeColor = System.Drawing.Color.White;
            this.paid_orders.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.paid_orders.Location = new System.Drawing.Point(18, 341);
            this.paid_orders.Margin = new System.Windows.Forms.Padding(2);
            this.paid_orders.Name = "paid_orders";
            this.paid_orders.Size = new System.Drawing.Size(188, 63);
            this.paid_orders.TabIndex = 55;
            this.paid_orders.Text = "   Paid Orders";
            this.paid_orders.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.paid_orders.UseVisualStyleBackColor = true;
            this.paid_orders.Click += new System.EventHandler(this.paid_orders_Click);
            // 
            // delete
            // 
            this.delete.FlatAppearance.BorderSize = 0;
            this.delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delete.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete.ForeColor = System.Drawing.Color.White;
            this.delete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.delete.Location = new System.Drawing.Point(16, 278);
            this.delete.Margin = new System.Windows.Forms.Padding(2);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(190, 63);
            this.delete.TabIndex = 54;
            this.delete.Text = "   Delete Item";
            this.delete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // update
            // 
            this.update.FlatAppearance.BorderSize = 0;
            this.update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.update.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update.ForeColor = System.Drawing.Color.White;
            this.update.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.update.Location = new System.Drawing.Point(14, 215);
            this.update.Margin = new System.Windows.Forms.Padding(2);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(190, 63);
            this.update.TabIndex = 53;
            this.update.Text = "   Update Item";
            this.update.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.update.UseVisualStyleBackColor = true;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // add
            // 
            this.add.FlatAppearance.BorderSize = 0;
            this.add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add.ForeColor = System.Drawing.Color.White;
            this.add.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.add.Location = new System.Drawing.Point(16, 152);
            this.add.Margin = new System.Windows.Forms.Padding(2);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(190, 63);
            this.add.TabIndex = 52;
            this.add.Text = "   Add Item";
            this.add.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // mainpanel3
            // 
            this.mainpanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainpanel3.Location = new System.Drawing.Point(206, 150);
            this.mainpanel3.Name = "mainpanel3";
            this.mainpanel3.Size = new System.Drawing.Size(864, 439);
            this.mainpanel3.TabIndex = 75;
            // 
            // Manager_home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1070, 589);
            this.Controls.Add(this.mainpanel3);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Manager_home";
            this.Text = "DashboardForm";
            this.Load += new System.EventHandler(this.Manager_home_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sparepartsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryMgmtDataSet1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label manager_name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button logout_btn;
        private inventoryMgmtDataSet4 inventoryMgmtDataSet1;
        private System.Windows.Forms.BindingSource sparepartsBindingSource;
        private inventoryMgmtDataSet4TableAdapters.sparepartsTableAdapter sparepartsTableAdapter;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel slide_panel1;
        private System.Windows.Forms.Button paid_orders;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Panel mainpanel3;
        private System.Windows.Forms.Panel slide_panel5;
        private System.Windows.Forms.Panel slide_panel4;
        private System.Windows.Forms.Panel slide_panel3;
        private System.Windows.Forms.Panel slide_panel2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button unpaid_orders;
    }
}