
namespace firstProject
{
    partial class Paid_Order
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Paid_Order));
            this.paid_orders_panel = new System.Windows.Forms.Panel();
            this.paid_dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.detailsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ordersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.inventoryMgmtDataSet4 = new firstProject.inventoryMgmtDataSet4();
            this.button3 = new System.Windows.Forms.Button();
            this.cancel_order_btn = new System.Windows.Forms.Button();
            this.label23 = new System.Windows.Forms.Label();
            this.make_unPaid_btn = new System.Windows.Forms.Button();
            this.p_order_paidTxt = new System.Windows.Forms.TextBox();
            this.p_order_priceTxt = new System.Windows.Forms.TextBox();
            this.p_partTxt = new System.Windows.Forms.TextBox();
            this.p_order_detailsTxt = new System.Windows.Forms.TextBox();
            this.p_order_idTxt = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.p_user = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.ordersTableAdapter = new firstProject.inventoryMgmtDataSet4TableAdapters.ordersTableAdapter();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.paid_orders_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.paid_dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryMgmtDataSet4)).BeginInit();
            this.SuspendLayout();
            // 
            // paid_orders_panel
            // 
            this.paid_orders_panel.Controls.Add(this.paid_dataGridView1);
            this.paid_orders_panel.Controls.Add(this.button3);
            this.paid_orders_panel.Controls.Add(this.cancel_order_btn);
            this.paid_orders_panel.Controls.Add(this.label23);
            this.paid_orders_panel.Controls.Add(this.make_unPaid_btn);
            this.paid_orders_panel.Controls.Add(this.p_order_paidTxt);
            this.paid_orders_panel.Controls.Add(this.p_order_priceTxt);
            this.paid_orders_panel.Controls.Add(this.p_partTxt);
            this.paid_orders_panel.Controls.Add(this.p_order_detailsTxt);
            this.paid_orders_panel.Controls.Add(this.p_order_idTxt);
            this.paid_orders_panel.Controls.Add(this.label24);
            this.paid_orders_panel.Controls.Add(this.label25);
            this.paid_orders_panel.Controls.Add(this.label26);
            this.paid_orders_panel.Controls.Add(this.p_user);
            this.paid_orders_panel.Controls.Add(this.label29);
            this.paid_orders_panel.Location = new System.Drawing.Point(0, 0);
            this.paid_orders_panel.Margin = new System.Windows.Forms.Padding(2);
            this.paid_orders_panel.Name = "paid_orders_panel";
            this.paid_orders_panel.Size = new System.Drawing.Size(957, 518);
            this.paid_orders_panel.TabIndex = 73;
            // 
            // paid_dataGridView1
            // 
            this.paid_dataGridView1.AllowUserToAddRows = false;
            this.paid_dataGridView1.AutoGenerateColumns = false;
            this.paid_dataGridView1.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.paid_dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.paid_dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightSeaGreen;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.paid_dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.paid_dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.paid_dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.userDataGridViewTextBoxColumn,
            this.detailsDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.paidDataGridViewTextBoxColumn});
            this.paid_dataGridView1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.paid_dataGridView1.DataSource = this.ordersBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.LightSeaGreen;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.paid_dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.paid_dataGridView1.Location = new System.Drawing.Point(322, 19);
            this.paid_dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.paid_dataGridView1.MinimumSize = new System.Drawing.Size(590, 491);
            this.paid_dataGridView1.Name = "paid_dataGridView1";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.paid_dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.paid_dataGridView1.RowTemplate.Height = 24;
            this.paid_dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.paid_dataGridView1.Size = new System.Drawing.Size(590, 491);
            this.paid_dataGridView1.TabIndex = 103;
            this.paid_dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.paid_dataGridView1_CellContentClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.Width = 46;
            // 
            // userDataGridViewTextBoxColumn
            // 
            this.userDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.userDataGridViewTextBoxColumn.DataPropertyName = "user";
            this.userDataGridViewTextBoxColumn.HeaderText = "user";
            this.userDataGridViewTextBoxColumn.Name = "userDataGridViewTextBoxColumn";
            this.userDataGridViewTextBoxColumn.Width = 63;
            // 
            // detailsDataGridViewTextBoxColumn
            // 
            this.detailsDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.detailsDataGridViewTextBoxColumn.DataPropertyName = "details";
            this.detailsDataGridViewTextBoxColumn.HeaderText = "details";
            this.detailsDataGridViewTextBoxColumn.Name = "detailsDataGridViewTextBoxColumn";
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "price";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.Width = 68;
            // 
            // paidDataGridViewTextBoxColumn
            // 
            this.paidDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.paidDataGridViewTextBoxColumn.DataPropertyName = "paid";
            this.paidDataGridViewTextBoxColumn.HeaderText = "paid";
            this.paidDataGridViewTextBoxColumn.Name = "paidDataGridViewTextBoxColumn";
            this.paidDataGridViewTextBoxColumn.Width = 64;
            // 
            // ordersBindingSource
            // 
            this.ordersBindingSource.DataMember = "orders";
            this.ordersBindingSource.DataSource = this.inventoryMgmtDataSet4;
            // 
            // inventoryMgmtDataSet4
            // 
            this.inventoryMgmtDataSet4.DataSetName = "inventoryMgmtDataSet4";
            this.inventoryMgmtDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(52, 409);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(212, 55);
            this.button3.TabIndex = 102;
            this.button3.Text = "Generate Paid Order-List PDF";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // cancel_order_btn
            // 
            this.cancel_order_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.cancel_order_btn.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.cancel_order_btn.FlatAppearance.BorderSize = 2;
            this.cancel_order_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancel_order_btn.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancel_order_btn.Image = ((System.Drawing.Image)(resources.GetObject("cancel_order_btn.Image")));
            this.cancel_order_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cancel_order_btn.Location = new System.Drawing.Point(52, 336);
            this.cancel_order_btn.Margin = new System.Windows.Forms.Padding(2);
            this.cancel_order_btn.Name = "cancel_order_btn";
            this.cancel_order_btn.Padding = new System.Windows.Forms.Padding(4);
            this.cancel_order_btn.Size = new System.Drawing.Size(212, 71);
            this.cancel_order_btn.TabIndex = 100;
            this.cancel_order_btn.Text = "Cancel Order";
            this.cancel_order_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.cancel_order_btn.UseVisualStyleBackColor = false;
            this.cancel_order_btn.Click += new System.EventHandler(this.cancel_order_btn_Click_1);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Century Gothic", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(86, 19);
            this.label23.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(181, 18);
            this.label23.TabIndex = 99;
            this.label23.Text = "Paid-Order details Form";
            // 
            // make_unPaid_btn
            // 
            this.make_unPaid_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.make_unPaid_btn.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.make_unPaid_btn.FlatAppearance.BorderSize = 2;
            this.make_unPaid_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.make_unPaid_btn.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.make_unPaid_btn.Image = ((System.Drawing.Image)(resources.GetObject("make_unPaid_btn.Image")));
            this.make_unPaid_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.make_unPaid_btn.Location = new System.Drawing.Point(52, 260);
            this.make_unPaid_btn.Margin = new System.Windows.Forms.Padding(2);
            this.make_unPaid_btn.Name = "make_unPaid_btn";
            this.make_unPaid_btn.Padding = new System.Windows.Forms.Padding(4);
            this.make_unPaid_btn.Size = new System.Drawing.Size(212, 72);
            this.make_unPaid_btn.TabIndex = 98;
            this.make_unPaid_btn.Text = "Make as Unpaid";
            this.make_unPaid_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.make_unPaid_btn.UseVisualStyleBackColor = false;
            this.make_unPaid_btn.Click += new System.EventHandler(this.make_unPaid_btn_Click);
            // 
            // p_order_paidTxt
            // 
            this.p_order_paidTxt.Location = new System.Drawing.Point(148, 229);
            this.p_order_paidTxt.Margin = new System.Windows.Forms.Padding(2);
            this.p_order_paidTxt.Name = "p_order_paidTxt";
            this.p_order_paidTxt.Size = new System.Drawing.Size(137, 20);
            this.p_order_paidTxt.TabIndex = 95;
            this.p_order_paidTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // p_order_priceTxt
            // 
            this.p_order_priceTxt.Location = new System.Drawing.Point(148, 188);
            this.p_order_priceTxt.Margin = new System.Windows.Forms.Padding(2);
            this.p_order_priceTxt.Name = "p_order_priceTxt";
            this.p_order_priceTxt.Size = new System.Drawing.Size(137, 20);
            this.p_order_priceTxt.TabIndex = 94;
            this.p_order_priceTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // p_partTxt
            // 
            this.p_partTxt.Location = new System.Drawing.Point(148, 149);
            this.p_partTxt.Margin = new System.Windows.Forms.Padding(2);
            this.p_partTxt.Name = "p_partTxt";
            this.p_partTxt.Size = new System.Drawing.Size(137, 20);
            this.p_partTxt.TabIndex = 92;
            this.p_partTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // p_order_detailsTxt
            // 
            this.p_order_detailsTxt.Location = new System.Drawing.Point(148, 108);
            this.p_order_detailsTxt.Margin = new System.Windows.Forms.Padding(2);
            this.p_order_detailsTxt.Name = "p_order_detailsTxt";
            this.p_order_detailsTxt.Size = new System.Drawing.Size(137, 20);
            this.p_order_detailsTxt.TabIndex = 91;
            this.p_order_detailsTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // p_order_idTxt
            // 
            this.p_order_idTxt.Location = new System.Drawing.Point(148, 67);
            this.p_order_idTxt.Margin = new System.Windows.Forms.Padding(2);
            this.p_order_idTxt.Name = "p_order_idTxt";
            this.p_order_idTxt.Size = new System.Drawing.Size(137, 20);
            this.p_order_idTxt.TabIndex = 90;
            this.p_order_idTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(34, 63);
            this.label24.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(71, 20);
            this.label24.TabIndex = 81;
            this.label24.Text = "Order Id";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(34, 232);
            this.label25.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(70, 20);
            this.label25.TabIndex = 80;
            this.label25.Text = "Is-Paid ?";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.Location = new System.Drawing.Point(34, 190);
            this.label26.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(46, 20);
            this.label26.TabIndex = 79;
            this.label26.Text = "Price";
            // 
            // p_user
            // 
            this.p_user.AutoSize = true;
            this.p_user.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p_user.Location = new System.Drawing.Point(34, 147);
            this.p_user.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.p_user.Name = "p_user";
            this.p_user.Size = new System.Drawing.Size(38, 20);
            this.p_user.TabIndex = 77;
            this.p_user.Text = "Part";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.Location = new System.Drawing.Point(34, 105);
            this.label29.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(57, 20);
            this.label29.TabIndex = 76;
            this.label29.Text = "Details";
            // 
            // ordersTableAdapter
            // 
            this.ordersTableAdapter.ClearBeforeFill = true;
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printDialog1
            // 
            this.printDialog1.Document = this.printDocument1;
            this.printDialog1.UseEXDialog = true;
            // 
            // Paid_Order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(957, 518);
            this.Controls.Add(this.paid_orders_panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Paid_Order";
            this.Text = "Paid_Order";
            this.Load += new System.EventHandler(this.Paid_Order_Load);
            this.paid_orders_panel.ResumeLayout(false);
            this.paid_orders_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.paid_dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryMgmtDataSet4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel paid_orders_panel;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button cancel_order_btn;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Button make_unPaid_btn;
        private System.Windows.Forms.TextBox p_order_paidTxt;
        private System.Windows.Forms.TextBox p_order_priceTxt;
        private System.Windows.Forms.TextBox p_partTxt;
        private System.Windows.Forms.TextBox p_order_detailsTxt;
        private System.Windows.Forms.TextBox p_order_idTxt;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label p_user;
        private System.Windows.Forms.Label label29;
        private inventoryMgmtDataSet4 inventoryMgmtDataSet4;
        private System.Windows.Forms.BindingSource ordersBindingSource;
        private inventoryMgmtDataSet4TableAdapters.ordersTableAdapter ordersTableAdapter;
        private System.Windows.Forms.DataGridView paid_dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn detailsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paidDataGridViewTextBoxColumn;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintDialog printDialog1;
    }
}